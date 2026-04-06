namespace DiaSharp.SDK.Symbols;

public unsafe partial interface ISymbol3 : ISymbol2
{
	int GetInlinee(out ISymbol inlinee);

	int GetInlineeID(out uint ID);
}
