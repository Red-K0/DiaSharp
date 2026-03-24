using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[DefaultMember(nameof(Item))]
[Guid("D5612573-6925-4468-8883-98CDEC8C384A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumInjectedSources
{
	IEnumVARIANT get__NewEnum();

	[DispId(1)]
	int get_Count();

	IDiaInjectedSource Item(uint index);

	uint Next(uint celt, [MarshalUsing(CountElementName = nameof(celt))] out IDiaInjectedSource[] rgelt);

	void Skip(uint celt);

	void Reset();

	IDiaEnumInjectedSources Clone();
}
