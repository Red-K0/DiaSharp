namespace DiaSharp.SDK.Symbols;

public partial interface ISymbol7 : ISymbol6
{
	int GetIsSignedReturn([MarshalAs(UnmanagedType.Bool)] out bool signed);
}
