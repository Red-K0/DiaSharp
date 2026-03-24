using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[DefaultMember("symIndexId")]
[Guid("A89E5969-92A1-4F8A-B704-00121C37ABBB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface IDiaSymbol9 : IDiaSymbol8
{
	[DispId(231)]
	uint get_framePadSize();

	[DispId(232)]
	uint get_framePadOffset();

	[DispId(233)]
	int get_isRTCs();
}
