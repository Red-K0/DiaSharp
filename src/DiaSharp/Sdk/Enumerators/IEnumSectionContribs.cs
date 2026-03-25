using DiaSharp.Interop;

namespace DiaSharp.Sdk.Enumerators;

[GeneratedComInterface]
[Guid("1994DEB2-2C82-4B1D-A57F-AFF424D54A68")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumSectionContribs
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	ISectionContrib Item(uint index);

	uint GetNext(uint contribCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out ISectionContrib[] contribs);

	void Skip(uint contribCount);

	void Reset();

	IEnumSectionContribs Clone();
}
