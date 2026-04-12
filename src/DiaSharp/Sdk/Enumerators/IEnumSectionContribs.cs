using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

[Guid("1994DEB2-2C82-4B1D-A57F-AFF424D54A68")]
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
