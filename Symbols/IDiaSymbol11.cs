using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Structs;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[DefaultMember("symIndexId")]
[Guid("B6F54FCD-05E3-433D-B305-B0C1437D2D16")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface IDiaSymbol11 : IDiaSymbol10
{
	void get_discriminatedUnionTag(out IDiaSymbol ppTagType, out uint pTagOffset, out TagValue pTagMask);

	void get_tagRanges(uint count, [MarshalUsing(CountElementName = nameof(count))] out uint[] pcRangeValues, [MarshalUsing(CountElementName = nameof(count))] out TagValue[] rangeValues);
}
