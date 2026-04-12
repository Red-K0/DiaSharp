namespace DiaSharp.SDK.Symbols;

public unsafe partial interface ISymbol6 : ISymbol5
{
	int GetIsStaticMemberFunction([MarshalAs(UnmanagedType.Bool)] out bool isStatic);
}
