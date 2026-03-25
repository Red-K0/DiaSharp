using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("8133DAD3-75FE-4234-AC7E-F8E7A1D3CBB3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface ISymbol6 : ISymbol5
{
	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsStaticMemberFunction();
}
