namespace DiaSharp.SDK.Callbacks;

[Guid("587A461C-B80B-4f54-9194-5032589A6319")]
public partial interface IReadExeAtOffsetCallback
{
	unsafe int ReadExecutableAt(ulong fileOffset, uint executableSize, uint* bytesWritten, byte* buffer);
}
