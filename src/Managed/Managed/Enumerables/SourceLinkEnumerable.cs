using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

sealed internal class SourceLinkEnumerable(IEnumSourceLink native) : ComEnumerable<IEnumSourceLink, byte[]>(native)
{
	protected override unsafe uint TryFetchBatch()
	{
		int result = _native.SizeOfNext(out uint bufferSize);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		byte[] managed = new byte[bufferSize];

		fixed (byte* p = managed) result = _native.GetNext(bufferSize, out _, p);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (result == (int)KnownResult.S_FALSE) return 0;

		AddToCache(managed);

		return 1;
	}
}
