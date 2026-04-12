using DiaSharp.CodeView;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.SDK;

public partial interface ISession
{
	int GetLoadAddress(out ulong address);

	int PutLoadAddress(ulong address);

	int GetGlobalScope(out ISymbol scope);

	int GetEnumTables(out IEnumTables tables);

	int GetSymbolsByAddress(out IEnumSymbolsByAddress symbols);

	int FindChildren(ISymbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions, out IEnumSymbols symbols);

	int FindChildrenEx(ISymbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions, out IEnumSymbols symbols);

	int FindChildrenExByAddress(ISymbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions, uint sectionIndex, uint offset, out IEnumSymbols symbols);

	int FindChildrenExByVA(ISymbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions, ulong virtualAddress, out IEnumSymbols symbols);

	int FindChildrenExByRVA(ISymbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions, uint relativeVirtualAddress, out IEnumSymbols symbols);

	int FindSymbolByAddress(uint sectionIndex, uint offset, SymbolTag tag, out ISymbol symbol);

	int FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag tag, out ISymbol symbol);

	int FindSymbolByVA(ulong virtualAddress, SymbolTag tag, out ISymbol symbol);

	int FindSymbolByToken(uint token, SymbolTag tag, out ISymbol symbol);

	int SymbolsAreEquivalent(ISymbol symbolA, ISymbol symbolB);

	int SymbolByID(uint id, out ISymbol symbol);

	int FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag tag, out int displacement, out ISymbol symbol);

	int FindSymbolByVA(ulong VirtualAddress, SymbolTag tag, out int displacement, out ISymbol symbol);

	int FindFile(ISymbol compiland, string name, NameSearchOptions searchOptions, out IEnumSourceFiles files);

	int FindFileByID(uint uniqueId, out ISourceFile file);

	int FindLines(ISymbol compiland, ISourceFile file, out IEnumLineNumbers lines);

	int FindLinesByAddress(uint segment, uint offset, uint length, out IEnumLineNumbers lines);

	int FindLinesByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines);

	int FindLinesByVA(ulong virtualAddress, uint length, out IEnumLineNumbers lines);

	int FindLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines);

	int FindInjectedSource(string sourceFile, out IEnumInjectedSources sources);

	int GetEnumDebugStreams(out IEnumDebugStreams streams);

	int FindInlineFramesByAddress(ISymbol parent, uint sectionIndex, uint offset, out IEnumSymbols inlinees);

	int FindInlineFramesByRVA(ISymbol parent, uint relativeVirtualAddress, out IEnumSymbols inlinees);

	int FindInlineFramesByVA(ISymbol parent, ulong virtualAddress, out IEnumSymbols inlinees);

	int FindInlineeLines(ISymbol parent, out IEnumLineNumbers lines);

	int FindInlineeLinesByAddress(ISymbol parent, uint isect, uint offset, uint length, out IEnumLineNumbers lines);

	int FindInlineeLinesByRVA(ISymbol parent, uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines);

	int FindInlineeLinesByVA(ISymbol parent, ulong virtualAddress, uint length, out IEnumLineNumbers lines);

	int FindInlineeLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines);

	int FindInlineesByName(string name, NameSearchOptions searchOptions, out IEnumSymbols inlinees);

	int FindAcceleratorInlineeLinesByLineNumber(ISymbol parent, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines);

	int FindSymbolsForAcceleratorPointerTag(ISymbol parent, uint tagValue, out IEnumSymbols symbols);

	int FindSymbolsByRVAForAcceleratorPointerTag(ISymbol parent, uint tagValue, uint relativeVirtualAddress, out IEnumSymbols symbols);

	int FindAcceleratorInlineesByName(string name, NameSearchOptions searchOptions, out IEnumSymbols symbols);

	int GetAddressForVA(ulong virtualAddress, out uint sectionIndex, out uint address);

	int GetAddressForRVA(uint relativeVirtualAddress, out uint sectionIndex, out uint address);

	int FindILOffsetsByAddress(uint sectionIndex, uint offset, uint length, out IEnumLineNumbers lines);

	int FindILOffsetsByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines);

	int FindILOffsetsByVA(ulong virtualAddress, uint length, out IEnumLineNumbers lines);

	int FindInputAssemblyFiles(out IEnumInputAssemblyFiles files);

	int FindInputAssembly(uint index, out IInputAssemblyFile assembly);

	int FindInputAssemblyByID(uint uniqueId, out IInputAssemblyFile assembly);

	int GetFunctionMetadataTokenMapSize(out uint size);

	unsafe int GetFunctionMetadataTokenMap(uint bufferSize, out uint bytesWritten, byte* buffer);

	int GetTypeMetadataTokenMapSize(out uint size);

	unsafe int GetTypeMetadataTokenMap(uint bufferSize, out uint bytesWritten, byte* buffer);

	int GetNumberOfFunctionFragmentsForVA(ulong functionVA, uint functionSize, out uint fragmentCount);

	int GetNumberOfFunctionFragmentsForRVA(uint functionRVA, uint functionSize, out uint fragmentCount);

	unsafe int GetFunctionFragmentsForVA(ulong functionVA, uint functionSize, uint fragmentCount, uint* buffer, out uint fragmentsWritten);

	unsafe int GetFunctionFragmentsForRVA(uint functionRVA, uint functionSize, uint fragmentCount, uint* buffer, out uint fragmentsWritten);

	int GetExports(out IEnumSymbols exports);

	int GetHeapAllocationSites(out IEnumSymbols sites);

	int FindInputAssemblyFile(ISymbol symbol, out IInputAssemblyFile assembly);
}
