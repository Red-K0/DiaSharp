namespace DiaSharp.SDK;

[Guid("C8E40ED2-A1D9-4221-8692-3CE661184B44")]
public partial interface IImageData
{
	int GetRelativeVirtualAddress(out uint rva);

	int GetVirtualAddress(out ulong va);

	int GetImageBase(out ulong imageBase);
}
