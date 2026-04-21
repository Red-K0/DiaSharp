using System.Collections;

namespace DiaSharp.COM;

public abstract class ComEnumerable<I, V>(I native, uint batchSize = 8) : ComObject<I>(native), IEnumerable<V> where I : class where V : notnull
{
	protected readonly uint _batchSize = batchSize;
	private readonly object _cacheLock = new();

	protected volatile int _objectCacheIndex = -1;
	protected volatile bool _completed;

	protected V[] _objectCache = [];

	public IEnumerator<V> GetEnumerator() => new ComEnumerator(this);
	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	protected bool TryRequestItem(int index, out V value)
	{
		if (index > _objectCacheIndex)
		{
			if (!_completed)
			{
				// Another lock could have added it.
				lock (_cacheLock) { if (index <= _objectCacheIndex || !(_completed = !TryFetchBatch())) goto Success; }
			}

			value = default!;
			return false;
		}

	Success:
		value = _objectCache[index];
		return true;
	}

	protected abstract bool TryFetchBatch();

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

	private sealed class ComEnumerator(ComEnumerable<I, V> parent) : IEnumerator<V>
	{
		private readonly ComEnumerable<I, V> _parent = parent;
		private int _index = -1;

		public V Current { get; private set; } = default!;
		object IEnumerator.Current => Current;

		public void Dispose() {}

		public bool MoveNext()
		{
			if (!_parent.TryRequestItem(++_index, out V? value)) return false;

			Current = value;
			return true;
		}

		public void Reset() => _index = -1;
	}
}
