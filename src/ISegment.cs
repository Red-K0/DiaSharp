using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("0775B784-C75B-4449-848B-B7BD3159545B")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISegment
{
	uint GetFrame();
	
	uint GetOffset();
	
	uint GetLength();
	
	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetRead();
	
	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetWrite();
	
	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetExecute();
	
	uint GetAddressSection();
	
	uint GetRelativeVirtualAddress();
	
	ulong GetVirtualAddress();
};
