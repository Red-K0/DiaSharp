using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

internal class TableEnumerable(IEnumTables native) : ComEnumerable<IEnumTables, Table>(native)
{
	protected override unsafe bool TryFetchBatch()
	{
		void** tables = stackalloc void*[(int)_batchSize];

		int result = _native.GetNext(_batchSize, tables, out uint tablesFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (tablesFetched == 0) return false;

		Table[] managed = new Table[tablesFetched];

		for (int i = 0; i < tablesFetched; i++) managed[i] = new(ComHelpers.Wrap<ITable>(tables[i]));

		AddRangeToCache(managed);

		return true;
	}
}