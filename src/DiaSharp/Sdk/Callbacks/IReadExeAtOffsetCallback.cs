namespace DiaSharp.SDK.Callbacks;

[GeneratedComInterface]
[Guid("587A461C-B80B-4f54-9194-5032589A6319")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IReadExeAtOffsetCallback
{
	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] ReadExecutableAt(ulong fileOffset, uint executableSize, out uint bytesWritten);
}
