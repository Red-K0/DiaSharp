using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[DefaultMember("symIndexId")]
[Guid("611E86CD-B7D1-4546-8A15-070E2B07A427")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface IDiaSymbol2 : IDiaSymbol
{
	[DispId(216)]
	int get_isObjCClass();

	[DispId(217)]
	int get_isObjCCategory();

	[DispId(218)]
	int get_isObjCProtocol();
}
