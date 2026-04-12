namespace DiaSharp.SDK.Symbols;

public unsafe partial interface ISymbol9 : ISymbol8
{
	int GetFramePadSize(out uint size);

	int GetFramePadOffset(out uint offset);

	int GetIsRuntimeStaticChecked([MarshalAs(UnmanagedType.Bool)] out bool enabled);
}
