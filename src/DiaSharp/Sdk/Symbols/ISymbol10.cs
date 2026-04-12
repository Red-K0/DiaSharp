namespace DiaSharp.SDK.Symbols;

[Guid("9034A70B-B0B7-4605-8A97-33772F3A7B8C")]
public unsafe partial interface ISymbol10 : ISymbol9
{
	unsafe int GetSourceLink(uint bufferSize, out uint blobSize, byte* buffer);
}
