using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Callbacks;

[GeneratedComInterface]
[Guid("587A461C-B80B-4f54-9194-5032589A6319")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaReadExeAtOffsetCallback
{
	[return: MarshalUsing(CountElementName = nameof(cbData))]
	byte[] ReadExecutableAt(ulong fileOffset, uint cbData, out uint pcbData);
}
