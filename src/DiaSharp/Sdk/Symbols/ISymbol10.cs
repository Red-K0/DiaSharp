namespace DiaSharp.SDK.Symbols;

public unsafe partial interface ISymbol10 : ISymbol9
{
	unsafe int GetSourceLink(uint bufferSize, out uint blobSize, byte* buffer);
}
