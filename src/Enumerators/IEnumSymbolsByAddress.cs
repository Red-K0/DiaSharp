using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Symbols;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("624B7D9C-24EA-4421-9D06-3B577471C1FA")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumSymbolsByAddress
{
	ISymbol GetSymbolByAddress(uint sectionNumber, uint offset);

	ISymbol GetSymbolByRVA(uint relativeVirtualAddress);

	ISymbol GetSymbolByVA(ulong virtualAddress);

	uint Next(uint symbolCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out ISymbol[] symbols);

	uint Prev(uint symbolCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out ISymbol[] symbols);

	IEnumSymbolsByAddress Clone();
}
