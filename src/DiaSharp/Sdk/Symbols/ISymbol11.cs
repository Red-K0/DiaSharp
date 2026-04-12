using DiaSharp.Native;

namespace DiaSharp.SDK.Symbols;

[Guid("B6F54FCD-05E3-433D-B305-B0C1437D2D16")]
public unsafe partial interface ISymbol11 : ISymbol10
{
	int GetDiscriminatedUnionTag(out ISymbol tagType, out uint tagOffset, out TagValue tagMask);

	unsafe int GetTagRanges(uint valueCount, out uint filledValueCount, TagValue* rangeValues);
}
