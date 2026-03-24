using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[DefaultMember(nameof(Item))]
[Guid("486943E8-D187-4A6B-A3C4-291259FFF60D")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumDebugStreamData
{
	IEnumVARIANT get__NewEnum();

	[DispId(1)]
	int get_Count();

	[DispId(2)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_Name();

	[return: MarshalUsing(CountElementName = nameof(cbData))]
	byte[] Item(uint index, uint cbData, out uint pcbData);

	uint Next(uint celt, uint cbData, out uint pcbData, [MarshalUsing(CountElementName = nameof(cbData))] out byte[] pbData);

	void Skip(uint celt);

	void Reset();

	IDiaEnumDebugStreamData Clone();
}
