using DiaSharp.CodeView;

namespace DiaSharp.SDK.Symbols;

public unsafe partial interface ISymbol8 : ISymbol7
{
	int GetCoroutineKind(out CoroutineKind kind);

	int GetAssociatedSymbolKind(out AssociationKind kind);

	int GetAssociatedSymbolSection(out uint section);

	int GetAssociatedSymbolOffset(out uint offset);

	int GetAssociatedSymbolRVA(out uint rva);

	int GeAassociatedSymbolAddress(out ulong address);
}
