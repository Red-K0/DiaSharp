using DiaSharp.CodeView;

namespace DiaSharp.SDK.Symbols;

[Guid("7F2E041F-1294-41BD-B83A-E715972D2CE3")]
public unsafe partial interface ISymbol8 : ISymbol7
{
	int GetCoroutineKind(out CoroutineKind kind);

	int GetAssociatedSymbolKind(out AssociationKind kind);

	int GetAssociatedSymbolSection(out uint section);

	int GetAssociatedSymbolOffset(out uint offset);

	int GetAssociatedSymbolRVA(out uint rva);

	int GeAassociatedSymbolAddress(out ulong address);
}
