using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

sealed internal class LineNumberEnumerable(IEnumLineNumbers native) : ComEnumerable<IEnumLineNumbers, LineNumber>(native)
{
	protected override unsafe uint TryFetchBatch()
	{
		void** numbers = stackalloc void*[(int)BatchSize];

		int result = _native.GetNext(BatchSize, numbers, out uint numbersFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (numbersFetched == 0) return 0;

		LineNumber[] managed = new LineNumber[numbersFetched];

		for (int i = 0; i < numbersFetched; i++) managed[i] = new(ComHelpers.Wrap<ILineNumber>(numbers[i]));

		AddRangeToCache(managed);

		return numbersFetched;
	}
}
