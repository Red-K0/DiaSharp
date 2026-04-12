namespace DiaSharp.SDK;

public partial interface IInputAssemblyFile
{
	int GetUniqueID(out uint ID);

	int GetIndex(out uint index);

	int GetTimestamp(out uint timestamp);

	int GetWasPDBAvailableAtILMerge([MarshalAs(UnmanagedType.Bool)] out bool available);

	int GetFilename([MarshalAs(UnmanagedType.BStr)] out string name);

	unsafe int GetVersion(uint bufferSize, out uint dataSize, byte* buffer);
}
