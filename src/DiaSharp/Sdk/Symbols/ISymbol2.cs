namespace DiaSharp.SDK.Symbols;

public partial interface ISymbol2 : ISymbol
{
	int GetIsObjectiveCClass([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetIsObjectiveCCategory([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetIsObjectiveCProtocol([MarshalAs(UnmanagedType.Bool)] out bool value);
}
