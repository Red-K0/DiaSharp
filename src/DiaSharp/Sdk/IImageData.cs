namespace DiaSharp.SDK;

[GeneratedComInterface]
[Guid("C8E40ED2-A1D9-4221-8692-3CE661184B44")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IImageData
{
	uint GetRelativeVirtualAddress();

	ulong GetVirtualAddress();

	ulong GetImageBase();
}
