using DiaSharp.CodeView;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.SDK;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("2F609EE1-D1C8-4E24-8288-3326BADCD211")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISession
{
	ulong GetLoadAddress();

	void PutLoadAddress(ulong virtualAddresslue);

	ISymbol GetGlobalScope();

	IEnumTables GetEnumTables();

	IEnumSymbolsByAddress GetSymbolsByAddress();

	IEnumSymbols FindChildren(ISymbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions);

	IEnumSymbols FindChildrenEx(ISymbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions);

	IEnumSymbols FindChildrenExByAddress(ISymbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions, uint sectionIndex, uint offset);

	IEnumSymbols FindChildrenExByVA(ISymbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions, ulong virtualAddress);

	IEnumSymbols FindChildrenExByRVA(ISymbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions, uint relativeVirtualAddress);

	ISymbol FindSymbolByAddress(uint sectionIndex, uint offset, SymbolTag tag);

	ISymbol FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag tag);

	ISymbol FindSymbolByVA(ulong virtualAddress, SymbolTag tag);

	ISymbol FindSymbolByToken(uint token, SymbolTag tag);

	void SymbolsAreEquivirtualAddresslent(ISymbol symbolA, ISymbol symbolB);

	ISymbol SymbolByID(uint id);

	ISymbol FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag tag, out int displacement);

	ISymbol FindSymbolByVA(ulong VirtualAddress, SymbolTag tag, out int displacement);

	IEnumSourceFiles FindFile(ISymbol compiland, string name, NameSearchOptions searchOptions);

	ISourceFile FindFileByID(uint uniqueId);

	IEnumLineNumbers FindLines(ISymbol compiland, ISourceFile file);

	IEnumLineNumbers FindLinesByAddress(uint segment, uint offset, uint length);

	IEnumLineNumbers FindLinesByRVA(uint relativeVirtualAddress, uint length);

	IEnumLineNumbers FindLinesByVA(ulong virtualAddress, uint length);

	IEnumLineNumbers FindLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column);

	IEnumInjectedSources FindInjectedSource(string sourceFile);

	IEnumDebugStreams GetEnumDebugStreams();

	IEnumSymbols FindInlineFramesByAddress(ISymbol parent, uint sectionIndex, uint offset);

	IEnumSymbols FindInlineFramesByRVA(ISymbol parent, uint relativeVirtualAddress);

	IEnumSymbols FindInlineFramesByVA(ISymbol parent, ulong virtualAddress);

	IEnumLineNumbers FindInlineeLines(ISymbol parent);

	IEnumLineNumbers FindInlineeLinesByAddress(ISymbol parent, uint isect, uint offset, uint length);

	IEnumLineNumbers FindInlineeLinesByRVA(ISymbol parent, uint relativeVirtualAddress, uint length);

	IEnumLineNumbers FindInlineeLinesByVA(ISymbol parent, ulong virtualAddress, uint length);

	IEnumLineNumbers FindInlineeLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column);

	IEnumSymbols FindInlineesByName(string name, NameSearchOptions searchOptions);

	IEnumLineNumbers FindAcceleratorInlineeLinesByLineNumber(ISymbol parent, ISourceFile file, uint lineNumber, uint column);

	IEnumSymbols FindSymbolsForAcceleratorPointerTag(ISymbol parent, uint tagValue);

	IEnumSymbols FindSymbolsByRVAForAcceleratorPointerTag(ISymbol parent, uint tagValue, uint relativeVirtualAddress);

	IEnumSymbols FindAcceleratorInlineesByName(string name, NameSearchOptions searchOptions);

	uint GetAddressForVA(ulong virtualAddress, out uint sectionIndex);

	uint GetAddressForRVA(uint relativeVirtualAddress, out uint sectionIndex);

	IEnumLineNumbers FindILOffsetsByAddress(uint sectionIndex, uint offset, uint length);

	IEnumLineNumbers FindILOffsetsByRVA(uint relativeVirtualAddress, uint length);

	IEnumLineNumbers FindILOffsetsByVA(ulong virtualAddress, uint length);

	IEnumInputAssemblyFiles FindInputAssemblyFiles();

	IInputAssemblyFile FindInputAssembly(uint index);

	IInputAssemblyFile FindInputAssemblyByID(uint uniqueId);

	uint GetFunctionMetadataTokenMapSize();

	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] GetFunctionMetadataTokenMap(uint bufferSize, out uint bytesWritten);

	uint GetTypeMetadataTokenMapSize();

	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] GetTypeMetadataTokenMap(uint bufferSize, out uint bytesWritten);

	uint GetNumberOfFunctionFragmentsForVA(ulong functionVA, uint functionSize);

	uint GetNumberOfFunctionFragmentsForRVA(uint functionRVA, uint functionSize);

	[return: MarshalUsing(CountElementName = nameof(fragmentCount))]
	uint[] GetFunctionFragmentsForVA(ulong functionVA, uint functionSize, uint fragmentCount, [MarshalUsing(CountElementName = nameof(fragmentCount))] out ulong[] fragmentVAs);

	[return: MarshalUsing(CountElementName = nameof(fragmentCount))]
	uint[] GetFunctionFragmentsForRVA(uint functionRVA, uint functionSize, uint fragmentCount, [MarshalUsing(CountElementName = nameof(fragmentCount))] out uint[] fragmentRVAs);

	IEnumSymbols GetExports();

	IEnumSymbols GetHeapAllocationSites();

	IInputAssemblyFile FindInputAssemblyFile(ISymbol symbol);
}
