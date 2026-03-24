using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("0775B784-C75B-4449-848B-B7BD3159545B")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaSegment
{
	[DispId(1)]
	uint get_frame();
	
	[DispId(2)]
	uint get_offset();
	
	[DispId(3)]
	uint get_length();
	
	[DispId(4)]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool get_read();
	
	[DispId(5)]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool get_write();
	
	[DispId(6)]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool get_execute();
	
	[DispId(7)]
	uint get_addressSection();
	
	[DispId(8)]
	uint get_relativeVirtualAddress();
	
	[DispId(9)]
	ulong get_virtualAddress();
};
