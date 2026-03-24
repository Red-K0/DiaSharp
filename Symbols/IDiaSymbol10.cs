using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[DefaultMember("symIndexId")]
[Guid("9034A70B-B0B7-4605-8A97-33772F3A7B8C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface IDiaSymbol10 : IDiaSymbol9
{
	void get_sourceLink(uint cb, out uint pcb, [MarshalUsing(CountElementName = nameof(cb))] out byte[] pb);
}
