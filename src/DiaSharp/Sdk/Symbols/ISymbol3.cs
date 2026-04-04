namespace DiaSharp.SDK.Symbols;

public partial interface ISymbol3 : ISymbol2
{
	int GetInlinee(out ISymbol inlinee);

	int GetInlineeID(out uint ID);
}
