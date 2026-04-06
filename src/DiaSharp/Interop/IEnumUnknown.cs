namespace DiaSharp.Interop;

public partial interface IEnumUnknown
{
	int Clone(out IEnumUnknown enumerator);

	unsafe int GetNext(uint elementCount, void** elements, out uint elementsFetched);

	int Reset();

	int Skip(uint elementCount);
}
