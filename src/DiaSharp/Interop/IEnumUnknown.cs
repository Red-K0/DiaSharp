namespace DiaSharp.Interop;

public partial interface IEnumUnknown
{
	void Clone(out IEnumUnknown enumerator);

	unsafe void GetNext(uint elementCount, void** elements, out uint elementsFetched);

	void Reset();

	void Skip(uint elementCount);
}
