using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Callbacks;

[GeneratedComInterface]
[Guid("8E3F80CA-7517-432a-BA07-285134AAEA8E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaReadExeAtRVACallback
{
	[return: MarshalUsing(CountElementName = nameof(cbData))]
	byte[] ReadExecutableAtRVA(uint relativeVirtualAddress, uint cbData, out uint pcbData);
}
