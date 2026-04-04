namespace DiaSharp.SDK.Callbacks;

public partial interface IReadExeAtRVACallback
{
	unsafe void ReadExecutableAtRVA(uint relativeVirtualAddress, uint executableSize, uint* bytesWritten, byte* buffer);
}
