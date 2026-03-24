using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[DefaultMember("symIndexId")]
[Guid("99B665F7-C1B2-49D3-89B2-A384361ACAB5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface IDiaSymbol3 : IDiaSymbol2
{
	[DispId(219)]
	IDiaSymbol get_inlinee();

	[DispId(220)]
	uint get_inlineeId();
}
