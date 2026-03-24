using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("AE605CDC-8105-4A23-B710-3259F1E26112")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaInjectedSource
{
	[DispId(1)]
	uint get_crc();

	[DispId(2)]
	ulong get_length();

	[DispId(3)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_fileName();

	[DispId(4)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_objectFileName();

	[DispId(5)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_virtualFilename();

	[DispId(6)]
	uint get_sourceCompression();

	[return: MarshalUsing(CountElementName = nameof(cbData))]
	byte[] get_source(uint cbData, out uint pcbData);
}
