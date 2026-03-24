using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[DefaultMember("symIndexId")]
[Guid("7F2E041F-1294-41BD-B83A-E715972D2CE3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface IDiaSymbol8 : IDiaSymbol7
{
	[DispId(225)]
	uint get_coroutineKind();

	[DispId(226)]
	uint get_associatedSymbolKind();

	[DispId(227)]
	uint get_associatedSymbolSection();

	[DispId(228)]
	uint get_associatedSymbolOffset();

	[DispId(229)]
	uint get_associatedSymbolRva();

	[DispId(230)]
	ulong get_associatedSymbolAddr();
}
