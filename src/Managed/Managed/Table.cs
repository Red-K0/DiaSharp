using DiaSharp.COM;
using DiaSharp.SDK;

namespace DiaSharp.Managed;

public class Table(ITable native) : ComEnumerable<ITable, nint>(native)
{
	private const string _dataSizeMessage = $"A table exceeds the maximum representable size. Use {nameof(ITable)}'s native implementation instead.";

	protected override unsafe uint TryFetchBatch()
	{
		void** elements = stackalloc void*[(int)_batchSize];

		int result = _native.GetNext(_batchSize, elements, out uint elementsFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (elementsFetched == 0) return 0;

		if (elementsFetched > int.MaxValue) throw new InvalidDataException(_dataSizeMessage);

		AddRangeToCache(new ReadOnlySpan<nint>(elements, (int)elementsFetched));

		return elementsFetched;
	}
}
