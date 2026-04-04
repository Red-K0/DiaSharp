namespace DiaSharp.SDK.Symbols;

public partial interface ISymbol6 : ISymbol5
{
	int GetIsStaticMemberFunction([MarshalAs(UnmanagedType.Bool)] out bool isStatic);
}
