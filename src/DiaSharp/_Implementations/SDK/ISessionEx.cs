#pragma warning disable CS0612, CS0618, IDE0008
using DiaSharp.CodeView;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([213, 238, 36, 205, 234, 95, 66, 71, 163, 32, 98, 84, 201, 32, 231, 139]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ISessionEx
{
	[SkipLocalsInit]
	int ISessionEx.IsFastLinkPDB(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[62])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISessionEx.IsPortablePDB(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[63])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISessionEx.GetSourceLinkInfo(ISymbol parent, out IEnumSourceLink link)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out link);
		void* __parent_native = default;
		void* __link_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__parent_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(parent);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void**, int>)__vtable_native[64])(__this, __parent_native, &__link_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			link = ComInterfaceMarshaller<IEnumSourceLink>.ConvertToManaged(__link_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSourceLink>.Free(__link_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<ISymbol>.Free(__parent_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISessionEx.GetLoadAddress(out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.PutLoadAddress(ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, int>)__vtable_native[4])(__this, address);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISessionEx.GetGlobalScope(out ISymbol scope)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetEnumTables(out IEnumTables tables)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetSymbolsByAddress(out IEnumSymbolsByAddress symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindChildren(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindChildrenEx(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindChildrenExByAddress(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, uint sectionIndex, uint offset, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindChildrenExByVA(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, ulong virtualAddress, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindChildrenExByRVA(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, uint relativeVirtualAddress, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindSymbolByAddress(uint sectionIndex, uint offset, SymbolTag symbolTag, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag symbolTag, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindSymbolByVA(ulong virtualAddress, SymbolTag symbolTag, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindSymbolByToken(uint token, SymbolTag symbolTag, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.SymbolsAreEquivalent(ISymbol symbolA, ISymbol symbolB)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.SymbolByID(uint id, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag symbolTag, out int displacement, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindSymbolByVA(ulong VirtualAddress, SymbolTag symbolTag, out int displacement, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindFile(ISymbol compiland, string name, NameSearchOptions searchOptions, out IEnumSourceFiles files)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindFileByID(uint uniqueId, out ISourceFile file)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindLines(ISymbol compiland, ISourceFile file, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindLinesByAddress(uint segment, uint offset, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindLinesByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindLinesByVA(ulong virtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInjectedSource(string sourceFile, out IEnumInjectedSources sources)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetEnumDebugStreams(out IEnumDebugStreams streams)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInlineFramesByAddress(ISymbol parent, uint sectionIndex, uint offset, out IEnumSymbols inlinees)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInlineFramesByRVA(ISymbol parent, uint relativeVirtualAddress, out IEnumSymbols inlinees)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInlineFramesByVA(ISymbol parent, ulong virtualAddress, out IEnumSymbols inlinees)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInlineeLines(ISymbol parent, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInlineeLinesByAddress(ISymbol parent, uint sectionIndex, uint offset, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInlineeLinesByRVA(ISymbol parent, uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInlineeLinesByVA(ISymbol parent, ulong virtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInlineeLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInlineesByName(string name, NameSearchOptions searchOptions, out IEnumSymbols inlinees)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindAcceleratorInlineeLinesByLineNumber(ISymbol parent, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindSymbolsForAcceleratorPointerTag(ISymbol parent, uint tagValue, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindSymbolsByRVAForAcceleratorPointerTag(ISymbol parent, uint tagValue, uint relativeVirtualAddress, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindAcceleratorInlineesByName(string name, NameSearchOptions searchOptions, out IEnumSymbols symbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetAddressForVA(ulong virtualAddress, out uint sectionIndex, out uint address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetAddressForRVA(uint relativeVirtualAddress, out uint sectionIndex, out uint address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindILOffsetsByAddress(uint sectionIndex, uint offset, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindILOffsetsByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindILOffsetsByVA(ulong virtualAddress, uint length, out IEnumLineNumbers lines)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInputAssemblyFiles(out IEnumInputAssemblyFiles files)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInputAssembly(uint index, out IInputAssemblyFile assembly)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInputAssemblyByID(uint uniqueId, out IInputAssemblyFile assembly)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetFunctionMetadataTokenMapSize(out uint size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetFunctionMetadataTokenMap(uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetTypeMetadataTokenMapSize(out uint size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetTypeMetadataTokenMap(uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetNumberOfFunctionFragmentsForVA(ulong functionVA, uint functionSize, out uint fragmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetNumberOfFunctionFragmentsForRVA(uint functionRVA, uint functionSize, out uint fragmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetFunctionFragmentsForVA(ulong functionVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
		int __retVal;

		__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint, uint*, uint*, int>)__vtable_native[57])(__this, functionVA, functionSize, fragmentCount, buffer, fragmentLengths);

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISessionEx.GetFunctionFragmentsForRVA(uint functionRVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
		int __retVal;

		__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint, uint*, uint*, int>)__vtable_native[58])(__this, functionRVA, functionSize, fragmentCount, buffer, fragmentLengths);

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISessionEx.GetExports(out IEnumSymbols exports)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.GetHeapAllocationSites(out IEnumSymbols sites)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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
	int ISessionEx.FindInputAssemblyFile(ISymbol symbol, out IInputAssemblyFile assembly)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISessionEx));
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

	int ISession.GetLoadAddress(out ulong address) => throw new UnreachableException();
	int ISession.PutLoadAddress(ulong address) => throw new UnreachableException();
	int ISession.GetGlobalScope(out ISymbol scope) => throw new UnreachableException();
	int ISession.GetEnumTables(out IEnumTables tables) => throw new UnreachableException();
	int ISession.GetSymbolsByAddress(out IEnumSymbolsByAddress symbols) => throw new UnreachableException();
	int ISession.FindChildren(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, out IEnumSymbols symbols) => throw new UnreachableException();
	int ISession.FindChildrenEx(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, out IEnumSymbols symbols) => throw new UnreachableException();
	int ISession.FindChildrenExByAddress(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, uint sectionIndex, uint offset, out IEnumSymbols symbols) => throw new UnreachableException();
	int ISession.FindChildrenExByVA(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, ulong virtualAddress, out IEnumSymbols symbols) => throw new UnreachableException();
	int ISession.FindChildrenExByRVA(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, uint relativeVirtualAddress, out IEnumSymbols symbols) => throw new UnreachableException();
	int ISession.FindSymbolByAddress(uint sectionIndex, uint offset, SymbolTag symbolTag, out ISymbol symbol) => throw new UnreachableException();
	int ISession.FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag symbolTag, out ISymbol symbol) => throw new UnreachableException();
	int ISession.FindSymbolByVA(ulong virtualAddress, SymbolTag symbolTag, out ISymbol symbol) => throw new UnreachableException();
	int ISession.FindSymbolByToken(uint token, SymbolTag symbolTag, out ISymbol symbol) => throw new UnreachableException();
	int ISession.SymbolsAreEquivalent(ISymbol symbolA, ISymbol symbolB) => throw new UnreachableException();
	int ISession.SymbolByID(uint id, out ISymbol symbol) => throw new UnreachableException();
	int ISession.FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag symbolTag, out int displacement, out ISymbol symbol) => throw new UnreachableException();
	int ISession.FindSymbolByVA(ulong VirtualAddress, SymbolTag symbolTag, out int displacement, out ISymbol symbol) => throw new UnreachableException();
	int ISession.FindFile(ISymbol compiland, string name, NameSearchOptions searchOptions, out IEnumSourceFiles files) => throw new UnreachableException();
	int ISession.FindFileByID(uint uniqueId, out ISourceFile file) => throw new UnreachableException();
	int ISession.FindLines(ISymbol compiland, ISourceFile file, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindLinesByAddress(uint segment, uint offset, uint length, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindLinesByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindLinesByVA(ulong virtualAddress, uint length, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindInjectedSource(string sourceFile, out IEnumInjectedSources sources) => throw new UnreachableException();
	int ISession.GetEnumDebugStreams(out IEnumDebugStreams streams) => throw new UnreachableException();
	int ISession.FindInlineFramesByAddress(ISymbol parent, uint sectionIndex, uint offset, out IEnumSymbols inlinees) => throw new UnreachableException();
	int ISession.FindInlineFramesByRVA(ISymbol parent, uint relativeVirtualAddress, out IEnumSymbols inlinees) => throw new UnreachableException();
	int ISession.FindInlineFramesByVA(ISymbol parent, ulong virtualAddress, out IEnumSymbols inlinees) => throw new UnreachableException();
	int ISession.FindInlineeLines(ISymbol parent, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindInlineeLinesByAddress(ISymbol parent, uint sectionIndex, uint offset, uint length, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindInlineeLinesByRVA(ISymbol parent, uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindInlineeLinesByVA(ISymbol parent, ulong virtualAddress, uint length, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindInlineeLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindInlineesByName(string name, NameSearchOptions searchOptions, out IEnumSymbols inlinees) => throw new UnreachableException();
	int ISession.FindAcceleratorInlineeLinesByLineNumber(ISymbol parent, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindSymbolsForAcceleratorPointerTag(ISymbol parent, uint tagValue, out IEnumSymbols symbols) => throw new UnreachableException();
	int ISession.FindSymbolsByRVAForAcceleratorPointerTag(ISymbol parent, uint tagValue, uint relativeVirtualAddress, out IEnumSymbols symbols) => throw new UnreachableException();
	int ISession.FindAcceleratorInlineesByName(string name, NameSearchOptions searchOptions, out IEnumSymbols symbols) => throw new UnreachableException();
	int ISession.GetAddressForVA(ulong virtualAddress, out uint sectionIndex, out uint address) => throw new UnreachableException();
	int ISession.GetAddressForRVA(uint relativeVirtualAddress, out uint sectionIndex, out uint address) => throw new UnreachableException();
	int ISession.FindILOffsetsByAddress(uint sectionIndex, uint offset, uint length, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindILOffsetsByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindILOffsetsByVA(ulong virtualAddress, uint length, out IEnumLineNumbers lines) => throw new UnreachableException();
	int ISession.FindInputAssemblyFiles(out IEnumInputAssemblyFiles files) => throw new UnreachableException();
	int ISession.FindInputAssembly(uint index, out IInputAssemblyFile assembly) => throw new UnreachableException();
	int ISession.FindInputAssemblyByID(uint uniqueId, out IInputAssemblyFile assembly) => throw new UnreachableException();
	int ISession.GetFunctionMetadataTokenMapSize(out uint size) => throw new UnreachableException();
	int ISession.GetFunctionMetadataTokenMap(uint bufferSize, out uint bytesWritten, byte* buffer) => throw new UnreachableException();
	int ISession.GetTypeMetadataTokenMapSize(out uint size) => throw new UnreachableException();
	int ISession.GetTypeMetadataTokenMap(uint bufferSize, out uint bytesWritten, byte* buffer) => throw new UnreachableException();
	int ISession.GetNumberOfFunctionFragmentsForVA(ulong functionVA, uint functionSize, out uint fragmentCount) => throw new UnreachableException();
	int ISession.GetNumberOfFunctionFragmentsForRVA(uint functionRVA, uint functionSize, out uint fragmentCount) => throw new UnreachableException();
	int ISession.GetFunctionFragmentsForVA(ulong functionVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths) => throw new UnreachableException();
	int ISession.GetFunctionFragmentsForRVA(uint functionRVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths) => throw new UnreachableException();
	int ISession.GetExports(out IEnumSymbols exports) => throw new UnreachableException();
	int ISession.GetHeapAllocationSites(out IEnumSymbols sites) => throw new UnreachableException();
	int ISession.FindInputAssemblyFile(ISymbol symbol, out IInputAssemblyFile assembly) => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_IsFastLinkPDB(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISessionEx @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISessionEx>(__this_native);
			__retVal = @this.IsFastLinkPDB(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_IsPortablePDB(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISessionEx @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISessionEx>(__this_native);
			__retVal = @this.IsPortablePDB(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetSourceLinkInfo(ComWrappers.ComInterfaceDispatch* __this_native, void* __parent_native, void** __link_native__param)
	{
		ISessionEx @this = default!;
		ISymbol parent = default!;
		ref void* __link_native = ref *__link_native__param;
		IEnumSourceLink link = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			parent = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__parent_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISessionEx>(__this_native);
			__retVal = @this.GetSourceLinkInfo(parent, out link);
			// Marshal - Convert managed data to native data.
			__link_native = ComInterfaceMarshaller<IEnumSourceLink>.ConvertToUnmanaged(link);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ISessionEx), sizeof(void*) * 65);
		{
			NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(ISession).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 62));
		}

		{
			vtable[62] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_IsFastLinkPDB;
			vtable[63] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_IsPortablePDB;
			vtable[64] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, void**, int>)&ABI_GetSourceLinkInfo;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public unsafe partial interface ISessionEx
	{

		[SkipLocalsInit, PreserveSig]
		new int GetLoadAddress(out ulong address) => ((ISession)this).GetLoadAddress(out address);

		[SkipLocalsInit, PreserveSig]
		new int PutLoadAddress(ulong address) => ((ISession)this).PutLoadAddress(address);

		[SkipLocalsInit, PreserveSig]
		new int GetGlobalScope(out ISymbol scope) => ((ISession)this).GetGlobalScope(out scope);

		[SkipLocalsInit, PreserveSig]
		new int GetEnumTables(out IEnumTables tables) => ((ISession)this).GetEnumTables(out tables);

		[SkipLocalsInit, PreserveSig]
		new int GetSymbolsByAddress(out IEnumSymbolsByAddress symbols) => ((ISession)this).GetSymbolsByAddress(out symbols);

		[SkipLocalsInit, PreserveSig]
		new int FindChildren(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, out IEnumSymbols symbols) => ((ISession)this).FindChildren(parent, symbolTag, name, searchOptions, out symbols);

		[SkipLocalsInit, PreserveSig]
		new int FindChildrenEx(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, out IEnumSymbols symbols) => ((ISession)this).FindChildrenEx(parent, symbolTag, name, searchOptions, out symbols);

		[SkipLocalsInit, PreserveSig]
		new int FindChildrenExByAddress(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, uint sectionIndex, uint offset, out IEnumSymbols symbols) => ((ISession)this).FindChildrenExByAddress(parent, symbolTag, name, searchOptions, sectionIndex, offset, out symbols);

		[SkipLocalsInit, PreserveSig]
		new int FindChildrenExByVA(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, ulong virtualAddress, out IEnumSymbols symbols) => ((ISession)this).FindChildrenExByVA(parent, symbolTag, name, searchOptions, virtualAddress, out symbols);

		[SkipLocalsInit, PreserveSig]
		new int FindChildrenExByRVA(ISymbol parent, SymbolTag symbolTag, string? name, NameSearchOptions searchOptions, uint relativeVirtualAddress, out IEnumSymbols symbols) => ((ISession)this).FindChildrenExByRVA(parent, symbolTag, name, searchOptions, relativeVirtualAddress, out symbols);

		[SkipLocalsInit, PreserveSig]
		new int FindSymbolByAddress(uint sectionIndex, uint offset, SymbolTag symbolTag, out ISymbol symbol) => ((ISession)this).FindSymbolByAddress(sectionIndex, offset, symbolTag, out symbol);

		[SkipLocalsInit, PreserveSig]
		new int FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag symbolTag, out ISymbol symbol) => ((ISession)this).FindSymbolByRVA(relativeVirtualAddress, symbolTag, out symbol);

		[SkipLocalsInit, PreserveSig]
		new int FindSymbolByVA(ulong virtualAddress, SymbolTag symbolTag, out ISymbol symbol) => ((ISession)this).FindSymbolByVA(virtualAddress, symbolTag, out symbol);

		[SkipLocalsInit, PreserveSig]
		new int FindSymbolByToken(uint token, SymbolTag symbolTag, out ISymbol symbol) => ((ISession)this).FindSymbolByToken(token, symbolTag, out symbol);

		[SkipLocalsInit, PreserveSig]
		new int SymbolsAreEquivalent(ISymbol symbolA, ISymbol symbolB) => ((ISession)this).SymbolsAreEquivalent(symbolA, symbolB);

		[SkipLocalsInit, PreserveSig]
		new int SymbolByID(uint id, out ISymbol symbol) => ((ISession)this).SymbolByID(id, out symbol);

		[SkipLocalsInit, PreserveSig]
		new int FindSymbolByRVA(uint relativeVirtualAddress, SymbolTag symbolTag, out int displacement, out ISymbol symbol) => ((ISession)this).FindSymbolByRVA(relativeVirtualAddress, symbolTag, out displacement, out symbol);

		[SkipLocalsInit, PreserveSig]
		new int FindSymbolByVA(ulong VirtualAddress, SymbolTag symbolTag, out int displacement, out ISymbol symbol) => ((ISession)this).FindSymbolByVA(VirtualAddress, symbolTag, out displacement, out symbol);

		[SkipLocalsInit, PreserveSig]
		new int FindFile(ISymbol compiland, string name, NameSearchOptions searchOptions, out IEnumSourceFiles files) => ((ISession)this).FindFile(compiland, name, searchOptions, out files);

		[SkipLocalsInit, PreserveSig]
		new int FindFileByID(uint uniqueId, out ISourceFile file) => ((ISession)this).FindFileByID(uniqueId, out file);

		[SkipLocalsInit, PreserveSig]
		new int FindLines(ISymbol compiland, ISourceFile file, out IEnumLineNumbers lines) => ((ISession)this).FindLines(compiland, file, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindLinesByAddress(uint segment, uint offset, uint length, out IEnumLineNumbers lines) => ((ISession)this).FindLinesByAddress(segment, offset, length, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindLinesByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines) => ((ISession)this).FindLinesByRVA(relativeVirtualAddress, length, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindLinesByVA(ulong virtualAddress, uint length, out IEnumLineNumbers lines) => ((ISession)this).FindLinesByVA(virtualAddress, length, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines) => ((ISession)this).FindLinesByLineNumber(compiland, file, lineNumber, column, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindInjectedSource(string sourceFile, out IEnumInjectedSources sources) => ((ISession)this).FindInjectedSource(sourceFile, out sources);

		[SkipLocalsInit, PreserveSig]
		new int GetEnumDebugStreams(out IEnumDebugStreams streams) => ((ISession)this).GetEnumDebugStreams(out streams);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineFramesByAddress(ISymbol parent, uint sectionIndex, uint offset, out IEnumSymbols inlinees) => ((ISession)this).FindInlineFramesByAddress(parent, sectionIndex, offset, out inlinees);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineFramesByRVA(ISymbol parent, uint relativeVirtualAddress, out IEnumSymbols inlinees) => ((ISession)this).FindInlineFramesByRVA(parent, relativeVirtualAddress, out inlinees);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineFramesByVA(ISymbol parent, ulong virtualAddress, out IEnumSymbols inlinees) => ((ISession)this).FindInlineFramesByVA(parent, virtualAddress, out inlinees);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineeLines(ISymbol parent, out IEnumLineNumbers lines) => ((ISession)this).FindInlineeLines(parent, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineeLinesByAddress(ISymbol parent, uint sectionIndex, uint offset, uint length, out IEnumLineNumbers lines) => ((ISession)this).FindInlineeLinesByAddress(parent, sectionIndex, offset, length, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineeLinesByRVA(ISymbol parent, uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines) => ((ISession)this).FindInlineeLinesByRVA(parent, relativeVirtualAddress, length, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineeLinesByVA(ISymbol parent, ulong virtualAddress, uint length, out IEnumLineNumbers lines) => ((ISession)this).FindInlineeLinesByVA(parent, virtualAddress, length, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineeLinesByLineNumber(ISymbol compiland, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines) => ((ISession)this).FindInlineeLinesByLineNumber(compiland, file, lineNumber, column, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineesByName(string name, NameSearchOptions searchOptions, out IEnumSymbols inlinees) => ((ISession)this).FindInlineesByName(name, searchOptions, out inlinees);

		[SkipLocalsInit, PreserveSig]
		new int FindAcceleratorInlineeLinesByLineNumber(ISymbol parent, ISourceFile file, uint lineNumber, uint column, out IEnumLineNumbers lines) => ((ISession)this).FindAcceleratorInlineeLinesByLineNumber(parent, file, lineNumber, column, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindSymbolsForAcceleratorPointerTag(ISymbol parent, uint tagValue, out IEnumSymbols symbols) => ((ISession)this).FindSymbolsForAcceleratorPointerTag(parent, tagValue, out symbols);

		[SkipLocalsInit, PreserveSig]
		new int FindSymbolsByRVAForAcceleratorPointerTag(ISymbol parent, uint tagValue, uint relativeVirtualAddress, out IEnumSymbols symbols) => ((ISession)this).FindSymbolsByRVAForAcceleratorPointerTag(parent, tagValue, relativeVirtualAddress, out symbols);

		[SkipLocalsInit, PreserveSig]
		new int FindAcceleratorInlineesByName(string name, NameSearchOptions searchOptions, out IEnumSymbols symbols) => ((ISession)this).FindAcceleratorInlineesByName(name, searchOptions, out symbols);

		[SkipLocalsInit, PreserveSig]
		new int GetAddressForVA(ulong virtualAddress, out uint sectionIndex, out uint address) => ((ISession)this).GetAddressForVA(virtualAddress, out sectionIndex, out address);

		[SkipLocalsInit, PreserveSig]
		new int GetAddressForRVA(uint relativeVirtualAddress, out uint sectionIndex, out uint address) => ((ISession)this).GetAddressForRVA(relativeVirtualAddress, out sectionIndex, out address);

		[SkipLocalsInit, PreserveSig]
		new int FindILOffsetsByAddress(uint sectionIndex, uint offset, uint length, out IEnumLineNumbers lines) => ((ISession)this).FindILOffsetsByAddress(sectionIndex, offset, length, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindILOffsetsByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers lines) => ((ISession)this).FindILOffsetsByRVA(relativeVirtualAddress, length, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindILOffsetsByVA(ulong virtualAddress, uint length, out IEnumLineNumbers lines) => ((ISession)this).FindILOffsetsByVA(virtualAddress, length, out lines);

		[SkipLocalsInit, PreserveSig]
		new int FindInputAssemblyFiles(out IEnumInputAssemblyFiles files) => ((ISession)this).FindInputAssemblyFiles(out files);

		[SkipLocalsInit, PreserveSig]
		new int FindInputAssembly(uint index, out IInputAssemblyFile assembly) => ((ISession)this).FindInputAssembly(index, out assembly);

		[SkipLocalsInit, PreserveSig]
		new int FindInputAssemblyByID(uint uniqueId, out IInputAssemblyFile assembly) => ((ISession)this).FindInputAssemblyByID(uniqueId, out assembly);

		[SkipLocalsInit, PreserveSig]
		new int GetFunctionMetadataTokenMapSize(out uint size) => ((ISession)this).GetFunctionMetadataTokenMapSize(out size);

		[SkipLocalsInit, PreserveSig]
		new int GetFunctionMetadataTokenMap(uint bufferSize, out uint bytesWritten, byte* buffer) => ((ISession)this).GetFunctionMetadataTokenMap(bufferSize, out bytesWritten, buffer);

		[SkipLocalsInit, PreserveSig]
		new int GetTypeMetadataTokenMapSize(out uint size) => ((ISession)this).GetTypeMetadataTokenMapSize(out size);

		[SkipLocalsInit, PreserveSig]
		new int GetTypeMetadataTokenMap(uint bufferSize, out uint bytesWritten, byte* buffer) => ((ISession)this).GetTypeMetadataTokenMap(bufferSize, out bytesWritten, buffer);

		[SkipLocalsInit, PreserveSig]
		new int GetNumberOfFunctionFragmentsForVA(ulong functionVA, uint functionSize, out uint fragmentCount) => ((ISession)this).GetNumberOfFunctionFragmentsForVA(functionVA, functionSize, out fragmentCount);

		[SkipLocalsInit, PreserveSig]
		new int GetNumberOfFunctionFragmentsForRVA(uint functionRVA, uint functionSize, out uint fragmentCount) => ((ISession)this).GetNumberOfFunctionFragmentsForRVA(functionRVA, functionSize, out fragmentCount);

		[SkipLocalsInit, PreserveSig]
		new int GetFunctionFragmentsForVA(ulong functionVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths) => ((ISession)this).GetFunctionFragmentsForVA(functionVA, functionSize, fragmentCount, buffer, fragmentLengths);

		[SkipLocalsInit, PreserveSig]
		new int GetFunctionFragmentsForRVA(uint functionRVA, uint functionSize, uint fragmentCount, uint* buffer, uint* fragmentLengths) => ((ISession)this).GetFunctionFragmentsForRVA(functionRVA, functionSize, fragmentCount, buffer, fragmentLengths);

		[SkipLocalsInit, PreserveSig]
		new int GetExports(out IEnumSymbols exports) => ((ISession)this).GetExports(out exports);

		[SkipLocalsInit, PreserveSig]
		new int GetHeapAllocationSites(out IEnumSymbols sites) => ((ISession)this).GetHeapAllocationSites(out sites);

		[SkipLocalsInit, PreserveSig]
		new int FindInputAssemblyFile(ISymbol symbol, out IInputAssemblyFile assembly) => ((ISession)this).FindInputAssemblyFile(symbol, out assembly);
	}
}