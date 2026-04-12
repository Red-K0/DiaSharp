using DiaSharp.Interop;

namespace DiaSharp.SDK;

[Guid("4A59FB77-ABAC-469B-A30B-9ECC85BFEF14")]
public partial interface ITable : IEnumUnknown
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetName([MarshalAs(UnmanagedType.LPWStr)] out string name);

	int GetCount(out int count);

	unsafe int Item(uint index, out void* item);
}
