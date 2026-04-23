using System.Collections;

namespace DiaSharp.COM;

public abstract class ComEnumerable<TInterface, TValue>(TInterface native) : ComObject<TInterface>(native), IEnumerable<TValue> where TInterface : class where TValue : notnull
{
	protected const uint BatchSize = 8;

	private readonly SemaphoreSlim _cacheLock = new(1);

	private volatile int _objectCacheIndex = -1;
	private volatile bool _completed;

	private TValue[] _objectCache = [];

	public IEnumerator<TValue> GetEnumerator() => new ComEnumerator(this);
	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	protected bool TryRequestItem(int index, out TValue value)
	{
		bool? result = CheckExists(out value);

		if (result == true) return true;

		if (result == false) return false;

		if (_cacheLock.Wait(0))
		{
			// We were first here, so the item cannot exist.
			try
			{
				uint fetched = TryFetchBatch();

				if (fetched == 0)
				{
					_completed = true;
					return false;
				}

				_completed = fetched < BatchSize;

				value = _objectCache[index];

				return true;
			}
			finally
			{
				_cacheLock.Release();
			}
		}
		else
		{
			// Someone got the lock before us, so no fetch should trigger.
			// Either it exists, or the enumeration is over.
			_cacheLock.Wait(Timeout.Infinite);

			try
			{
				return CheckExists(out value)!.Value;
			}
			finally
			{
				_cacheLock.Release();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool? CheckExists(out TValue value)
		{
			if (index <= _objectCacheIndex)
			{
				value = _objectCache[index];
				return true;
			}

			value = default!;

			return _completed ? false : null;
		}
	}

	protected abstract uint TryFetchBatch();

	protected void AddToCache(TValue value)
	{
		int nextIndex = _objectCacheIndex + 1;

		if (_objectCache.Length <= nextIndex) Array.Resize(ref _objectCache, _objectCache.Length == 0 ? 4 : _objectCache.Length * 2);

		_objectCache[nextIndex] = value;
		_objectCacheIndex = nextIndex;
	}

	protected void AddRangeToCache(ReadOnlySpan<TValue> values)
	{
		if (values.Length == 0) return;

		int startIndex = _objectCacheIndex + 1, requiredLength = startIndex + values.Length;

		if (_objectCache.Length < requiredLength)
		{
			int newSize = _objectCache.Length == 0 ? 4 : _objectCache.Length * 2;

			Array.Resize(ref _objectCache, newSize < requiredLength ? requiredLength : newSize);
		}

		values.CopyTo(_objectCache.AsSpan(startIndex));

		_objectCacheIndex = requiredLength - 1;
	}

	private struct ComEnumerator(ComEnumerable<TInterface, TValue> parent) : IEnumerator<TValue>
	{
		private readonly ComEnumerable<TInterface, TValue> _parent = parent;
		private int _index = -1;

		public TValue Current { get; private set; } = default!;
		readonly object IEnumerator.Current => Current;

		public readonly void Dispose() {}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool MoveNext()
		{
			if (!_parent.TryRequestItem(++_index, out TValue? value)) return false;

			Current = value;
			return true;
		}

		public void Reset() => _index = -1;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			_cacheLock.Dispose();
			_objectCache = null!;
		}

		base.Dispose(disposing);
	}
}
