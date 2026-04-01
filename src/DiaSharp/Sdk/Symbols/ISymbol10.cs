namespace DiaSharp.SDK.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("9034A70B-B0B7-4605-8A97-33772F3A7B8C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISymbol10 : ISymbol9
{
	[return: MarshalUsing(CountElementName = nameof(blobSize))]
	byte[] GetSourceLink(uint bufferSize, out uint blobSize);
}
