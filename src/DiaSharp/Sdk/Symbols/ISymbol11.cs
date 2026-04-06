using DiaSharp.Native;

namespace DiaSharp.SDK.Symbols;

public unsafe partial interface ISymbol11 : ISymbol10
{
	int GetDiscriminatedUnionTag(out ISymbol tagType, out uint tagOffset, out TagValue tagMask);

	unsafe int GetTagRanges(uint valueCount, out uint filledValueCount, TagValue* rangeValues);
}
