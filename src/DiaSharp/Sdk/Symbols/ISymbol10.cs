namespace DiaSharp.SDK.Symbols;

public partial interface ISymbol10 : ISymbol9
{
	unsafe int GetSourceLink(uint bufferSize, out uint blobSize, byte* buffer);
}
