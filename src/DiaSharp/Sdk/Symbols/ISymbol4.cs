namespace DiaSharp.SDK.Symbols;

public partial interface ISymbol4 : ISymbol3
{
	int GetIsNoExcept([MarshalAs(UnmanagedType.Bool)] out bool noexcept);
}
