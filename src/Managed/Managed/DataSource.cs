using DiaSharp.CodeView;
using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed;

public sealed unsafe class DataSource() : ComObject<IDataSource>(ComHelpers.CoCreateInstance<IDataSource>(Constants.DiaSourceGUID))
{
	private string[]? _streamVerificationCache;

	#region LoadData(...)

	public void LoadData(string pdbPath, bool prefetch = false)
	{
		EnsureNotDisposed();

		if (prefetch && TryQueryInterface(out IDataSourceEx? sourceEx))
		{
			int result = sourceEx.LoadDataFromPDB(pdbPath, true);

			ComHelpers.Release(ref sourceEx);

			HandleLoadResult(result);

			return;
		}

		HandleLoadResult(_native.LoadDataFromPDB(pdbPath));
	}

	public void LoadData(string pdbPath, Guid guidSignature, uint signature, uint age, bool prefetch = false)
	{
		EnsureNotDisposed();

		if (prefetch && TryQueryInterface(out IDataSourceEx? sourceEx))
		{
			int result = sourceEx.LoadAndValidateDataFromPDB(pdbPath, guidSignature == Guid.Empty ? null : &guidSignature, signature, age, true);

			ComHelpers.Release(ref sourceEx);

			HandleLoadResult(result);

			return;
		}

		HandleLoadResult(_native.LoadAndValidateDataFromPDB(pdbPath, guidSignature == Guid.Empty ? null : &guidSignature, signature, age));
	}

	public void LoadData(string exePath, string searchPath, bool prefetch = false)
	{
		EnsureNotDisposed();

		if (prefetch && TryQueryInterface(out IDataSourceEx? sourceEx))
		{
			int result = sourceEx.LoadDataForExe(exePath, searchPath, null, true);

			ComHelpers.Release(ref sourceEx);

			HandleLoadResult(result);

			return;
		}

		HandleLoadResult(_native.LoadDataForExe(exePath, searchPath, null));
	}

	public void LoadData(string exePath, string searchPath, ReadOnlySpan<byte> codeViewInfo, bool prefetch = false)
	{
		EnsureNotDisposed();

		fixed (byte* p = codeViewInfo) HandleLoadResult(_native.LoadDataFromCodeViewInfo(exePath, searchPath, (uint)codeViewInfo.Length, p, null));
	}

	public void LoadData(string exePath, string searchPath, DateTimeOffset exeTimestamp, DateTimeOffset debugTimestamp, uint exeSize, ReadOnlySpan<byte> miscInfo)
	{
		EnsureNotDisposed();

		fixed (byte* p = miscInfo) HandleLoadResult(_native.LoadDataFromMiscInfo(exePath, searchPath, (uint)exeTimestamp.ToUnixTimeSeconds(), (uint)debugTimestamp.ToUnixTimeSeconds(), exeSize, (uint)miscInfo.Length, p, null));
	}

	public void LoadData(Stream stream, bool prefetch = false)
	{
		EnsureNotDisposed();

		ComStream cStream = new(stream);

		if (prefetch && TryQueryInterface(out IDataSourceEx? sourceEx))
		{
			int result = sourceEx.LoadDataFromIStream(cStream, true);

			ComHelpers.Release(ref sourceEx);

			HandleLoadResult(result);

			return;
		}

		HandleLoadResult(_native.LoadDataFromIStream(cStream));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[StackTraceHidden]
	private static void HandleLoadResult(int result)
	{
		if (result == 0) return;

		switch ((KnownResult)result)
		{
			default: Marshal.ThrowExceptionForHR(result); break;

			case KnownResult.E_PDB_NOT_FOUND: throw new FileNotFoundException("The PDB file could not be opened, or has an invalid format.");

			case KnownResult.E_PDB_FORMAT: throw new InvalidDataException("The PDB provided is in an incompatible or unsupported format.");

			case KnownResult.E_INVALIDARG: throw new ArgumentException("One or more of the arguments provided are invalid.");

			case KnownResult.E_UNEXPECTED: throw new InvalidOperationException("The data source already has data prepared.");

			case KnownResult.E_PDB_INVALID_SIG: throw new InvalidDataException("The PDB does not match the provided signatures.");

			case KnownResult.E_PDB_INVALID_AGE: throw new InvalidDataException("The PDB does not match the provided age constraint.");
		}
	}

	#endregion

	public Session OpenSession()
	{
		int result = _native.OpenSession(out ISession session);

		if (result == 0) return new(session);

		switch ((KnownResult)result)
		{
			default: Marshal.ThrowExceptionForHR(result); break;

			case KnownResult.E_UNEXPECTED: throw new InvalidOperationException("The data source has not been initialized.");

			case KnownResult.E_OUTOFMEMORY: throw new OutOfMemoryException("Not enough system memory is available to open a session.");

			case KnownResult.E_INVALIDARG:
				Environment.FailFast(
					$"An unreachable fail state was reached in {nameof(OpenSession)}. The runtime's state is likely corrupt, or a COM object's pointer was invalidated.",
					new UnreachableException("An invalid pointer was passed to OpenSession().")
				);
				return null!;
		}

		return null!;
	}

	#region Streams

	public ulong GetStreamSize(string stream)
	{
		IDataSourceEx sourceEx = EnsureAndQuery<IDataSourceEx>();

		int result = sourceEx.GetStreamSize(stream, out ulong size);

		ComHelpers.Release(ref sourceEx);

		if (result == 0)
		{
			if (size == 0)
			{
				if (CheckStreamExists(stream)) return 0;

				goto streamFail;
			}

			return size;
		}

		if (CheckStreamExists(stream)) Marshal.ThrowExceptionForHR(result);

	streamFail:
		throw new FileNotFoundException($"The requested stream '{stream}' does not exist, or is inaccessible.");
	}

	public MemoryStream GetStream(string stream) => GetStream(stream, 0, GetStreamSize(stream), true);

	public MemoryStream GetStream(string stream, int start, int length) => GetStream(stream, start, (ulong)length, false);

	private MemoryStream GetStream(string stream, int start, ulong length, bool comSize)
	{
		IDataSourceEx sourceEx = EnsureAndQuery<IDataSourceEx>();

		// This is intentionally checked here, and not in accessing overloads.
		// GetStreamSize can return a value greater than what we can represent, reaching a failure state.
		// Given that the parameterless overload can trigger it, this should be handled here, and not outside.
		if (comSize && length > (ulong)Array.MaxLength) throw new ArgumentOutOfRangeException(nameof(length), length, "The size of the stream requested is greater than the maximum supported stream size.");

		byte[] buffer = new byte[(int)length];
		ulong bytesWritten;
		int result;

		fixed (byte* b = buffer) result = sourceEx.GetStreamRawData(stream, (ulong)start, length, out bytesWritten, b);

		ComHelpers.Release(ref sourceEx);

		if (result == 0)
		{
			if (bytesWritten == 0)
			{
				if (CheckStreamExists(stream)) return new MemoryStream([], 0, 0, false);

				goto streamFail;
			}

			// Yes, this can explode memory use.
			// If that matters, don't pass stupid values.
			if (!comSize && (int)bytesWritten < buffer.Length) Array.Resize(ref buffer, (int)bytesWritten);

			return new(buffer, 0, (int)bytesWritten, false);
		}

		if (CheckStreamExists(stream)) Marshal.ThrowExceptionForHR(result);

	streamFail:
		throw new FileNotFoundException($"The requested stream '{stream}' does not exist, or is inaccessible.");
	}

	public IEnumerable<string> FindNamedStreams(string name, NameSearchOptions searchOptions = NameSearchOptions.None)
	{
		IDataSourceEx2 sourceEx2 = EnsureAndQuery<IDataSourceEx2>();

		int result = sourceEx2.FindNamedStreams(name, searchOptions, out IEnumNamedStreams streams);

		ComHelpers.Release(ref sourceEx2);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new Enumerables.NamedStreamsEnumerable(streams);
	}

	private bool CheckStreamExists(string stream)
	{
		_streamVerificationCache ??= CreateVerificationCache();

		return _streamVerificationCache.Contains(stream);
	}

	private string[] CreateVerificationCache()
	{
		List<string> streams = [];

		foreach (string stream in FindNamedStreams("", NameSearchOptions.None)) streams.Add(stream);

		return [.. streams];
	}

	#endregion

	public bool ValidatePDB(string pdbPath, Guid guidSignature, uint signature, uint age, out bool privateSymbolsStripped)
	{
		IDataSourceEx sourceEx = EnsureAndQuery<IDataSourceEx>();

		int result = sourceEx.ValidatePDB(pdbPath, &guidSignature, signature, age, out privateSymbolsStripped);

		ComHelpers.Release(ref sourceEx);

		return result == 0;
	}
}
