using DiaSharp.CodeView;
using DiaSharp.COM;
using DiaSharp.Managed.Enumerables;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.Managed;

public sealed unsafe class Session(ISession session) : ComObject<ISession>(session)
{
	#region ISession

	public ulong LoadAddress
	{
		get => GetS<ulong>(_native.GetLoadAddress)!.Value;

		set => SetProp(_native.PutLoadAddress, value);
	}

	public Symbol GlobalScope => new(GetC<ISymbol>(_native.GetGlobalScope)!);

	public IEnumerable<Table> Tables => new TableEnumerable(GetC<IEnumTables>(_native.GetEnumTables)!);

	public IEnumerable<Symbol> FindChildren(Symbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions)
	{
		EnsureNotDisposed();

		int result = _native.FindChildrenEx(parent._native, tag, name, searchOptions, out IEnumSymbols symbols);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol> FindChildrenByAddress(Symbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions, uint sectionIndex, uint offset)
	{
		EnsureNotDisposed();

		int result = _native.FindChildrenExByAddress(parent._native, tag, name, searchOptions, sectionIndex, offset, out IEnumSymbols symbols);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol> FindChildrenByVA(Symbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions, ulong virtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindChildrenExByVA(parent._native, tag, name, searchOptions, virtualAddress, out IEnumSymbols symbols);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol> FindChildrenByRVA(Symbol parent, SymbolTag tag, string name, NameSearchOptions searchOptions, uint relativeVirtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindChildrenExByRVA(parent._native, tag, name, searchOptions, relativeVirtualAddress, out IEnumSymbols symbols);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public Symbol FindSymbolByAddress(uint sectionIndex, uint offset, SymbolTag tag)
	{
		EnsureNotDisposed();

		int result = _native.FindSymbolByAddress(sectionIndex, offset, tag, out ISymbol symbol);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new Symbol(symbol);
	}

	public Symbol FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag tag)
	{
		EnsureNotDisposed();

		int result = _native.FindSymbolByRVA(relativeVirtualAddress, tag, out ISymbol symbol);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new Symbol(symbol);
	}

	public Symbol FindSymbolByVA(ulong virtualAddress, SymbolTag tag)
	{
		EnsureNotDisposed();

		int result = _native.FindSymbolByVA(virtualAddress, tag, out ISymbol symbol);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new Symbol(symbol);
	}

	public Symbol FindSymbolByToken(uint token, SymbolTag tag)
	{
		EnsureNotDisposed();

		int result = _native.FindSymbolByToken(token, tag, out ISymbol symbol);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new Symbol(symbol);
	}

	public bool SymbolsAreEquivalent(Symbol symbolA, Symbol symbolB)
	{
		EnsureNotDisposed();

		int result = _native.SymbolsAreEquivalent(symbolA._native, symbolB._native);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return result == 0;
	}

	public Symbol SymbolByID(uint id)
	{
		EnsureNotDisposed();

		int result = _native.SymbolByID(id, out ISymbol symbol);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new Symbol(symbol);
	}

	public Symbol FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag tag, out int displacement)
	{
		EnsureNotDisposed();

		int result = _native.FindSymbolByRVA(relativeVirtualAddress, tag, out displacement, out ISymbol symbol);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new(symbol);
	}

	public Symbol FindSymbolByVA(ulong VirtualAddress, SymbolTag tag, out int displacement)
	{
		EnsureNotDisposed();

		int result = _native.FindSymbolByVA(VirtualAddress, tag, out displacement, out ISymbol symbol);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new(symbol);
	}

	public IEnumerable<SourceFile> FindFile(Symbol compiland, string name, NameSearchOptions searchOptions)
	{
		EnsureNotDisposed();
		
		int result = _native.FindFile(compiland._native, name, searchOptions, out IEnumSourceFiles files);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SourceFileEnumerable(files);
	}

	public SourceFile FindFileByID(uint uniqueId)
	{
		EnsureNotDisposed();
		
		int result = _native.FindFileByID(uniqueId, out ISourceFile file);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new(file);
	}

	public IEnumerable<LineNumber> FindLines(Symbol compiland, SourceFile file)
	{
		EnsureNotDisposed();
		
		int result = _native.FindLines(compiland._native, file._native, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<LineNumber> FindLinesByAddress(uint segment, uint offset, uint length)
	{
		EnsureNotDisposed();
		
		int result = _native.FindLinesByAddress(segment, offset, length, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<LineNumber> FindLinesByRVA(uint relativeVirtualAddress, uint length)
	{
		EnsureNotDisposed();
		
		int result = _native.FindLinesByRVA(relativeVirtualAddress, length, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<LineNumber> FindLinesByVA(ulong virtualAddress, uint length)
	{
		EnsureNotDisposed();
		
		int result = _native.FindLinesByVA(virtualAddress, length, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<LineNumber> FindLinesByLineNumber(Symbol compiland, SourceFile file, uint lineNumber, uint column)
	{
		EnsureNotDisposed();
		
		int result = _native.FindLinesByLineNumber(compiland._native, file._native, lineNumber, column, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<InjectedSource> FindInjectedSource(string sourceFile)
	{
		EnsureNotDisposed();

		int result = _native.FindInjectedSource(sourceFile, out IEnumInjectedSources sources);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new InjectedSourceEnumerable(sources); 
	}

	public IEnumerable<IEnumerable<byte[]>> DebugStreams => new DebugStreamEnumerable(GetC<IEnumDebugStreams>(_native.GetEnumDebugStreams)!);

	public IEnumerable<Symbol> FindInlineFramesByAddress(Symbol parent, uint sectionIndex, uint offset)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineFramesByAddress(parent._native, sectionIndex, offset, out IEnumSymbols frames);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(frames);
	}

	public IEnumerable<Symbol> FindInlineFramesByRVA(Symbol parent, uint relativeVirtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineFramesByRVA(parent._native, relativeVirtualAddress, out IEnumSymbols frames);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(frames);
	}

	public IEnumerable<Symbol> FindInlineFramesByVA(Symbol parent, ulong virtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineFramesByVA(parent._native, virtualAddress, out IEnumSymbols frames);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(frames);
	}

	public IEnumerable<LineNumber> FindInlineeLines(Symbol parent)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineeLines(parent._native, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<LineNumber> FindInlineeLinesByAddress(Symbol parent, uint sectionIndex, uint offset, uint length)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineeLinesByAddress(parent._native, sectionIndex, offset, length, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<LineNumber> FindInlineeLinesByRVA(Symbol parent, uint relativeVirtualAddress, uint length)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineeLinesByRVA(parent._native, relativeVirtualAddress, length, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<LineNumber> FindInlineeLinesByVA(Symbol parent, ulong virtualAddress, uint length)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineeLinesByVA(parent._native, virtualAddress, length, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<LineNumber> FindInlineeLinesByLineNumber(Symbol compiland, SourceFile file, uint lineNumber, uint column)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineeLinesByLineNumber(compiland._native, file._native, lineNumber, column, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<Symbol> FindInlineesByName(string name, NameSearchOptions searchOptions)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineesByName(name, searchOptions, out IEnumSymbols inlinees);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(inlinees);
	}

	public IEnumerable<LineNumber> FindAcceleratorInlineeLinesByLineNumber(Symbol parent, SourceFile file, uint lineNumber, uint column)
	{
		EnsureNotDisposed();

		int result = _native.FindAcceleratorInlineeLinesByLineNumber(parent._native, file._native, lineNumber, column, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<Symbol> FindSymbolsForAcceleratorPointerTag(Symbol parent, uint tagValue)
	{
		EnsureNotDisposed();

		int result = _native.FindSymbolsForAcceleratorPointerTag(parent._native, tagValue, out IEnumSymbols symbols);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol> FindSymbolsByRVAForAcceleratorPointerTag(Symbol parent, uint tagValue, uint relativeVirtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindSymbolsByRVAForAcceleratorPointerTag(parent._native, tagValue, relativeVirtualAddress, out IEnumSymbols symbols);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol> FindAcceleratorInlineesByName(string name, NameSearchOptions searchOptions)
	{
		EnsureNotDisposed();

		int result = _native.FindAcceleratorInlineesByName(name, searchOptions, out IEnumSymbols inlinees);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(inlinees);
	}

	public (uint SectionIndex, uint Address) GetAddressForVA(ulong virtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.GetAddressForVA(virtualAddress, out uint sectionIndex, out uint address);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return (sectionIndex, address);
	}

	public (uint SectionIndex, uint Address) GetAddressForRVA(uint relativeVirtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.GetAddressForRVA(relativeVirtualAddress, out uint sectionIndex, out uint address);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return (sectionIndex, address);
	}

	public IEnumerable<LineNumber> FindILOffsets(Symbol symbol)
	{
		EnsureNotDisposed();

		int result = _native.FindILOffsetsByVA(symbol.VirtualAddress!.Value, (uint)symbol.Length!.Value, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<LineNumber> FindILOffsetsByAddress(uint sectionIndex, uint offset, uint length)
	{
		EnsureNotDisposed();

		int result = _native.FindILOffsetsByAddress(sectionIndex, offset, length, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<LineNumber> FindILOffsetsByRVA(uint relativeVirtualAddress, uint length)
	{
		EnsureNotDisposed();

		int result = _native.FindILOffsetsByRVA(relativeVirtualAddress, length, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<LineNumber> FindILOffsetsByVA(ulong virtualAddress, uint length)
	{
		EnsureNotDisposed();

		int result = _native.FindILOffsetsByVA(virtualAddress, length, out IEnumLineNumbers lines);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(lines);
	}

	public IEnumerable<InputAssemblyFile> InputAssemblyFiles => new InputAssemblyFileEnumerable(GetC<IEnumInputAssemblyFiles>(_native.FindInputAssemblyFiles)!);

	public InputAssemblyFile FindInputAssembly(uint index)
	{
		EnsureNotDisposed();

		int result = _native.FindInputAssembly(index, out IInputAssemblyFile assembly);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new(assembly);
	}

	public InputAssemblyFile FindInputAssemblyByID(uint uniqueId)
	{
		EnsureNotDisposed();

		int result = _native.FindInputAssemblyByID(uniqueId, out IInputAssemblyFile assembly);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new(assembly);
	}

	public uint FunctionMetadataTokenMapSize => GetS<uint>(_native.GetFunctionMetadataTokenMapSize)!.Value;

	public byte[] FunctionMetadataTokenMap => GetA<byte>(_native.GetFunctionMetadataTokenMap)!;

	public uint TypeMetadataTokenMapSize => GetS<uint>(_native.GetTypeMetadataTokenMapSize)!.Value;

	public byte[] TypeMetadataTokenMap => GetA<byte>(_native.GetTypeMetadataTokenMap)!;

	public uint GetNumberOfFunctionFragments(Symbol symbol)
	{
		EnsureNotDisposed();

		int result = _native.GetNumberOfFunctionFragmentsForVA(symbol.VirtualAddress!.Value, (uint)symbol.Length!.Value, out uint count);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return count;
	}

	public uint GetNumberOfFunctionFragmentsForVA(ulong functionVA, uint functionSize)
	{
		EnsureNotDisposed();

		int result = _native.GetNumberOfFunctionFragmentsForVA(functionVA, functionSize, out uint count);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return count;
	}

	public uint GetNumberOfFunctionFragmentsForRVA(uint functionRVA, uint functionSize)
	{
		EnsureNotDisposed();

		int result = _native.GetNumberOfFunctionFragmentsForRVA(functionRVA, functionSize, out uint count);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return count;
	}

	public ReadOnlySpan<FunctionFragment> GetFunctionFragments(Symbol symbol)
	{
		EnsureNotDisposed();

		int length = (int)symbol.Length!;

		uint* addresses = stackalloc uint[length], lengths = stackalloc uint[length];

		int result = _native.GetFunctionFragmentsForVA(symbol.VirtualAddress!.Value, (uint)length, GetNumberOfFunctionFragments(symbol), addresses, lengths);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		FunctionFragment[] fragments = new FunctionFragment[length];

		for (int i = 0; i < length; i++) fragments[i] = new(addresses[i], lengths[i]);

		return fragments;
	}

	public IEnumerable<Symbol> Exports => new SymbolEnumerable(GetC<IEnumSymbols>(_native.GetExports)!);

	public IEnumerable<Symbol> HeapAllocationSites => new SymbolEnumerable(GetC<IEnumSymbols>(_native.GetHeapAllocationSites)!);

	public InputAssemblyFile FindInputAssemblyFile(Symbol symbol)
	{
		EnsureNotDisposed();

		int result = _native.FindInputAssemblyFile(symbol._native, out IInputAssemblyFile assembly);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new(assembly);

	}

	#endregion

	#region ISessionEx

	public bool FastLinkPDB
	{
		get
		{
			ISessionEx session = EnsureAndQuery<ISessionEx>();

			bool value = GetS<bool>(session.IsFastLinkPDB)!.Value;

			ComHelpers.Release(ref session);

			return value;
		}
	}

	public bool PortablePDB
	{
		get
		{
			ISessionEx session = EnsureAndQuery<ISessionEx>();

			bool value = GetS<bool>(session.IsPortablePDB)!.Value;

			ComHelpers.Release(ref session);

			return value;
		}
	}

	public IEnumerable<byte[]> GetSourceLinkInfo(Symbol symbol)
	{
		ISessionEx session = EnsureAndQuery<ISessionEx>();

		int result = session.GetSourceLinkInfo(symbol._native, out IEnumSourceLink enumerator);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SourceLinkEnumerable(enumerator);
	}

	#endregion
}
