namespace DiaSharp.Sdk;

[GeneratedComInterface]
[Guid("3BFE56B0-390C-4863-9430-1F3D083B7684")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IInputAssemblyFile
{
	uint GetUniqueID();

	uint GetIndex();

	uint GetTimestamp();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetWasPdbAvailableAtILMerge();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFilename();

	[return: MarshalUsing(CountElementName = nameof(bufferSize))]
	byte[] GetVersion(uint bufferSize, out uint dataSize);
}
