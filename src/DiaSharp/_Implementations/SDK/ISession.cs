#pragma warning disable CS0612, CS0618, IDE0008
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
		Unsafe.SkipInit(out address);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __address_native = &address)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[3])(__this, __address_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.PutLoadAddress(ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, int>)__vtable_native[4])(__this, address);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetGlobalScope(out ISymbol scope)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out scope);
		void* __scope_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[5])(__this, &__scope_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			scope = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__scope_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__scope_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetEnumTables(out IEnumTables tables)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out tables);
		void* __tables_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[6])(__this, &__tables_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			tables = ComInterfaceMarshaller<IEnumTables>.ConvertToManaged(__tables_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumTables>.Free(__tables_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetSymbolsByAddress(out IEnumSymbolsByAddress symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbols);
		void* __symbols_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[7])(__this, &__symbols_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbols = ComInterfaceMarshaller<IEnumSymbolsByAddress>.ConvertToManaged(__symbols_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbolsByAddress>.Free(__symbols_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindChildren(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbols);
		void* __parent_native = default;
		void* __symbols_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, SymbolTag, ushort*, NameSearchOptions, void**, int>)__vtable_native[8])(__this, __parent_native, symbolTag, (ushort*)__name_native, searchOptions, &__symbols_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindChildrenEx(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbols);
		void* __parent_native = default;
		void* __symbols_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, SymbolTag, ushort*, NameSearchOptions, void**, int>)__vtable_native[9])(__this, __parent_native, symbolTag, (ushort*)__name_native, searchOptions, &__symbols_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindChildrenExByAddress(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, uint sectionIndex, uint offset, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbols);
		void* __parent_native = default;
		void* __symbols_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, SymbolTag, ushort*, NameSearchOptions, uint, uint, void**, int>)__vtable_native[10])(__this, __parent_native, symbolTag, (ushort*)__name_native, searchOptions, sectionIndex, offset, &__symbols_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindChildrenExByVA(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, ulong virtualAddress, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbols);
		void* __parent_native = default;
		void* __symbols_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, SymbolTag, ushort*, NameSearchOptions, ulong, void**, int>)__vtable_native[11])(__this, __parent_native, symbolTag, (ushort*)__name_native, searchOptions, virtualAddress, &__symbols_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindChildrenExByRVA(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, uint relativeVirtualAddress, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbols);
		void* __parent_native = default;
		void* __symbols_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, SymbolTag, ushort*, NameSearchOptions, uint, void**, int>)__vtable_native[12])(__this, __parent_native, symbolTag, (ushort*)__name_native, searchOptions, relativeVirtualAddress, &__symbols_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolByAddress(uint sectionIndex, uint offset, SymbolTag symbolTag, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbol);
		void* __symbol_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, SymbolTag, void**, int>)__vtable_native[13])(__this, sectionIndex, offset, symbolTag, &__symbol_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag symbolTag, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbol);
		void* __symbol_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, SymbolTag, void**, int>)__vtable_native[14])(__this, relativeVirtualAddress, symbolTag, &__symbol_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolByVA(ulong virtualAddress, SymbolTag symbolTag, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbol);
		void* __symbol_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, SymbolTag, void**, int>)__vtable_native[15])(__this, virtualAddress, symbolTag, &__symbol_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolByToken(uint token, SymbolTag symbolTag, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbol);
		void* __symbol_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, SymbolTag, void**, int>)__vtable_native[16])(__this, token, symbolTag, &__symbol_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.SymbolsAreEquivalent(ISymbol symbolA, ISymbol symbolB)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		void* __symbolA_native = default;
		void* __symbolB_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__symbolB_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbolB);
			__symbolA_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbolA);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void*, int>)__vtable_native[17])(__this, __symbolA_native, __symbolB_native);
			}

			GC.KeepAlive(this);
		}
		finally
		{
			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__symbolB_native);
			ComInterfaceMarshaller<ISymbol>.Free(__symbolA_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.SymbolByID(uint id, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbol);
		void* __symbol_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[18])(__this, id, &__symbol_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag symbolTag, out int displacement, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out displacement);
		Unsafe.SkipInit(out symbol);
		void* __symbol_native = default;
		int __retVal = default;

		try
		{
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (int* __displacement_native = &displacement)
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, SymbolTag, int*, void**, int>)__vtable_native[19])(__this, relativeVirtualAddress, symbolTag, __displacement_native, &__symbol_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolByVA(ulong VirtualAddress, SymbolTag symbolTag, out int displacement, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out displacement);
		Unsafe.SkipInit(out symbol);
		void* __symbol_native = default;
		int __retVal = default;

		try
		{
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (int* __displacement_native = &displacement)
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, SymbolTag, int*, void**, int>)__vtable_native[20])(__this, VirtualAddress, symbolTag, __displacement_native, &__symbol_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindFile(ISymbol compiland, string name, NameSearchOptions searchOptions, out IEnumSourceFiles files)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out files);
		void* __compiland_native = default;
		void* __files_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__compiland_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(compiland);
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, ushort*, NameSearchOptions, void**, int>)__vtable_native[21])(__this, __compiland_native, (ushort*)__name_native, searchOptions, &__files_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			files = ComInterfaceMarshaller<IEnumSourceFiles>.ConvertToManaged(__files_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSourceFiles>.Free(__files_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__compiland_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindFileByID(uint uniqueId, out ISourceFile file)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out file);
		void* __file_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[22])(__this, uniqueId, &__file_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			file = ComInterfaceMarshaller<ISourceFile>.ConvertToManaged(__file_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISourceFile>.Free(__file_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindLines(ISymbol compiland, ISourceFile file, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __compiland_native = default;
		void* __file_native = default;
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__file_native = ComInterfaceMarshaller<ISourceFile>.ConvertToUnmanaged(file);
			__compiland_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(compiland);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void*, void**, int>)__vtable_native[23])(__this, __compiland_native, __file_native, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISourceFile>.Free(__file_native);
			ComInterfaceMarshaller<ISymbol>.Free(__compiland_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindLinesByAddress(uint segment, uint offset, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint, void**, int>)__vtable_native[24])(__this, segment, offset, length, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindLinesByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, void**, int>)__vtable_native[25])(__this, relativeVirtualAddress, length, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindLinesByVA(ulong virtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, void**, int>)__vtable_native[26])(__this, virtualAddress, length, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __compiland_native = default;
		void* __file_native = default;
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__file_native = ComInterfaceMarshaller<ISourceFile>.ConvertToUnmanaged(file);
			__compiland_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(compiland);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void*, uint, uint, void**, int>)__vtable_native[27])(__this, __compiland_native, __file_native, lineNumber, column, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISourceFile>.Free(__file_native);
			ComInterfaceMarshaller<ISymbol>.Free(__compiland_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInjectedSource(string sourceFile, out IEnumInjectedSources sources)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out sources);
		void* __sources_native = default;
		int __retVal = default;

		try
		{
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __sourceFile_native = &Utf16StringMarshaller.GetPinnableReference(sourceFile))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, void**, int>)__vtable_native[28])(__this, (ushort*)__sourceFile_native, &__sources_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			sources = ComInterfaceMarshaller<IEnumInjectedSources>.ConvertToManaged(__sources_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumInjectedSources>.Free(__sources_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetEnumDebugStreams(out IEnumDebugStreams streams)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out streams);
		void* __streams_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[29])(__this, &__streams_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			streams = ComInterfaceMarshaller<IEnumDebugStreams>.ConvertToManaged(__streams_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumDebugStreams>.Free(__streams_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineFramesByAddress(ISymbol parent, uint sectionIndex, uint offset, out IEnumSymbols inlinees)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out inlinees);
		void* __parent_native = default;
		void* __inlinees_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, uint, void**, int>)__vtable_native[30])(__this, __parent_native, sectionIndex, offset, &__inlinees_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			inlinees = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__inlinees_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__inlinees_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineFramesByRVA(ISymbol parent, uint relativeVirtualAddress, out IEnumSymbols inlinees)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out inlinees);
		void* __parent_native = default;
		void* __inlinees_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, void**, int>)__vtable_native[31])(__this, __parent_native, relativeVirtualAddress, &__inlinees_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			inlinees = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__inlinees_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__inlinees_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineFramesByVA(ISymbol parent, ulong virtualAddress, out IEnumSymbols inlinees)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out inlinees);
		void* __parent_native = default;
		void* __inlinees_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, ulong, void**, int>)__vtable_native[32])(__this, __parent_native, virtualAddress, &__inlinees_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			inlinees = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__inlinees_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__inlinees_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineeLines(ISymbol parent, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __parent_native = default;
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void**, int>)__vtable_native[33])(__this, __parent_native, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineeLinesByAddress(ISymbol parent, uint sectionIndex, uint offset, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __parent_native = default;
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, uint, uint, void**, int>)__vtable_native[34])(__this, __parent_native, sectionIndex, offset, length, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineeLinesByRVA(ISymbol parent, uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __parent_native = default;
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, uint, void**, int>)__vtable_native[35])(__this, __parent_native, relativeVirtualAddress, length, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineeLinesByVA(ISymbol parent, ulong virtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __parent_native = default;
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, ulong, uint, void**, int>)__vtable_native[36])(__this, __parent_native, virtualAddress, length, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineeLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __compiland_native = default;
		void* __file_native = default;
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__file_native = ComInterfaceMarshaller<ISourceFile>.ConvertToUnmanaged(file);
			__compiland_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(compiland);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void*, uint, uint, void**, int>)__vtable_native[37])(__this, __compiland_native, __file_native, lineNumber, column, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISourceFile>.Free(__file_native);
			ComInterfaceMarshaller<ISymbol>.Free(__compiland_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInlineesByName(string name, NameSearchOptions searchOptions, out IEnumSymbols inlinees)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out inlinees);
		void* __inlinees_native = default;
		int __retVal = default;

		try
		{
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, NameSearchOptions, void**, int>)__vtable_native[38])(__this, (ushort*)__name_native, searchOptions, &__inlinees_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			inlinees = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__inlinees_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__inlinees_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindAcceleratorInlineeLinesByLineNumber(ISymbol parent, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __parent_native = default;
		void* __file_native = default;
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__file_native = ComInterfaceMarshaller<ISourceFile>.ConvertToUnmanaged(file);
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void*, uint, uint, void**, int>)__vtable_native[39])(__this, __parent_native, __file_native, lineNumber, column, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISourceFile>.Free(__file_native);
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolsForAcceleratorPointerTag(ISymbol parent, uint tagValue, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbols);
		void* __parent_native = default;
		void* __symbols_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, void**, int>)__vtable_native[40])(__this, __parent_native, tagValue, &__symbols_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindSymbolsByRVAForAcceleratorPointerTag(ISymbol parent, uint tagValue, uint relativeVirtualAddress, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbols);
		void* __parent_native = default;
		void* __symbols_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, uint, void**, int>)__vtable_native[41])(__this, __parent_native, tagValue, relativeVirtualAddress, &__symbols_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindAcceleratorInlineesByName(string name, NameSearchOptions searchOptions, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbols);
		void* __symbols_native = default;
		int __retVal = default;

		try
		{
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, NameSearchOptions, void**, int>)__vtable_native[42])(__this, (ushort*)__name_native, searchOptions, &__symbols_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbols = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__symbols_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__symbols_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetAddressForVA(ulong virtualAddress, out uint sectionIndex, out uint address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		Unsafe.SkipInit(out sectionIndex);
		Unsafe.SkipInit(out address);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __address_native = &address)
		fixed (uint* __sectionIndex_native = &sectionIndex)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint*, uint*, int>)__vtable_native[43])(__this, virtualAddress, __sectionIndex_native, __address_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetAddressForRVA(uint relativeVirtualAddress, out uint sectionIndex, out uint address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		Unsafe.SkipInit(out sectionIndex);
		Unsafe.SkipInit(out address);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __address_native = &address)
		fixed (uint* __sectionIndex_native = &sectionIndex)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, uint*, int>)__vtable_native[44])(__this, relativeVirtualAddress, __sectionIndex_native, __address_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindILOffsetsByAddress(uint sectionIndex, uint offset, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint, void**, int>)__vtable_native[45])(__this, sectionIndex, offset, length, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindILOffsetsByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, void**, int>)__vtable_native[46])(__this, relativeVirtualAddress, length, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindILOffsetsByVA(ulong virtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out lines);
		void* __lines_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, void**, int>)__vtable_native[47])(__this, virtualAddress, length, &__lines_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			lines = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__lines_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__lines_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInputAssemblyFiles(out IEnumInputAssemblyFiles files)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out files);
		void* __files_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[48])(__this, &__files_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			files = ComInterfaceMarshaller<IEnumInputAssemblyFiles>.ConvertToManaged(__files_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumInputAssemblyFiles>.Free(__files_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInputAssembly(uint index, out IInputAssemblyFile assembly)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out assembly);
		void* __assembly_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[49])(__this, index, &__assembly_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			assembly = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToManaged(__assembly_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IInputAssemblyFile>.Free(__assembly_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInputAssemblyByID(uint uniqueId, out IInputAssemblyFile assembly)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out assembly);
		void* __assembly_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[50])(__this, uniqueId, &__assembly_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			assembly = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToManaged(__assembly_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IInputAssemblyFile>.Free(__assembly_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetFunctionMetadataTokenMapSize(out uint size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		Unsafe.SkipInit(out size);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __size_native = &size)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[51])(__this, __size_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetFunctionMetadataTokenMap(uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		Unsafe.SkipInit(out bytesWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[52])(__this, bufferSize, __bytesWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetTypeMetadataTokenMapSize(out uint size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		Unsafe.SkipInit(out size);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __size_native = &size)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[53])(__this, __size_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetTypeMetadataTokenMap(uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		Unsafe.SkipInit(out bytesWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[54])(__this, bufferSize, __bytesWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetNumberOfFunctionFragmentsForVA(ulong functionVA, uint functionSize, out uint fragmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		Unsafe.SkipInit(out fragmentCount);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __fragmentCount_native = &fragmentCount)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint*, int>)__vtable_native[55])(__this, functionVA, functionSize, __fragmentCount_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetNumberOfFunctionFragmentsForRVA(uint functionRVA, uint functionSize, out uint fragmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		Unsafe.SkipInit(out fragmentCount);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __fragmentCount_native = &fragmentCount)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint*, int>)__vtable_native[56])(__this, functionRVA, functionSize, __fragmentCount_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetFunctionFragmentsForVA(ulong functionVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		int __retVal;

		__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint, uint*, uint*, int>)__vtable_native[57])(__this, functionVA, functionSize, fragmentCount, buffer, fragmentLengths);

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetFunctionFragmentsForRVA(uint functionRVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		int __retVal;

		__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint, uint*, uint*, int>)__vtable_native[58])(__this, functionRVA, functionSize, fragmentCount, buffer, fragmentLengths);

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetExports(out IEnumSymbols exports)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out exports);
		void* __exports_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[59])(__this, &__exports_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			exports = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__exports_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__exports_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.GetHeapAllocationSites(out IEnumSymbols sites)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out sites);
		void* __sites_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[60])(__this, &__sites_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			sites = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__sites_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__sites_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISession.FindInputAssemblyFile(ISymbol symbol, out IInputAssemblyFile assembly)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISession));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out assembly);
		void* __symbol_native = default;
		void* __assembly_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__symbol_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void**, int>)__vtable_native[61])(__this, __symbol_native, &__assembly_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			assembly = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToManaged(__assembly_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IInputAssemblyFile>.Free(__assembly_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
		}

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetLoadAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __address_native__param)
	{
		ISession @this = default!;
		ref ulong __address_native = ref *__address_native__param;
		ulong address = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetLoadAddress(out address);
			// Marshal - Convert managed data to native data.
			__address_native = address;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_PutLoadAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong address)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			ISession @this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.PutLoadAddress(address);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetGlobalScope(ComWrappers.ComInterfaceDispatch* __this_native, void** __scope_native__param)
	{
		ISession @this = default!;
		ref void* __scope_native = ref *__scope_native__param;
		ISymbol scope = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetGlobalScope(out scope);
			// Marshal - Convert managed data to native data.
			__scope_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(scope);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetEnumTables(ComWrappers.ComInterfaceDispatch* __this_native, void** __tables_native__param)
	{
		ISession @this = default!;
		ref void* __tables_native = ref *__tables_native__param;
		IEnumTables tables = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetEnumTables(out tables);
			// Marshal - Convert managed data to native data.
			__tables_native = ComInterfaceMarshaller<IEnumTables>.ConvertToUnmanaged(tables);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetSymbolsByAddress(ComWrappers.ComInterfaceDispatch* __this_native, void** __symbols_native__param)
	{
		ISession @this = default!;
		ref void* __symbols_native = ref *__symbols_native__param;
		IEnumSymbolsByAddress symbols = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetSymbolsByAddress(out symbols);
			// Marshal - Convert managed data to native data.
			__symbols_native = ComInterfaceMarshaller<IEnumSymbolsByAddress>.ConvertToUnmanaged(symbols);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindChildren(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions searchOptions, void** __symbols_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		string name = default!;
		ref void* __symbols_native = ref *__symbols_native__param;
		IEnumSymbols symbols = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			name = Utf16StringMarshaller.ConvertToManaged(__name_native)!;
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindChildren(parent, symbolTag, name, searchOptions, out symbols);
			// Marshal - Convert managed data to native data.
			__symbols_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindChildrenEx(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions searchOptions, void** __symbols_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		string name = default!;
		ref void* __symbols_native = ref *__symbols_native__param;
		IEnumSymbols symbols = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			name = Utf16StringMarshaller.ConvertToManaged(__name_native)!;
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindChildrenEx(parent, symbolTag, name, searchOptions, out symbols);
			// Marshal - Convert managed data to native data.
			__symbols_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindChildrenExByAddress(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions searchOptions, uint sectionIndex, uint offset, void** __symbols_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		string name = default!;
		ref void* __symbols_native = ref *__symbols_native__param;
		IEnumSymbols symbols = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			name = Utf16StringMarshaller.ConvertToManaged(__name_native)!;
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindChildrenExByAddress(parent, symbolTag, name, searchOptions, sectionIndex, offset, out symbols);
			// Marshal - Convert managed data to native data.
			__symbols_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindChildrenExByVA(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions searchOptions, ulong virtualAddress, void** __symbols_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		string name = default!;
		ref void* __symbols_native = ref *__symbols_native__param;
		IEnumSymbols symbols = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			name = Utf16StringMarshaller.ConvertToManaged(__name_native)!;
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindChildrenExByVA(parent, symbolTag, name, searchOptions, virtualAddress, out symbols);
			// Marshal - Convert managed data to native data.
			__symbols_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindChildrenExByRVA(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions searchOptions, uint relativeVirtualAddress, void** __symbols_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		string name = default!;
		ref void* __symbols_native = ref *__symbols_native__param;
		IEnumSymbols symbols = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			name = Utf16StringMarshaller.ConvertToManaged(__name_native)!;
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindChildrenExByRVA(parent, symbolTag, name, searchOptions, relativeVirtualAddress, out symbols);
			// Marshal - Convert managed data to native data.
			__symbols_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindSymbolByAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint sectionIndex, uint offset, SymbolTag symbolTag, void** __symbol_native__param)
	{
		ISession @this = default!;
		ref void* __symbol_native = ref *__symbol_native__param;
		ISymbol symbol = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindSymbolByAddress(sectionIndex, offset, symbolTag, out symbol);
			// Marshal - Convert managed data to native data.
			__symbol_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindSymbolByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, SymbolTag symbolTag, void** __symbol_native__param)
	{
		ISession @this = default!;
		ref void* __symbol_native = ref *__symbol_native__param;
		ISymbol symbol = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindSymbolByRVA(relativeVirtualAddress, symbolTag, out symbol);
			// Marshal - Convert managed data to native data.
			__symbol_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindSymbolByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, SymbolTag symbolTag, void** __symbol_native__param)
	{
		ISession @this = default!;
		ref void* __symbol_native = ref *__symbol_native__param;
		ISymbol symbol = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindSymbolByVA(virtualAddress, symbolTag, out symbol);
			// Marshal - Convert managed data to native data.
			__symbol_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindSymbolByToken(ComWrappers.ComInterfaceDispatch* __this_native, uint token, SymbolTag symbolTag, void** __symbol_native__param)
	{
		ISession @this = default!;
		ref void* __symbol_native = ref *__symbol_native__param;
		ISymbol symbol = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindSymbolByToken(token, symbolTag, out symbol);
			// Marshal - Convert managed data to native data.
			__symbol_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_SymbolsAreEquivalent(ComWrappers.ComInterfaceDispatch* __this_native, void* __symbolA_native, void* __symbolB_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			ISymbol symbolB = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbolB_native)!;
			ISymbol symbolA = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbolA_native)!;
			ISession @this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.SymbolsAreEquivalent(symbolA, symbolB);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_SymbolByID(ComWrappers.ComInterfaceDispatch* __this_native, uint id, void** __symbol_native__param)
	{
		ISession @this = default!;
		ref void* __symbol_native = ref *__symbol_native__param;
		ISymbol symbol = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.SymbolByID(id, out symbol);
			// Marshal - Convert managed data to native data.
			__symbol_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindSymbolByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, SymbolTag symbolTag, int* __displacement_native__param, void** __symbol_native__param)
	{
		ISession @this = default!;
		ref int __displacement_native = ref *__displacement_native__param;
		int displacement = default!;
		ref void* __symbol_native = ref *__symbol_native__param;
		ISymbol symbol = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindSymbolByRVA(relativeVirtualAddress, symbolTag, out displacement, out symbol);
			// Marshal - Convert managed data to native data.
			__symbol_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);
			__displacement_native = displacement;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindSymbolByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong VirtualAddress, SymbolTag symbolTag, int* __displacement_native__param, void** __symbol_native__param)
	{
		ISession @this = default!;
		ref int __displacement_native = ref *__displacement_native__param;
		int displacement = default!;
		ref void* __symbol_native = ref *__symbol_native__param;
		ISymbol symbol = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindSymbolByVA(VirtualAddress, symbolTag, out displacement, out symbol);
			// Marshal - Convert managed data to native data.
			__symbol_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);
			__displacement_native = displacement;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindFile(ComWrappers.ComInterfaceDispatch* __this_native, void* __compiland_native, ushort* __name_native, NameSearchOptions searchOptions, void** __files_native__param)
	{
		ISession @this = default!;
		ISymbol compiland = default!;
		string name = default!;
		ref void* __files_native = ref *__files_native__param;
		IEnumSourceFiles files = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			name = Utf16StringMarshaller.ConvertToManaged(__name_native)!;
			compiland = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__compiland_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindFile(compiland, name, searchOptions, out files);
			// Marshal - Convert managed data to native data.
			__files_native = ComInterfaceMarshaller<IEnumSourceFiles>.ConvertToUnmanaged(files);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindFileByID(ComWrappers.ComInterfaceDispatch* __this_native, uint uniqueId, void** __file_native__param)
	{
		ISession @this = default!;
		ref void* __file_native = ref *__file_native__param;
		ISourceFile file = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindFileByID(uniqueId, out file);
			// Marshal - Convert managed data to native data.
			__file_native = ComInterfaceMarshaller<ISourceFile>.ConvertToUnmanaged(file);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindLines(ComWrappers.ComInterfaceDispatch* __this_native, void* __compiland_native, void* __file_native, void** __lines_native__param)
	{
		ISession @this = default!;
		ISymbol compiland = default!;
		ISourceFile file = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			file = ComInterfaceMarshaller<ISourceFile>.ConvertToManaged(__file_native)!;
			compiland = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__compiland_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindLines(compiland, file, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindLinesByAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint segment, uint offset, uint length, void** __lines_native__param)
	{
		ISession @this = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindLinesByAddress(segment, offset, length, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindLinesByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, uint length, void** __lines_native__param)
	{
		ISession @this = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindLinesByRVA(relativeVirtualAddress, length, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindLinesByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, uint length, void** __lines_native__param)
	{
		ISession @this = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindLinesByVA(virtualAddress, length, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindLinesByLineNumber(ComWrappers.ComInterfaceDispatch* __this_native, void* __compiland_native, void* __file_native, uint lineNumber, uint column, void** __lines_native__param)
	{
		ISession @this = default!;
		ISymbol compiland = default!;
		ISourceFile file = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			file = ComInterfaceMarshaller<ISourceFile>.ConvertToManaged(__file_native)!;
			compiland = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__compiland_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindLinesByLineNumber(compiland, file, lineNumber, column, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInjectedSource(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __sourceFile_native, void** __sources_native__param)
	{
		ISession @this = default!;
		string sourceFile = default!;
		ref void* __sources_native = ref *__sources_native__param;
		IEnumInjectedSources sources = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			sourceFile = Utf16StringMarshaller.ConvertToManaged(__sourceFile_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInjectedSource(sourceFile, out sources);
			// Marshal - Convert managed data to native data.
			__sources_native = ComInterfaceMarshaller<IEnumInjectedSources>.ConvertToUnmanaged(sources);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetEnumDebugStreams(ComWrappers.ComInterfaceDispatch* __this_native, void** __streams_native__param)
	{
		ISession @this = default!;
		ref void* __streams_native = ref *__streams_native__param;
		IEnumDebugStreams streams = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetEnumDebugStreams(out streams);
			// Marshal - Convert managed data to native data.
			__streams_native = ComInterfaceMarshaller<IEnumDebugStreams>.ConvertToUnmanaged(streams);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInlineFramesByAddress(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, uint sectionIndex, uint offset, void** __inlinees_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		ref void* __inlinees_native = ref *__inlinees_native__param;
		IEnumSymbols inlinees = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInlineFramesByAddress(parent, sectionIndex, offset, out inlinees);
			// Marshal - Convert managed data to native data.
			__inlinees_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(inlinees);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInlineFramesByRVA(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, uint relativeVirtualAddress, void** __inlinees_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		ref void* __inlinees_native = ref *__inlinees_native__param;
		IEnumSymbols inlinees = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInlineFramesByRVA(parent, relativeVirtualAddress, out inlinees);
			// Marshal - Convert managed data to native data.
			__inlinees_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(inlinees);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInlineFramesByVA(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, ulong virtualAddress, void** __inlinees_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		ref void* __inlinees_native = ref *__inlinees_native__param;
		IEnumSymbols inlinees = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInlineFramesByVA(parent, virtualAddress, out inlinees);
			// Marshal - Convert managed data to native data.
			__inlinees_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(inlinees);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInlineeLines(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, void** __lines_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInlineeLines(parent, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInlineeLinesByAddress(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, uint sectionIndex, uint offset, uint length, void** __lines_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInlineeLinesByAddress(parent, sectionIndex, offset, length, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInlineeLinesByRVA(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, uint relativeVirtualAddress, uint length, void** __lines_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInlineeLinesByRVA(parent, relativeVirtualAddress, length, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInlineeLinesByVA(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, ulong virtualAddress, uint length, void** __lines_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInlineeLinesByVA(parent, virtualAddress, length, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInlineeLinesByLineNumber(ComWrappers.ComInterfaceDispatch* __this_native, void* __compiland_native, void* __file_native, uint lineNumber, uint column, void** __lines_native__param)
	{
		ISession @this = default!;
		ISymbol compiland = default!;
		ISourceFile file = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			file = ComInterfaceMarshaller<ISourceFile>.ConvertToManaged(__file_native)!;
			compiland = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__compiland_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInlineeLinesByLineNumber(compiland, file, lineNumber, column, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInlineesByName(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __name_native, NameSearchOptions searchOptions, void** __inlinees_native__param)
	{
		ISession @this = default!;
		string name = default!;
		ref void* __inlinees_native = ref *__inlinees_native__param;
		IEnumSymbols inlinees = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			name = Utf16StringMarshaller.ConvertToManaged(__name_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInlineesByName(name, searchOptions, out inlinees);
			// Marshal - Convert managed data to native data.
			__inlinees_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(inlinees);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindAcceleratorInlineeLinesByLineNumber(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, void* __file_native, uint lineNumber, uint column, void** __lines_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		ISourceFile file = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			file = ComInterfaceMarshaller<ISourceFile>.ConvertToManaged(__file_native)!;
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindAcceleratorInlineeLinesByLineNumber(parent, file, lineNumber, column, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindSymbolsForAcceleratorPointerTag(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, uint tagValue, void** __symbols_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		ref void* __symbols_native = ref *__symbols_native__param;
		IEnumSymbols symbols = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindSymbolsForAcceleratorPointerTag(parent, tagValue, out symbols);
			// Marshal - Convert managed data to native data.
			__symbols_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindSymbolsByRVAForAcceleratorPointerTag(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, uint tagValue, uint relativeVirtualAddress, void** __symbols_native__param)
	{
		ISession @this = default!;
		ISymbol parent = default!;
		ref void* __symbols_native = ref *__symbols_native__param;
		IEnumSymbols symbols = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindSymbolsByRVAForAcceleratorPointerTag(parent, tagValue, relativeVirtualAddress, out symbols);
			// Marshal - Convert managed data to native data.
			__symbols_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindAcceleratorInlineesByName(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __name_native, NameSearchOptions searchOptions, void** __symbols_native__param)
	{
		ISession @this = default!;
		string name = default!;
		ref void* __symbols_native = ref *__symbols_native__param;
		IEnumSymbols symbols = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			name = Utf16StringMarshaller.ConvertToManaged(__name_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindAcceleratorInlineesByName(name, searchOptions, out symbols);
			// Marshal - Convert managed data to native data.
			__symbols_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(symbols);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetAddressForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, uint* __sectionIndex_native__param, uint* __address_native__param)
	{
		ISession @this = default!;
		ref uint __sectionIndex_native = ref *__sectionIndex_native__param;
		uint sectionIndex = default!;
		ref uint __address_native = ref *__address_native__param;
		uint address = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetAddressForVA(virtualAddress, out sectionIndex, out address);
			// Marshal - Convert managed data to native data.
			__address_native = address;
			__sectionIndex_native = sectionIndex;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetAddressForRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, uint* __sectionIndex_native__param, uint* __address_native__param)
	{
		ISession @this = default!;
		ref uint __sectionIndex_native = ref *__sectionIndex_native__param;
		uint sectionIndex = default!;
		ref uint __address_native = ref *__address_native__param;
		uint address = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetAddressForRVA(relativeVirtualAddress, out sectionIndex, out address);
			// Marshal - Convert managed data to native data.
			__address_native = address;
			__sectionIndex_native = sectionIndex;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindILOffsetsByAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint sectionIndex, uint offset, uint length, void** __lines_native__param)
	{
		ISession @this = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindILOffsetsByAddress(sectionIndex, offset, length, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindILOffsetsByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, uint length, void** __lines_native__param)
	{
		ISession @this = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindILOffsetsByRVA(relativeVirtualAddress, length, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindILOffsetsByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, uint length, void** __lines_native__param)
	{
		ISession @this = default!;
		ref void* __lines_native = ref *__lines_native__param;
		IEnumLineNumbers lines = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindILOffsetsByVA(virtualAddress, length, out lines);
			// Marshal - Convert managed data to native data.
			__lines_native = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(lines);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInputAssemblyFiles(ComWrappers.ComInterfaceDispatch* __this_native, void** __files_native__param)
	{
		ISession @this = default!;
		ref void* __files_native = ref *__files_native__param;
		IEnumInputAssemblyFiles files = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInputAssemblyFiles(out files);
			// Marshal - Convert managed data to native data.
			__files_native = ComInterfaceMarshaller<IEnumInputAssemblyFiles>.ConvertToUnmanaged(files);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInputAssembly(ComWrappers.ComInterfaceDispatch* __this_native, uint index, void** __assembly_native__param)
	{
		ISession @this = default!;
		ref void* __assembly_native = ref *__assembly_native__param;
		IInputAssemblyFile assembly = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInputAssembly(index, out assembly);
			// Marshal - Convert managed data to native data.
			__assembly_native = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToUnmanaged(assembly);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInputAssemblyByID(ComWrappers.ComInterfaceDispatch* __this_native, uint uniqueId, void** __assembly_native__param)
	{
		ISession @this = default!;
		ref void* __assembly_native = ref *__assembly_native__param;
		IInputAssemblyFile assembly = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInputAssemblyByID(uniqueId, out assembly);
			// Marshal - Convert managed data to native data.
			__assembly_native = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToUnmanaged(assembly);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetFunctionMetadataTokenMapSize(ComWrappers.ComInterfaceDispatch* __this_native, uint* __size_native__param)
	{
		ISession @this = default!;
		ref uint __size_native = ref *__size_native__param;
		uint size = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetFunctionMetadataTokenMapSize(out size);
			// Marshal - Convert managed data to native data.
			__size_native = size;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetFunctionMetadataTokenMap(ComWrappers.ComInterfaceDispatch* __this_native, uint bufferSize, uint* __bytesWritten_native__param, byte* buffer)
	{
		ISession @this = default!;
		ref uint __bytesWritten_native = ref *__bytesWritten_native__param;
		uint bytesWritten = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetFunctionMetadataTokenMap(bufferSize, out bytesWritten, buffer);
			// Marshal - Convert managed data to native data.
			__bytesWritten_native = bytesWritten;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetTypeMetadataTokenMapSize(ComWrappers.ComInterfaceDispatch* __this_native, uint* __size_native__param)
	{
		ISession @this = default!;
		ref uint __size_native = ref *__size_native__param;
		uint size = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetTypeMetadataTokenMapSize(out size);
			// Marshal - Convert managed data to native data.
			__size_native = size;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetTypeMetadataTokenMap(ComWrappers.ComInterfaceDispatch* __this_native, uint bufferSize, uint* __bytesWritten_native__param, byte* buffer)
	{
		ISession @this = default!;
		ref uint __bytesWritten_native = ref *__bytesWritten_native__param;
		uint bytesWritten = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetTypeMetadataTokenMap(bufferSize, out bytesWritten, buffer);
			// Marshal - Convert managed data to native data.
			__bytesWritten_native = bytesWritten;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNumberOfFunctionFragmentsForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong functionVA, uint functionSize, uint* __fragmentCount_native__param)
	{
		ISession @this = default!;
		ref uint __fragmentCount_native = ref *__fragmentCount_native__param;
		uint fragmentCount = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetNumberOfFunctionFragmentsForVA(functionVA, functionSize, out fragmentCount);
			// Marshal - Convert managed data to native data.
			__fragmentCount_native = fragmentCount;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNumberOfFunctionFragmentsForRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint functionRVA, uint functionSize, uint* __fragmentCount_native__param)
	{
		ISession @this = default!;
		ref uint __fragmentCount_native = ref *__fragmentCount_native__param;
		uint fragmentCount = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetNumberOfFunctionFragmentsForRVA(functionRVA, functionSize, out fragmentCount);
			// Marshal - Convert managed data to native data.
			__fragmentCount_native = fragmentCount;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetFunctionFragmentsForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong functionVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			ISession @this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetFunctionFragmentsForVA(functionVA, functionSize, fragmentCount, buffer, fragmentLengths);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetFunctionFragmentsForRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint functionRVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			ISession @this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetFunctionFragmentsForRVA(functionRVA, functionSize, fragmentCount, buffer, fragmentLengths);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetExports(ComWrappers.ComInterfaceDispatch* __this_native, void** __exports_native__param)
	{
		ISession @this = default!;
		ref void* __exports_native = ref *__exports_native__param;
		IEnumSymbols exports = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetExports(out exports);
			// Marshal - Convert managed data to native data.
			__exports_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(exports);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetHeapAllocationSites(ComWrappers.ComInterfaceDispatch* __this_native, void** __sites_native__param)
	{
		ISession @this = default!;
		ref void* __sites_native = ref *__sites_native__param;
		IEnumSymbols sites = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.GetHeapAllocationSites(out sites);
			// Marshal - Convert managed data to native data.
			__sites_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(sites);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FindInputAssemblyFile(ComWrappers.ComInterfaceDispatch* __this_native, void* __symbol_native, void** __assembly_native__param)
	{
		ISession @this = default!;
		ISymbol symbol = default!;
		ref void* __assembly_native = ref *__assembly_native__param;
		IInputAssemblyFile assembly = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISession>(__this_native);
			__retVal = @this.FindInputAssemblyFile(symbol, out assembly);
			// Marshal - Convert managed data to native data.
			__assembly_native = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToUnmanaged(assembly);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ISession), sizeof(void*) * 62);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
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
		}

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