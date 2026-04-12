using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

[Guid("FE30E878-54AC-44F1-81BA-39DE940F6052")]
public partial interface IEnumLineNumbers
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int Item(uint index, out ILineNumber number);

	unsafe int GetNext(uint lineCount, void** lines, out uint linesFetched);

	int Skip(uint lineCount);

	int Reset();

	int Clone(out IEnumLineNumbers enumerator);
}
