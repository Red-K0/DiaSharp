namespace DiaSharp.SDK;

public partial interface IImageData
{
	int GetRelativeVirtualAddress(out uint rva);

	int GetVirtualAddress(out ulong va);

	int GetImageBase(out ulong imageBase);
}
