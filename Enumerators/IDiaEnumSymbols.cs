using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;
using DiaSharp.Symbols;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[DefaultMember(nameof(Item))]
[Guid("CAB72C48-443B-48F5-9B0B-42F0820AB29A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumSymbols
{
	IEnumVARIANT get__NewEnum();

	[DispId(1)]
	int get_count();

	IDiaSymbol Item(uint index);

	void Next(uint elementCount, [MarshalUsing(CountElementName = nameof(elementCount))] out IDiaSymbol[] elements, out uint elementsFetched);

	void Skip(uint celt);

	void Reset();

	IDiaEnumSymbols Clone();
}
