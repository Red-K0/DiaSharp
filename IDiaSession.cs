using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Enumerators;
using DiaSharp.Enums;
using DiaSharp.Symbols;

namespace DiaSharp;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("2F609EE1-D1C8-4E24-8288-3326BADCD211")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaSession
{
	[DispId(1)]
	ulong get_loadAddress();

	[DispId(1)]
	void put_loadAddress(ulong value);

	[DispId(2)]
	IDiaSymbol get_globalScope();

	IDiaEnumTables getEnumTables();

	IDiaEnumSymbolsByAddr getSymbolsByAddr();

	IDiaEnumSymbols findChildren(IDiaSymbol parent, SymbolTag symTag, string name, uint compareFlags);

	IDiaEnumSymbols findChildrenEx(IDiaSymbol parent, SymbolTag symTag, string name, uint compareFlags);

	IDiaEnumSymbols findChildrenExByAddr(IDiaSymbol parent, SymbolTag symTag, string name, uint compareFlags, uint isect, uint offset);

	IDiaEnumSymbols findChildrenExByVA(IDiaSymbol parent, SymbolTag symTag, string name, uint compareFlags, ulong va);

	IDiaEnumSymbols findChildrenExByRVA(IDiaSymbol parent, SymbolTag symTag, string name, uint compareFlags, uint rva);

	IDiaSymbol findSymbolByAddr(uint isect, uint offset, SymbolTag symTag);

	IDiaSymbol findSymbolByRVA(uint rva, SymbolTag symTag);

	IDiaSymbol findSymbolByVA(ulong va, SymbolTag symTag);

	IDiaSymbol findSymbolByToken(uint token, SymbolTag symTag);

	void symsAreEquiv(IDiaSymbol symbolA, IDiaSymbol symbolB);

	IDiaSymbol symbolById(uint id);

	IDiaSymbol findSymbolByRVAEx(uint rva, SymbolTag symTag, out int displacement);

	IDiaSymbol findSymbolByVAEx(ulong va, SymbolTag symTag, out int displacement);

	IDiaEnumSourceFiles findFile(IDiaSymbol pCompiland, string name, uint compareFlags);

	IDiaSourceFile findFileById(uint uniqueId);

	IDiaEnumLineNumbers findLines(IDiaSymbol compiland, IDiaSourceFile file);

	IDiaEnumLineNumbers findLinesByAddr(uint seg, uint offset, uint length);

	IDiaEnumLineNumbers findLinesByRVA(uint rva, uint length);

	IDiaEnumLineNumbers findLinesByVA(ulong va, uint length);

	IDiaEnumLineNumbers findLinesByLinenum(IDiaSymbol compiland, IDiaSourceFile file, uint linenum, uint column);

	IDiaEnumInjectedSources findInjectedSource(string srcFile);

	IDiaEnumDebugStreams getEnumDebugStreams();

	IDiaEnumSymbols findInlineFramesByAddr(IDiaSymbol parent, uint isect, uint offset);

	IDiaEnumSymbols findInlineFramesByRVA(IDiaSymbol parent, uint rva);

	IDiaEnumSymbols findInlineFramesByVA(IDiaSymbol parent, ulong va);

	IDiaEnumLineNumbers findInlineeLines(IDiaSymbol parent);

	IDiaEnumLineNumbers findInlineeLinesByAddr(IDiaSymbol parent, uint isect, uint offset, uint length);

	IDiaEnumLineNumbers findInlineeLinesByRVA(IDiaSymbol parent, uint rva, uint length);

	IDiaEnumLineNumbers findInlineeLinesByVA(IDiaSymbol parent, ulong va, uint length);

	IDiaEnumLineNumbers findInlineeLinesByLinenum(IDiaSymbol compiland, IDiaSourceFile file, uint linenum, uint column);

	IDiaEnumSymbols findInlineesByName(string name, uint option);

	IDiaEnumLineNumbers findAcceleratorInlineeLinesByLinenum(IDiaSymbol parent, IDiaSourceFile file, uint linenum, uint column);

	IDiaEnumSymbols findSymbolsForAcceleratorPointerTag(IDiaSymbol parent, uint tagValue);

	IDiaEnumSymbols findSymbolsByRVAForAcceleratorPointerTag(IDiaSymbol parent, uint tagValue, uint rva);

	IDiaEnumSymbols findAcceleratorInlineesByName(string name, uint option);

	uint addressForVA(ulong va, out uint pISect);

	uint addressForRVA(uint rva, out uint pISect);

	IDiaEnumLineNumbers findILOffsetsByAddr(uint isect, uint offset, uint length);

	IDiaEnumLineNumbers findILOffsetsByRVA(uint rva, uint length);

	IDiaEnumLineNumbers findILOffsetsByVA(ulong va, uint length);

	IDiaEnumInputAssemblyFiles findInputAssemblyFiles();

	IDiaInputAssemblyFile findInputAssembly(uint index);

	IDiaInputAssemblyFile findInputAssemblyById(uint uniqueId);

	uint getFuncMDTokenMapSize();

	[return: MarshalUsing(CountElementName = nameof(cb))]
	byte[] getFuncMDTokenMap(uint cb, out uint pcb);

	uint getTypeMDTokenMapSize();

	[return: MarshalUsing(CountElementName = nameof(cb))]
	byte[] getTypeMDTokenMap(uint cb, out uint pcb);

	uint getNumberOfFunctionFragments_VA(ulong vaFunc, uint cbFunc);

	uint getNumberOfFunctionFragments_RVA(uint rvaFunc, uint cbFunc);

	void getFunctionFragments_VA(ulong vaFunc, uint cbFunc, uint cFragments, [MarshalUsing(CountElementName = nameof(cFragments))] out ulong[] pVaFragment, [MarshalUsing(CountElementName = nameof(cFragments))] out uint[] pLenFragment);

	void getFunctionFragments_RVA(uint rvaFunc, uint cbFunc, uint cFragments, [MarshalUsing(CountElementName = nameof(cFragments))] out uint[] pRvaFragment, [MarshalUsing(CountElementName = nameof(cFragments))] out uint[] pLenFragment);

	IDiaEnumSymbols getExports();

	IDiaEnumSymbols getHeapAllocationSites();

	IDiaInputAssemblyFile findInputAssemblyFile(IDiaSymbol pSymbol);
}
