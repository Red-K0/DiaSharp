using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("C8E40ED2-A1D9-4221-8692-3CE661184B44")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaImageData
{
	[DispId(2)]
	uint get_relativeVirtualAddress();

	[DispId(3)]
	ulong get_virtualAddress();

	[DispId(4)]
	ulong get_imageBase();
}
