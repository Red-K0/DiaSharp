using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[DefaultMember(nameof(Item))]
[Guid("C65C2B0A-1150-4D7A-AFCC-E05BF3DEE81E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumTables
{
	IEnumVARIANT get__NewEnum();

	[DispId(1)]
	int get_Count();

	IDiaTable Item(int index);

	IDiaTable Item([MarshalAs(UnmanagedType.BStr)] string name);

	uint Next(uint celt, [MarshalUsing(CountElementName = nameof(celt))] out IDiaTable[] rgelt);

	void Skip(uint celt);

	void Reset();

	IDiaEnumTables Clone();
}
