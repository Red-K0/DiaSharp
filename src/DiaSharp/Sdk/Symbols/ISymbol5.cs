namespace DiaSharp.SDK.Symbols;

public unsafe partial interface ISymbol5 : ISymbol4
{
	int GetHasAbsoluteAddress([MarshalAs(UnmanagedType.Bool)] out bool absolute);
}
