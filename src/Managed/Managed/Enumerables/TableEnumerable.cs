using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

sealed internal class TableEnumerable(IEnumTables native) : ComEnumerable<IEnumTables, Table>(native)
{
	protected override unsafe uint TryFetchBatch()
	{
		void** tables = stackalloc void*[(int)BatchSize];

		int result = _native.GetNext(BatchSize, tables, out uint tablesFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (tablesFetched == 0) return 0;

		Table[] managed = new Table[tablesFetched];

		for (int i = 0; i < tablesFetched; i++) managed[i] = new(ComHelpers.Wrap<ITable>(tables[i]));

		AddRangeToCache(managed);

		return tablesFetched;
	}
}