namespace DiaSharp.SDK;

[Guid("3BFE56B0-390C-4863-9430-1F3D083B7684")]
public partial interface IInputAssemblyFile
{
	int GetUniqueID(out uint id);

	int GetIndex(out uint index);

	int GetTimestamp(out uint timestamp);

	int GetWasPDBAvailableAtILMerge([MarshalAs(UnmanagedType.Bool)] out bool available);

	int GetFilename([MarshalAs(UnmanagedType.BStr)] out string name);

	unsafe int GetVersion(uint bufferSize, out uint dataSize, byte* buffer);
}
