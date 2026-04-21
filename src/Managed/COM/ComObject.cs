namespace DiaSharp.COM;

public abstract class ComObject<I>(I native) : IDisposable where I : class
{
	private static readonly object _unsupported = new();

	private readonly Dictionary<string, object> _propertyCache = [];

	private bool _disposed = false;

	internal I _native = native;

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

	#region Helpers

	#region Property Helpers

	#region Getters

	protected unsafe delegate int GetBuffer<T>(uint bufferSize, out uint dataSize, T* buffer) where T : unmanaged;
	protected unsafe delegate int GetBufferA(uint bufferSize, out uint dataSize, void** buffer);
	protected unsafe delegate int GetBufferB(uint bufferSize, void** buffer, out uint dataSize);
	protected delegate int GetF<T>(out T value);

	[StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected T? GetC<T>(GetF<T> function, bool ensured = false, [CallerMemberName] string key = "") where T : class
	{
		if (!ensured) EnsureNotDisposed();

		ref object? cached = ref CollectionsMarshal.GetValueRefOrAddDefault(_propertyCache, key, out bool exists);

		if (exists) return !ReferenceEquals(cached, _unsupported) ? (T?)cached : null;

		int result = function(out T value);

		if (result == (int)KnownResult.S_FALSE)
		{
			cached = _unsupported;
			return null;
		}

		if (result < 0)
		{
			_propertyCache.Remove(key);
			Marshal.ThrowExceptionForHR(result);
		}

		cached = value;

		return value;
	}

	[StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected T? GetS<T>(GetF<T> function, bool ensured = false, [CallerMemberName] string key = "") where T : struct
	{
		if (!ensured) EnsureNotDisposed();

		ref object? cached = ref CollectionsMarshal.GetValueRefOrAddDefault(_propertyCache, key, out bool exists);

		if (exists) return !ReferenceEquals(cached, _unsupported) ? (T?)cached : null;

		int result = function(out T value);

		if (result == (int)KnownResult.S_FALSE)
		{
			cached = _unsupported;
			return null;
		}

		if (result < 0)
		{
			_propertyCache.Remove(key);
			Marshal.ThrowExceptionForHR(result);
		}

		cached = value;

		return value;
	}

	[StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected bool TryGetC<T>(GetF<T> function, [NotNullWhen(true)] out T? value, bool ensured = false, [CallerMemberName] string key = "") where T : class
	{
		T? result = GetC(function, ensured, key);

		value = result;

		return value != null;
	}

	[StackTraceHidden]
	protected T[]? GetA<T>(GetBuffer<T> function, bool ensured = false, [CallerMemberName] string key = "") where T : unmanaged
	{
		if (!ensured) EnsureNotDisposed();

		ref object? cached = ref CollectionsMarshal.GetValueRefOrAddDefault(_propertyCache, key, out bool exists);

		if (exists) return !ReferenceEquals(cached, _unsupported) ? (T[]?)cached : null;

		unsafe
		{
			int result = function(0, out uint size, null);

			if (result == (int)KnownResult.S_FALSE) return null;

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			T* elements = stackalloc T[(int)size];

			result = function(size, out _, elements);

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			T[] array = new ReadOnlySpan<T>(elements, (int)size).ToArray();

			cached = array;

			return array;
		}
	}

	[StackTraceHidden]
	protected unsafe void*[]? GetProp(GetBufferA function, bool ensured = false, [CallerMemberName] string key = "")
	{
		if (!ensured) EnsureNotDisposed();

		ref object? cached = ref CollectionsMarshal.GetValueRefOrAddDefault(_propertyCache, key, out bool exists);

		if (exists) return !ReferenceEquals(cached, _unsupported) ? (void*[]?)cached : null;

		unsafe
		{
			int result = function(0, out uint size, null);

			if (result == (int)KnownResult.S_FALSE) return null;

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			void** elements = stackalloc void*[(int)size];

			result = function(size, out _, elements);

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			void*[] array = Unsafe.As<void*[]>(new ReadOnlySpan<nint>(elements, (int)size).ToArray());

			cached = array;

			return array;
		}
	}

	[StackTraceHidden]
	protected unsafe void*[]? GetProp(GetBufferB function, bool ensured = false, [CallerMemberName] string key = "")
	{
		if (!ensured) EnsureNotDisposed();

		ref object? cached = ref CollectionsMarshal.GetValueRefOrAddDefault(_propertyCache, key, out bool exists);

		if (exists) return !ReferenceEquals(cached, _unsupported) ? (void*[]?)cached : null;

		unsafe
		{
			int result = function(0, null, out uint size);

			if (result == (int)KnownResult.S_FALSE) return null;

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			void** elements = stackalloc void*[(int)size];

			result = function(size, elements, out _);

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			void*[] array = Unsafe.As<void*[]>(new ReadOnlySpan<nint>(elements, (int)size).ToArray());

			cached = array;

			return array;
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

	protected static unsafe bool TryGetSingle<V>(GetBufferA next, out V single) where V : class
	{
		void* value;

		int result = next(1, out _, &value);

		if (result == (int)KnownResult.S_FALSE)
		{
			single = default!;
			return false;
		}

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		single = ComHelpers.Wrap<V>(value);

		return true;
	}

	protected static unsafe bool TryGetSingle<V>(GetBufferB next, out V single) where V : class
	{
		void* value;

		int result = next(1, &value, out _);

		if (result == (int)KnownResult.S_FALSE)
		{
			single = default!;
			return false;
		}

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		single = ComHelpers.Wrap<V>(value);

		return true;
	}

	#endregion
}
