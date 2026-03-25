using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("A89E5969-92A1-4F8A-B704-00121C37ABBB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface ISymbol9 : ISymbol8
{
	uint GetFramePadSize();

	uint GetFramePadOffset();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsRuntimeStaticChecked();
}
