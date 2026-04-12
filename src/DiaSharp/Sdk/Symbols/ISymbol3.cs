namespace DiaSharp.SDK.Symbols;

[Guid("99B665F7-C1B2-49D3-89B2-A384361ACAB5")]
public unsafe partial interface ISymbol3 : ISymbol2
{
	int GetInlinee(out ISymbol inlinee);

	int GetInlineeID(out uint ID);
}
