using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[DefaultMember(nameof(Item))]
[Guid("1994DEB2-2C82-4B1D-A57F-AFF424D54A68")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumSectionContribs
{
	IEnumVARIANT get__NewEnum();

	[DispId(1)]
	int get_Count();

	IDiaSectionContrib Item(uint index);

	uint Next(uint celt, [MarshalUsing(CountElementName = nameof(celt))] out IDiaSectionContrib[] rgelt);

	void Skip(uint celt);

	void Reset();

	IDiaEnumSectionContribs Clone();
}
