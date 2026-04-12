namespace DiaSharp.SDK;

public partial interface ISegment
{
	int GetFrame(out uint frame);

	int GetOffset(out uint offset);

	int GetLength(out uint length);

	int GetRead([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetWrite([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetExecute([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetAddressSection(out uint section);

	int GetRelativeVirtualAddress(out uint rva);

	int GetVirtualAddress(out ulong va);
};
