using DiaSharp.Interop;

namespace DiaSharp.SDK;

public partial interface ITable : IEnumUnknown
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetName([MarshalAs(UnmanagedType.LPWStr)] out string name);

	int GetCount(out int count);

	unsafe int Item(uint index, out void* item);
}
