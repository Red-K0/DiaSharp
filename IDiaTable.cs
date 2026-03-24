using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp;

[GeneratedComInterface]
[DefaultMember(nameof(Item))]
[Guid("4A59FB77-ABAC-469B-A30B-9ECC85BFEF14")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaTable : IEnumUnknown
{
	IEnumVARIANT get__NewEnum();

	[DispId(1)]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string get_name();

	[DispId(2)]
	int get_count();

	IUnknown Item(uint index);
}
