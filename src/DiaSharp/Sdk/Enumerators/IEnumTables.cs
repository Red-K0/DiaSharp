using DiaSharp.Interop;
using DiaSharp.Native;

namespace DiaSharp.SDK.Enumerators;

[GeneratedComInterface]
[Guid("C65C2B0A-1150-4D7A-AFCC-E05BF3DEE81E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumTables
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	ITable Item(Variant index);

	uint GetNext(uint tableCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out ITable[] tables);

	void Skip(uint tableCount);

	void Reset();

	IEnumTables Clone();
}
