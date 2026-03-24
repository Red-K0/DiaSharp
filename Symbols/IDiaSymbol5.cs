using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[DefaultMember("symIndexId")]
[Guid("ABE2DE00-DC2D-4793-AF9A-EF1D90832644")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface IDiaSymbol5 : IDiaSymbol4
{
	[DispId(222)]
	int get_hasAbsoluteAddress();
}
