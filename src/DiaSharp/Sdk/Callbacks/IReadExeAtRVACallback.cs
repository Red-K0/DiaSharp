namespace DiaSharp.Sdk.Callbacks;

[GeneratedComInterface]
[Guid("8E3F80CA-7517-432a-BA07-285134AAEA8E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IReadExeAtRVACallback
{
	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] ReadExecutableAtRVA(uint relativeVirtualAddress, uint executableSize, out uint bytesWritten);
}
