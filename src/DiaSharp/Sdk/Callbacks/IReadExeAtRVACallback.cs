namespace DiaSharp.SDK.Callbacks;

[Guid("8E3F80CA-7517-432a-BA07-285134AAEA8E")]
public partial interface IReadExeAtRVACallback
{
	unsafe int ReadExecutableAtRVA(uint relativeVirtualAddress, uint executableSize, uint* bytesWritten, byte* buffer);
}
