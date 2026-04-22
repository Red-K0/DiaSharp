using System.Collections;

namespace DiaSharp.COM;

public abstract class ComEnumerable<I, V>(I native, uint batchSize = 8) : ComObject<I>(native), IEnumerable<V> where I : class where V : notnull
{
	protected readonly uint _batchSize = batchSize;
	private readonly SemaphoreSlim _cacheLock = new(1);

	protected volatile int _objectCacheIndex = -1;
	protected volatile bool _completed;

	protected V[] _objectCache = [];

	public IEnumerator<V> GetEnumerator() => new ComEnumerator(this);
	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	protected bool TryRequestItem(int index, out V value)
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

				_completed = fetched < _batchSize;

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
		bool? CheckExists(out V value)
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

	protected void AddToCache(V value)
	{
		int nextIndex = _objectCacheIndex + 1;

		if (_objectCache.Length <= nextIndex) Array.Resize(ref _objectCache, _objectCache.Length == 0 ? 4 : _objectCache.Length * 2);

		_objectCache[nextIndex] = value;
		_objectCacheIndex = nextIndex;
	}

	protected void AddRangeToCache(ReadOnlySpan<V> values)
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

	private struct ComEnumerator(ComEnumerable<I, V> parent) : IEnumerator<V>
	{
		private readonly ComEnumerable<I, V> _parent = parent;
		private int _index = -1;

		public V Current { get; private set; } = default!;
		readonly object IEnumerator.Current => Current;

		public readonly void Dispose() {}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool MoveNext()
		{
			if (!_parent.TryRequestItem(++_index, out V? value)) return false;

			Current = value;
			return true;
		}

		public void Reset() => _index = -1;
	}
}
