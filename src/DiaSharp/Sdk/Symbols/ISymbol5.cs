namespace DiaSharp.SDK.Symbols;

[Guid("ABE2DE00-DC2D-4793-AF9A-EF1D90832644")]
public unsafe partial interface ISymbol5 : ISymbol4
{
	int GetHasAbsoluteAddress([MarshalAs(UnmanagedType.Bool)] out bool absolute);
}
