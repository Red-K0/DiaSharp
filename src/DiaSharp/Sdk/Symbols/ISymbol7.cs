namespace DiaSharp.SDK.Symbols;

[Guid("64CE6CD5-7315-4328-86D6-10E303E010B4")]
public unsafe partial interface ISymbol7 : ISymbol6
{
	int GetIsSignedReturn([MarshalAs(UnmanagedType.Bool)] out bool signed);
}
