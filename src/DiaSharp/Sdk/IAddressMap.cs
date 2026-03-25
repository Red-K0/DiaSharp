using DiaSharp.Native;

namespace DiaSharp.Sdk;

[GeneratedComInterface]
[Guid("B62A2E7A-067A-4ea3-B598-04C09717502C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IAddressMap
{
	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsAddressMapEnabled();

	void SetIsAddressMapEnabled([MarshalAs(UnmanagedType.Bool)] bool value);

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsRelativeVirtualAddressEnabled();

	void SetIsRelativeVirtualAddressEnabled([MarshalAs(UnmanagedType.Bool)] bool value);

	uint GetImageAlignment();

	void SetImageAlignment(uint value);

	void SetImageHeaders(uint dataSize, [MarshalUsing(CountElementName = nameof(dataSize))] ImageSectionHeader[] data, [MarshalAs(UnmanagedType.Bool)] bool originalHeaders);

	void SetAddressMap(uint dataSize, [MarshalUsing(CountElementName = nameof(dataSize))] AddressMapEntry[] data, [MarshalAs(UnmanagedType.Bool)] bool imageToSymbols);
};
