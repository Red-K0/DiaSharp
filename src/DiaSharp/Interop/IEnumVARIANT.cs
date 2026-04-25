namespace DiaSharp.Interop;

[Guid("00020404-0000-0000-C000-000000000046")]
public partial interface IEnumVARIANT
{
	int Clone(out IEnumVARIANT enumerator);

	unsafe int GetNext(uint elementCount, void** elements, out uint elementsFetched);

	int Reset();

	int Skip(uint elementCount);
}