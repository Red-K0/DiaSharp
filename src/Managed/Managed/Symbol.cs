using DiaSharp.CodeView;
using DiaSharp.CodeView.Hlsl;
using DiaSharp.COM;
using DiaSharp.Managed.Enumerables;
using DiaSharp.Native;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.Managed;

[SuppressMessage("Performance", "CA1819:Properties should not return arrays", Justification = "Readonly semantics are unnecessary.")]
public sealed unsafe class Symbol(ISymbol symbol) : ComObject<ISymbol>(symbol)
{
	#region ISymbol

	public uint? SymbolIndexID => GetS<uint>(_native.GetSymbolIndexID);

	public SymbolTag? SymbolTag => GetS<SymbolTag>(_native.GetSymbolTag);

	public string? Name => GetC<string>(_native.GetName);

	public Symbol? LexicalParent => TryGetC(_native.GetLexicalParent, out ISymbol? native) ? new(native) : null;

	public Symbol? ClassParent => TryGetC(_native.GetClassParent, out ISymbol? native) ? new(native) : null;

	public Symbol? SymbolType => TryGetC(_native.GetSymbolType, out ISymbol? native) ? new(native) : null;

	public DataKind? DataKind => GetS<DataKind>(_native.GetDataKind);

	public LocationType? LocationType => GetS<LocationType>(_native.GetLocationType);

	public uint? AddressSection => GetS<uint>(_native.GetAddressSection);

	public uint? AddressOffset => GetS<uint>(_native.GetAddressOffset);

	public uint? RelativeVirtualAddress => GetS<uint>(_native.GetRelativeVirtualAddress);

	public ulong? VirtualAddress => GetS<ulong>(_native.GetVirtualAddress);

	public uint? RegisterID => GetS<uint>(_native.GetRegisterID);

	public int? Offset => GetS<int>(_native.GetOffset);

	public ulong? Length => GetS<ulong>(_native.GetLength);

	public uint? Slot => GetS<uint>(_native.GetSlot);

	public bool? VolatileType => GetS<bool>(_native.GetVolatileType);

	public bool? ConstType => GetS<bool>(_native.GetConstType);

	public bool? UnalignedType => GetS<bool>(_native.GetUnalignedType);

	public Access? Access => GetS<Access>(_native.GetAccess);

	public string? LibraryName => GetC<string>(_native.GetLibraryName);

	public CpuType? Platform => GetS<CpuType>(_native.GetPlatform);

	public CompileFlagLanguage? Language => GetS<CompileFlagLanguage>(_native.GetLanguage);

	public bool? EditAndContinueEnabled => GetS<bool>(_native.GetEditAndContinueEnabled);

	public uint? FrontendMajor => GetS<uint>(_native.GetFrontendMajor);

	public uint? FrontendMinor => GetS<uint>(_native.GetFrontendMinor);

	public uint? FrontendBuild => GetS<uint>(_native.GetFrontendBuild);

	public uint? BackendMajor => GetS<uint>(_native.GetBackendMajor);

	public uint? BackendMinor => GetS<uint>(_native.GetBackendMinor);

	public uint? BackendBuild => GetS<uint>(_native.GetBackendBuild);

	public string? SourceFileName => GetC<string>(_native.GetSourceFileName);

	public ThunkOrdinal? ThunkOrdinal => GetS<ThunkOrdinal>(_native.GetThunkOrdinal);

	public int? ThisAdjustor => GetS<int>(_native.GetThisAdjustor);

	public uint? VirtualBaseOffset => GetS<uint>(_native.GetVirtualBaseOffset);

	public bool? Virtual => GetS<bool>(_native.GetIsVirtual);

	public bool? Intro => GetS<bool>(_native.GetIsIntro);

	public bool? Pure => GetS<bool>(_native.GetIsPure);

	public CodeView.CallingConvention? CallingConvention => GetS<CodeView.CallingConvention>(_native.GetCallingConvention);

	public Variant? Value => GetS<Variant>(_native.GetValue);

	public BasicType? BaseType => GetS<BasicType>(_native.GetBaseType);

	public uint? Token => GetS<uint>(_native.GetToken);

	public uint? Timestamp => GetS<uint>(_native.GetTimestamp);

	[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "The property name is consistent, even on 'System.Type'.")]
	public Guid? GUID => GetS<Guid>(_native.GetGUID);

	public string? SymbolsFileName => GetC<string>(_native.GetSymbolsFileName);

	public bool? Reference => GetS<bool>(_native.GetIsReference);

	public uint? Count => GetS<uint>(_native.GetCount);

	public uint? BitPosition => GetS<uint>(_native.GetBitPosition);

	public Symbol? ArrayIndexType => TryGetC(_native.GetArrayIndexType, out ISymbol? native) ? new(native) : null;

	public bool? Packed => GetS<bool>(_native.GetIsPacked);

	public bool? HasConstructor => GetS<bool>(_native.GetHasConstructor);

	public bool? HasOverloadedOperator => GetS<bool>(_native.GetHasOverloadedOperator);

	public bool? Nested => GetS<bool>(_native.GetIsNested);

	public bool? HasNestedTypes => GetS<bool>(_native.GetHasNestedTypes);

	public bool? HasAssignmentOperator => GetS<bool>(_native.GetHasAssignmentOperator);

	public bool? HasCastOperator => GetS<bool>(_native.GetHasCastOperator);

	public bool? Scoped => GetS<bool>(_native.GetIsScoped);

	public bool? VirtualBaseClass => GetS<bool>(_native.GetIsVirtualBaseClass);

	public bool? IndirectVirtualBaseClass => GetS<bool>(_native.GetIsIndirectVirtualBaseClass);

	public int? VirtualBasePointerOffset => GetS<int>(_native.GetVirtualBasePointerOffset);

	public Symbol? VirtualTableShape => TryGetC(_native.GetVirtualTableShape, out ISymbol? native) ? new(native) : null;

	public uint? LexicalParentID => GetS<uint>(_native.GetLexicalParentID);

	public uint? ClassParentID => GetS<uint>(_native.GetClassParentID);

	public uint? TypeID => GetS<uint>(_native.GetTypeID);

	public uint? ArrayIndexTypeID => GetS<uint>(_native.GetArrayIndexTypeID);

	public uint? VirtualTableShapeID => GetS<uint>(_native.GetVirtualTableShapeID);

	public bool? Code => GetS<bool>(_native.GetIsCode);

	public bool? Function => GetS<bool>(_native.GetIsFunction);

	public bool? Managed => GetS<bool>(_native.GetIsManaged);

	public bool? MSIL => GetS<bool>(_native.GetIsMSIL);

	public uint? VirtualBaseDisplacementIndex => GetS<uint>(_native.GetVirtualBaseDisplacementIndex);

	public uint? Age => GetS<uint>(_native.GetAge);

	public uint? Signature => GetS<uint>(_native.GetSignature);

	public bool? CompilerGenerated => GetS<bool>(_native.GetIsCompilerGenerated);

	public bool? AddressTaken => GetS<bool>(_native.GetIsAddressTaken);

	public uint? Rank => GetS<uint>(_native.GetRank);

	public Symbol? LowerBound => TryGetC(_native.GetLowerBound, out ISymbol? native) ? new(native) : null;

	public Symbol? UpperBound => TryGetC(_native.GetUpperBound, out ISymbol? native) ? new(native) : null;

	public uint? LowerBoundID => GetS<uint>(_native.GetLowerBoundID);

	public uint? UpperBoundID => GetS<uint>(_native.GetUpperBoundID);

	public byte[]? DataBytes => GetA<byte>(_native.GetDataBytes);

	public IEnumerable<Symbol>? FindChildrenUnaware(SymbolTag symbolTag, string? name = null, NameSearchOptions compareFlags = NameSearchOptions.None)
	{
		EnsureNotDisposed();

		int result = _native.FindChildrenUnaware(symbolTag, name, compareFlags, out IEnumSymbols symbols);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol>? FindChildren(SymbolTag symbolTag, string? name = null, NameSearchOptions compareFlags = NameSearchOptions.None)
	{
		EnsureNotDisposed();

		int result = _native.FindChildren(symbolTag, name, compareFlags, out IEnumSymbols symbols);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol>? FindChildrenByAddress(SymbolTag symbolTag, uint sectionIndex, uint offset, string? name = null, NameSearchOptions compareFlags = NameSearchOptions.None)
	{
		EnsureNotDisposed();

		int result = _native.FindChildrenByAddress(symbolTag, name, compareFlags, sectionIndex, offset, out IEnumSymbols symbols);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol>? FindChildrenByVA(SymbolTag symbolTag, ulong virtualAddress, string? name = null, NameSearchOptions compareFlags = NameSearchOptions.None)
	{
		EnsureNotDisposed();

		int result = _native.FindChildrenByVA(symbolTag, name, compareFlags, virtualAddress, out IEnumSymbols symbols);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol>? FindChildrenByRVA(SymbolTag symbolTag, uint relativeVirtualAddress, string? name = null, NameSearchOptions compareFlags = NameSearchOptions.None)
	{
		EnsureNotDisposed();

		int result = _native.FindChildrenByRVA(symbolTag, name, compareFlags, relativeVirtualAddress, out IEnumSymbols symbols);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public uint? TargetSection => GetS<uint>(_native.GetTargetSection);

	public uint? TargetOffset => GetS<uint>(_native.GetTargetOffset);

	public uint? TargetRelativeVirtualAddress => GetS<uint>(_native.GetTargetRelativeVirtualAddress);

	public ulong? TargetVirtualAddress => GetS<ulong>(_native.GetTargetVirtualAddress);

	public Native.ImageFileMachine? MachineType => GetS<Native.ImageFileMachine>(_native.GetMachineType);

	public uint? OemID => GetS<uint>(_native.GetOemID);

	public uint? OemSymbolID => GetS<uint>(_native.GetOemSymbolID);

	public Symbol[]? Types
	{
		get
		{
			void*[]? elements = GetA(_native.GetTypes);

			if (elements == null) return null;

			Symbol[] symbols = new Symbol[elements.Length];

			for (int i = 0; i < elements.Length; i++) symbols[i] = new(ComHelpers.Wrap<ISymbol>(elements[i]));

			return symbols;
		}
	}

	public unsafe uint[]? TypeIDs => GetA<uint>(_native.GetTypeIDs);

	public Symbol? ObjectPointerType => TryGetC(_native.GetObjectPointerType, out ISymbol? native) ? new(native) : null;

	public UdtKind? UdtKind => GetS<UdtKind>(_native.GetUdtKind);

	public string? GetUndecoratedName(UndecorateOptions undecorateOptions = UndecorateOptions.None)
	{
		EnsureNotDisposed();

		int result = _native.GetUndecoratedName(undecorateOptions, out string undecorated);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return undecorated;
	}

	public bool? NoReturn => GetS<bool>(_native.GetIsNoReturn);

	public bool? HasCustomCallingConvention => GetS<bool>(_native.GetHasCustomCallingConvention);

	public bool? NoInline => GetS<bool>(_native.GetNoInline);

	public bool? HasOptimizedCodeDebugInfo => GetS<bool>(_native.GetHasOptimizedCodeDebugInfo);

	public bool? NotReached => GetS<bool>(_native.GetIsNotReached);

	public bool? HasInterruptReturn => GetS<bool>(_native.GetHasInterruptReturn);

	public bool? HasFarReturn => GetS<bool>(_native.GetHasFarReturn);

	public bool? Static => GetS<bool>(_native.GetIsStatic);

	public bool? HasDebugInfo => GetS<bool>(_native.GetHasDebugInfo);

	public bool? LinkTimeCodeGeneration => GetS<bool>(_native.GetIsLTCG);

	public bool? DataAligned => GetS<bool>(_native.GetIsDataAligned);

	public bool? HasSecurityChecks => GetS<bool>(_native.GetHasSecurityChecks);

	public string? CompilerName => GetC<string>(_native.GetCompilerName);

	public bool? HasAlloca => GetS<bool>(_native.GetHasAlloca);

	public bool? HasSetJump => GetS<bool>(_native.GetHasSetJump);

	public bool? HasLongJump => GetS<bool>(_native.GetHasLongJump);

	public bool? HasInlineAssembly => GetS<bool>(_native.GetHasInlAsm);

	public bool? HasExceptionHandling => GetS<bool>(_native.GetHasEH);

	public bool? HasStructuredExceptionHandling => GetS<bool>(_native.GetHasSEH);

	public bool? HasAsyncExceptionHandling => GetS<bool>(_native.GetHasEHa);

	public bool? Naked => GetS<bool>(_native.GetIsNaked);

	public bool? Aggregated => GetS<bool>(_native.GetIsAggregated);

	public bool? Split => GetS<bool>(_native.GetIsSplit);

	public Symbol? Container => TryGetC(_native.GetContainer, out ISymbol? native) ? new(native) : null;

	public bool? InliningSpecified => GetS<bool>(_native.GetInliningSpecified);

	public bool? NoStackOrderingSpecified => GetS<bool>(_native.GetNoStackOrderingSpecified);

	public Symbol? VirtualBaseTableType => TryGetC(_native.GetVirtualBaseTableType, out ISymbol? native) ? new(native) : null;

	public bool? HasManagedCode => GetS<bool>(_native.GetHasManagedCode);

	public bool? Hotpatchable => GetS<bool>(_native.GetIsHotpatchable);

	public bool? ConvertedCIL => GetS<bool>(_native.GetIsConvertedCIL);

	public bool? MSILNetmodule => GetS<bool>(_native.GetIsMSILNetmodule);

	public bool? HasCTypes => GetS<bool>(_native.GetHasCTypes);

	public bool? Stripped => GetS<bool>(_native.GetIsStripped);

	public uint? FrontendQFE => GetS<uint>(_native.GetFrontendQFE);

	public uint? BackendQFE => GetS<uint>(_native.GetBackendQFE);

	public bool? Inlined => GetS<bool>(_native.GetWasInlined);

	public bool? HasStrictGSCheck => GetS<bool>(_native.GetHasStrictGSCheck);

	public bool? CxxReturnUdt => GetS<bool>(_native.GetIsCxxReturnUdt);

	public bool? ConstructorVirtualBase => GetS<bool>(_native.GetIsConstructorVirtualBase);

	public bool? RValueReference => GetS<bool>(_native.GetIsRValueReference);

	public Symbol? UnmodifiedType => TryGetC(_native.GetUnmodifiedType, out ISymbol? native) ? new(native) : null;

	public bool? FramePointerPresent => GetS<bool>(_native.GetFramePointerPresent);

	public bool? HasSafeBuffers => GetS<bool>(_native.GetHasSafeBuffers);

	public bool? Intrinsic => GetS<bool>(_native.GetIsIntrinsic);

	public bool? Sealed => GetS<bool>(_native.GetIsSealed);

	public bool? HasHfaFloat => GetS<bool>(_native.GetHasHfaFloat);

	public bool? HasHfaDouble => GetS<bool>(_native.GetHasHfaDouble);

	public uint? LiveRangeStartAddressSection => GetS<uint>(_native.GetLiveRangeStartAddressSection);

	public uint? LiveRangeStartAddressOffset => GetS<uint>(_native.GetLiveRangeStartAddressOffset);

	public uint? LiveRangeStartRelativeVirtualAddress => GetS<uint>(_native.GetLiveRangeStartRelativeVirtualAddress);

	public uint? LiveRangeCount => GetS<uint>(_native.GetLiveRangeCount);

	public ulong? LiveRangeLength => GetS<ulong>(_native.GetLiveRangeLength);

	public uint? OffsetInUdt => GetS<uint>(_native.GetOffsetInUdt);

	public uint? ParamBasePointerRegisterID => GetS<uint>(_native.GetParamBasePointerRegisterID);

	public uint? LocalBasePointerRegisterID => GetS<uint>(_native.GetLocalBasePointerRegisterID);

	public bool? LocationControlFlowDependent => GetS<bool>(_native.GetIsLocationControlFlowDependent);

	public uint? Stride => GetS<uint>(_native.GetStride);

	public uint? NumberOfRows => GetS<uint>(_native.GetNumberOfRows);

	public uint? NumberOfColumns => GetS<uint>(_native.GetNumberOfColumns);

	public bool? MatrixRowMajor => GetS<bool>(_native.GetIsMatrixRowMajor);

	public uint[]? NumericProperties => GetA<uint>(_native.GetNumericProperties);

	public ushort[]? ModifierValues => GetA<ushort>(_native.GetModifierValues);

	public bool? ReturnValue => GetS<bool>(_native.GetIsReturnValue);

	public bool? OptimizedAway => GetS<bool>(_native.GetIsOptimizedAway);

	public BuiltIn? BuiltInKind => GetS<BuiltIn>(_native.GetBuiltInKind);

	public Register? RegisterType => GetS<Register>(_native.GetRegisterType);

	public uint? BaseDataSlot => GetS<uint>(_native.GetBaseDataSlot);

	public uint? BaseDataOffset => GetS<uint>(_native.GetBaseDataOffset);

	public uint? TextureSlot => GetS<uint>(_native.GetTextureSlot);

	public uint? SamplerSlot => GetS<uint>(_native.GetSamplerSlot);

	public uint? UavSlot => GetS<uint>(_native.GetUavSlot);

	public uint? SizeInUdt => GetS<uint>(_native.GetSizeInUdt);

	public MemorySpace? MemorySpaceKind => GetS<MemorySpace>(_native.GetMemorySpaceKind);

	public uint? UnmodifiedTypeId => GetS<uint>(_native.GetUnmodifiedTypeId);

	public uint? SubTypeId => GetS<uint>(_native.GetSubTypeId);

	public Symbol? SubType => TryGetC(_native.GetSubType, out ISymbol? native) ? new(native) : null;

	public uint? NumberOfModifiers => GetS<uint>(_native.GetNumberOfModifiers);

	public uint? NumberOfRegisterIndices => GetS<uint>(_native.GetNumberOfRegisterIndices);

	public bool? HLSLData => GetS<bool>(_native.GetIsHLSLData);

	public bool? PointerToDataMember => GetS<bool>(_native.GetIsPointerToDataMember);

	public bool? PointerToMemberFunction => GetS<bool>(_native.GetIsPointerToMemberFunction);

	public bool? SingleInheritance => GetS<bool>(_native.GetIsSingleInheritance);

	public bool? InheritsMultiple => GetS<bool>(_native.GetIsMultipleInheritance);

	public bool? InheritsVirtual => GetS<bool>(_native.GetIsVirtualInheritance);

	public bool? RestrictedType => GetS<bool>(_native.GetRestrictedType);

	public bool? PointerBasedOnSymbolValue => GetS<bool>(_native.GetIsPointerBasedOnSymbolValue);

	public Symbol? BaseSymbol => TryGetC(_native.GetBaseSymbol, out ISymbol? native) ? new(native) : null;

	public uint? BaseSymbolId => GetS<uint>(_native.GetBaseSymbolId);

	public string? ObjectFileName => GetC<string>(_native.GetObjectFileName);

	public bool? AcceleratorGroupSharedLocal => GetS<bool>(_native.GetIsAcceleratorGroupSharedLocal);

	public bool? AcceleratorPointerTagLiveRange => GetS<bool>(_native.GetIsAcceleratorPointerTagLiveRange);

	public bool? AcceleratorStubFunction => GetS<bool>(_native.GetIsAcceleratorStubFunction);

	public uint? NumberOfAcceleratorPointerTags => GetS<uint>(_native.GetNumberOfAcceleratorPointerTags);

	public bool? SDL => GetS<bool>(_native.GetIsSDL);

	public bool? WinRTPointer => GetS<bool>(_native.GetIsWinRTPointer);

	public bool? RefUdt => GetS<bool>(_native.GetIsRefUdt);

	public bool? ValueUdt => GetS<bool>(_native.GetIsValueUdt);

	public bool? InterfaceUdt => GetS<bool>(_native.GetIsInterfaceUdt);

	public IEnumerable<Symbol>? FindInlineFramesByAddress(uint sectionIndex, uint offset)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineFramesByAddress(sectionIndex, offset, out IEnumSymbols symbols);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol>? FindInlineFramesByRVA(uint relativeVirtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineFramesByRVA(relativeVirtualAddress, out IEnumSymbols symbols);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol>? FindInlineFramesByVA(ulong virtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineFramesByVA(virtualAddress, out IEnumSymbols symbols);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<LineNumber>? InlineeLines => TryGetC(_native.FindInlineeLines, out IEnumLineNumbers? native) ? new LineNumberEnumerable(native) : null;

	public IEnumerable<LineNumber>? FindInlineeLinesByAddress(uint sectionIndex, uint offset, uint length)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineeLinesByAddress(sectionIndex, offset, length, out IEnumLineNumbers numbers);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(numbers);
	}

	public IEnumerable<LineNumber>? FindInlineeLinesByRVA(uint relativeVirtualAddress, uint length)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineeLinesByRVA(relativeVirtualAddress, length, out IEnumLineNumbers numbers);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(numbers);
	}

	public IEnumerable<LineNumber>? FindInlineeLinesByVA(ulong virtualAddress, uint length)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineeLinesByVA(virtualAddress, length, out IEnumLineNumbers numbers);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(numbers);
	}

	public IEnumerable<Symbol>? FindSymbolsForAcceleratorPointerTag(uint tagValue)
	{
		EnsureNotDisposed();

		int result = _native.FindSymbolsForAcceleratorPointerTag(tagValue, out IEnumSymbols symbols);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol>? FindSymbolsByRVAForAcceleratorPointerTag(uint tagValue, uint relativeVirtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindSymbolsByRVAForAcceleratorPointerTag(tagValue, relativeVirtualAddress, out IEnumSymbols symbols);

		if (result == (int)KnownResult.S_FALSE) return null;

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<uint>? AcceleratorPointerTags => GetA<uint>(_native.GetAcceleratorPointerTags);

	public LineNumber? SourceLineOnTypeDefinition => TryGetC(_native.GetSourceLineOnTypeDefinition, out ILineNumber? native) ? new(native) : null;

	public bool? IsPGO => GetS<bool>(_native.GetIsPGO);

	public bool? HasValidPGOCounts => GetS<bool>(_native.GetHasValidPGOCounts);

	public bool? OptimizedForSpeed => GetS<bool>(_native.GetIsOptimizedForSpeed);

	public uint? PGOEntryCount => GetS<uint>(_native.GetPGOEntryCount);

	public uint? PGOEdgeCount => GetS<uint>(_native.GetPGOEdgeCount);

	public ulong? PGODynamicInstructionCount => GetS<ulong>(_native.GetPGODynamicInstructionCount);

	public uint? StaticSize => GetS<uint>(_native.GetStaticSize);

	public uint? FinalLiveStaticSize => GetS<uint>(_native.GetFinalLiveStaticSize);

	public string? PhaseName => GetC<string>(_native.GetPhaseName);

	public bool? HasControlFlowCheck => GetS<bool>(_native.GetHasControlFlowCheck);

	public bool? ConstantExport => GetS<bool>(_native.GetIsConstantExport);

	public bool? DataExport => GetS<bool>(_native.GetIsDataExport);

	public bool? PrivateExport => GetS<bool>(_native.GetPrivateExport);

	public bool? NoNameExport => GetS<bool>(_native.GetNoNameExport);

	public bool? ExportHasExplicitlyAssignedOrdinal => GetS<bool>(_native.GetExportHasExplicitlyAssignedOrdinal);

	public bool? ExportIsForwarder => GetS<bool>(_native.GetExportIsForwarder);

	public uint? Ordinal => GetS<uint>(_native.GetOrdinal);

	public uint? FrameSize => GetS<uint>(_native.GetFrameSize);

	public uint? ExceptionHandlerAddressSection => GetS<uint>(_native.GetExceptionHandlerAddressSection);

	public uint? ExceptionHandlerAddressOffset => GetS<uint>(_native.GetExceptionHandlerAddressOffset);

	public uint? ExceptionHandlerRelativeVirtualAddress => GetS<uint>(_native.GetExceptionHandlerRelativeVirtualAddress);

	public ulong? ExceptionHandlerVirtualAddress => GetS<ulong>(_native.GetExceptionHandlerVirtualAddress);

	public InputAssemblyFile? InputAssemblyFile => TryGetC(_native.FindInputAssemblyFile, out IInputAssemblyFile? native) ? new(native) : null;

	public SectionCharacteristics? Characteristics => GetS<SectionCharacteristics>(_native.GetCharacteristics);

	public Symbol? CoffGroup => TryGetC(_native.GetCoffGroup, out ISymbol? native) ? new(native) : null;

	public uint? BindID => GetS<uint>(_native.GetBindID);

	public uint? BindSpace => GetS<uint>(_native.GetBindSpace);

	public uint? BindSlot => GetS<uint>(_native.GetBindSlot);

	#endregion

	#region ISymbol2

	public bool? ObjectiveCClass
	{
		get
		{
			ISymbol2 symbol = EnsureAndQuery<ISymbol2>();

			bool? value = GetS<bool>(symbol.GetIsObjectiveCClass);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public bool? ObjectiveCCategory
	{
		get
		{
			ISymbol2 symbol = EnsureAndQuery<ISymbol2>();

			bool? value = GetS<bool>(symbol.GetIsObjectiveCCategory);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public bool? ObjectiveCProtocol
	{
		get
		{
			ISymbol2 symbol = EnsureAndQuery<ISymbol2>();

			bool? value = GetS<bool>(symbol.GetIsObjectiveCProtocol);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol3

	public Symbol? Inlinee
	{
		get
		{
			ISymbol3 symbol = EnsureAndQuery<ISymbol3>();

			Symbol? value = TryGetC(symbol.GetInlinee, out ISymbol? native) ? new(native) : null;

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public uint? InlineeID
	{
		get
		{
			ISymbol3 symbol = EnsureAndQuery<ISymbol3>();

			uint? value = GetS<uint>(symbol.GetInlineeID);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol4

	public bool? NoExcept
	{
		get
		{
			ISymbol4 symbol = EnsureAndQuery<ISymbol4>();

			bool? value = GetS<bool>(symbol.GetIsNoExcept);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol5

	public bool? AbsoluteAddress
	{
		get
		{
			ISymbol5 symbol = EnsureAndQuery<ISymbol5>();

			bool? value = GetS<bool>(symbol.GetHasAbsoluteAddress);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol6

	public bool? StaticMemberFunction
	{
		get
		{
			ISymbol6 symbol = EnsureAndQuery<ISymbol6>();

			bool? value = GetS<bool>(symbol.GetIsStaticMemberFunction);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol7

	public bool? SignedReturn
	{
		get
		{
			ISymbol7 symbol = EnsureAndQuery<ISymbol7>();

			bool? value = GetS<bool>(symbol.GetIsSignedReturn);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol8

	public CoroutineKind? CoroutineKind
	{
		get
		{
			ISymbol8 symbol = EnsureAndQuery<ISymbol8>();

			CoroutineKind? value = GetS<CoroutineKind>(symbol.GetCoroutineKind);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public AssociationKind? AssociatedSymbolKind
	{
		get
		{
			ISymbol8 symbol = EnsureAndQuery<ISymbol8>();

			AssociationKind? value = GetS<AssociationKind>(symbol.GetAssociatedSymbolKind);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public uint? AssociatedSymbolSection
	{
		get
		{
			ISymbol8 symbol = EnsureAndQuery<ISymbol8>();

			uint? value = GetS<uint>(symbol.GetAssociatedSymbolSection);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public uint? AssociatedSymbolOffset
	{
		get
		{
			ISymbol8 symbol = EnsureAndQuery<ISymbol8>();

			uint? value = GetS<uint>(symbol.GetAssociatedSymbolOffset);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public uint? AssociatedSymbolRVA
	{
		get
		{
			ISymbol8 symbol = EnsureAndQuery<ISymbol8>();

			uint? value = GetS<uint>(symbol.GetAssociatedSymbolRVA);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public ulong? AssociatedSymbolAddress
	{
		get
		{
			ISymbol8 symbol = EnsureAndQuery<ISymbol8>();

			ulong? value = GetS<ulong>(symbol.GetAssociatedSymbolAddress);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol9

	public uint? FramePadSize
	{
		get
		{
			ISymbol9 symbol = EnsureAndQuery<ISymbol9>();

			uint? value = GetS<uint>(symbol.GetFramePadSize);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public uint? FramePadOffset
	{
		get
		{
			ISymbol9 symbol = EnsureAndQuery<ISymbol9>();

			uint? value = GetS<uint>(symbol.GetFramePadOffset);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public bool? RuntimeStaticChecked
	{
		get
		{
			ISymbol9 symbol = EnsureAndQuery<ISymbol9>();

			bool? value = GetS<bool>(symbol.GetIsRuntimeStaticChecked);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol10

	public byte[]? SourceLink
	{
		get
		{
			ISymbol10 symbol = EnsureAndQuery<ISymbol10>();

			byte[]? value = GetA<byte>(symbol.GetSourceLink);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol11

	public DiscriminatedUnionTag? DiscriminatedUnionTag
	{
		get
		{
			ISymbol11 symbol = EnsureAndQuery<ISymbol11>();

			int result = symbol.GetDiscriminatedUnionTag(out ISymbol type, out uint offset, out TagValue mask);

			ComHelpers.Release(ref symbol);

			if (result == (int)KnownResult.S_FALSE) return null;

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			return new(new(type), offset, mask);
		}
	}

	public TagValue[]? TagRanges
	{
		get
		{
			ISymbol11 symbol = EnsureAndQuery<ISymbol11>();

			TagValue[]? value = GetA<TagValue>(symbol.GetTagRanges);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion
}
