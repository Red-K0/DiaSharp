using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("AE605CDC-8105-4A23-B710-3259F1E26112")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IInjectedSource
{
	uint GetCRC();

	ulong GetLength();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFilename();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetObjectFilename();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetVirtualFilename();

	uint GetSourceCompression();

	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] GetSource(uint dataSize, out uint bytesWritten);
}
