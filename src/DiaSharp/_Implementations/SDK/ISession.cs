#pragma warning disable IDE0008, IDE0022

using DiaSharp.CodeView;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([225, 158, 96, 47, 200, 209, 36, 78, 130, 136, 51, 38, 186, 220, 210, 17]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ISession
{
	[SkipLocalsInit]
	int ISession.GetLoadAddress(out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		fixed (ulong* __address_native = &address)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[3])(__this, __address_native);
		}
	}

	[SkipLocalsInit]
	int ISession.PutLoadAddress(ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		return ((delegate* unmanaged[MemberFunction]<void*, ulong, int>)__vtable_native[4])(__this, address);
	}

	[SkipLocalsInit]
	int ISession.GetGlobalScope(out ISymbol scope)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __scope_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[5])(__this, &__scope_native);

		scope = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__scope_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__scope_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetEnumTables(out IEnumTables tables)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __tables_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[6])(__this, &__tables_native);

		tables = ComInterfaceMarshaller<IEnumTables>.ConvertToManaged(__tables_native)!;

		ComInterfaceMarshaller<IEnumTables>.Free(__tables_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetSymbolsByAddress(out IEnumSymbolsByAddress symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbols_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[7])(__this, &__symbols_native);

		symbols = ComInterfaceMarshaller<IEnumSymbolsByAddress>.ConvertToManaged(__symbols_native)!;

		ComInterfaceMarshaller<IEnumSymbolsByAddress>.Free(__symbols_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindChildren(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbols_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, SymbolTag, ushort*, NameSearchOptions, void**, int>)__vtable_native[8])(__this, __parent_native, symbolTag, (ushort*)__name_native, searchOptions, &__symbols_native);
		}

		symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindChildrenEx(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbols_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, SymbolTag, ushort*, NameSearchOptions, void**, int>)__vtable_native[9])(__this, __parent_native, symbolTag, (ushort*)__name_native, searchOptions, &__symbols_native);
		}

		symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindChildrenExByAddress(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, uint sectionIndex, uint offset, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbols_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, SymbolTag, ushort*, NameSearchOptions, uint, uint, void**, int>)__vtable_native[10])(__this, __parent_native, symbolTag, (ushort*)__name_native, searchOptions, sectionIndex, offset, &__symbols_native);
		}

		symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindChildrenExByVA(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, ulong virtualAddress, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbols_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, SymbolTag, ushort*, NameSearchOptions, ulong, void**, int>)__vtable_native[11])(__this, __parent_native, symbolTag, (ushort*)__name_native, searchOptions, virtualAddress, &__symbols_native);
		}

		symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindChildrenExByRVA(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, uint relativeVirtualAddress, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbols_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, SymbolTag, ushort*, NameSearchOptions, uint, void**, int>)__vtable_native[12])(__this, __parent_native, symbolTag, (ushort*)__name_native, searchOptions, relativeVirtualAddress, &__symbols_native);
		}

		symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolByAddress(uint sectionIndex, uint offset, SymbolTag symbolTag, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbol_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, SymbolTag, void**, int>)__vtable_native[13])(__this, sectionIndex, offset, symbolTag, &__symbol_native);

		symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag symbolTag, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbol_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, SymbolTag, void**, int>)__vtable_native[14])(__this, relativeVirtualAddress, symbolTag, &__symbol_native);

		symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolByVA(ulong virtualAddress, SymbolTag symbolTag, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbol_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, SymbolTag, void**, int>)__vtable_native[15])(__this, virtualAddress, symbolTag, &__symbol_native);

		symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolByToken(uint token, SymbolTag symbolTag, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbol_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, SymbolTag, void**, int>)__vtable_native[16])(__this, token, symbolTag, &__symbol_native);

		symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.SymbolsAreEquivalent(ISymbol symbolA, ISymbol symbolB)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		void *__symbolA_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbolA), __symbolB_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbolB);

		ComInterfaceMarshaller<ISymbol>.Free(__symbolB_native);
		ComInterfaceMarshaller<ISymbol>.Free(__symbolA_native);

		return ((delegate* unmanaged[MemberFunction]<void*, void*, void*, int>)__vtable_native[17])(__this, __symbolA_native, __symbolB_native);
	}

	[SkipLocalsInit]
	int ISession.SymbolByID(uint id, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbol_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[18])(__this, id, &__symbol_native);

		symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag symbolTag, out int displacement, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbol_native = null;

		int __retVal;

		fixed (int* __displacement_native = &displacement)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, SymbolTag, int*, void**, int>)__vtable_native[19])(__this, relativeVirtualAddress, symbolTag, __displacement_native, &__symbol_native);
		}

		symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolByVA(ulong VirtualAddress, SymbolTag symbolTag, out int displacement, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbol_native = null;

		int __retVal;

		fixed (int* __displacement_native = &displacement)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, SymbolTag, int*, void**, int>)__vtable_native[20])(__this, VirtualAddress, symbolTag, __displacement_native, &__symbol_native);
		}

		symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindFile(ISymbol compiland, string name, NameSearchOptions searchOptions, out IEnumSourceFiles files)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __files_native = null;

		void* __compiland_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(compiland);

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, ushort*, NameSearchOptions, void**, int>)__vtable_native[21])(__this, __compiland_native, (ushort*)__name_native, searchOptions, &__files_native);
		}

		files = ComInterfaceMarshaller<IEnumSourceFiles>.ConvertToManaged(__files_native)!;

		ComInterfaceMarshaller<IEnumSourceFiles>.Free(__files_native);
		ComInterfaceMarshaller<ISymbol>.Free(__compiland_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindFileByID(uint uniqueId, out ISourceFile file)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __file_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[22])(__this, uniqueId, &__file_native);

		file = ComInterfaceMarshaller<ISourceFile>.ConvertToManaged(__file_native)!;

		ComInterfaceMarshaller<ISourceFile>.Free(__file_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindLines(ISymbol compiland, ISourceFile file, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		void* __compiland_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(compiland);
		void* __file_native = ComInterfaceMarshaller<ISourceFile>.ConvertToUnmanaged(file);

		int __retVal;

		__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void*, void**, int>)__vtable_native[23])(__this, __compiland_native, __file_native, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
		ComInterfaceMarshaller<ISourceFile>.Free(__file_native);
		ComInterfaceMarshaller<ISymbol>.Free(__compiland_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindLinesByAddress(uint segment, uint offset, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint, void**, int>)__vtable_native[24])(__this, segment, offset, length, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindLinesByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, void**, int>)__vtable_native[25])(__this, relativeVirtualAddress, length, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindLinesByVA(ulong virtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, void**, int>)__vtable_native[26])(__this, virtualAddress, length, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		void* __compiland_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(compiland);
		void* __file_native = ComInterfaceMarshaller<ISourceFile>.ConvertToUnmanaged(file);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void*, uint, uint, void**, int>)__vtable_native[27])(__this, __compiland_native, __file_native, lineNumber, column, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
		ComInterfaceMarshaller<ISourceFile>.Free(__file_native);
		ComInterfaceMarshaller<ISymbol>.Free(__compiland_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInjectedSource(string sourceFile, out IEnumInjectedSources sources)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __sources_native = null;

		int __retVal;

		fixed (void* __sourceFile_native = &Utf16StringMarshaller.GetPinnableReference(sourceFile))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, void**, int>)__vtable_native[28])(__this, (ushort*)__sourceFile_native, &__sources_native);
		}

		sources = ComInterfaceMarshaller<IEnumInjectedSources>.ConvertToManaged(__sources_native)!;

		ComInterfaceMarshaller<IEnumInjectedSources>.Free(__sources_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetEnumDebugStreams(out IEnumDebugStreams streams)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __streams_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[29])(__this, &__streams_native);

		streams = ComInterfaceMarshaller<IEnumDebugStreams>.ConvertToManaged(__streams_native)!;

		ComInterfaceMarshaller<IEnumDebugStreams>.Free(__streams_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineFramesByAddress(ISymbol parent, uint sectionIndex, uint offset, out IEnumSymbols inlinees)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __inlinees_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, uint, void**, int>)__vtable_native[30])(__this, __parent_native, sectionIndex, offset, &__inlinees_native);

		inlinees = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__inlinees_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__inlinees_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineFramesByRVA(ISymbol parent, uint relativeVirtualAddress, out IEnumSymbols inlinees)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __inlinees_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, void**, int>)__vtable_native[31])(__this, __parent_native, relativeVirtualAddress, &__inlinees_native);

		inlinees = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__inlinees_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__inlinees_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineFramesByVA(ISymbol parent, ulong virtualAddress, out IEnumSymbols inlinees)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __inlinees_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, ulong, void**, int>)__vtable_native[32])(__this, __parent_native, virtualAddress, &__inlinees_native);

		inlinees = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__inlinees_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__inlinees_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineeLines(ISymbol parent, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void**, int>)__vtable_native[33])(__this, __parent_native, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineeLinesByAddress(ISymbol parent, uint sectionIndex, uint offset, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, uint, uint, void**, int>)__vtable_native[34])(__this, __parent_native, sectionIndex, offset, length, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineeLinesByRVA(ISymbol parent, uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, uint, void**, int>)__vtable_native[35])(__this, __parent_native, relativeVirtualAddress, length, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineeLinesByVA(ISymbol parent, ulong virtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, ulong, uint, void**, int>)__vtable_native[36])(__this, __parent_native, virtualAddress, length, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineeLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		void* __compiland_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(compiland);
		void* __file_native = ComInterfaceMarshaller<ISourceFile>.ConvertToUnmanaged(file);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void*, uint, uint, void**, int>)__vtable_native[37])(__this, __compiland_native, __file_native, lineNumber, column, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
		ComInterfaceMarshaller<ISourceFile>.Free(__file_native);
		ComInterfaceMarshaller<ISymbol>.Free(__compiland_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineesByName(string name, NameSearchOptions searchOptions, out IEnumSymbols inlinees)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __inlinees_native = null;

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, NameSearchOptions, void**, int>)__vtable_native[38])(__this, (ushort*)__name_native, searchOptions, &__inlinees_native);
		}

		inlinees = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__inlinees_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__inlinees_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindAcceleratorInlineeLinesByLineNumber(ISymbol parent, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
		void* __file_native = ComInterfaceMarshaller<ISourceFile>.ConvertToUnmanaged(file);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void*, uint, uint, void**, int>)__vtable_native[39])(__this, __parent_native, __file_native, lineNumber, column, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
		ComInterfaceMarshaller<ISourceFile>.Free(__file_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolsForAcceleratorPointerTag(ISymbol parent, uint tagValue, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbols_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, void**, int>)__vtable_native[40])(__this, __parent_native, tagValue, &__symbols_native);

		symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolsByRVAForAcceleratorPointerTag(ISymbol parent, uint tagValue, uint relativeVirtualAddress, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbols_native = null;

		void* __parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, uint, void**, int>)__vtable_native[41])(__this, __parent_native, tagValue, relativeVirtualAddress, &__symbols_native);

		symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
		ComInterfaceMarshaller<ISymbol>.Free(__parent_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindAcceleratorInlineesByName(string name, NameSearchOptions searchOptions, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbols_native = null;

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, NameSearchOptions, void**, int>)__vtable_native[42])(__this, (ushort*)__name_native, searchOptions, &__symbols_native);
		}

		symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetAddressForVA(ulong virtualAddress, out uint sectionIndex, out uint address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		fixed (uint* __address_native = &address)
		fixed (uint* __sectionIndex_native = &sectionIndex)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong, uint*, uint*, int>)__vtable_native[43])(__this, virtualAddress, __sectionIndex_native, __address_native);
		}
	}

	[SkipLocalsInit]
	int ISession.GetAddressForRVA(uint relativeVirtualAddress, out uint sectionIndex, out uint address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		fixed (uint* __address_native = &address)
		fixed (uint* __sectionIndex_native = &sectionIndex)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, uint*, int>)__vtable_native[44])(__this, relativeVirtualAddress, __sectionIndex_native, __address_native);
		}
	}

	[SkipLocalsInit]
	int ISession.FindILOffsetsByAddress(uint sectionIndex, uint offset, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint, void**, int>)__vtable_native[45])(__this, sectionIndex, offset, length, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindILOffsetsByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, void**, int>)__vtable_native[46])(__this, relativeVirtualAddress, length, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindILOffsetsByVA(ulong virtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __lines_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, void**, int>)__vtable_native[47])(__this, virtualAddress, length, &__lines_native);

		lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInputAssemblyFiles(out IEnumInputAssemblyFiles files)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __files_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[48])(__this, &__files_native);

		files = ComInterfaceMarshaller<IEnumInputAssemblyFiles>.ConvertToManaged(__files_native)!;

		ComInterfaceMarshaller<IEnumInputAssemblyFiles>.Free(__files_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInputAssembly(uint index, out IInputAssemblyFile assembly)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __assembly_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[49])(__this, index, &__assembly_native);

		assembly = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToManaged(__assembly_native)!;

		ComInterfaceMarshaller<IInputAssemblyFile>.Free(__assembly_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInputAssemblyByID(uint uniqueId, out IInputAssemblyFile assembly)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __assembly_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[50])(__this, uniqueId, &__assembly_native);

		assembly = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToManaged(__assembly_native)!;

		ComInterfaceMarshaller<IInputAssemblyFile>.Free(__assembly_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetFunctionMetadataTokenMapSize(out uint size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		fixed (uint* __size_native = &size)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[51])(__this, __size_native);
		}
	}

	[SkipLocalsInit]
	int ISession.GetFunctionMetadataTokenMap(uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[52])(__this, bufferSize, __bytesWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int ISession.GetTypeMetadataTokenMapSize(out uint size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		fixed (uint* __size_native = &size)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[53])(__this, __size_native);
		}
	}

	[SkipLocalsInit]
	int ISession.GetTypeMetadataTokenMap(uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[54])(__this, bufferSize, __bytesWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int ISession.GetNumberOfFunctionFragmentsForVA(ulong functionVA, uint functionSize, out uint fragmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		fixed (uint* __fragmentCount_native = &fragmentCount)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint*, int>)__vtable_native[55])(__this, functionVA, functionSize, __fragmentCount_native);
		}
	}

	[SkipLocalsInit]
	int ISession.GetNumberOfFunctionFragmentsForRVA(uint functionRVA, uint functionSize, out uint fragmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		fixed (uint* __fragmentCount_native = &fragmentCount)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint*, int>)__vtable_native[56])(__this, functionRVA, functionSize, __fragmentCount_native);
		}
	}

	[SkipLocalsInit]
	int ISession.GetFunctionFragmentsForVA(ulong functionVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		return ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint, uint*, uint*, int>)__vtable_native[57])(__this, functionVA, functionSize, fragmentCount, buffer, fragmentLengths);
	}

	[SkipLocalsInit]
	int ISession.GetFunctionFragmentsForRVA(uint functionRVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint, uint*, uint*, int>)__vtable_native[58])(__this, functionRVA, functionSize, fragmentCount, buffer, fragmentLengths);
	}

	[SkipLocalsInit]
	int ISession.GetExports(out IEnumSymbols exports)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __exports_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[59])(__this, &__exports_native);

		exports = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__exports_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__exports_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetHeapAllocationSites(out IEnumSymbols sites)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __sites_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[60])(__this, &__sites_native);

		sites = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__sites_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__sites_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInputAssemblyFile(ISymbol symbol, out IInputAssemblyFile assembly)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __assembly_native = null;

		void* __symbol_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void**, int>)__vtable_native[61])(__this, __symbol_native, &__assembly_native);

		assembly = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToManaged(__assembly_native)!;

		ComInterfaceMarshaller<IInputAssemblyFile>.Free(__assembly_native);
		ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLoadAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __address_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetLoadAddress(out *__address_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_PutLoadAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong address)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).PutLoadAddress(address);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetGlobalScope(ComWrappers.ComInterfaceDispatch* __this_native, void** __scope_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetGlobalScope(out ISymbol scope);

		*__scope_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(scope);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetEnumTables(ComWrappers.ComInterfaceDispatch* __this_native, void** __tables_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetEnumTables(out IEnumTables tables);

		*__tables_native__param = ComInterfaceMarshaller<IEnumTables>.ConvertToUnmanaged(tables);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSymbolsByAddress(ComWrappers.ComInterfaceDispatch* __this_native, void** __symbols_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetSymbolsByAddress(out IEnumSymbolsByAddress symbols);

		*__symbols_native__param = ComInterfaceMarshaller<IEnumSymbolsByAddress>.ConvertToUnmanaged(symbols);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindChildren(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions searchOptions, void** __symbols_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindChildren(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, symbolTag, Utf16StringMarshaller.ConvertToManaged(__name_native)!, searchOptions, out IEnumSymbols symbols);

		*__symbols_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindChildrenEx(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions searchOptions, void** __symbols_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindChildrenEx(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, symbolTag, Utf16StringMarshaller.ConvertToManaged(__name_native)!, searchOptions, out IEnumSymbols symbols);

		*__symbols_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindChildrenExByAddress(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions searchOptions, uint sectionIndex, uint offset, void** __symbols_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindChildrenExByAddress(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, symbolTag, Utf16StringMarshaller.ConvertToManaged(__name_native)!, searchOptions, sectionIndex, offset, out IEnumSymbols symbols);

		*__symbols_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindChildrenExByVA(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions searchOptions, ulong virtualAddress, void** __symbols_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindChildrenExByVA(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, symbolTag, Utf16StringMarshaller.ConvertToManaged(__name_native)!, searchOptions, virtualAddress, out IEnumSymbols symbols);

		*__symbols_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindChildrenExByRVA(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions searchOptions, uint relativeVirtualAddress, void** __symbols_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindChildrenExByRVA(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, symbolTag, Utf16StringMarshaller.ConvertToManaged(__name_native)!, searchOptions, relativeVirtualAddress, out IEnumSymbols symbols);

		*__symbols_native__param  = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindSymbolByAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint sectionIndex, uint offset, SymbolTag symbolTag, void** __symbol_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindSymbolByAddress(sectionIndex, offset, symbolTag, out ISymbol symbol);

		*__symbol_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindSymbolByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, SymbolTag symbolTag, void** __symbol_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindSymbolByRVA(relativeVirtualAddress, symbolTag, out ISymbol symbol);

		*__symbol_native__param= ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindSymbolByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, SymbolTag symbolTag, void** __symbol_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindSymbolByVA(virtualAddress, symbolTag, out ISymbol symbol);

		*__symbol_native__param= ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindSymbolByToken(ComWrappers.ComInterfaceDispatch* __this_native, uint token, SymbolTag symbolTag, void** __symbol_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindSymbolByToken(token, symbolTag, out ISymbol symbol);

		*__symbol_native__param= ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_SymbolsAreEquivalent(ComWrappers.ComInterfaceDispatch* __this_native, void* __symbolA_native, void* __symbolB_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).SymbolsAreEquivalent(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbolA_native)!, ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbolB_native)!);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_SymbolByID(ComWrappers.ComInterfaceDispatch* __this_native, uint id, void** __symbol_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).SymbolByID(id, out ISymbol symbol);

		*__symbol_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindSymbolByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, SymbolTag symbolTag, int* __displacement_native__param, void** __symbol_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindSymbolByRVA(relativeVirtualAddress, symbolTag, out *__displacement_native__param, out ISymbol symbol);

		*__symbol_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindSymbolByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong VirtualAddress, SymbolTag symbolTag, int* __displacement_native__param, void** __symbol_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindSymbolByVA(VirtualAddress, symbolTag, out *__displacement_native__param, out ISymbol symbol);

		*__symbol_native__param= ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindFile(ComWrappers.ComInterfaceDispatch* __this_native, void* __compiland_native, ushort* __name_native, NameSearchOptions searchOptions, void** __files_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindFile(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__compiland_native)!, Utf16StringMarshaller.ConvertToManaged(__name_native)!, searchOptions, out IEnumSourceFiles files);

		*__files_native__param = ComInterfaceMarshaller<IEnumSourceFiles>.ConvertToUnmanaged(files);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindFileByID(ComWrappers.ComInterfaceDispatch* __this_native, uint uniqueId, void** __file_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindFileByID(uniqueId, out ISourceFile file);

		*__file_native__param = ComInterfaceMarshaller<ISourceFile>.ConvertToUnmanaged(file);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindLines(ComWrappers.ComInterfaceDispatch* __this_native, void* __compiland_native, void* __file_native, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindLines(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__compiland_native)!, ComInterfaceMarshaller<ISourceFile>.ConvertToManaged(__file_native)!, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindLinesByAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint segment, uint offset, uint length, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindLinesByAddress(segment, offset, length, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindLinesByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, uint length, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindLinesByRVA(relativeVirtualAddress, length, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindLinesByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, uint length, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindLinesByVA(virtualAddress, length, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindLinesByLineNumber(ComWrappers.ComInterfaceDispatch* __this_native, void* __compiland_native, void* __file_native, uint lineNumber, uint column, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindLinesByLineNumber(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__compiland_native)!, ComInterfaceMarshaller<ISourceFile>.ConvertToManaged(__file_native)!, lineNumber, column, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInjectedSource(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __sourceFile_native, void** __sources_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInjectedSource(Utf16StringMarshaller.ConvertToManaged(__sourceFile_native)!, out IEnumInjectedSources sources);

		*__sources_native__param = ComInterfaceMarshaller<IEnumInjectedSources>.ConvertToUnmanaged(sources);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetEnumDebugStreams(ComWrappers.ComInterfaceDispatch* __this_native, void** __streams_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetEnumDebugStreams(out IEnumDebugStreams streams);

		*__streams_native__param = ComInterfaceMarshaller<IEnumDebugStreams>.ConvertToUnmanaged(streams);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineFramesByAddress(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, uint sectionIndex, uint offset, void** __inlinees_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInlineFramesByAddress(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, sectionIndex, offset, out IEnumSymbols inlinees);

		*__inlinees_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(inlinees);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineFramesByRVA(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, uint relativeVirtualAddress, void** __inlinees_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInlineFramesByRVA(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, relativeVirtualAddress, out IEnumSymbols inlinees);

		*__inlinees_native__param  = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(inlinees);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineFramesByVA(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, ulong virtualAddress, void** __inlinees_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInlineFramesByVA(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, virtualAddress, out IEnumSymbols inlinees);

		*__inlinees_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(inlinees);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineeLines(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInlineeLines(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineeLinesByAddress(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, uint sectionIndex, uint offset, uint length, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInlineeLinesByAddress(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, sectionIndex, offset, length, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineeLinesByRVA(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, uint relativeVirtualAddress, uint length, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInlineeLinesByRVA(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, relativeVirtualAddress, length, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineeLinesByVA(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, ulong virtualAddress, uint length, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInlineeLinesByVA(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, virtualAddress, length, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineeLinesByLineNumber(ComWrappers.ComInterfaceDispatch* __this_native, void* __compiland_native, void* __file_native, uint lineNumber, uint column, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInlineeLinesByLineNumber(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__compiland_native)!, ComInterfaceMarshaller<ISourceFile>.ConvertToManaged(__file_native)!, lineNumber, column, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineesByName(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __name_native, NameSearchOptions searchOptions, void** __inlinees_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInlineesByName(Utf16StringMarshaller.ConvertToManaged(__name_native)!, searchOptions, out IEnumSymbols inlinees);

		*__inlinees_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(inlinees);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindAcceleratorInlineeLinesByLineNumber(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, void* __file_native, uint lineNumber, uint column, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindAcceleratorInlineeLinesByLineNumber(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, ComInterfaceMarshaller<ISourceFile>.ConvertToManaged(__file_native)!, lineNumber, column, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindSymbolsForAcceleratorPointerTag(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, uint tagValue, void** __symbols_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindSymbolsForAcceleratorPointerTag(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, tagValue, out IEnumSymbols symbols);

		*__symbols_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindSymbolsByRVAForAcceleratorPointerTag(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, uint tagValue, uint relativeVirtualAddress, void** __symbols_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindSymbolsByRVAForAcceleratorPointerTag(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!, tagValue, relativeVirtualAddress, out IEnumSymbols symbols);

		*__symbols_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindAcceleratorInlineesByName(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __name_native, NameSearchOptions searchOptions, void** __symbols_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindAcceleratorInlineesByName(Utf16StringMarshaller.ConvertToManaged(__name_native)!, searchOptions, out IEnumSymbols symbols);

		*__symbols_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAddressForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, uint* __sectionIndex_native__param, uint* __address_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetAddressForVA(virtualAddress, out *__sectionIndex_native__param, out *__address_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAddressForRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, uint* __sectionIndex_native__param, uint* __address_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetAddressForRVA(relativeVirtualAddress, out *__sectionIndex_native__param, out *__address_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindILOffsetsByAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint sectionIndex, uint offset, uint length, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindILOffsetsByAddress(sectionIndex, offset, length, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindILOffsetsByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, uint length, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindILOffsetsByRVA(relativeVirtualAddress, length, out IEnumLineNumbers lines);

		*__lines_native__param  = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindILOffsetsByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, uint length, void** __lines_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindILOffsetsByVA(virtualAddress, length, out IEnumLineNumbers lines);

		*__lines_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInputAssemblyFiles(ComWrappers.ComInterfaceDispatch* __this_native, void** __files_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInputAssemblyFiles(out IEnumInputAssemblyFiles files);

		*__files_native__param = ComInterfaceMarshaller<IEnumInputAssemblyFiles>.ConvertToUnmanaged(files);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInputAssembly(ComWrappers.ComInterfaceDispatch* __this_native, uint index, void** __assembly_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInputAssembly(index, out IInputAssemblyFile assembly);

		*__assembly_native__param = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToUnmanaged(assembly);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInputAssemblyByID(ComWrappers.ComInterfaceDispatch* __this_native, uint uniqueId, void** __assembly_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInputAssemblyByID(uniqueId, out IInputAssemblyFile assembly);

		*__assembly_native__param = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToUnmanaged(assembly);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFunctionMetadataTokenMapSize(ComWrappers.ComInterfaceDispatch* __this_native, uint* __size_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetFunctionMetadataTokenMapSize(out *__size_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFunctionMetadataTokenMap(ComWrappers.ComInterfaceDispatch* __this_native, uint bufferSize, uint* __bytesWritten_native__param, byte* buffer)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetFunctionMetadataTokenMap(bufferSize, out *__bytesWritten_native__param, buffer);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetTypeMetadataTokenMapSize(ComWrappers.ComInterfaceDispatch* __this_native, uint* __size_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetTypeMetadataTokenMapSize(out *__size_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetTypeMetadataTokenMap(ComWrappers.ComInterfaceDispatch* __this_native, uint bufferSize, uint* __bytesWritten_native__param, byte* buffer)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetTypeMetadataTokenMap(bufferSize, out *__bytesWritten_native__param, buffer);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNumberOfFunctionFragmentsForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong functionVA, uint functionSize, uint* __fragmentCount_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetNumberOfFunctionFragmentsForVA(functionVA, functionSize, out *__fragmentCount_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNumberOfFunctionFragmentsForRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint functionRVA, uint functionSize, uint* __fragmentCount_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetNumberOfFunctionFragmentsForRVA(functionRVA, functionSize, out *__fragmentCount_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFunctionFragmentsForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong functionVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetFunctionFragmentsForVA(functionVA, functionSize, fragmentCount, buffer, fragmentLengths);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFunctionFragmentsForRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint functionRVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetFunctionFragmentsForRVA(functionRVA, functionSize, fragmentCount, buffer, fragmentLengths);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetExports(ComWrappers.ComInterfaceDispatch* __this_native, void** __exports_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetExports(out IEnumSymbols exports);

		*__exports_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(exports);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHeapAllocationSites(ComWrappers.ComInterfaceDispatch* __this_native, void** __sites_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).GetHeapAllocationSites(out IEnumSymbols sites);

		*__sites_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(sites);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInputAssemblyFile(ComWrappers.ComInterfaceDispatch* __this_native, void* __symbol_native, void** __assembly_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native).FindInputAssemblyFile(ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!, out IInputAssemblyFile assembly);

		*__assembly_native__param = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToUnmanaged(assembly);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ISession), sizeof(void*) * 62);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetLoadAddress;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, int>)&ABI_PutLoadAddress;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetGlobalScope;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetEnumTables;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetSymbolsByAddress;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, SymbolTag, ushort*, NameSearchOptions, void**, int>)&ABI_FindChildren;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, SymbolTag, ushort*, NameSearchOptions, void**, int>)&ABI_FindChildrenEx;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, SymbolTag, ushort*, NameSearchOptions, uint, uint, void**, int>)&ABI_FindChildrenExByAddress;
		vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, SymbolTag, ushort*, NameSearchOptions, ulong, void**, int>)&ABI_FindChildrenExByVA;
		vtable[12] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, SymbolTag, ushort*, NameSearchOptions, uint, void**, int>)&ABI_FindChildrenExByRVA;
		vtable[13] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, SymbolTag, void**, int>)&ABI_FindSymbolByAddress;
		vtable[14] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, SymbolTag, void**, int>)&ABI_FindSymbolByRVA;
		vtable[15] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, SymbolTag, void**, int>)&ABI_FindSymbolByVA;
		vtable[16] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, SymbolTag, void**, int>)&ABI_FindSymbolByToken;
		vtable[17] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, void*, int>)&ABI_SymbolsAreEquivalent;
		vtable[18] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_SymbolByID;
		vtable[19] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, SymbolTag, int*, void**, int>)&ABI_FindSymbolByRVA;
		vtable[20] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, SymbolTag, int*, void**, int>)&ABI_FindSymbolByVA;
		vtable[21] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, ushort*, NameSearchOptions, void**, int>)&ABI_FindFile;
		vtable[22] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_FindFileByID;
		vtable[23] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, void*, void**, int>)&ABI_FindLines;
		vtable[24] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, uint, void**, int>)&ABI_FindLinesByAddress;
		vtable[25] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, void**, int>)&ABI_FindLinesByRVA;
		vtable[26] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, uint, void**, int>)&ABI_FindLinesByVA;
		vtable[27] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, void*, uint, uint, void**, int>)&ABI_FindLinesByLineNumber;
		vtable[28] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, void**, int>)&ABI_FindInjectedSource;
		vtable[29] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetEnumDebugStreams;
		vtable[30] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, uint, uint, void**, int>)&ABI_FindInlineFramesByAddress;
		vtable[31] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, uint, void**, int>)&ABI_FindInlineFramesByRVA;
		vtable[32] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, ulong, void**, int>)&ABI_FindInlineFramesByVA;
		vtable[33] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, void**, int>)&ABI_FindInlineeLines;
		vtable[34] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, uint, uint, uint, void**, int>)&ABI_FindInlineeLinesByAddress;
		vtable[35] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, uint, uint, void**, int>)&ABI_FindInlineeLinesByRVA;
		vtable[36] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, ulong, uint, void**, int>)&ABI_FindInlineeLinesByVA;
		vtable[37] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, void*, uint, uint, void**, int>)&ABI_FindInlineeLinesByLineNumber;
		vtable[38] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, NameSearchOptions, void**, int>)&ABI_FindInlineesByName;
		vtable[39] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, void*, uint, uint, void**, int>)&ABI_FindAcceleratorInlineeLinesByLineNumber;
		vtable[40] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, uint, void**, int>)&ABI_FindSymbolsForAcceleratorPointerTag;
		vtable[41] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, uint, uint, void**, int>)&ABI_FindSymbolsByRVAForAcceleratorPointerTag;
		vtable[42] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, NameSearchOptions, void**, int>)&ABI_FindAcceleratorInlineesByName;
		vtable[43] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, uint*, uint*, int>)&ABI_GetAddressForVA;
		vtable[44] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, uint*, int>)&ABI_GetAddressForRVA;
		vtable[45] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, uint, void**, int>)&ABI_FindILOffsetsByAddress;
		vtable[46] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, void**, int>)&ABI_FindILOffsetsByRVA;
		vtable[47] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, uint, void**, int>)&ABI_FindILOffsetsByVA;
		vtable[48] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_FindInputAssemblyFiles;
		vtable[49] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_FindInputAssembly;
		vtable[50] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_FindInputAssemblyByID;
		vtable[51] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetFunctionMetadataTokenMapSize;
		vtable[52] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, byte*, int>)&ABI_GetFunctionMetadataTokenMap;
		vtable[53] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetTypeMetadataTokenMapSize;
		vtable[54] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, byte*, int>)&ABI_GetTypeMetadataTokenMap;
		vtable[55] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, uint, uint*, int>)&ABI_GetNumberOfFunctionFragmentsForVA;
		vtable[56] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, uint*, int>)&ABI_GetNumberOfFunctionFragmentsForRVA;
		vtable[57] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, uint, uint, uint*, uint*, int>)&ABI_GetFunctionFragmentsForVA;
		vtable[58] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, uint, uint*, uint*, int>)&ABI_GetFunctionFragmentsForRVA;
		vtable[59] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetExports;
		vtable[60] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetHeapAllocationSites;
		vtable[61] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, void**, int>)&ABI_FindInputAssemblyFile;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface ISession
	{
	}
}