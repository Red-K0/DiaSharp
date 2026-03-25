using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Structs;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("B6F54FCD-05E3-433D-B305-B0C1437D2D16")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface ISymbol11 : ISymbol10
{
	void GetDiscriminatedUnionTag(out ISymbol tagType, out uint tagOffset, out TagValue tagMask);

	void GetTagRanges(uint valueCount, out uint filledValueCount, [MarshalUsing(CountElementName = nameof(filledValueCount))] out TagValue[] rangeValues);
}
