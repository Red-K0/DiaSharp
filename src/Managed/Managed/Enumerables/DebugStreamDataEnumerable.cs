using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

internal class DebugStreamDataEnumerable(IEnumDebugStreamData native) : ComEnumerable<IEnumDebugStreamData, byte[]>(native)
{
	private const string _dataSizeMessage = $"A debug stream's data exceeds the maximum representable size. Use {nameof(IEnumDebugStreamData)}'s native implementation instead.";

	// To receive the data buffers, we would need to allocate a potentially large unmanaged buffer.
	// We then need to read each block as [uint size][byte[] bytes], where the blocks are contiguously laid out.
	// This unfortunately leads to a temporarily doubled memory size if the approach of multiple batched items is used.
	// As a result, a less time-optimal implementation is used, in exchange for not blowing up the heap.
	protected override unsafe bool TryFetchBatch()
	{
#if USE_LARGE_BUFFERS

		int result = _native.GetNext(_batchSize, 0, out uint allocSize, null, out _);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (allocSize == 0) return false;

		void* alloc = NativeMemory.Alloc(allocSize);

		try
		{
			result = _native.GetNext(_batchSize, allocSize, out _, (byte*)alloc, out uint fetched);

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			if (fetched == 0) return false;

			byte* pointer = (byte*)alloc;

			for (int i = 0; i < fetched; i++)
			{
				uint size = *(uint*)pointer;

				if (size > int.MaxValue) throw new InvalidDataException(_dataSizeMessage);

				byte[] buffer = new byte[(int)size];

				new ReadOnlySpan<byte>(pointer += sizeof(uint), (int)size).CopyTo(buffer);

				pointer += size;

				AddToCache(buffer);
			}

			return true;
		}
		finally
		{
			NativeMemory.Free(alloc);
		}

#else

		for (int i = 0; i < _batchSize; i++)
		{
			int result = _native.GetNext(1, 0, out uint bufferSize, null, out uint fetched);

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			if (fetched == 0) return _objectCacheIndex != -1;

			if (bufferSize > int.MaxValue) throw new InvalidDataException(_dataSizeMessage);

			byte[] buffer = new byte[bufferSize];

			fixed (byte* p = buffer) result = _native.GetNext(1, bufferSize, out _, p, out _);

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			AddToCache(buffer);
		}

		return true;

#endif
	}
}
