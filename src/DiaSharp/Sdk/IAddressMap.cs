using DiaSharp.Native;

namespace DiaSharp.SDK;

[Guid("B62A2E7A-067A-4ea3-B598-04C09717502C")]
public partial interface IAddressMap
{
	int GetIsAddressMapEnabled([MarshalAs(UnmanagedType.Bool)] out bool enabled);

	int SetIsAddressMapEnabled([MarshalAs(UnmanagedType.Bool)] bool enabled);

	int GetIsRelativeVirtualAddressEnabled([MarshalAs(UnmanagedType.Bool)] out bool enabled);

	int SetIsRelativeVirtualAddressEnabled([MarshalAs(UnmanagedType.Bool)] bool enabled);

	int GetImageAlignment(out uint alignment);

	int SetImageAlignment(uint value);

	unsafe int SetImageHeaders(uint dataSize, ImageSectionHeader* data, [MarshalAs(UnmanagedType.Bool)] bool originalHeaders);

	unsafe int SetAddressMap(uint dataSize, AddressMapEntry* data, [MarshalAs(UnmanagedType.Bool)] bool imageToSymbols);
};
