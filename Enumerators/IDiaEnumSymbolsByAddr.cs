using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Symbols;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("624B7D9C-24EA-4421-9D06-3B577471C1FA")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumSymbolsByAddr
{
	IDiaSymbol symbolByAddr(uint isect, uint offset);

	IDiaSymbol symbolByRVA(uint relativeVirtualAddress);

	IDiaSymbol symbolByVA(ulong virtualAddress);

	uint Next(uint celt, [MarshalUsing(CountElementName = nameof(celt))] out IDiaSymbol[] rgelt);

	uint Prev(uint celt, [MarshalUsing(CountElementName = nameof(celt))] out IDiaSymbol[] rgelt);

	IDiaEnumSymbolsByAddr Clone();
}
