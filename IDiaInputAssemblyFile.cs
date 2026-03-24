using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("3BFE56B0-390C-4863-9430-1F3D083B7684")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaInputAssemblyFile
{
	[DispId(1)]
	uint GetUniqueID();

	[DispId(2)]
	uint GetIndex();

	[DispId(3)]
	uint GetTimestamp();

	[DispId(4)]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetPdbAvailableAtILMerge();

	[DispId(5)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFilename();

	void GetVersion(uint bufferSize, out uint dataSize, [MarshalUsing(CountElementName = nameof(bufferSize))] out byte[] data);
}
