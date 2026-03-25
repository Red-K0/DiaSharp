using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Symbols;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("1E45BD02-BE45-4D71-BA32-0E576CFCD59F")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumSymbolsByAddressEx : IEnumSymbolsByAddress
{
	ISymbol GetSymbolByAddress([MarshalAs(UnmanagedType.Bool)] bool promoteBlockSymbols, uint sectionNumber, uint offset);

	ISymbol GetSymbolByRVA([MarshalAs(UnmanagedType.Bool)] bool promoteBlockSymbols, uint relativeVirtualAddress);

	ISymbol GetSymbolByVA([MarshalAs(UnmanagedType.Bool)] bool promoteBlockSymbols, ulong virtualAddress);

	uint GetNext([MarshalAs(UnmanagedType.Bool)] bool promoteBlockSymbols, uint symbolCount, [MarshalUsing(CountElementName = nameof(symbolCount))] out ISymbol[] symbols);

	uint Prev([MarshalAs(UnmanagedType.Bool)] bool promoteBlockSymbols, uint symbolCount, [MarshalUsing(CountElementName = nameof(symbolCount))] out ISymbol[] symbols);
}
