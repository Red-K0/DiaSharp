using DiaSharp.CodeView;
using DiaSharp.CodeView.Hlsl;
using DiaSharp.COM;
using DiaSharp.Managed.Enumerables;
using DiaSharp.Native;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.Managed;

public sealed unsafe class Symbol(ISymbol symbol) : ComObject<ISymbol>(symbol)
{
	#region ISymbol

	public uint SymbolIndexID => GetProp<uint>(_native.GetSymbolIndexID);

	public SymbolTag SymbolTag => GetProp<SymbolTag>(_native.GetSymbolTag);

	public string Name => GetProp<string>(_native.GetName);

	public Symbol LexicalParent => new(GetProp<ISymbol>(_native.GetLexicalParent));

	public Symbol ClassParent => new(GetProp<ISymbol>(_native.GetClassParent));

	public Symbol SymbolType => new(GetProp<ISymbol>(_native.GetSymbolType));

	public DataKind DataKind => GetProp<DataKind>(_native.GetDataKind);

	public LocationType LocationType => GetProp<LocationType>(_native.GetLocationType);

	public uint AddressSection => GetProp<uint>(_native.GetAddressSection);

	public uint AddressOffset => GetProp<uint>(_native.GetAddressOffset);

	public uint RelativeVirtualAddress => GetProp<uint>(_native.GetRelativeVirtualAddress);

	public ulong VirtualAddress => GetProp<ulong>(_native.GetVirtualAddress);

	public uint RegisterID => GetProp<uint>(_native.GetRegisterID);

	public int Offset => GetProp<int>(_native.GetOffset);

	public ulong Length => GetProp<ulong>(_native.GetLength);

	public uint Slot => GetProp<uint>(_native.GetSlot);

	public bool VolatileType => GetProp<bool>(_native.GetVolatileType);

	public bool ConstType => GetProp<bool>(_native.GetConstType);

	public bool UnalignedType => GetProp<bool>(_native.GetUnalignedType);

	public uint Access => GetProp<uint>(_native.GetAccess);

	public string LibraryName => GetProp<string>(_native.GetLibraryName);

	public uint Platform => GetProp<uint>(_native.GetPlatform);

	public uint Language => GetProp<uint>(_native.GetLanguage);

	public bool EditAndContinueEnabled => GetProp<bool>(_native.GetEditAndContinueEnabled);

	public uint FrontendMajor => GetProp<uint>(_native.GetFrontendMajor);

	public uint FrontendMinor => GetProp<uint>(_native.GetFrontendMinor);

	public uint FrontendBuild => GetProp<uint>(_native.GetFrontendBuild);

	public uint BackendMajor => GetProp<uint>(_native.GetBackendMajor);

	public uint BackendMinor => GetProp<uint>(_native.GetBackendMinor);

	public uint BackendBuild => GetProp<uint>(_native.GetBackendBuild);

	public string SourceFileName => GetProp<string>(_native.GetSourceFileName);

	public string Unused => GetProp<string>(_native.GetUnused);

	public ThunkOrdinal ThunkOrdinal => GetProp<ThunkOrdinal>(_native.GetThunkOrdinal);

	public int ThisAdjustor => GetProp<int>(_native.GetThisAdjustor);

	public uint VirtualBaseOffset => GetProp<uint>(_native.GetVirtualBaseOffset);

	public bool IsVirtual => GetProp<bool>(_native.GetIsVirtual);

	public bool IsIntro => GetProp<bool>(_native.GetIsIntro);

	public bool IsPure => GetProp<bool>(_native.GetIsPure);

	public uint CallingConvention => GetProp<uint>(_native.GetCallingConvention);

	public Variant Value => GetProp<Variant>(_native.GetValue);

	public uint BaseType => GetProp<uint>(_native.GetBaseType);

	public uint Token => GetProp<uint>(_native.GetToken);

	public uint Timestamp => GetProp<uint>(_native.GetTimestamp);

	public Guid GUID => GetProp<Guid>(_native.GetGUID);

	public string SymbolsFileName => GetProp<string>(_native.GetSymbolsFileName);

	public bool IsReference => GetProp<bool>(_native.GetIsReference);

	public uint Count => GetProp<uint>(_native.GetCount);

	public uint BitPosition => GetProp<uint>(_native.GetBitPosition);

	public Symbol ArrayIndexType => new(GetProp<ISymbol>(_native.GetArrayIndexType));

	public bool IsPacked => GetProp<bool>(_native.GetIsPacked);

	public bool HasConstructor => GetProp<bool>(_native.GetHasConstructor);

	public bool HasOverloadedOperator => GetProp<bool>(_native.GetHasOverloadedOperator);

	public bool IsNested => GetProp<bool>(_native.GetIsNested);

	public bool HasNestedTypes => GetProp<bool>(_native.GetHasNestedTypes);

	public bool HasAssignmentOperator => GetProp<bool>(_native.GetHasAssignmentOperator);

	public bool HasCastOperator => GetProp<bool>(_native.GetHasCastOperator);

	public bool IsScoped => GetProp<bool>(_native.GetIsScoped);

	public bool IsVirtualBaseClass => GetProp<bool>(_native.GetIsVirtualBaseClass);

	public bool IsIndirectVirtualBaseClass => GetProp<bool>(_native.GetIsIndirectVirtualBaseClass);

	public int VirtualBasePointerOffset => GetProp<int>(_native.GetVirtualBasePointerOffset);

	public Symbol VirtualTableShape => new(GetProp<ISymbol>(_native.GetVirtualTableShape));

	public uint LexicalParentID => GetProp<uint>(_native.GetLexicalParentID);

	public uint ClassParentID => GetProp<uint>(_native.GetClassParentID);

	public uint TypeID => GetProp<uint>(_native.GetTypeID);

	public uint ArrayIndexTypeID => GetProp<uint>(_native.GetArrayIndexTypeID);

	public uint VirtualTableShapeID => GetProp<uint>(_native.GetVirtualTableShapeID);

	public bool IsCode => GetProp<bool>(_native.GetIsCode);

	public bool IsFunction => GetProp<bool>(_native.GetIsFunction);

	public bool IsManaged => GetProp<bool>(_native.GetIsManaged);

	public bool IsMSIL => GetProp<bool>(_native.GetIsMSIL);

	public uint VirtualBaseDisplacementIndex => GetProp<uint>(_native.GetVirtualBaseDisplacementIndex);

	public uint Age => GetProp<uint>(_native.GetAge);

	public uint Signature => GetProp<uint>(_native.GetSignature);

	public bool IsCompilerGenerated => GetProp<bool>(_native.GetIsCompilerGenerated);

	public bool IsAddressTaken => GetProp<bool>(_native.GetIsAddressTaken);

	public uint Rank => GetProp<uint>(_native.GetRank);

	public Symbol LowerBound => new(GetProp<ISymbol>(_native.GetLowerBound));

	public Symbol UpperBound => new(GetProp<ISymbol>(_native.GetUpperBound));

	public uint LowerBoundID => GetProp<uint>(_native.GetLowerBoundID);

	public uint UpperBoundID => GetProp<uint>(_native.GetUpperBoundID);

	public ReadOnlySpan<byte> DataBytes => GetProp<byte>(_native.GetDataBytes);

	public IEnumerable<Symbol> FindChildrenUnaware(SymbolTag symbolTag, string name, NameSearchOptions compareFlags)
	{
		EnsureNotDisposed();

		int result = _native.FindChildrenUnaware(symbolTag, name, compareFlags, out IEnumSymbols symbols);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol> FindChildren(SymbolTag symbolTag, string name, NameSearchOptions compareFlags)
	{
		EnsureNotDisposed();

		int result = _native.FindChildren(symbolTag, name, compareFlags, out IEnumSymbols symbols);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol> FindChildrenByAddress(SymbolTag symbolTag, string name, NameSearchOptions compareFlags, uint sectionIndex, uint offset)
	{
		EnsureNotDisposed();

		int result = _native.FindChildrenByAddress(symbolTag, name, compareFlags, sectionIndex, offset, out IEnumSymbols symbols);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol> FindChildrenByVA(SymbolTag symbolTag, string name, NameSearchOptions compareFlags, ulong virtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindChildrenByVA(symbolTag, name, compareFlags, virtualAddress, out IEnumSymbols symbols);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol> FindChildrenByRVA(SymbolTag symbolTag, string name, NameSearchOptions compareFlags, uint relativeVirtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindChildrenByRVA(symbolTag, name, compareFlags, relativeVirtualAddress, out IEnumSymbols symbols);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public uint TargetSection => GetProp<uint>(_native.GetTargetSection);

	public uint TargetOffset => GetProp<uint>(_native.GetTargetOffset);

	public uint TargetRelativeVirtualAddress => GetProp<uint>(_native.GetTargetRelativeVirtualAddress);

	public ulong TargetVirtualAddress => GetProp<ulong>(_native.GetTargetVirtualAddress);

	public Native.ImageFileMachine MachineType => GetProp<Native.ImageFileMachine>(_native.GetMachineType);

	public uint OemID => GetProp<uint>(_native.GetOemID);

	public uint OemSymbolID => GetProp<uint>(_native.GetOemSymbolID);

	public Symbol[] Types
	{
		get
		{
			ReadOnlySpan<nint> elements = GetProp(_native.GetTypes);

			Symbol[] symbols = new Symbol[elements.Length];

			for (int i = 0; i < elements.Length; i++) symbols[i] = new(ComHelpers.Wrap<ISymbol>((void*)elements[i]));

			return symbols;
		}
	}

	public unsafe ReadOnlySpan<uint> TypeIDs => GetProp<uint>(_native.GetTypeIDs);

	public Symbol ObjectPointerType => new(GetProp<ISymbol>(_native.GetObjectPointerType));

	public UdtKind UdtKind => GetProp<UdtKind>(_native.GetUdtKind);

	public string GetUndecoratedName(UndecorateOptions undecorateOptions = UndecorateOptions.None)
	{
		EnsureNotDisposed();

		int result = _native.GetUndecoratedName(undecorateOptions, out string undecorated);

		if (result == 1) throw new InvalidOperationException("Property is unsupported in the object's current state.");

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return undecorated;
	}

	public bool IsNoReturn => GetProp<bool>(_native.GetIsNoReturn);

	public bool HasCustomCallingConvention => GetProp<bool>(_native.GetHasCustomCallingConvention);

	public bool NoInline => GetProp<bool>(_native.GetNoInline);

	public bool HasOptimizedCodeDebugInfo => GetProp<bool>(_native.GetHasOptimizedCodeDebugInfo);

	public bool IsNotReached => GetProp<bool>(_native.GetIsNotReached);

	public bool HasInterruptReturn => GetProp<bool>(_native.GetHasInterruptReturn);

	public bool HasFarReturn => GetProp<bool>(_native.GetHasFarReturn);

	public bool IsStatic => GetProp<bool>(_native.GetIsStatic);

	public bool HasDebugInfo => GetProp<bool>(_native.GetHasDebugInfo);

	public bool IsLTCG => GetProp<bool>(_native.GetIsLTCG);

	public bool IsDataAligned => GetProp<bool>(_native.GetIsDataAligned);

	public bool HasSecurityChecks => GetProp<bool>(_native.GetHasSecurityChecks);

	public string CompilerName => GetProp<string>(_native.GetCompilerName);

	public bool HasAlloca => GetProp<bool>(_native.GetHasAlloca);

	public bool HasSetJump => GetProp<bool>(_native.GetHasSetJump);

	public bool HasLongJump => GetProp<bool>(_native.GetHasLongJump);

	public bool HasInlAsm => GetProp<bool>(_native.GetHasInlAsm);

	public bool HasEH => GetProp<bool>(_native.GetHasEH);

	public bool HasSEH => GetProp<bool>(_native.GetHasSEH);

	public bool HasEHa => GetProp<bool>(_native.GetHasEHa);

	public bool IsNaked => GetProp<bool>(_native.GetIsNaked);

	public bool IsAggregated => GetProp<bool>(_native.GetIsAggregated);

	public bool IsSplitted => GetProp<bool>(_native.GetIsSplitted);

	public Symbol Container => new(GetProp<ISymbol>(_native.GetContainer));

	public bool InliningSpecified => GetProp<bool>(_native.GetInliningSpecified);

	public bool NoStackOrderingSpecified => GetProp<bool>(_native.GetNoStackOrderingSpecified);

	public Symbol VirtualBaseTableType => new(GetProp<ISymbol>(_native.GetVirtualBaseTableType));

	public bool HasManagedCode => GetProp<bool>(_native.GetHasManagedCode);

	public bool IsHotpatchable => GetProp<bool>(_native.GetIsHotpatchable);

	public bool IsConvertedCIL => GetProp<bool>(_native.GetIsConvertedCIL);

	public bool IsMSILNetmodule => GetProp<bool>(_native.GetIsMSILNetmodule);

	public bool HasCTypes => GetProp<bool>(_native.GetHasCTypes);

	public bool IsStripped => GetProp<bool>(_native.GetIsStripped);

	public uint FrontendQFE => GetProp<uint>(_native.GetFrontendQFE);

	public uint BackendQFE => GetProp<uint>(_native.GetBackendQFE);

	public bool WasInlined => GetProp<bool>(_native.GetWasInlined);

	public bool HasStrictGSCheck => GetProp<bool>(_native.GetHasStrictGSCheck);

	public bool IsCxxReturnUdt => GetProp<bool>(_native.GetIsCxxReturnUdt);

	public bool IsConstructorVirtualBase => GetProp<bool>(_native.GetIsConstructorVirtualBase);

	public bool IsRValueReference => GetProp<bool>(_native.GetIsRValueReference);

	public Symbol UnmodifiedType => new(GetProp<ISymbol>(_native.GetUnmodifiedType));

	public bool FramePointerPresent => GetProp<bool>(_native.GetFramePointerPresent);

	public bool HasSafeBuffers => GetProp<bool>(_native.GetHasSafeBuffers);

	public bool IsIntrinsic => GetProp<bool>(_native.GetIsIntrinsic);

	public bool IsSealed => GetProp<bool>(_native.GetIsSealed);

	public bool HasHfaFloat => GetProp<bool>(_native.GetHasHfaFloat);

	public bool HasHfaDouble => GetProp<bool>(_native.GetHasHfaDouble);

	public uint LiveRangeStartAddressSection => GetProp<uint>(_native.GetLiveRangeStartAddressSection);

	public uint LiveRangeStartAddressOffset => GetProp<uint>(_native.GetLiveRangeStartAddressOffset);

	public uint LiveRangeStartRelativeVirtualAddress => GetProp<uint>(_native.GetLiveRangeStartRelativeVirtualAddress);

	public uint LiveRangeCount => GetProp<uint>(_native.GetLiveRangeCount);

	public ulong LiveRangeLength => GetProp<ulong>(_native.GetLiveRangeLength);

	public uint OffsetInUdt => GetProp<uint>(_native.GetOffsetInUdt);

	public uint ParamBasePointerRegisterID => GetProp<uint>(_native.GetParamBasePointerRegisterID);

	public uint LocalBasePointerRegisterID => GetProp<uint>(_native.GetLocalBasePointerRegisterID);

	public bool IsLocationControlFlowDependent => GetProp<bool>(_native.GetIsLocationControlFlowDependent);

	public uint Stride => GetProp<uint>(_native.GetStride);

	public uint NumberOfRows => GetProp<uint>(_native.GetNumberOfRows);

	public uint NumberOfColumns => GetProp<uint>(_native.GetNumberOfColumns);

	public bool IsMatrixRowMajor => GetProp<bool>(_native.GetIsMatrixRowMajor);

	public ReadOnlySpan<uint> NumericProperties => GetProp<uint>(_native.GetNumericProperties);

	public ReadOnlySpan<ushort> ModifierValues => GetProp<ushort>(_native.GetModifierValues);

	public bool IsReturnValue => GetProp<bool>(_native.GetIsReturnValue);

	public bool IsOptimizedAway => GetProp<bool>(_native.GetIsOptimizedAway);

	public BuiltIn BuiltInKind => GetProp<BuiltIn>(_native.GetBuiltInKind);

	public Register RegisterType => GetProp<Register>(_native.GetRegisterType);

	public uint BaseDataSlot => GetProp<uint>(_native.GetBaseDataSlot);

	public uint BaseDataOffset => GetProp<uint>(_native.GetBaseDataOffset);

	public uint TextureSlot => GetProp<uint>(_native.GetTextureSlot);

	public uint SamplerSlot => GetProp<uint>(_native.GetSamplerSlot);

	public uint UavSlot => GetProp<uint>(_native.GetUavSlot);

	public uint SizeInUdt => GetProp<uint>(_native.GetSizeInUdt);

	public MemorySpace MemorySpaceKind => GetProp<MemorySpace>(_native.GetMemorySpaceKind);

	public uint UnmodifiedTypeId => GetProp<uint>(_native.GetUnmodifiedTypeId);

	public uint SubTypeId => GetProp<uint>(_native.GetSubTypeId);

	public Symbol SubType => new(GetProp<ISymbol>(_native.GetSubType));

	public uint NumberOfModifiers => GetProp<uint>(_native.GetNumberOfModifiers);

	public uint NumberOfRegisterIndices => GetProp<uint>(_native.GetNumberOfRegisterIndices);

	public bool IsHLSLData => GetProp<bool>(_native.GetIsHLSLData);

	public bool IsPointerToDataMember => GetProp<bool>(_native.GetIsPointerToDataMember);

	public bool IsPointerToMemberFunction => GetProp<bool>(_native.GetIsPointerToMemberFunction);

	public bool IsSingleInheritance => GetProp<bool>(_native.GetIsSingleInheritance);

	public bool IsMultipleInheritance => GetProp<bool>(_native.GetIsMultipleInheritance);

	public bool IsVirtualInheritance => GetProp<bool>(_native.GetIsVirtualInheritance);

	public bool RestrictedType => GetProp<bool>(_native.GetRestrictedType);

	public bool IsPointerBasedOnSymbolValue => GetProp<bool>(_native.GetIsPointerBasedOnSymbolValue);

	public Symbol BaseSymbol => new(GetProp<ISymbol>(_native.GetBaseSymbol));

	public uint BaseSymbolId => GetProp<uint>(_native.GetBaseSymbolId);

	public string ObjectFileName => GetProp<string>(_native.GetObjectFileName);

	public bool IsAcceleratorGroupSharedLocal => GetProp<bool>(_native.GetIsAcceleratorGroupSharedLocal);

	public bool IsAcceleratorPointerTagLiveRange => GetProp<bool>(_native.GetIsAcceleratorPointerTagLiveRange);

	public bool IsAcceleratorStubFunction => GetProp<bool>(_native.GetIsAcceleratorStubFunction);

	public uint NumberOfAcceleratorPointerTags => GetProp<uint>(_native.GetNumberOfAcceleratorPointerTags);

	public bool IsSDL => GetProp<bool>(_native.GetIsSDL);

	public bool IsWinRTPointer => GetProp<bool>(_native.GetIsWinRTPointer);

	public bool IsRefUdt => GetProp<bool>(_native.GetIsRefUdt);

	public bool IsValueUdt => GetProp<bool>(_native.GetIsValueUdt);

	public bool IsInterfaceUdt => GetProp<bool>(_native.GetIsInterfaceUdt);

	public IEnumerable<Symbol> FindInlineFramesByAddress(uint sectionIndex, uint offset)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineFramesByAddress(sectionIndex, offset, out IEnumSymbols symbols);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol> FindInlineFramesByRVA(uint relativeVirtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineFramesByRVA(relativeVirtualAddress, out IEnumSymbols symbols);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol> FindInlineFramesByVA(ulong virtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineFramesByVA(virtualAddress, out IEnumSymbols symbols);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<LineNumber> InlineeLines => new LineNumberEnumerable(GetProp<IEnumLineNumbers>(_native.FindInlineeLines));

	public IEnumerable<LineNumber> FindInlineeLinesByAddress(uint sectionIndex, uint offset, uint length)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineeLinesByAddress(sectionIndex, offset, length, out IEnumLineNumbers numbers);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(numbers);
	}

	public IEnumerable<LineNumber> FindInlineeLinesByRVA(uint relativeVirtualAddress, uint length)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineeLinesByRVA(relativeVirtualAddress, length, out IEnumLineNumbers numbers);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(numbers);
	}

	public IEnumerable<LineNumber> FindInlineeLinesByVA(ulong virtualAddress, uint length)
	{
		EnsureNotDisposed();

		int result = _native.FindInlineeLinesByVA(virtualAddress, length, out IEnumLineNumbers numbers);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new LineNumberEnumerable(numbers);
	}

	public IEnumerable<Symbol> FindSymbolsForAcceleratorPointerTag(uint tagValue)
	{
		EnsureNotDisposed();

		int result = _native.FindSymbolsForAcceleratorPointerTag(tagValue, out IEnumSymbols symbols);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public IEnumerable<Symbol> FindSymbolsByRVAForAcceleratorPointerTag(uint tagValue, uint relativeVirtualAddress)
	{
		EnsureNotDisposed();

		int result = _native.FindSymbolsByRVAForAcceleratorPointerTag(tagValue, relativeVirtualAddress, out IEnumSymbols symbols);

		if (result == 1) return [];

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return new SymbolEnumerable(symbols);
	}

	public ReadOnlySpan<uint> AcceleratorPointerTags => GetProp<uint>(_native.GetAcceleratorPointerTags);

	public LineNumber SourceLineOnTypeDefinition => new(GetProp<ILineNumber>(_native.GetSourceLineOnTypeDefinition));

	public bool IsPGO => GetProp<bool>(_native.GetIsPGO);

	public bool HasValidPGOCounts => GetProp<bool>(_native.GetHasValidPGOCounts);

	public bool IsOptimizedForSpeed => GetProp<bool>(_native.GetIsOptimizedForSpeed);

	public uint PGOEntryCount => GetProp<uint>(_native.GetPGOEntryCount);

	public uint PGOEdgeCount => GetProp<uint>(_native.GetPGOEdgeCount);

	public ulong PGODynamicInstructionCount => GetProp<ulong>(_native.GetPGODynamicInstructionCount);

	public uint StaticSize => GetProp<uint>(_native.GetStaticSize);

	public uint FinalLiveStaticSize => GetProp<uint>(_native.GetFinalLiveStaticSize);

	public string PhaseName => GetProp<string>(_native.GetPhaseName);

	public bool HasControlFlowCheck => GetProp<bool>(_native.GetHasControlFlowCheck);

	public bool IsConstantExport => GetProp<bool>(_native.GetIsConstantExport);

	public bool IsDataExport => GetProp<bool>(_native.GetIsDataExport);

	public bool PrivateExport => GetProp<bool>(_native.GetPrivateExport);

	public bool NoNameExport => GetProp<bool>(_native.GetNoNameExport);

	public bool ExportHasExplicitlyAssignedOrdinal => GetProp<bool>(_native.GetExportHasExplicitlyAssignedOrdinal);

	public bool ExportIsForwarder => GetProp<bool>(_native.GetExportIsForwarder);

	public uint Ordinal => GetProp<uint>(_native.GetOrdinal);

	public uint FrameSize => GetProp<uint>(_native.GetFrameSize);

	public uint ExceptionHandlerAddressSection => GetProp<uint>(_native.GetExceptionHandlerAddressSection);

	public uint ExceptionHandlerAddressOffset => GetProp<uint>(_native.GetExceptionHandlerAddressOffset);

	public uint ExceptionHandlerRelativeVirtualAddress => GetProp<uint>(_native.GetExceptionHandlerRelativeVirtualAddress);

	public ulong ExceptionHandlerVirtualAddress => GetProp<ulong>(_native.GetExceptionHandlerVirtualAddress);

	public InputAssemblyFile InputAssemblyFile => new(GetProp<IInputAssemblyFile>(_native.FindInputAssemblyFile));

	public uint Characteristics => GetProp<uint>(_native.GetCharacteristics);

	public Symbol CoffGroup => new(GetProp<ISymbol>(_native.GetCoffGroup));

	public uint BindID => GetProp<uint>(_native.GetBindID);

	public uint BindSpace => GetProp<uint>(_native.GetBindSpace);

	public uint BindSlot => GetProp<uint>(_native.GetBindSlot);

	#endregion

	#region ISymbol2

	public bool ObjectiveCClass
	{
		get
		{
			ISymbol2 symbol = EnsureAndQuery<ISymbol2>();

			bool value = GetProp<bool>(symbol.GetIsObjectiveCClass);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public bool ObjectiveCCategory
	{
		get
		{
			ISymbol2 symbol = EnsureAndQuery<ISymbol2>();

			bool value = GetProp<bool>(symbol.GetIsObjectiveCCategory);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public bool ObjectiveCProtocol
	{
		get
		{
			ISymbol2 symbol = EnsureAndQuery<ISymbol2>();

			bool value = GetProp<bool>(symbol.GetIsObjectiveCProtocol);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol3

	public Symbol Inlinee
	{
		get
		{
			ISymbol3 symbol = EnsureAndQuery<ISymbol3>();

			ISymbol value = GetProp<ISymbol>(symbol.GetInlinee);

			ComHelpers.Release(ref symbol);

			return new(value);
		}
	}

	public uint InlineeID
	{
		get
		{
			ISymbol3 symbol = EnsureAndQuery<ISymbol3>();

			uint value = GetProp<uint>(symbol.GetInlineeID);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol4

	public bool NoExcept
	{
		get
		{
			ISymbol4 symbol = EnsureAndQuery<ISymbol4>();

			bool value = GetProp<bool>(symbol.GetIsNoExcept);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol5

	public bool AbsoluteAddress
	{
		get
		{
			ISymbol5 symbol = EnsureAndQuery<ISymbol5>();

			bool value = GetProp<bool>(symbol.GetHasAbsoluteAddress);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol6

	public bool StaticMemberFunction
	{
		get
		{
			ISymbol6 symbol = EnsureAndQuery<ISymbol6>();

			bool value = GetProp<bool>(symbol.GetIsStaticMemberFunction);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol7

	public bool SignedReturn
	{
		get
		{
			ISymbol7 symbol = EnsureAndQuery<ISymbol7>();

			bool value = GetProp<bool>(symbol.GetIsSignedReturn);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol8

	public CoroutineKind CoroutineKind
	{
		get
		{
			ISymbol8 symbol = EnsureAndQuery<ISymbol8>();

			CoroutineKind value = GetProp<CoroutineKind>(symbol.GetCoroutineKind);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public AssociationKind AssociatedSymbolKind
	{
		get
		{
			ISymbol8 symbol = EnsureAndQuery<ISymbol8>();

			AssociationKind value = GetProp<AssociationKind>(symbol.GetAssociatedSymbolKind);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public uint AssociatedSymbolSection
	{
		get
		{
			ISymbol8 symbol = EnsureAndQuery<ISymbol8>();

			uint value = GetProp<uint>(symbol.GetAssociatedSymbolSection);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public uint AssociatedSymbolOffset
	{
		get
		{
			ISymbol8 symbol = EnsureAndQuery<ISymbol8>();

			uint value = GetProp<uint>(symbol.GetAssociatedSymbolOffset);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public uint AssociatedSymbolRVA
	{
		get
		{
			ISymbol8 symbol = EnsureAndQuery<ISymbol8>();

			uint value = GetProp<uint>(symbol.GetAssociatedSymbolRVA);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public ulong AssociatedSymbolAddress
	{
		get
		{
			ISymbol8 symbol = EnsureAndQuery<ISymbol8>();

			ulong value = GetProp<ulong>(symbol.GetAssociatedSymbolAddress);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol9

	public uint FramePadSize
	{
		get
		{
			ISymbol9 symbol = EnsureAndQuery<ISymbol9>();

			uint value = GetProp<uint>(symbol.GetFramePadSize);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public uint FramePadOffset
	{
		get
		{
			ISymbol9 symbol = EnsureAndQuery<ISymbol9>();

			uint value = GetProp<uint>(symbol.GetFramePadOffset);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	public bool RuntimeStaticChecked
	{
		get
		{
			ISymbol9 symbol = EnsureAndQuery<ISymbol9>();

			bool value = GetProp<bool>(symbol.GetIsRuntimeStaticChecked);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol10

	public ReadOnlySpan<byte> SourceLink
	{
		get
		{
			ISymbol10 symbol = EnsureAndQuery<ISymbol10>();

			ReadOnlySpan<byte> value = GetProp<byte>(symbol.GetSourceLink);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion

	#region ISymbol11

	public void GetDiscriminatedUnionTag(out ISymbol tagType, out uint tagOffset, out TagValue tagMask)
	{
		ISymbol11 symbol = EnsureAndQuery<ISymbol11>();

		int result = symbol.GetDiscriminatedUnionTag(out tagType, out tagOffset, out tagMask);

		if (result == (int)KnownResult.S_FALSE) throw new InvalidOperationException("Property is unsupported in the object's current state.");

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		ComHelpers.Release(ref symbol);
	}

	public ReadOnlySpan<TagValue> TagRanges
	{
		get
		{
			ISymbol11 symbol = EnsureAndQuery<ISymbol11>();

			ReadOnlySpan<TagValue> value = GetProp<TagValue>(symbol.GetTagRanges);

			ComHelpers.Release(ref symbol);

			return value;
		}
	}

	#endregion
}
