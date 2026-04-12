namespace DiaSharp.SDK.Symbols;

[Guid("A89E5969-92A1-4F8A-B704-00121C37ABBB")]
public unsafe partial interface ISymbol9 : ISymbol8
{
	int GetFramePadSize(out uint size);

	int GetFramePadOffset(out uint offset);

	int GetIsRuntimeStaticChecked([MarshalAs(UnmanagedType.Bool)] out bool enabled);
}
