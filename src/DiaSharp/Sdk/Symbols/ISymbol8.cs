using DiaSharp.CodeView;

namespace DiaSharp.SDK.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("7F2E041F-1294-41BD-B83A-E715972D2CE3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISymbol8 : ISymbol7
{
	CoroutineKind GetCoroutineKind();

	AssociationKind GetAssociatedSymbolKind();

	uint GetAssociatedSymbolSection();

	uint GetAssociatedSymbolOffset();

	uint GetAssociatedSymbolRVA();

	ulong GeAassociatedSymbolAddress();
}
