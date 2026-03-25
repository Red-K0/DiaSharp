namespace DiaSharp.CodeView.Hlsl;

/// <summary>
/// Specifies the HLSL memory space kind.
/// </summary>
/// <remarks>
/// Use the Symbol::GetmemorySpaceKind method to retrieve the memory space kind for an HLSL symbol.
/// </remarks>
[Obsolete(_Constants.HlslObsoleteMessage)]
public enum MemorySpace
{
	Data       = 0x00,
	Sampler    = 0x01,
	Resource   = 0x02,
	RWResource = 0x03,
	Max        = 0x0F,
}
