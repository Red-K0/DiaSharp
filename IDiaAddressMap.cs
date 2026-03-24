using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Structs;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("B62A2E7A-067A-4ea3-B598-04C09717502C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaAddressMap
{
	[DispId(3)]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool get_addressMapEnabled();

	[DispId(3)]
	void set_addressMapEnabled([MarshalAs(UnmanagedType.Bool)] bool value);

	[DispId(4)]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool get_relativeVirtualAddressEnabled();

	[DispId(4)]
	void set_relativeVirtualAddressEnabled([MarshalAs(UnmanagedType.Bool)] bool value);

	[DispId(5)]
	uint get_imageAlign();

	[DispId(5)]
	void set_imageAlign(uint value);

	void set_imageHeaders(uint cData, [MarshalUsing(CountElementName = nameof(cData))] ImageSectionHeader[] pData, [MarshalAs(UnmanagedType.Bool)] bool originalHeaders);

	void set_addressMap(uint cData, [MarshalUsing(CountElementName = nameof(cData))] AddressMapEntry[] pData, [MarshalAs(UnmanagedType.Bool)] bool imageToSymbols);
};
