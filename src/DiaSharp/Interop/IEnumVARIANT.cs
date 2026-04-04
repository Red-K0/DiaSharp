namespace DiaSharp.Interop;

public partial interface IEnumVARIANT
{
	IEnumVARIANT Clone();

	unsafe uint GetNext(uint elementCount, void** elements);

	void Reset();

	uint Skip();
}