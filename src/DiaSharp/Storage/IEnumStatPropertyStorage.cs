namespace DiaSharp.Storage;

[GeneratedComInterface]
[Guid("00000139-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumStatPropertyStorage
{
	IEnumStatPropertyStorage Clone();

	uint GetNext(uint propertyCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out StatPropertyStorage[] properties);

	void Reset();

	void Skip(uint propertyCount);
}
