namespace DiaSharp.SDK.Callbacks;

public partial interface IReadExeAtOffsetCallback
{
	unsafe int ReadExecutableAt(ulong fileOffset, uint executableSize, uint* bytesWritten, byte* buffer);
}
