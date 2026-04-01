using DiaSharp.SDK.Enumerators;

namespace DiaSharp.SDK;

[GeneratedComInterface]
[Guid("A2EF5353-F5A8-4EB3-90D2-CB526ACB3CDD")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISourceFile
{
	uint GetUniqueID();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFileName();

	uint GetChecksumType();

	IEnumSymbols GetCompilands();

	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] GetChecksum(uint bufferSize, out uint bytesWritten);
}
