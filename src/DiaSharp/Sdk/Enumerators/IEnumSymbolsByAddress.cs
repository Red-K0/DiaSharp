using DiaSharp.SDK.Symbols;

namespace DiaSharp.SDK.Enumerators;

[Guid("624B7D9C-24EA-4421-9D06-3B577471C1FA")]
public partial interface IEnumSymbolsByAddress
{
	int GetSymbolByAddress(uint sectionNumber, uint offset, out ISymbol symbol);

	int GetSymbolByRVA(uint relativeVirtualAddress, out ISymbol symbol);

	int GetSymbolByVA(ulong virtualAddress, out ISymbol symbol);

	unsafe int GetNext(uint symbolCount, void** symbols, out uint symbolsFetched);

	unsafe int GetPrevious(uint symbolCount, void** symbols, out uint symbolsFetched);

	int Clone(out IEnumSymbolsByAddress enumeator);
}
