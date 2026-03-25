using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("BF6C88A7-E9D6-4346-99A1-D053DE5A7808")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISymbol4 : ISymbol3
{
	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsNoExcept();
}
