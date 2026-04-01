namespace DiaSharp.SDK.Enumerators;

[GeneratedComInterface]
[Guid("136d8151-ade7-4704-af13-324080762e8f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumSourceLink2 : IEnumSourceLink
{
	ulong SizeOfNext2();

	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] GetNext(ulong bufferSize, out ulong bytesWritten);
}
