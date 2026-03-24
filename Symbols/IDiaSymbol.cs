using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Enumerators;
using DiaSharp.Enums;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[DefaultMember("symIndexId")]
[Guid("CB787B2F-BD6C-4635-BA52-933126BD2DCD")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface IDiaSymbol
{
	[DispId(0)]
	uint get_symIndexId();

	[DispId(1)]
	uint get_symTag();

	[DispId(2)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_name();

	[DispId(3)]
	IDiaSymbol get_lexicalParent();

	[DispId(4)]
	IDiaSymbol get_classParent();

	[DispId(5)]
	IDiaSymbol get_type();

	[DispId(6)]
	uint get_dataKind();

	[DispId(7)]
	uint get_locationType();

	[DispId(8)]
	uint get_addressSection();

	[DispId(9)]
	uint get_addressOffset();

	[DispId(10)]
	uint get_relativeVirtualAddress();

	[DispId(11)]
	ulong get_virtualAddress();

	[DispId(12)]
	uint get_registerId();

	[DispId(13)]
	int get_offset();

	[DispId(14)]
	ulong get_length();

	[DispId(15)]
	uint get_slot();

	[DispId(16)]
	int get_volatileType();

	[DispId(17)]
	int get_constType();

	[DispId(18)]
	int get_unalignedType();

	[DispId(19)]
	uint get_access();

	[DispId(20)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_libraryName();

	[DispId(21)]
	uint get_platform();

	[DispId(22)]
	uint get_language();

	[DispId(23)]
	int get_editAndContinueEnabled();

	[DispId(24)]
	uint get_frontEndMajor();

	[DispId(25)]
	uint get_frontEndMinor();

	[DispId(26)]
	uint get_frontEndBuild();

	[DispId(27)]
	uint get_backEndMajor();

	[DispId(28)]
	uint get_backEndMinor();

	[DispId(29)]
	uint get_backEndBuild();

	[DispId(30)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_sourceFileName();

	[DispId(31)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_unused();

	[DispId(32)]
	uint get_thunkOrdinal();

	[DispId(33)]
	int get_thisAdjust();

	[DispId(34)]
	uint get_virtualBaseOffset();

	[DispId(35)]
	int get_virtual();

	[DispId(36)]
	int get_intro();

	[DispId(37)]
	int get_pure();

	[DispId(38)]
	uint get_callingConvention();

	[DispId(39)]
	void* get_value();

	[DispId(40)]
	uint get_baseType();

	[DispId(41)]
	uint get_token();

	[DispId(42)]
	uint get_timeStamp();

	[DispId(43)]
	Guid get_guid();

	[DispId(44)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_symbolsFileName();

	[DispId(46)]
	int get_reference();

	[DispId(47)]
	uint get_count();

	[DispId(49)]
	uint get_bitPosition();

	[DispId(50)]
	IDiaSymbol get_arrayIndexType();

	[DispId(51)]
	int get_packed();

	[DispId(52)]
	int get_constructor();

	[DispId(53)]
	int get_overloadedOperator();

	[DispId(54)]
	int get_nested();

	[DispId(55)]
	int get_hasNestedTypes();

	[DispId(56)]
	int get_hasAssignmentOperator();

	[DispId(57)]
	int get_hasCastOperator();

	[DispId(58)]
	int get_scoped();

	[DispId(59)]
	int get_virtualBaseClass();

	[DispId(60)]
	int get_indirectVirtualBaseClass();

	[DispId(61)]
	int get_virtualBasePointerOffset();

	[DispId(62)]
	IDiaSymbol get_virtualTableShape();

	[DispId(64)]
	uint get_lexicalParentId();

	[DispId(65)]
	uint get_classParentId();

	[DispId(66)]
	uint get_typeId();

	[DispId(67)]
	uint get_arrayIndexTypeId();

	[DispId(68)]
	uint get_virtualTableShapeId();

	[DispId(69)]
	int get_code();

	[DispId(70)]
	int get_function();

	[DispId(71)]
	int get_managed();

	[DispId(72)]
	int get_msil();

	[DispId(73)]
	uint get_virtualBaseDispIndex();

	[DispId(74)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_undecoratedName();

	[DispId(75)]
	uint get_age();

	[DispId(76)]
	uint get_signature();

	[DispId(77)]
	int get_compilerGenerated();

	[DispId(78)]
	int get_addressTaken();

	[DispId(79)]
	uint get_rank();

	[DispId(80)]
	IDiaSymbol get_lowerBound();

	[DispId(81)]
	IDiaSymbol get_upperBound();

	[DispId(82)]
	uint get_lowerBoundId();

	[DispId(83)]
	uint get_upperBoundId();

	[return: MarshalUsing(CountElementName = nameof(cbData))]
	byte[] get_dataBytes(uint cbData, out uint pcbData);

	IDiaEnumSymbols findChildren(SymbolTag symTag, string name, uint compareFlags);

	IDiaEnumSymbols findChildrenEx(SymbolTag symTag, string name, uint compareFlags);

	IDiaEnumSymbols findChildrenExByAddr(SymbolTag symTag, string name, uint compareFlags, uint isect, uint offset);

	IDiaEnumSymbols findChildrenExByVA(SymbolTag symTag, string name, uint compareFlags, ulong va);

	IDiaEnumSymbols findChildrenExByRVA(SymbolTag symTag, string name, uint compareFlags, uint rva);

	[DispId(84)]
	uint get_targetSection();

	[DispId(85)]
	uint get_targetOffset();

	[DispId(86)]
	uint get_targetRelativeVirtualAddress();

	[DispId(87)]
	ulong get_targetVirtualAddress();

	[DispId(88)]
	uint get_machineType();

	[DispId(89)]
	uint get_oemId();

	[DispId(90)]
	uint get_oemSymbolId();

	void get_types(uint cTypes, [MarshalUsing(CountElementName = nameof(cTypes))] out uint[] pcTypes, [MarshalUsing(CountElementName = nameof(cTypes))] out IDiaSymbol[] pTypes);

	void get_typeIds(uint cTypeIds, [MarshalUsing(CountElementName = nameof(cTypeIds))] out uint[] pcTypeIds, [MarshalUsing(CountElementName = nameof(cTypeIds))] out uint[] pdwTypeIds);

	[DispId(91)]
	IDiaSymbol get_objectPointerType();

	[DispId(92)]
	uint get_udtKind();

	[return: MarshalAs(UnmanagedType.BStr)]
	string get_undecoratedNameEx(uint undecorateOptions);

	[DispId(93)]
	int get_noReturn();

	[DispId(94)]
	int get_customCallingConvention();

	[DispId(95)]
	int get_noInline();

	[DispId(96)]
	int get_optimizedCodeDebugInfo();

	[DispId(97)]
	int get_notReached();

	[DispId(98)]
	int get_interruptReturn();

	[DispId(99)]
	int get_farReturn();

	[DispId(100)]
	int get_isStatic();

	[DispId(101)]
	int get_hasDebugInfo();

	[DispId(102)]
	int get_isLTCG();

	[DispId(103)]
	int get_isDataAligned();

	[DispId(104)]
	int get_hasSecurityChecks();

	[DispId(105)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_compilerName();

	[DispId(106)]
	int get_hasAlloca();

	[DispId(107)]
	int get_hasSetJump();

	[DispId(108)]
	int get_hasLongJump();

	[DispId(109)]
	int get_hasInlAsm();

	[DispId(110)]
	int get_hasEH();

	[DispId(111)]
	int get_hasSEH();

	[DispId(112)]
	int get_hasEHa();

	[DispId(113)]
	int get_isNaked();

	[DispId(114)]
	int get_isAggregated();

	[DispId(115)]
	int get_isSplitted();

	[DispId(116)]
	IDiaSymbol get_container();

	[DispId(117)]
	int get_inlSpec();

	[DispId(118)]
	int get_noStackOrdering();

	[DispId(119)]
	IDiaSymbol get_virtualBaseTableType();

	[DispId(120)]
	int get_hasManagedCode();

	[DispId(121)]
	int get_isHotpatchable();

	[DispId(122)]
	int get_isCVTCIL();

	[DispId(123)]
	int get_isMSILNetmodule();

	[DispId(124)]
	int get_isCTypes();

	[DispId(125)]
	int get_isStripped();

	[DispId(126)]
	uint get_frontEndQFE();

	[DispId(127)]
	uint get_backEndQFE();

	[DispId(128)]
	int get_wasInlined();

	[DispId(129)]
	int get_strictGSCheck();

	[DispId(130)]
	int get_isCxxReturnUdt();

	[DispId(131)]
	int get_isConstructorVirtualBase();

	[DispId(132)]
	int get_RValueReference();

	[DispId(133)]
	IDiaSymbol get_unmodifiedType();

	[DispId(134)]
	int get_framePointerPresent();

	[DispId(135)]
	int get_isSafeBuffers();

	[DispId(136)]
	int get_intrinsic();

	[DispId(137)]
	int get_sealed();

	[DispId(138)]
	int get_hfaFloat();

	[DispId(139)]
	int get_hfaDouble();

	[DispId(140)]
	uint get_liveRangeStartAddressSection();

	[DispId(141)]
	uint get_liveRangeStartAddressOffset();

	[DispId(142)]
	uint get_liveRangeStartRelativeVirtualAddress();

	[DispId(143)]
	uint get_countLiveRanges();

	[DispId(144)]
	ulong get_liveRangeLength();

	[DispId(145)]
	uint get_offsetInUdt();

	[DispId(146)]
	uint get_paramBasePointerRegisterId();

	[DispId(147)]
	uint get_localBasePointerRegisterId();

	[DispId(148)]
	int get_isLocationControlFlowDependent();

	[DispId(149)]
	uint get_stride();

	[DispId(150)]
	uint get_numberOfRows();

	[DispId(151)]
	uint get_numberOfColumns();

	[DispId(152)]
	int get_isMatrixRowMajor();

	[return: MarshalUsing(CountElementName = nameof(cnt))]
	uint[] get_numericProperties(uint cnt, out uint pcnt);

	[return: MarshalUsing(CountElementName = nameof(cnt))]
	ushort[] get_modifierValues(uint cnt, out uint pcnt);

	[DispId(153)]
	int get_isReturnValue();

	[DispId(154)]
	int get_isOptimizedAway();

	[DispId(155)]
	uint get_builtInKind();

	[DispId(156)]
	uint get_registerType();

	[DispId(157)]
	uint get_baseDataSlot();

	[DispId(158)]
	uint get_baseDataOffset();

	[DispId(159)]
	uint get_textureSlot();

	[DispId(160)]
	uint get_samplerSlot();

	[DispId(161)]
	uint get_uavSlot();

	[DispId(162)]
	uint get_sizeInUdt();

	[DispId(163)]
	uint get_memorySpaceKind();

	[DispId(164)]
	uint get_unmodifiedTypeId();

	[DispId(165)]
	uint get_subTypeId();

	[DispId(166)]
	IDiaSymbol get_subType();

	[DispId(167)]
	uint get_numberOfModifiers();

	[DispId(168)]
	uint get_numberOfRegisterIndices();

	[DispId(169)]
	int get_isHLSLData();

	[DispId(170)]
	int get_isPointerToDataMember();

	[DispId(171)]
	int get_isPointerToMemberFunction();

	[DispId(172)]
	int get_isSingleInheritance();

	[DispId(173)]
	int get_isMultipleInheritance();

	[DispId(174)]
	int get_isVirtualInheritance();

	[DispId(175)]
	int get_restrictedType();

	[DispId(176)]
	int get_isPointerBasedOnSymbolValue();

	[DispId(177)]
	IDiaSymbol get_baseSymbol();

	[DispId(178)]
	uint get_baseSymbolId();

	[DispId(179)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_objectFileName();

	[DispId(180)]
	int get_isAcceleratorGroupSharedLocal();

	[DispId(181)]
	int get_isAcceleratorPointerTagLiveRange();

	[DispId(182)]
	int get_isAcceleratorStubFunction();

	[DispId(183)]
	uint get_numberOfAcceleratorPointerTags();

	[DispId(184)]
	int get_isSdl();

	[DispId(185)]
	int get_isWinRTPointer();

	[DispId(186)]
	int get_isRefUdt();

	[DispId(187)]
	int get_isValueUdt();

	[DispId(188)]
	int get_isInterfaceUdt();

	IDiaEnumSymbols findInlineFramesByAddr(uint isect, uint offset);

	IDiaEnumSymbols findInlineFramesByRVA(uint rva);

	IDiaEnumSymbols findInlineFramesByVA(ulong va);

	IDiaEnumLineNumbers findInlineeLines();

	IDiaEnumLineNumbers findInlineeLinesByAddr(uint isect, uint offset, uint length);

	IDiaEnumLineNumbers findInlineeLinesByRVA(uint rva, uint length);

	IDiaEnumLineNumbers findInlineeLinesByVA(ulong va, uint length);

	IDiaEnumSymbols findSymbolsForAcceleratorPointerTag(uint tagValue);

	IDiaEnumSymbols findSymbolsByRVAForAcceleratorPointerTag(uint tagValue, uint rva);

	[return: MarshalUsing(CountElementName = nameof(cnt))]
	uint[] get_acceleratorPointerTags(uint cnt, out uint pcnt);

	IDiaLineNumber getSrcLineOnTypeDefn();

	[DispId(189)]
	int get_isPGO();

	[DispId(190)]
	int get_hasValidPGOCounts();

	[DispId(191)]
	int get_isOptimizedForSpeed();

	[DispId(192)]
	uint get_PGOEntryCount();

	[DispId(193)]
	uint get_PGOEdgeCount();

	[DispId(194)]
	ulong get_PGODynamicInstructionCount();

	[DispId(195)]
	uint get_staticSize();

	[DispId(196)]
	uint get_finalLiveStaticSize();

	[DispId(197)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_phaseName();

	[DispId(198)]
	int get_hasControlFlowCheck();

	[DispId(199)]
	int get_constantExport();

	[DispId(200)]
	int get_dataExport();

	[DispId(201)]
	int get_privateExport();

	[DispId(202)]
	int get_noNameExport();

	[DispId(203)]
	int get_exportHasExplicitlyAssignedOrdinal();

	[DispId(204)]
	int get_exportIsForwarder();

	[DispId(205)]
	uint get_ordinal();

	[DispId(206)]
	uint get_frameSize();

	[DispId(207)]
	uint get_exceptionHandlerAddressSection();

	[DispId(208)]
	uint get_exceptionHandlerAddressOffset();

	[DispId(209)]
	uint get_exceptionHandlerRelativeVirtualAddress();

	[DispId(210)]
	ulong get_exceptionHandlerVirtualAddress();

	IDiaInputAssemblyFile findInputAssemblyFile();

	[DispId(211)]
	uint get_characteristics();

	[DispId(212)]
	IDiaSymbol get_coffGroup();

	[DispId(213)]
	uint get_bindID();

	[DispId(214)]
	uint get_bindSpace();

	[DispId(215)]
	uint get_bindSlot();
}
