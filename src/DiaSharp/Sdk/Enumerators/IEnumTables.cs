using DiaSharp.Interop;
using DiaSharp.Native;

namespace DiaSharp.SDK.Enumerators;

[Guid("C65C2B0A-1150-4D7A-AFCC-E05BF3DEE81E")]
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
