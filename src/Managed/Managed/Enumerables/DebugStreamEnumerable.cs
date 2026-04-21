using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

internal class DebugStreamEnumerable(IEnumDebugStreams native) : ComEnumerable<IEnumDebugStreams, DebugStreamDataEnumerable>(native)
{
	protected override unsafe bool TryFetchBatch()
	{
		void** streams = stackalloc void*[(int)_batchSize];

		int result = _native.GetNext(_batchSize, streams, out uint streamsFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (streamsFetched == 0) return false;

		DebugStreamDataEnumerable[] managed = new DebugStreamDataEnumerable[streamsFetched];

		for (int i = 0; i < streamsFetched; i++) managed[i] = new(ComHelpers.Wrap<IEnumDebugStreamData>(streams[i]));

		AddRangeToCache(managed);

		return true;
	}
}
