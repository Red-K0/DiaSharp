using System.Collections;
using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Enumerables;

sealed internal class NamedStreamsEnumerable(IEnumNamedStreams native) : ComObject<IEnumNamedStreams>(native), IEnumerable<string>
{
	public IEnumerator<string> GetEnumerator() => new NamedStreamsEnumerator(CloneNative());

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	private IEnumNamedStreams CloneNative()
	{
		int result = _native.Clone(out IEnumNamedStreams? clone);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return clone;
	}

	private sealed class NamedStreamsEnumerator(IEnumNamedStreams native) : ComObject<IEnumNamedStreams>(native), IEnumerator<string>
	{
		[AllowNull]
		public string Current { get => field ?? throw new InvalidOperationException(); private set; }

		object IEnumerator.Current => Current;

		public bool MoveNext()
		{
			int result = _native.GetNext(out string name);

			if (result == 1)
			{
				Current = null;
				return false;
			}

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			Current = name;
			return true;
		}

		public void Reset()
		{
			int result = _native.Reset();

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			Current = null;
		}
	}
}
