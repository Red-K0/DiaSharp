namespace DiaSharp.Interop;

[Guid("00000100-0000-0000-C000-000000000046")]
public partial interface IEnumUnknown
{
	int Clone(out IEnumUnknown enumerator);

	unsafe int GetNext(uint elementCount, void** elements, out uint elementsFetched);

	int Reset();

	int Skip(uint elementCount);
}
