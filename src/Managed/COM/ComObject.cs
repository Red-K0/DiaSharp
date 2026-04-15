namespace DiaSharp.COM;

public abstract class ComObject<I>(I native) : IDisposable where I : class
{
	private bool _disposed = false;

	protected I _native = native;

	protected void EnsureNotDisposed() => ObjectDisposedException.ThrowIf(_disposed, this);

	protected bool TryQueryInterface<Q>([NotNullWhen(true)] out Q? queried) where Q : class
	{
		EnsureNotDisposed();

		try
		{
			queried = ComHelpers.QueryInterface<I, Q>(_native!);
			return true;
		}
		catch
		{
			queried = null;
			return false;
		}
	}

	public void Dispose()
	{
		if (!_disposed)
		{
			ComHelpers.Release(ref _native!);
			_disposed = true;
		}

		GC.SuppressFinalize(this);
	}

	#region Property Helpers

	#region Getters

	protected unsafe delegate int GetBuffer<T>(uint bufferSize, out uint dataSize, T* buffer) where T : unmanaged;
	protected unsafe delegate int GetBuffer(uint bufferSize, out uint dataSize, void** buffer);
	protected delegate int Get<T>(out T value);

	[StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected T GetProp<T>(Get<T> function, bool ensured = false)
	{
		if (!ensured) EnsureNotDisposed();

		int result = function(out T value);

		if (result == (int)KnownResult.S_FALSE) throw new InvalidOperationException("Property is unsupported in the object's current state.");

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return value;
	}

	[StackTraceHidden]
	protected ReadOnlySpan<T> GetProp<T>(GetBuffer<T> function, bool ensured = false) where T : unmanaged
	{
		if (!ensured) EnsureNotDisposed();

		unsafe
		{
			int result = function(0, out uint size, null);

			if (result == (int)KnownResult.S_FALSE) throw new InvalidOperationException("Property is unsupported in the object's current state.");

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			T* elements = stackalloc T[(int)size];

			result = function(size, out _, elements);

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			return new ReadOnlySpan<T>(elements, (int)size);
		}
	}

	[StackTraceHidden]
	protected ReadOnlySpan<nint> GetProp(GetBuffer function, bool ensured = false)
	{
		if (!ensured) EnsureNotDisposed();

		unsafe
		{
			int result = function(0, out uint size, null);

			if (result == (int)KnownResult.S_FALSE) throw new InvalidOperationException("Property is unsupported in the object's current state.");

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			void** elements = stackalloc void*[(int)size];

			result = function(size, out _, elements);

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			return new(elements, (int)size);
		}
	}

	#endregion

	#region Setters

	protected delegate int Set<T>(T value);

	[StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected void SetProp<T>(Set<T> function, T value, bool ensured = false)
	{
		if (!ensured) EnsureNotDisposed();

		int result = function(value);

		if (result == (int)KnownResult.S_FALSE) throw new InvalidOperationException("Property is unsupported in the object's current state.");

		if (result < 0) Marshal.ThrowExceptionForHR(result);
	}

	#endregion

	#endregion

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected Q EnsureAndQuery<Q>() where Q : class
	{
		EnsureNotDisposed();

		return !TryQueryInterface(out Q? queried)
			? throw new PlatformNotSupportedException($"The {nameof(Q)} interface is unsupported, please ensure the latest version of the DIA SDK is installed.")
			: queried;
	}
}
