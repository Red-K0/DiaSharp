using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Symbols;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("1E45BD02-BE45-4D71-BA32-0E576CFCD59F")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumSymbolsByAddr2 : IDiaEnumSymbolsByAddr
{
	IDiaSymbol symbolByAddrEx(int fPromoteBlockSym, uint isect, uint offset);

	IDiaSymbol symbolByRVAEx(int fPromoteBlockSym, uint relativeVirtualAddress);

	IDiaSymbol symbolByVAEx(int fPromoteBlockSym, ulong virtualAddress);

	uint NextEx(int fPromoteBlockSym, uint celt, [MarshalUsing(CountElementName = nameof(celt))] out IDiaSymbol[] rgelt);

	uint PrevEx(int fPromoteBlockSym, uint celt, [MarshalUsing(CountElementName = nameof(celt))] out IDiaSymbol[] rgelt);
}
