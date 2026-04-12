namespace DiaSharp.Storage;

public partial interface IEnumStatPropertyStorage
{
	int Clone(out IEnumStatPropertyStorage enumerator);

	unsafe int GetNext(uint propertyCount, StatPropertyStorage* properties, out uint propertiesWritten);

	int Reset();

	int Skip(uint propertyCount);
}
