using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Enumerators;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("A2EF5353-F5A8-4EB3-90D2-CB526ACB3CDD")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaSourceFile
{
	[DispId(2)]
	uint get_uniqueId();

	[DispId(3)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_fileName();

	[DispId(4)]
	uint get_checksumType();

	[DispId(5)]
	IDiaEnumSymbols get_compilands();

	[return: MarshalUsing(CountElementName = nameof(cbData))]
	byte[] get_checksum(uint cbData, out uint pcbData);
}
