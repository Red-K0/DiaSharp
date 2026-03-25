using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;
using DiaSharp.Structs;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("C65C2B0A-1150-4D7A-AFCC-E05BF3DEE81E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumTables
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	ITable Item(Variant index);

	uint Next(uint tableCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out ITable[] tables);

	void Skip(uint tableCount);

	void Reset();

	IEnumTables Clone();
}
