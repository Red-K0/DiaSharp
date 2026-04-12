namespace DiaSharp.COM;

public abstract class ComObject<I>(I native) : IDisposable where I : class
{
	protected delegate int Get<T>(out T value);
	protected delegate int Set<T>(T value);

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

	[StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected T ThrowOrGet<T>(Get<T> function)
	{
		int result = function(out T value);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return value;
	}

	[StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected void ThrowOrSet<T>(Set<T> function, T value)
	{
		int result = function(value);

		if (result < 0) Marshal.ThrowExceptionForHR(result);
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
}
