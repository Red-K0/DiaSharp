using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

sealed internal class LineNumberEnumerable(IEnumLineNumbers native) : ComEnumerable<IEnumLineNumbers, LineNumber>(native)
{
	protected override unsafe bool TryFetchBatch()
	{
		void** numbers = stackalloc void*[(int)_batchSize];

		int result = _native.GetNext(_batchSize, numbers, out uint numbersFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (numbersFetched == 0) return false;

		LineNumber[] managed = new LineNumber[numbersFetched];

		for (int i = 0; i < numbersFetched; i++) managed[i] = new(ComHelpers.Wrap<ILineNumber>(numbers[i]));

		AddRangeToCache(managed);

		return true;
	}
}
