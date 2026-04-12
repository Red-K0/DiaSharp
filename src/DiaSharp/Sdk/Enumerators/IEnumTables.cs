using DiaSharp.Interop;
using DiaSharp.Native;

namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumTables
{
	int GetNewEnum(out IEnumVARIANT enumrator);

	int GetCount(out int count);

	int Item(Variant index, out ITable table);

	unsafe int GetNext(uint tableCount, void** tables, out uint tablesFetched);

	int Skip(uint tableCount);

	int Reset();

	int Clone(out IEnumTables enumerator);
}
