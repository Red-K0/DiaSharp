using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("99B665F7-C1B2-49D3-89B2-A384361ACAB5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface ISymbol3 : ISymbol2
{
	ISymbol GetInlinee();

	uint GetInlineeID();
}
