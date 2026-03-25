using System.Runtime.InteropServices.Marshalling;
using DiaSharp.CodeView.HLSL;
using DiaSharp.Enumerators;
using DiaSharp.Enums;
using DiaSharp.Structs;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("CB787B2F-BD6C-4635-BA52-933126BD2DCD")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISymbol
{
	uint GetSymbolIndexID();

	SymbolTag GetSymbolTag();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetName();

	ISymbol GetLexicalParent();

	ISymbol GetClassParent();

	ISymbol GetSymbolType();

	DataKind GetDataKind();

	LocationType GetLocationType();

	uint GetAddressSection();

	uint GetAddressOffset();

	uint GetRelativeVirtualAddress();

	ulong GetVirtualAddress();

	uint GetRegisterID();

	int GetOffset();

	ulong GetLength();

	uint GetSlot();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetVolatileType();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetConstType();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetUnalignedType();

	uint GetAccess();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetLibraryName();

	uint GetPlatform();

	uint GetLanguage();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetEditAndContinueEnabled();

	uint GetFrontendMajor();

	uint GetFrontendMinor();

	uint GetFrontendBuild();

	uint GetBackendMajor();

	uint GetBackendMinor();

	uint GetBackendBuild();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetSourceFileName();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetUnused();

	ThunkOrdinal GetThunkOrdinal();

	int GetThisAdjustor();

	uint GetVirtualBaseOffset();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsVirtual();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsIntro();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsPure();

	uint GetCallingConvention();

	Variant GetValue();

	uint GetBaseType();

	uint GetToken();

	uint GetTimestamp();

	Guid GetGUID();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetSymbolsFileName();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsReference();

	uint GetCount();

	uint GetBitPosition();

	ISymbol GetArrayIndexType();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsPacked();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasConstructor();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasOverloadedOperator();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsNested();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasNestedTypes();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasAssignmentOperator();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasCastOperator();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsScoped();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsVirtualBaseClass();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsIndirectVirtualBaseClass();

	int GetVirtualBasePointerOffset();

	ISymbol GetVirtualTableShape();

	uint GetLexicalParentID();

	uint GetClassParentID();

	uint GetTypeID();

	uint GetArrayIndexTypeID();

	uint GetVirtualTableShapeID();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsCode();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsFunction();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsManaged();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsMSIL();

	uint GetVirtualBaseDisplacementIndex();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetUndecoratedName();

	uint GetAge();

	uint GetSignature();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsCompilerGenerated();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsAddressTaken();

	uint GetRank();

	ISymbol GetLowerBound();

	ISymbol GetUpperBound();

	uint GetLowerBoundID();

	uint GetUpperBoundID();

	[return: MarshalUsing(CountElementName = nameof(dataWritten))]
	byte[] GetDataBytes(uint dataSize, out uint dataWritten);

	IEnumSymbols FindChildrenUnaware(SymbolTag symbolTag, string name, NameSearchOptions compareFlags);

	IEnumSymbols FindChildren(SymbolTag symbolTag, string name, NameSearchOptions compareFlags);

	IEnumSymbols FindChildrenByAddress(SymbolTag symbolTag, string name, NameSearchOptions compareFlags, uint sectionIndex, uint offset);

	IEnumSymbols FindChildrenByVA(SymbolTag symbolTag, string name, NameSearchOptions compareFlags, ulong virtualAddress);

	IEnumSymbols FindChildrenByRVA(SymbolTag symbolTag, string name, NameSearchOptions compareFlags, uint relativeVirtualAddress);

	uint GetTargetSection();

	uint GetTargetOffset();

	uint GetTargetRelativeVirtualAddress();

	ulong GetTargetVirtualAddress();

	Enums.ImageFileMachine GetMachineType();

	uint GetOemID();

	uint GetOemSymbolID();

	[return: MarshalUsing(CountElementName = nameof(typesWritten))]
	ISymbol[] GetTypes(uint typeCount, out uint typesWritten);

	[return: MarshalUsing(CountElementName = nameof(typeIDsWritten))]
	uint[] GetTypeIDs(uint typeIDCount, out uint typeIDsWritten);

	ISymbol GetObjectPointerType();

	UdtKind GetUdtKind();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetUndecoratedName(UndecorateOptions undecorateOptions);

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsNoReturn();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasCustomCallingConvention();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetNoInline();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasOptimizedCodeDebugInfo();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsNotReached();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasInterruptReturn();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasFarReturn();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsStatic();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasDebugInfo();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsLTCG();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsDataAligned();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasSecurityChecks();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetCompilerName();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasAlloca();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasSetJump();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasLongJump();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasInlAsm();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasEH();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasSEH();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasEHa();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsNaked();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsAggregated();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsSplitted();

	ISymbol GetContainer();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetInliningSpecified();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetNoStackOrderingSpecified();

	ISymbol GetVirtualBaseTableType();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasManagedCode();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsHotpatchable();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsConvertedCIL();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsMSILNetmodule();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasCTypes();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsStripped();

	uint GetFrontendQFE();

	uint GetBackendQFE();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetWasInlined();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasStrictGSCheck();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsCxxReturnUdt();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsConstructorVirtualBase();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsRValueReference();

	ISymbol GetUnmodifiedType();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetFramePointerPresent();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasSafeBuffers();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsIntrinsic();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsSealed();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasHfaFloat();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasHfaDouble();

	uint GetLiveRangeStartAddressSection();

	uint GetLiveRangeStartAddressOffset();

	uint GetLiveRangeStartRelativeVirtualAddress();

	uint GetLiveRangeCount();

	ulong GetLiveRangeLength();

	uint GetOffsetInUdt();

	uint GetParamBasePointerRegisterID();

	uint GetLocalBasePointerRegisterID();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsLocationControlFlowDependent();

	uint GetStride();

	uint GetNumberOfRows();

	uint GetNumberOfColumns();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsMatrixRowMajor();

	[return: MarshalUsing(CountElementName = nameof(countWritten))]
	uint[] GetNumericProperties(uint propertyCount, out uint countWritten);

	[return: MarshalUsing(CountElementName = nameof(countWritten))]
	ushort[] GetModifierValues(uint propertyCount, out uint countWritten);

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsReturnValue();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsOptimizedAway();

	[Obsolete(_Constants.HlslObsoleteMessage)]
	BuiltIn GetBuiltInKind();

	[Obsolete(_Constants.HlslObsoleteMessage)]
	Register GetRegisterType();

	uint GetBaseDataSlot();

	uint GetBaseDataOffset();

	uint GetTextureSlot();

	uint GetSamplerSlot();

	uint GetUavSlot();

	uint GetSizeInUdt();

	[Obsolete(_Constants.HlslObsoleteMessage)]
	MemorySpace GetMemorySpaceKind();

	uint GetUnmodifiedTypeId();

	uint GetSubTypeId();

	ISymbol GetSubType();

	uint GetNumberOfModifiers();

	uint GetNumberOfRegisterIndices();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsHLSLData();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsPointerToDataMember();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsPointerToMemberFunction();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsSingleInheritance();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsMultipleInheritance();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsVirtualInheritance();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetRestrictedType();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsPointerBasedOnSymbolValue();

	ISymbol GetBaseSymbol();

	uint GetBaseSymbolId();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetObjectFileName();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsAcceleratorGroupSharedLocal();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsAcceleratorPointerTagLiveRange();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsAcceleratorStubFunction();

	uint GetNumberOfAcceleratorPointerTags();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsSDL();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsWinRTPointer();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsRefUdt();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsValueUdt();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsInterfaceUdt();

	IEnumSymbols FindInlineFramesByAddress(uint sectionIndex, uint offset);

	IEnumSymbols FindInlineFramesByRVA(uint relativeVirtualAddress);

	IEnumSymbols FindInlineFramesByVA(ulong virtualAddress);

	IEnumLineNumbers FindInlineeLines();

	IEnumLineNumbers FindInlineeLinesByAddress(uint sectionIndex, uint offset, uint length);

	IEnumLineNumbers FindInlineeLinesByRVA(uint relativeVirtualAddress, uint length);

	IEnumLineNumbers FindInlineeLinesByVA(ulong virtualAddress, uint length);

	IEnumSymbols FindSymbolsForAcceleratorPointerTag(uint tagValue);

	IEnumSymbols FindSymbolsByRVAForAcceleratorPointerTag(uint tagValue, uint relativeVirtualAddress);

	[return: MarshalUsing(CountElementName = nameof(tagCount))]
	uint[] GetAcceleratorPointerTags(uint tagCount, out uint tagsWritten);

	ILineNumber GetSourceLineOnTypeDefinition();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsPGO();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasValidPGOCounts();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsOptimizedForSpeed();

	uint GetPGOEntryCount();

	uint GetPGOEdgeCount();

	ulong GetPGODynamicInstructionCount();

	uint GetStaticSize();

	uint GetFinalLiveStaticSize();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetPhaseName();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasControlFlowCheck();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsConstantExport();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsDataExport();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetPrivateExport();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetNoNameExport();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetExportHasExplicitlyAssignedOrdinal();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetExportIsForwarder();

	uint GetOrdinal();

	uint GetFrameSize();

	uint GetExceptionHandlerAddressSection();

	uint GetExceptionHandlerAddressOffset();

	uint GetExceptionHandlerRelativeVirtualAddress();

	ulong GetExceptionHandlerVirtualAddress();

	IInputAssemblyFile FindInputAssemblyFile();

	uint GetCharacteristics();

	ISymbol GetCoffGroup();

	uint GetBindID();

	uint GetBindSpace();

	uint GetBindSlot();
}
