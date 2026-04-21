using DiaSharp.COM;
using DiaSharp.SDK;

namespace DiaSharp.Managed;

public class Table(ITable native) : ComEnumerable<ITable, nint>(native)
{
	protected override unsafe bool TryFetchBatch()
	{
		void** elements = stackalloc void*[(int)_batchSize];

		int result = _native.GetNext(_batchSize, elements, out uint elementsFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (elementsFetched == 0) return false;

		AddRangeToCache(new ReadOnlySpan<nint>(elements, (int)elementsFetched));

		return true;
	}
}
