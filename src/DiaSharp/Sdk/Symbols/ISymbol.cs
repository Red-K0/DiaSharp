using DiaSharp.CodeView;
using DiaSharp.CodeView.Hlsl;
using DiaSharp.Native;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.SDK.Symbols;

[Guid("CB787B2F-BD6C-4635-BA52-933126BD2DCD")]
public unsafe partial interface ISymbol
{
	int GetSymbolIndexID(out uint result);

	int GetSymbolTag(out SymbolTag result);

	int GetName([MarshalAs(UnmanagedType.BStr)] out string result);

	int GetLexicalParent(out ISymbol result);

	int GetClassParent(out ISymbol result);

	int GetSymbolType(out ISymbol result);

	int GetDataKind(out DataKind result);

	int GetLocationType(out LocationType result);

	int GetAddressSection(out uint result);

	int GetAddressOffset(out uint result);

	int GetRelativeVirtualAddress(out uint result);

	int GetVirtualAddress(out ulong result);

	int GetRegisterID(out uint result);

	int GetOffset(out int result);

	int GetLength(out ulong result);

	int GetSlot(out uint result);

	int GetVolatileType([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetConstType([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetUnalignedType([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetAccess(out uint result);

	int GetLibraryName([MarshalAs(UnmanagedType.BStr)] out string result);

	int GetPlatform(out uint result);

	int GetLanguage(out uint result);

	int GetEditAndContinueEnabled([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetFrontendMajor(out uint result);

	int GetFrontendMinor(out uint result);

	int GetFrontendBuild(out uint result);

	int GetBackendMajor(out uint result);

	int GetBackendMinor(out uint result);

	int GetBackendBuild(out uint result);

	int GetSourceFileName([MarshalAs(UnmanagedType.BStr)] out string result);

	int GetUnused([MarshalAs(UnmanagedType.BStr)] out string result);

	int GetThunkOrdinal(out ThunkOrdinal result);

	int GetThisAdjustor(out int result);

	int GetVirtualBaseOffset(out uint result);

	int GetIsVirtual([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsIntro([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsPure([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetCallingConvention(out uint result);

	int GetValue(out Variant result);

	int GetBaseType(out uint result);

	int GetToken(out uint result);

	int GetTimestamp(out uint result);

	int GetGUID(out Guid result);

	int GetSymbolsFileName([MarshalAs(UnmanagedType.BStr)] out string result);

	int GetIsReference([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetCount(out uint result);

	int GetBitPosition(out uint result);

	int GetArrayIndexType(out ISymbol result);

	int GetIsPacked([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasConstructor([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasOverloadedOperator([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsNested([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasNestedTypes([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasAssignmentOperator([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasCastOperator([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsScoped([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsVirtualBaseClass([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsIndirectVirtualBaseClass([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetVirtualBasePointerOffset(out int result);

	int GetVirtualTableShape(out ISymbol result);

	int GetLexicalParentID(out uint result);

	int GetClassParentID(out uint result);

	int GetTypeID(out uint result);

	int GetArrayIndexTypeID(out uint result);

	int GetVirtualTableShapeID(out uint result);

	int GetIsCode([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsFunction([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsManaged([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsMSIL([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetVirtualBaseDisplacementIndex(out uint result);

	int GetUndecoratedName([MarshalAs(UnmanagedType.BStr)] out string result);

	int GetAge(out uint result);

	int GetSignature(out uint result);

	int GetIsCompilerGenerated([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsAddressTaken([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetRank(out uint result);

	int GetLowerBound(out ISymbol result);

	int GetUpperBound(out ISymbol result);

	int GetLowerBoundID(out uint result);

	int GetUpperBoundID(out uint result);

	unsafe int GetDataBytes(uint dataSize, out uint dataWritten, byte* buffer);

	int FindChildrenUnaware(SymbolTag symbolTag, string name, NameSearchOptions compareFlags, out IEnumSymbols result);

	int FindChildren(SymbolTag symbolTag, string name, NameSearchOptions compareFlags, out IEnumSymbols result);

	int FindChildrenByAddress(SymbolTag symbolTag, string name, NameSearchOptions compareFlags, uint sectionIndex, uint offset, out IEnumSymbols result);

	int FindChildrenByVA(SymbolTag symbolTag, string name, NameSearchOptions compareFlags, ulong virtualAddress, out IEnumSymbols result);

	int FindChildrenByRVA(SymbolTag symbolTag, string name, NameSearchOptions compareFlags, uint relativeVirtualAddress, out IEnumSymbols result);

	int GetTargetSection(out uint result);

	int GetTargetOffset(out uint result);

	int GetTargetRelativeVirtualAddress(out uint result);

	int GetTargetVirtualAddress(out ulong result);

	int GetMachineType(out DiaSharp.Native.ImageFileMachine result);

	int GetOemID(out uint result);

	int GetOemSymbolID(out uint result);

	unsafe int GetTypes(uint typeCount, out uint typesWritten, void** buffer);

	unsafe int GetTypeIDs(uint typeIDCount, out uint typeIDsWritten, uint* buffer);

	int GetObjectPointerType(out ISymbol result);

	int GetUdtKind(out UdtKind result);

	int GetUndecoratedName(UndecorateOptions undecorateOptions, [MarshalAs(UnmanagedType.BStr)] out string result);

	int GetIsNoReturn([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasCustomCallingConvention([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetNoInline([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasOptimizedCodeDebugInfo([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsNotReached([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasInterruptReturn([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasFarReturn([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsStatic([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasDebugInfo([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsLTCG([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsDataAligned([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasSecurityChecks([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetCompilerName([MarshalAs(UnmanagedType.BStr)] out string result);

	int GetHasAlloca([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasSetJump([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasLongJump([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasInlAsm([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasEH([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasSEH([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasEHa([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsNaked([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsAggregated([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsSplitted([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetContainer(out ISymbol result);

	int GetInliningSpecified([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetNoStackOrderingSpecified([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetVirtualBaseTableType(out ISymbol result);

	int GetHasManagedCode([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsHotpatchable([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsConvertedCIL([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsMSILNetmodule([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasCTypes([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsStripped([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetFrontendQFE(out uint result);

	int GetBackendQFE(out uint result);

	int GetWasInlined([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasStrictGSCheck([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsCxxReturnUdt([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsConstructorVirtualBase([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsRValueReference([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetUnmodifiedType(out ISymbol result);

	int GetFramePointerPresent([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasSafeBuffers([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsIntrinsic([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsSealed([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasHfaFloat([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasHfaDouble([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetLiveRangeStartAddressSection(out uint result);

	int GetLiveRangeStartAddressOffset(out uint result);

	int GetLiveRangeStartRelativeVirtualAddress(out uint result);

	int GetLiveRangeCount(out uint result);

	int GetLiveRangeLength(out ulong result);

	int GetOffsetInUdt(out uint result);

	int GetParamBasePointerRegisterID(out uint result);

	int GetLocalBasePointerRegisterID(out uint result);

	int GetIsLocationControlFlowDependent([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetStride(out uint result);

	int GetNumberOfRows(out uint result);

	int GetNumberOfColumns(out uint result);

	int GetIsMatrixRowMajor([MarshalAs(UnmanagedType.Bool)] out bool result);

	unsafe int GetNumericProperties(uint propertyCount, out uint countWritten, uint* buffer);

	unsafe int GetModifierValues(uint propertyCount, out uint countWritten, ushort* buffer);

	int GetIsReturnValue([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsOptimizedAway([MarshalAs(UnmanagedType.Bool)] out bool result);

	[PreserveSig, Obsolete(_Globals.HlslObsoleteMessage)]
	int GetBuiltInKind(out BuiltIn result);

	[PreserveSig, Obsolete(_Globals.HlslObsoleteMessage)]
	int GetRegisterType(out Register result);

	int GetBaseDataSlot(out uint result);

	int GetBaseDataOffset(out uint result);

	int GetTextureSlot(out uint result);

	int GetSamplerSlot(out uint result);

	int GetUavSlot(out uint result);

	int GetSizeInUdt(out uint result);

	[PreserveSig, Obsolete(_Globals.HlslObsoleteMessage)]
	int GetMemorySpaceKind(out MemorySpace result);

	int GetUnmodifiedTypeId(out uint result);

	int GetSubTypeId(out uint result);

	int GetSubType(out ISymbol result);

	int GetNumberOfModifiers(out uint result);

	int GetNumberOfRegisterIndices(out uint result);

	int GetIsHLSLData([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsPointerToDataMember([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsPointerToMemberFunction([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsSingleInheritance([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsMultipleInheritance([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsVirtualInheritance([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetRestrictedType([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsPointerBasedOnSymbolValue([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetBaseSymbol(out ISymbol result);

	int GetBaseSymbolId(out uint result);

	int GetObjectFileName([MarshalAs(UnmanagedType.BStr)] out string result);

	int GetIsAcceleratorGroupSharedLocal([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsAcceleratorPointerTagLiveRange([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsAcceleratorStubFunction([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetNumberOfAcceleratorPointerTags(out uint result);

	int GetIsSDL([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsWinRTPointer([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsRefUdt([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsValueUdt([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsInterfaceUdt([MarshalAs(UnmanagedType.Bool)] out bool result);

	int FindInlineFramesByAddress(uint sectionIndex, uint offset, out IEnumSymbols result);

	int FindInlineFramesByRVA(uint relativeVirtualAddress, out IEnumSymbols result);

	int FindInlineFramesByVA(ulong virtualAddress, out IEnumSymbols result);

	int FindInlineeLines(out IEnumLineNumbers result);

	int FindInlineeLinesByAddress(uint sectionIndex, uint offset, uint length, out IEnumLineNumbers result);

	int FindInlineeLinesByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers result);

	int FindInlineeLinesByVA(ulong virtualAddress, uint length, out IEnumLineNumbers result);

	int FindSymbolsForAcceleratorPointerTag(uint tagValue, out IEnumSymbols result);

	int FindSymbolsByRVAForAcceleratorPointerTag(uint tagValue, uint relativeVirtualAddress, out IEnumSymbols result);

	unsafe int GetAcceleratorPointerTags(uint tagCount, out uint tagsWritten, uint* buffer);

	int GetSourceLineOnTypeDefinition(out ILineNumber result);

	int GetIsPGO([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetHasValidPGOCounts([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsOptimizedForSpeed([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetPGOEntryCount(out uint result);

	int GetPGOEdgeCount(out uint result);

	int GetPGODynamicInstructionCount(out ulong result);

	int GetStaticSize(out uint result);

	int GetFinalLiveStaticSize(out uint result);

	int GetPhaseName([MarshalAs(UnmanagedType.BStr)] out string result);

	int GetHasControlFlowCheck([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsConstantExport([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetIsDataExport([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetPrivateExport([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetNoNameExport([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetExportHasExplicitlyAssignedOrdinal([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetExportIsForwarder([MarshalAs(UnmanagedType.Bool)] out bool result);

	int GetOrdinal(out uint result);

	int GetFrameSize(out uint result);

	int GetExceptionHandlerAddressSection(out uint result);

	int GetExceptionHandlerAddressOffset(out uint result);

	int GetExceptionHandlerRelativeVirtualAddress(out uint result);

	int GetExceptionHandlerVirtualAddress(out ulong result);

	int FindInputAssemblyFile(out IInputAssemblyFile result);

	int GetCharacteristics(out uint result);

	int GetCoffGroup(out ISymbol result);

	int GetBindID(out uint result);

	int GetBindSpace(out uint result);

	int GetBindSlot(out uint result);
}