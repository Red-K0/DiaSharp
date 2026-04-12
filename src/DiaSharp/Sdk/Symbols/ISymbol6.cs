namespace DiaSharp.SDK.Symbols;

[Guid("8133DAD3-75FE-4234-AC7E-F8E7A1D3CBB3")]
public unsafe partial interface ISymbol6 : ISymbol5
{
	int GetIsStaticMemberFunction([MarshalAs(UnmanagedType.Bool)] out bool isStatic);
}
