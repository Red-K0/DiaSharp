using System.Diagnostics.CodeAnalysis;
using DiaSharp.COM;

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
}