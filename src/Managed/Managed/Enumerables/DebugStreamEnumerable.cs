using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

sealed internal class DebugStreamEnumerable(IEnumDebugStreams native) : ComEnumerable<IEnumDebugStreams, DebugStreamDataEnumerable>(native)
{
	protected override unsafe uint TryFetchBatch()
	{
		void** streams = stackalloc void*[(int)BatchSize];

		int result = _native.GetNext(BatchSize, streams, out uint streamsFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (streamsFetched == 0) return 0;

		DebugStreamDataEnumerable[] managed = new DebugStreamDataEnumerable[streamsFetched];

		for (int i = 0; i < streamsFetched; i++) managed[i] = new(ComHelpers.Wrap<IEnumDebugStreamData>(streams[i]));

		AddRangeToCache(managed);

		return streamsFetched;
	}
}
