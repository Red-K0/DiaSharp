namespace DiaSharp.Storage;

[Guid("00000139-0000-0000-C000-000000000046")]
public partial interface IEnumStatPropertyStorage
{
	int Clone(out IEnumStatPropertyStorage enumerator);

	unsafe int GetNext(uint propertyCount, StatPropertyStorage* properties, out uint propertiesWritten);

	int Reset();

	int Skip(uint propertyCount);
}
