using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("611E86CD-B7D1-4546-8A15-070E2B07A427")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISymbol2 : ISymbol
{
	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsObjectiveCClass();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsObjectiveCCategory();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsObjectiveCProtocol();
}
