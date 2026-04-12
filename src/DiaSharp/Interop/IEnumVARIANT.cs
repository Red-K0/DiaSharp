namespace DiaSharp.Interop;

[Guid("00020404-0000-0000-C000-000000000046")]
public partial interface IEnumVARIANT
{
	IEnumVARIANT Clone();

	unsafe uint GetNext(uint elementCount, void** elements);

	void Reset();

	uint Skip();
}