using DiaSharp.SDK.Symbols;

namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumSymbolsByAddress
{
	int GetSymbolByAddress(uint sectionNumber, uint offset, out ISymbol symbol);

	int GetSymbolByRVA(uint relativeVirtualAddress, out ISymbol symbol);

	int GetSymbolByVA(ulong virtualAddress, out ISymbol symbol);

	unsafe int GetNext(uint symbolCount, void** symbols, out uint symbolsFetched);

	unsafe int Prev(uint symbolCount, void** symbols, out uint symbolsFetched);

	int Clone(out IEnumSymbolsByAddress enumeator);
}
