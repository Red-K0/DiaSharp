namespace DiaSharp.SDK.Symbols;

[Guid("BF6C88A7-E9D6-4346-99A1-D053DE5A7808")]
public unsafe partial interface ISymbol4 : ISymbol3
{
	int GetIsNoExcept([MarshalAs(UnmanagedType.Bool)] out bool noexcept);
}
