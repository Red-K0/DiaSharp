namespace DiaSharp.SDK.Symbols;

[Guid("611E86CD-B7D1-4546-8A15-070E2B07A427")]
public unsafe partial interface ISymbol2 : ISymbol
{
	int GetIsObjectiveCClass([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetIsObjectiveCCategory([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetIsObjectiveCProtocol([MarshalAs(UnmanagedType.Bool)] out bool value);
}
