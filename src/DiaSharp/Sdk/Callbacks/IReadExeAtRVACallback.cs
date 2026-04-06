namespace DiaSharp.SDK.Callbacks;

public partial interface IReadExeAtRVACallback
{
	unsafe int ReadExecutableAtRVA(uint relativeVirtualAddress, uint executableSize, uint* bytesWritten, byte* buffer);
}
