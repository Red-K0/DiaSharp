using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumSectionContribs
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int Item(uint index, out ISectionContrib contrib);

	unsafe int GetNext(uint contribCount, void** contribs, out uint contribsFetched);

	int Skip(uint contribCount);

	int Reset();

	int Clone(out IEnumSectionContribs enumerator);
}
