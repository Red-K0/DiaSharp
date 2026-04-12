using DiaSharp.SDK.Symbols;

namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumSymbolsByAddressEx : IEnumSymbolsByAddress
{
	int GetSymbolByAddress([MarshalAs(UnmanagedType.Bool)] bool promoteBlockSymbols, uint sectionNumber, uint offset, out ISymbol symbol);

	int GetSymbolByRVA([MarshalAs(UnmanagedType.Bool)] bool promoteBlockSymbols, uint relativeVirtualAddress, out ISymbol symbol);

	int GetSymbolByVA([MarshalAs(UnmanagedType.Bool)] bool promoteBlockSymbols, ulong virtualAddress, out ISymbol symbol);

	unsafe int GetNext([MarshalAs(UnmanagedType.Bool)] bool promoteBlockSymbols, uint symbolCount, void** symbols, out uint symbolsFetched);

	unsafe int Prev([MarshalAs(UnmanagedType.Bool)] bool promoteBlockSymbols, uint symbolCount, void** symbols, out uint symbolsFetched);
}
