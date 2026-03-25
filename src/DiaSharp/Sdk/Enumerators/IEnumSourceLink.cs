namespace DiaSharp.Sdk.Enumerators;

[GeneratedComInterface]
[Guid("45cd1eb3-5c6c-43e3-b20a-a4d8035de4e2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumSourceLink
{
	uint Count();

	uint SizeOfNext();

	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] GetNext(uint bufferSize, out uint bytesWritten);

	void Skip(uint byteCount);

	void Reset();

	IEnumSourceLink Clone();
}
