namespace DiaSharp.SDK.Callbacks;

public partial interface IReadExeAtOffsetCallback
{
	unsafe void ReadExecutableAt(ulong fileOffset, uint executableSize, uint* bytesWritten, byte* buffer);
}
