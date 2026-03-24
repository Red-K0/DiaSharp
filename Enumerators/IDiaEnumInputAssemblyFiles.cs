using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[DefaultMember(nameof(Item))]
[Guid("1C7FF653-51F7-457E-8419-B20F57EF7E4D")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumInputAssemblyFiles
{
	IEnumVARIANT get__NewEnum();

	[DispId(1)]
	int get_Count();

	IDiaInputAssemblyFile Item(uint index);

	uint Next(uint celt, [MarshalUsing(CountElementName = nameof(celt))] out IDiaInputAssemblyFile[] rgelt);

	void Skip(uint celt);

	void Reset();

	IDiaEnumInputAssemblyFiles Clone();
}
