namespace DiaSharp.COM;

public abstract class ComObject<TInterface>(TInterface native) : IDisposable where TInterface : class
{
	private static readonly object _unsupported = new();

	private readonly Dictionary<int, object?> _propertyCache = [];

	private bool _disposed;

	internal TInterface _native = native;

	protected void EnsureNotDisposed() => ObjectDisposedException.ThrowIf(_disposed, this);

	[SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Failures are expected in this API.")]
	protected bool TryQueryInterface<TQueried>([NotNullWhen(true)] out TQueried? queried) where TQueried : class
	{
		EnsureNotDisposed();

		try
		{
			queried = ComHelpers.QueryInterface<TInterface, TQueried>(_native!);
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
		Dispose(true);

		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (_disposed) return;

		// This dictionary can be massive.
		if (disposing) _propertyCache.Clear();

		ComHelpers.Release(ref _native!);

		_disposed = true;
	}

	#region Helpers

	#region Property Helpers

	#region Getters

	protected unsafe delegate int GetBuffer(uint bufferSize, out uint dataSize, void** buffer);
	protected unsafe delegate int GetBuffer<T>(uint bufferSize, out uint dataSize, T* buffer) where T : unmanaged;
	protected delegate int GetSingle<T>(out T value);

	[StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected T? GetC<T>(GetSingle<T> function, bool ensured = false, [CallerLineNumber] int key = -1) where T : class
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
	protected bool TryGetC<T>(GetSingle<T> function, [NotNullWhen(true)] out T? value, bool ensured = false, [CallerLineNumber] int key = -1) where T : class
	{
		T? result = GetC(function, ensured, key);

		value = result;

		return value != null;
	}

	[StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected T? GetS<T>(GetSingle<T> function, bool ensured = false, [CallerLineNumber] int key = -1) where T : struct
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
	protected unsafe void*[]? GetA(GetBuffer function, bool ensured = false, [CallerLineNumber] int key = -1) => Unsafe.As<void*[]>(GetA(Unsafe.As<GetBuffer<nint>>(function), ensured, key));

	[StackTraceHidden]
	protected T[]? GetA<T>(GetBuffer<T> function, bool ensured = false, [CallerLineNumber] int key = -1) where T : unmanaged
	{
		if (!ensured) EnsureNotDisposed();

		ref object? cached = ref CollectionsMarshal.GetValueRefOrAddDefault(_propertyCache, key, out bool exists);

		if (exists) return ReferenceEquals(cached, _unsupported) ? null : (T[])((T[])cached!).Clone();

		unsafe
		{
			int result = function(0, out uint size, null);

			if (result == (int)KnownResult.S_FALSE) return null;

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			T[] array;

			if (size * sizeof(T) < 4096)
			{
				T* elements = stackalloc T[(int)size];

				result = function(size, out _, elements);

				if (result < 0) Marshal.ThrowExceptionForHR(result);

				array = new ReadOnlySpan<T>(elements, (int)size).ToArray();
			}
			else
			{
				array = new T[size];

				fixed (T* elements = array) result = function(size, out _, elements);

				if (result < 0) Marshal.ThrowExceptionForHR(result);
			}

			cached = array;

			return (T[])array.Clone();
		}
	}

	#endregion

	#region Setters

	protected delegate int SetValue<T>(T? value);

	[StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected void Set<T>(SetValue<T> function, T? value, bool ensured = false, [CallerLineNumber] int key = -1)
	{
		if (!ensured) EnsureNotDisposed();

		int result = function(value);

		if (result == (int)KnownResult.S_FALSE) throw new InvalidOperationException("Property is unsupported in the object's current state.");

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		// Invalidate the cached result (if any), but don't assign anything. We don't know how COM transforms the result of our assignment.

		_propertyCache.Remove(key);
	}

	#endregion

	#endregion

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected TQueried EnsureAndQuery<TQueried>() where TQueried : class
	{
		EnsureNotDisposed();

		return !TryQueryInterface(out TQueried? queried)
			? throw new PlatformNotSupportedException($"The {nameof(TQueried)} interface is unsupported, please ensure the latest version of the DIA SDK is installed.")
			: queried;
	}

	#endregion
}
