using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

sealed internal class NamedStreamsEnumerable(IEnumNamedStreams native) : ComEnumerable<IEnumNamedStreams, string>(native)
{
	protected override bool TryFetchBatch()
	{
		int result = _native.GetNext(out string name);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (name is null) return false;

		AddToCache(name);

		return true;
	}
}
