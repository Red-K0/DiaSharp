using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[DefaultMember("symIndexId")]
[Guid("BF6C88A7-E9D6-4346-99A1-D053DE5A7808")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface IDiaSymbol4 : IDiaSymbol3
{
	[DispId(221)]
	int get_noexcept();
}
