using DiaSharp.CodeView;
using DiaSharp.CodeView.Hlsl;
using DiaSharp.Native;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;
using ImageFileMachine = DiaSharp.Native.ImageFileMachine;

#pragma warning disable CS0612, CS0618, IDE0008
file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([31, 4, 46, 127, 148, 18, 189, 65, 184, 58, 231, 21, 151, 45, 44, 227]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ISymbol8
{
	[SkipLocalsInit]
	int ISymbol8.GetCoroutineKind(out CoroutineKind kind)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out kind);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (CoroutineKind* __kind_native = &kind)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, CoroutineKind*, int>)__vtable_native[248])(__this, __kind_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetAssociatedSymbolKind(out AssociationKind kind)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out kind);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (AssociationKind* __kind_native = &kind)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, AssociationKind*, int>)__vtable_native[249])(__this, __kind_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetAssociatedSymbolSection(out uint section)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out section);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __section_native = &section)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[250])(__this, __section_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetAssociatedSymbolOffset(out uint offset)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out offset);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __offset_native = &offset)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[251])(__this, __offset_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetAssociatedSymbolRVA(out uint relativeVirtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out relativeVirtualAddress);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __rva_native = &relativeVirtualAddress)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[252])(__this, __rva_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetAssociatedSymbolAddress(out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out address);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __address_native = &address)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[253])(__this, __address_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetSymbolIndexID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetSymbolTag(out SymbolTag result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (SymbolTag* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, SymbolTag*, int>)__vtable_native[4])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		ushort* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[5])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = BStrStringMarshaller.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLexicalParent(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[6])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetClassParent(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[7])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetSymbolType(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[8])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetDataKind(out DataKind result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (DataKind* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, DataKind*, int>)__vtable_native[9])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLocationType(out LocationType result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (LocationType* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, LocationType*, int>)__vtable_native[10])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetAddressSection(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[11])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetAddressOffset(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[12])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetRelativeVirtualAddress(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[13])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetVirtualAddress(out ulong result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[14])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetRegisterID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[15])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetOffset(out int result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (int* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[16])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLength(out ulong result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[17])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetSlot(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[18])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetVolatileType(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[19])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetConstType(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[20])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetUnalignedType(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[21])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetAccess(out Access result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (Access* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, Access*, int>)__vtable_native[22])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLibraryName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		ushort* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[23])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = BStrStringMarshaller.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetPlatform(out CpuType result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (CpuType* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, CpuType*, int>)__vtable_native[24])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLanguage(out CompileFlagLanguage result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (CompileFlagLanguage* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, CompileFlagLanguage*, int>)__vtable_native[25])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetEditAndContinueEnabled(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[26])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetFrontendMajor(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[27])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetFrontendMinor(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[28])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetFrontendBuild(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[29])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBackendMajor(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[30])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBackendMinor(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[31])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBackendBuild(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[32])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetSourceFileName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		ushort* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[33])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = BStrStringMarshaller.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetUnused(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		ushort* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[34])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = BStrStringMarshaller.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetThunkOrdinal(out ThunkOrdinal result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ThunkOrdinal* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ThunkOrdinal*, int>)__vtable_native[35])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetThisAdjustor(out int result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (int* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[36])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetVirtualBaseOffset(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[37])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsVirtual(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[38])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsIntro(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[39])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsPure(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[40])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetCallingConvention(out DiaSharp.CodeView.CallingConvention result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (DiaSharp.CodeView.CallingConvention* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, DiaSharp.CodeView.CallingConvention*, int>)__vtable_native[41])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetValue(out Variant result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (Variant* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, Variant*, int>)__vtable_native[42])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBaseType(out BasicType result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (BasicType* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, BasicType*, int>)__vtable_native[43])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetToken(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[44])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetTimestamp(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[45])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetGUID(out Guid result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (Guid* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, Guid*, int>)__vtable_native[46])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetSymbolsFileName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		ushort* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[47])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = BStrStringMarshaller.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsReference(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[48])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetCount(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[49])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBitPosition(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[50])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetArrayIndexType(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[51])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsPacked(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[52])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasConstructor(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[53])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasOverloadedOperator(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[54])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsNested(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[55])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasNestedTypes(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[56])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasAssignmentOperator(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[57])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasCastOperator(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[58])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsScoped(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[59])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsVirtualBaseClass(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[60])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsIndirectVirtualBaseClass(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[61])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetVirtualBasePointerOffset(out int result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (int* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[62])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetVirtualTableShape(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[63])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLexicalParentID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[64])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetClassParentID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[65])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetTypeID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[66])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetArrayIndexTypeID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[67])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetVirtualTableShapeID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[68])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsCode(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[69])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsFunction(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[70])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsManaged(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[71])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsMSIL(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[72])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetVirtualBaseDisplacementIndex(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[73])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetUndecoratedName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		ushort* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[74])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = BStrStringMarshaller.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetAge(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[75])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetSignature(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[76])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsCompilerGenerated(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[77])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsAddressTaken(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[78])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetRank(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[79])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLowerBound(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[80])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetUpperBound(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[81])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLowerBoundID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[82])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetUpperBoundID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[83])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetDataBytes(uint dataSize, out uint dataWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out dataWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __dataWritten_native = &dataWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[84])(__this, dataSize, __dataWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindChildrenUnaware(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, SymbolTag, ushort*, NameSearchOptions, void**, int>)__vtable_native[85])(__this, symbolTag, (ushort*)__name_native, compareFlags, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindChildren(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, SymbolTag, ushort*, NameSearchOptions, void**, int>)__vtable_native[86])(__this, symbolTag, (ushort*)__name_native, compareFlags, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindChildrenByAddress(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, uint sectionIndex, uint offset, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, SymbolTag, ushort*, NameSearchOptions, uint, uint, void**, int>)__vtable_native[87])(__this, symbolTag, (ushort*)__name_native, compareFlags, sectionIndex, offset, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindChildrenByVA(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, ulong virtualAddress, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, SymbolTag, ushort*, NameSearchOptions, ulong, void**, int>)__vtable_native[88])(__this, symbolTag, (ushort*)__name_native, compareFlags, virtualAddress, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindChildrenByRVA(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, uint relativeVirtualAddress, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, SymbolTag, ushort*, NameSearchOptions, uint, void**, int>)__vtable_native[89])(__this, symbolTag, (ushort*)__name_native, compareFlags, relativeVirtualAddress, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetTargetSection(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[90])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetTargetOffset(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[91])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetTargetRelativeVirtualAddress(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[92])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetTargetVirtualAddress(out ulong result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[93])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetMachineType(out ImageFileMachine result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ImageFileMachine* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ImageFileMachine*, int>)__vtable_native[94])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetOemID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[95])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetOemSymbolID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[96])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetTypes(uint typeCount, out uint typesWritten, void** buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out typesWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __typesWritten_native = &typesWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, void**, int>)__vtable_native[97])(__this, typeCount, __typesWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetTypeIDs(uint typeIDCount, out uint typeIDsWritten, uint* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out typeIDsWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __typeIDsWritten_native = &typeIDsWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, uint*, int>)__vtable_native[98])(__this, typeIDCount, __typeIDsWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetObjectPointerType(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[99])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetUdtKind(out UdtKind result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (UdtKind* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, UdtKind*, int>)__vtable_native[100])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetUndecoratedName(UndecorateOptions undecorateOptions, out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		ushort* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, UndecorateOptions, ushort**, int>)__vtable_native[101])(__this, undecorateOptions, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = BStrStringMarshaller.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsNoReturn(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[102])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasCustomCallingConvention(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[103])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetNoInline(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[104])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasOptimizedCodeDebugInfo(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[105])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsNotReached(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[106])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasInterruptReturn(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[107])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasFarReturn(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[108])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsStatic(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[109])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasDebugInfo(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[110])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsLTCG(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[111])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsDataAligned(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[112])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasSecurityChecks(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[113])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetCompilerName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		ushort* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[114])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = BStrStringMarshaller.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasAlloca(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[115])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasSetJump(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[116])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasLongJump(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[117])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasInlAsm(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[118])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasEH(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[119])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasSEH(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[120])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasEHa(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[121])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsNaked(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[122])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsAggregated(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[123])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsSplit(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[124])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetContainer(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[125])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetInliningSpecified(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[126])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetNoStackOrderingSpecified(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[127])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetVirtualBaseTableType(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[128])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasManagedCode(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[129])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsHotpatchable(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[130])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsConvertedCIL(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[131])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsMSILNetmodule(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[132])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasCTypes(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[133])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsStripped(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[134])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetFrontendQFE(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[135])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBackendQFE(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[136])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetWasInlined(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[137])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasStrictGSCheck(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[138])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsCxxReturnUdt(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[139])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsConstructorVirtualBase(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[140])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsRValueReference(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[141])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetUnmodifiedType(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[142])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetFramePointerPresent(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[143])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasSafeBuffers(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[144])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsIntrinsic(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[145])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsSealed(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[146])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasHfaFloat(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[147])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasHfaDouble(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[148])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLiveRangeStartAddressSection(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[149])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLiveRangeStartAddressOffset(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[150])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLiveRangeStartRelativeVirtualAddress(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[151])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLiveRangeCount(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[152])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLiveRangeLength(out ulong result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[153])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetOffsetInUdt(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[154])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetParamBasePointerRegisterID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[155])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetLocalBasePointerRegisterID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[156])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsLocationControlFlowDependent(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[157])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetStride(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[158])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetNumberOfRows(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[159])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetNumberOfColumns(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[160])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsMatrixRowMajor(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[161])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetNumericProperties(uint propertyCount, out uint countWritten, uint* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out countWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __countWritten_native = &countWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, uint*, int>)__vtable_native[162])(__this, propertyCount, __countWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetModifierValues(uint propertyCount, out uint countWritten, ushort* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out countWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __countWritten_native = &countWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, ushort*, int>)__vtable_native[163])(__this, propertyCount, __countWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsReturnValue(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[164])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsOptimizedAway(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[165])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBuiltInKind(out BuiltIn result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (BuiltIn* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, BuiltIn*, int>)__vtable_native[166])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetRegisterType(out Register result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (Register* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, Register*, int>)__vtable_native[167])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBaseDataSlot(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[168])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBaseDataOffset(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[169])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetTextureSlot(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[170])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetSamplerSlot(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[171])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetUavSlot(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[172])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetSizeInUdt(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[173])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetMemorySpaceKind(out MemorySpace result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (MemorySpace* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, MemorySpace*, int>)__vtable_native[174])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetUnmodifiedTypeId(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[175])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetSubTypeId(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[176])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetSubType(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[177])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetNumberOfModifiers(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[178])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetNumberOfRegisterIndices(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[179])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsHLSLData(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[180])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsPointerToDataMember(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[181])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsPointerToMemberFunction(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[182])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsSingleInheritance(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[183])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsMultipleInheritance(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[184])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsVirtualInheritance(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[185])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetRestrictedType(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[186])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsPointerBasedOnSymbolValue(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[187])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBaseSymbol(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[188])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBaseSymbolId(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[189])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetObjectFileName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		ushort* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[190])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = BStrStringMarshaller.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsAcceleratorGroupSharedLocal(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[191])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsAcceleratorPointerTagLiveRange(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[192])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsAcceleratorStubFunction(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[193])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetNumberOfAcceleratorPointerTags(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[194])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsSDL(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[195])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsWinRTPointer(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[196])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsRefUdt(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[197])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsValueUdt(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[198])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsInterfaceUdt(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[199])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindInlineFramesByAddress(uint sectionIndex, uint offset, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, void**, int>)__vtable_native[200])(__this, sectionIndex, offset, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindInlineFramesByRVA(uint relativeVirtualAddress, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[201])(__this, relativeVirtualAddress, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindInlineFramesByVA(ulong virtualAddress, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, void**, int>)__vtable_native[202])(__this, virtualAddress, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindInlineeLines(out IEnumLineNumbers result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[203])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindInlineeLinesByAddress(uint sectionIndex, uint offset, uint length, out IEnumLineNumbers result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint, void**, int>)__vtable_native[204])(__this, sectionIndex, offset, length, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindInlineeLinesByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, void**, int>)__vtable_native[205])(__this, relativeVirtualAddress, length, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindInlineeLinesByVA(ulong virtualAddress, uint length, out IEnumLineNumbers result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, void**, int>)__vtable_native[206])(__this, virtualAddress, length, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumLineNumbers>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindSymbolsForAcceleratorPointerTag(uint tagValue, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[207])(__this, tagValue, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindSymbolsByRVAForAcceleratorPointerTag(uint tagValue, uint relativeVirtualAddress, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, void**, int>)__vtable_native[208])(__this, tagValue, relativeVirtualAddress, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetAcceleratorPointerTags(uint tagCount, out uint tagsWritten, uint* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out tagsWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __tagsWritten_native = &tagsWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, uint*, int>)__vtable_native[209])(__this, tagCount, __tagsWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetSourceLineOnTypeDefinition(out ILineNumber result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[210])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ILineNumber>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ILineNumber>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsPGO(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[211])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasValidPGOCounts(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[212])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsOptimizedForSpeed(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[213])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetPGOEntryCount(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[214])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetPGOEdgeCount(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[215])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetPGODynamicInstructionCount(out ulong result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[216])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetStaticSize(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[217])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetFinalLiveStaticSize(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[218])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetPhaseName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		ushort* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[219])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = BStrStringMarshaller.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasControlFlowCheck(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[220])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsConstantExport(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[221])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsDataExport(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[222])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetPrivateExport(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[223])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetNoNameExport(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[224])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetExportHasExplicitlyAssignedOrdinal(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[225])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetExportIsForwarder(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __result_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[226])(__this, &__result_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		result = __result_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetOrdinal(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[227])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetFrameSize(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[228])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetExceptionHandlerAddressSection(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[229])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetExceptionHandlerAddressOffset(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[230])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetExceptionHandlerRelativeVirtualAddress(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[231])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetExceptionHandlerVirtualAddress(out ulong result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[232])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.FindInputAssemblyFile(out IInputAssemblyFile result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[233])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IInputAssemblyFile>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetCharacteristics(out SectionCharacteristics result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (SectionCharacteristics* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, SectionCharacteristics*, int>)__vtable_native[234])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetCoffGroup(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out result);
		void* __result_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[235])(__this, &__result_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__result_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBindID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[236])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBindSpace(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[237])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetBindSlot(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out result);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __result_native = &result)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[238])(__this, __result_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsObjectiveCClass(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[239])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsObjectiveCCategory(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[240])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsObjectiveCProtocol(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[241])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetInlinee(out ISymbol inlinee)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out inlinee);
		void* __inlinee_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[242])(__this, &__inlinee_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			inlinee = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__inlinee_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__inlinee_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetInlineeID(out uint ID)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out ID);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __ID_native = &ID)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[243])(__this, __ID_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsNoExcept(out bool noexcept)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out noexcept);
		int __noexcept_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[244])(__this, &__noexcept_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		noexcept = __noexcept_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetHasAbsoluteAddress(out bool absolute)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out absolute);
		int __absolute_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[245])(__this, &__absolute_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		absolute = __absolute_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsStaticMemberFunction(out bool isStatic)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out isStatic);
		int __isStatic_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[246])(__this, &__isStatic_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		isStatic = __isStatic_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol8.GetIsSignedReturn(out bool signed)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol8));
		Unsafe.SkipInit(out signed);
		int __signed_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[247])(__this, &__signed_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		signed = __signed_native != 0;
		return __retVal;
	}

	int ISymbol.GetSymbolIndexID(out uint result) => throw new UnreachableException();
	int ISymbol.GetSymbolTag(out SymbolTag result) => throw new UnreachableException();
	int ISymbol.GetName(out string result) => throw new UnreachableException();
	int ISymbol.GetLexicalParent(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetClassParent(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetSymbolType(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetDataKind(out DataKind result) => throw new UnreachableException();
	int ISymbol.GetLocationType(out LocationType result) => throw new UnreachableException();
	int ISymbol.GetAddressSection(out uint result) => throw new UnreachableException();
	int ISymbol.GetAddressOffset(out uint result) => throw new UnreachableException();
	int ISymbol.GetRelativeVirtualAddress(out uint result) => throw new UnreachableException();
	int ISymbol.GetVirtualAddress(out ulong result) => throw new UnreachableException();
	int ISymbol.GetRegisterID(out uint result) => throw new UnreachableException();
	int ISymbol.GetOffset(out int result) => throw new UnreachableException();
	int ISymbol.GetLength(out ulong result) => throw new UnreachableException();
	int ISymbol.GetSlot(out uint result) => throw new UnreachableException();
	int ISymbol.GetVolatileType(out bool result) => throw new UnreachableException();
	int ISymbol.GetConstType(out bool result) => throw new UnreachableException();
	int ISymbol.GetUnalignedType(out bool result) => throw new UnreachableException();
	int ISymbol.GetAccess(out Access result) => throw new UnreachableException();
	int ISymbol.GetLibraryName(out string result) => throw new UnreachableException();
	int ISymbol.GetPlatform(out CpuType result) => throw new UnreachableException();
	int ISymbol.GetLanguage(out CompileFlagLanguage result) => throw new UnreachableException();
	int ISymbol.GetEditAndContinueEnabled(out bool result) => throw new UnreachableException();
	int ISymbol.GetFrontendMajor(out uint result) => throw new UnreachableException();
	int ISymbol.GetFrontendMinor(out uint result) => throw new UnreachableException();
	int ISymbol.GetFrontendBuild(out uint result) => throw new UnreachableException();
	int ISymbol.GetBackendMajor(out uint result) => throw new UnreachableException();
	int ISymbol.GetBackendMinor(out uint result) => throw new UnreachableException();
	int ISymbol.GetBackendBuild(out uint result) => throw new UnreachableException();
	int ISymbol.GetSourceFileName(out string result) => throw new UnreachableException();
	int ISymbol.GetUnused(out string result) => throw new UnreachableException();
	int ISymbol.GetThunkOrdinal(out ThunkOrdinal result) => throw new UnreachableException();
	int ISymbol.GetThisAdjustor(out int result) => throw new UnreachableException();
	int ISymbol.GetVirtualBaseOffset(out uint result) => throw new UnreachableException();
	int ISymbol.GetIsVirtual(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsIntro(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsPure(out bool result) => throw new UnreachableException();
	int ISymbol.GetCallingConvention(out DiaSharp.CodeView.CallingConvention result) => throw new UnreachableException();
	int ISymbol.GetValue(out Variant result) => throw new UnreachableException();
	int ISymbol.GetBaseType(out BasicType result) => throw new UnreachableException();
	int ISymbol.GetToken(out uint result) => throw new UnreachableException();
	int ISymbol.GetTimestamp(out uint result) => throw new UnreachableException();
	int ISymbol.GetGUID(out Guid result) => throw new UnreachableException();
	int ISymbol.GetSymbolsFileName(out string result) => throw new UnreachableException();
	int ISymbol.GetIsReference(out bool result) => throw new UnreachableException();
	int ISymbol.GetCount(out uint result) => throw new UnreachableException();
	int ISymbol.GetBitPosition(out uint result) => throw new UnreachableException();
	int ISymbol.GetArrayIndexType(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetIsPacked(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasConstructor(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasOverloadedOperator(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsNested(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasNestedTypes(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasAssignmentOperator(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasCastOperator(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsScoped(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsVirtualBaseClass(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsIndirectVirtualBaseClass(out bool result) => throw new UnreachableException();
	int ISymbol.GetVirtualBasePointerOffset(out int result) => throw new UnreachableException();
	int ISymbol.GetVirtualTableShape(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetLexicalParentID(out uint result) => throw new UnreachableException();
	int ISymbol.GetClassParentID(out uint result) => throw new UnreachableException();
	int ISymbol.GetTypeID(out uint result) => throw new UnreachableException();
	int ISymbol.GetArrayIndexTypeID(out uint result) => throw new UnreachableException();
	int ISymbol.GetVirtualTableShapeID(out uint result) => throw new UnreachableException();
	int ISymbol.GetIsCode(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsFunction(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsManaged(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsMSIL(out bool result) => throw new UnreachableException();
	int ISymbol.GetVirtualBaseDisplacementIndex(out uint result) => throw new UnreachableException();
	int ISymbol.GetUndecoratedName(out string result) => throw new UnreachableException();
	int ISymbol.GetAge(out uint result) => throw new UnreachableException();
	int ISymbol.GetSignature(out uint result) => throw new UnreachableException();
	int ISymbol.GetIsCompilerGenerated(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsAddressTaken(out bool result) => throw new UnreachableException();
	int ISymbol.GetRank(out uint result) => throw new UnreachableException();
	int ISymbol.GetLowerBound(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetUpperBound(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetLowerBoundID(out uint result) => throw new UnreachableException();
	int ISymbol.GetUpperBoundID(out uint result) => throw new UnreachableException();
	int ISymbol.GetDataBytes(uint dataSize, out uint dataWritten, byte* buffer) => throw new UnreachableException();
	int ISymbol.FindChildrenUnaware(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, out IEnumSymbols result) => throw new UnreachableException();
	int ISymbol.FindChildren(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, out IEnumSymbols result) => throw new UnreachableException();
	int ISymbol.FindChildrenByAddress(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, uint sectionIndex, uint offset, out IEnumSymbols result) => throw new UnreachableException();
	int ISymbol.FindChildrenByVA(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, ulong virtualAddress, out IEnumSymbols result) => throw new UnreachableException();
	int ISymbol.FindChildrenByRVA(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, uint relativeVirtualAddress, out IEnumSymbols result) => throw new UnreachableException();
	int ISymbol.GetTargetSection(out uint result) => throw new UnreachableException();
	int ISymbol.GetTargetOffset(out uint result) => throw new UnreachableException();
	int ISymbol.GetTargetRelativeVirtualAddress(out uint result) => throw new UnreachableException();
	int ISymbol.GetTargetVirtualAddress(out ulong result) => throw new UnreachableException();
	int ISymbol.GetMachineType(out ImageFileMachine result) => throw new UnreachableException();
	int ISymbol.GetOemID(out uint result) => throw new UnreachableException();
	int ISymbol.GetOemSymbolID(out uint result) => throw new UnreachableException();
	int ISymbol.GetTypes(uint typeCount, out uint typesWritten, void** buffer) => throw new UnreachableException();
	int ISymbol.GetTypeIDs(uint typeIDCount, out uint typeIDsWritten, uint* buffer) => throw new UnreachableException();
	int ISymbol.GetObjectPointerType(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetUdtKind(out UdtKind result) => throw new UnreachableException();
	int ISymbol.GetUndecoratedName(UndecorateOptions undecorateOptions, out string result) => throw new UnreachableException();
	int ISymbol.GetIsNoReturn(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasCustomCallingConvention(out bool result) => throw new UnreachableException();
	int ISymbol.GetNoInline(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasOptimizedCodeDebugInfo(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsNotReached(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasInterruptReturn(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasFarReturn(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsStatic(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasDebugInfo(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsLTCG(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsDataAligned(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasSecurityChecks(out bool result) => throw new UnreachableException();
	int ISymbol.GetCompilerName(out string result) => throw new UnreachableException();
	int ISymbol.GetHasAlloca(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasSetJump(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasLongJump(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasInlAsm(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasEH(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasSEH(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasEHa(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsNaked(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsAggregated(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsSplit(out bool result) => throw new UnreachableException();
	int ISymbol.GetContainer(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetInliningSpecified(out bool result) => throw new UnreachableException();
	int ISymbol.GetNoStackOrderingSpecified(out bool result) => throw new UnreachableException();
	int ISymbol.GetVirtualBaseTableType(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetHasManagedCode(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsHotpatchable(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsConvertedCIL(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsMSILNetmodule(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasCTypes(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsStripped(out bool result) => throw new UnreachableException();
	int ISymbol.GetFrontendQFE(out uint result) => throw new UnreachableException();
	int ISymbol.GetBackendQFE(out uint result) => throw new UnreachableException();
	int ISymbol.GetWasInlined(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasStrictGSCheck(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsCxxReturnUdt(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsConstructorVirtualBase(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsRValueReference(out bool result) => throw new UnreachableException();
	int ISymbol.GetUnmodifiedType(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetFramePointerPresent(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasSafeBuffers(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsIntrinsic(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsSealed(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasHfaFloat(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasHfaDouble(out bool result) => throw new UnreachableException();
	int ISymbol.GetLiveRangeStartAddressSection(out uint result) => throw new UnreachableException();
	int ISymbol.GetLiveRangeStartAddressOffset(out uint result) => throw new UnreachableException();
	int ISymbol.GetLiveRangeStartRelativeVirtualAddress(out uint result) => throw new UnreachableException();
	int ISymbol.GetLiveRangeCount(out uint result) => throw new UnreachableException();
	int ISymbol.GetLiveRangeLength(out ulong result) => throw new UnreachableException();
	int ISymbol.GetOffsetInUdt(out uint result) => throw new UnreachableException();
	int ISymbol.GetParamBasePointerRegisterID(out uint result) => throw new UnreachableException();
	int ISymbol.GetLocalBasePointerRegisterID(out uint result) => throw new UnreachableException();
	int ISymbol.GetIsLocationControlFlowDependent(out bool result) => throw new UnreachableException();
	int ISymbol.GetStride(out uint result) => throw new UnreachableException();
	int ISymbol.GetNumberOfRows(out uint result) => throw new UnreachableException();
	int ISymbol.GetNumberOfColumns(out uint result) => throw new UnreachableException();
	int ISymbol.GetIsMatrixRowMajor(out bool result) => throw new UnreachableException();
	int ISymbol.GetNumericProperties(uint propertyCount, out uint countWritten, uint* buffer) => throw new UnreachableException();
	int ISymbol.GetModifierValues(uint propertyCount, out uint countWritten, ushort* buffer) => throw new UnreachableException();
	int ISymbol.GetIsReturnValue(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsOptimizedAway(out bool result) => throw new UnreachableException();
	int ISymbol.GetBuiltInKind(out BuiltIn result) => throw new UnreachableException();
	int ISymbol.GetRegisterType(out Register result) => throw new UnreachableException();
	int ISymbol.GetBaseDataSlot(out uint result) => throw new UnreachableException();
	int ISymbol.GetBaseDataOffset(out uint result) => throw new UnreachableException();
	int ISymbol.GetTextureSlot(out uint result) => throw new UnreachableException();
	int ISymbol.GetSamplerSlot(out uint result) => throw new UnreachableException();
	int ISymbol.GetUavSlot(out uint result) => throw new UnreachableException();
	int ISymbol.GetSizeInUdt(out uint result) => throw new UnreachableException();
	int ISymbol.GetMemorySpaceKind(out MemorySpace result) => throw new UnreachableException();
	int ISymbol.GetUnmodifiedTypeId(out uint result) => throw new UnreachableException();
	int ISymbol.GetSubTypeId(out uint result) => throw new UnreachableException();
	int ISymbol.GetSubType(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetNumberOfModifiers(out uint result) => throw new UnreachableException();
	int ISymbol.GetNumberOfRegisterIndices(out uint result) => throw new UnreachableException();
	int ISymbol.GetIsHLSLData(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsPointerToDataMember(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsPointerToMemberFunction(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsSingleInheritance(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsMultipleInheritance(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsVirtualInheritance(out bool result) => throw new UnreachableException();
	int ISymbol.GetRestrictedType(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsPointerBasedOnSymbolValue(out bool result) => throw new UnreachableException();
	int ISymbol.GetBaseSymbol(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetBaseSymbolId(out uint result) => throw new UnreachableException();
	int ISymbol.GetObjectFileName(out string result) => throw new UnreachableException();
	int ISymbol.GetIsAcceleratorGroupSharedLocal(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsAcceleratorPointerTagLiveRange(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsAcceleratorStubFunction(out bool result) => throw new UnreachableException();
	int ISymbol.GetNumberOfAcceleratorPointerTags(out uint result) => throw new UnreachableException();
	int ISymbol.GetIsSDL(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsWinRTPointer(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsRefUdt(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsValueUdt(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsInterfaceUdt(out bool result) => throw new UnreachableException();
	int ISymbol.FindInlineFramesByAddress(uint sectionIndex, uint offset, out IEnumSymbols result) => throw new UnreachableException();
	int ISymbol.FindInlineFramesByRVA(uint relativeVirtualAddress, out IEnumSymbols result) => throw new UnreachableException();
	int ISymbol.FindInlineFramesByVA(ulong virtualAddress, out IEnumSymbols result) => throw new UnreachableException();
	int ISymbol.FindInlineeLines(out IEnumLineNumbers result) => throw new UnreachableException();
	int ISymbol.FindInlineeLinesByAddress(uint sectionIndex, uint offset, uint length, out IEnumLineNumbers result) => throw new UnreachableException();
	int ISymbol.FindInlineeLinesByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers result) => throw new UnreachableException();
	int ISymbol.FindInlineeLinesByVA(ulong virtualAddress, uint length, out IEnumLineNumbers result) => throw new UnreachableException();
	int ISymbol.FindSymbolsForAcceleratorPointerTag(uint tagValue, out IEnumSymbols result) => throw new UnreachableException();
	int ISymbol.FindSymbolsByRVAForAcceleratorPointerTag(uint tagValue, uint relativeVirtualAddress, out IEnumSymbols result) => throw new UnreachableException();
	int ISymbol.GetAcceleratorPointerTags(uint tagCount, out uint tagsWritten, uint* buffer) => throw new UnreachableException();
	int ISymbol.GetSourceLineOnTypeDefinition(out ILineNumber result) => throw new UnreachableException();
	int ISymbol.GetIsPGO(out bool result) => throw new UnreachableException();
	int ISymbol.GetHasValidPGOCounts(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsOptimizedForSpeed(out bool result) => throw new UnreachableException();
	int ISymbol.GetPGOEntryCount(out uint result) => throw new UnreachableException();
	int ISymbol.GetPGOEdgeCount(out uint result) => throw new UnreachableException();
	int ISymbol.GetPGODynamicInstructionCount(out ulong result) => throw new UnreachableException();
	int ISymbol.GetStaticSize(out uint result) => throw new UnreachableException();
	int ISymbol.GetFinalLiveStaticSize(out uint result) => throw new UnreachableException();
	int ISymbol.GetPhaseName(out string result) => throw new UnreachableException();
	int ISymbol.GetHasControlFlowCheck(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsConstantExport(out bool result) => throw new UnreachableException();
	int ISymbol.GetIsDataExport(out bool result) => throw new UnreachableException();
	int ISymbol.GetPrivateExport(out bool result) => throw new UnreachableException();
	int ISymbol.GetNoNameExport(out bool result) => throw new UnreachableException();
	int ISymbol.GetExportHasExplicitlyAssignedOrdinal(out bool result) => throw new UnreachableException();
	int ISymbol.GetExportIsForwarder(out bool result) => throw new UnreachableException();
	int ISymbol.GetOrdinal(out uint result) => throw new UnreachableException();
	int ISymbol.GetFrameSize(out uint result) => throw new UnreachableException();
	int ISymbol.GetExceptionHandlerAddressSection(out uint result) => throw new UnreachableException();
	int ISymbol.GetExceptionHandlerAddressOffset(out uint result) => throw new UnreachableException();
	int ISymbol.GetExceptionHandlerRelativeVirtualAddress(out uint result) => throw new UnreachableException();
	int ISymbol.GetExceptionHandlerVirtualAddress(out ulong result) => throw new UnreachableException();
	int ISymbol.FindInputAssemblyFile(out IInputAssemblyFile result) => throw new UnreachableException();
	int ISymbol.GetCharacteristics(out SectionCharacteristics result) => throw new UnreachableException();
	int ISymbol.GetCoffGroup(out ISymbol result) => throw new UnreachableException();
	int ISymbol.GetBindID(out uint result) => throw new UnreachableException();
	int ISymbol.GetBindSpace(out uint result) => throw new UnreachableException();
	int ISymbol.GetBindSlot(out uint result) => throw new UnreachableException();
	int ISymbol2.GetIsObjectiveCClass(out bool value) => throw new UnreachableException();
	int ISymbol2.GetIsObjectiveCCategory(out bool value) => throw new UnreachableException();
	int ISymbol2.GetIsObjectiveCProtocol(out bool value) => throw new UnreachableException();
	int ISymbol3.GetInlinee(out ISymbol inlinee) => throw new UnreachableException();
	int ISymbol3.GetInlineeID(out uint ID) => throw new UnreachableException();
	int ISymbol4.GetIsNoExcept(out bool noexcept) => throw new UnreachableException();
	int ISymbol5.GetHasAbsoluteAddress(out bool absolute) => throw new UnreachableException();
	int ISymbol6.GetIsStaticMemberFunction(out bool isStatic) => throw new UnreachableException();
	int ISymbol7.GetIsSignedReturn(out bool signed) => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetCoroutineKind(ComWrappers.ComInterfaceDispatch* __this_native, CoroutineKind* __kind_native__param)
	{
		ISymbol8 @this = default!;
		ref CoroutineKind __kind_native = ref *__kind_native__param;
		CoroutineKind kind = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol8>(__this_native);
			__retVal = @this.GetCoroutineKind(out kind);
			// Marshal - Convert managed data to native data.
			__kind_native = kind;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetAssociatedSymbolKind(ComWrappers.ComInterfaceDispatch* __this_native, AssociationKind* __kind_native__param)
	{
		ISymbol8 @this = default!;
		ref AssociationKind __kind_native = ref *__kind_native__param;
		AssociationKind kind = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol8>(__this_native);
			__retVal = @this.GetAssociatedSymbolKind(out kind);
			// Marshal - Convert managed data to native data.
			__kind_native = kind;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetAssociatedSymbolSection(ComWrappers.ComInterfaceDispatch* __this_native, uint* __section_native__param)
	{
		ISymbol8 @this = default!;
		ref uint __section_native = ref *__section_native__param;
		uint section = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol8>(__this_native);
			__retVal = @this.GetAssociatedSymbolSection(out section);
			// Marshal - Convert managed data to native data.
			__section_native = section;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetAssociatedSymbolOffset(ComWrappers.ComInterfaceDispatch* __this_native, uint* __offset_native__param)
	{
		ISymbol8 @this = default!;
		ref uint __offset_native = ref *__offset_native__param;
		uint offset = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol8>(__this_native);
			__retVal = @this.GetAssociatedSymbolOffset(out offset);
			// Marshal - Convert managed data to native data.
			__offset_native = offset;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetAssociatedSymbolRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint* __rva_native__param)
	{
		ISymbol8 @this = default!;
		ref uint __rva_native = ref *__rva_native__param;
		uint relativeVirtualAddress = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol8>(__this_native);
			__retVal = @this.GetAssociatedSymbolRVA(out relativeVirtualAddress);
			// Marshal - Convert managed data to native data.
			__rva_native = relativeVirtualAddress;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GeAassociatedSymbolAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __address_native__param)
	{
		ISymbol8 @this = default!;
		ref ulong __address_native = ref *__address_native__param;
		ulong address = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol8>(__this_native);
			__retVal = @this.GetAssociatedSymbolAddress(out address);
			// Marshal - Convert managed data to native data.
			__address_native = address;
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ISymbol8), sizeof(void*) * 254);
		{
			NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(ISymbol7).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 248));
		}

		{
			vtable[248] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, CoroutineKind*, int>)&ABI_GetCoroutineKind;
			vtable[249] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, AssociationKind*, int>)&ABI_GetAssociatedSymbolKind;
			vtable[250] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetAssociatedSymbolSection;
			vtable[251] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetAssociatedSymbolOffset;
			vtable[252] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetAssociatedSymbolRVA;
			vtable[253] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GeAassociatedSymbolAddress;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK.Symbols
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public unsafe partial interface ISymbol8
	{

		[SkipLocalsInit, PreserveSig]
		new int GetSymbolIndexID(out uint result) => ((ISymbol)this).GetSymbolIndexID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetSymbolTag(out SymbolTag result) => ((ISymbol)this).GetSymbolTag(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetName(out string result) => ((ISymbol)this).GetName(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLexicalParent(out ISymbol result) => ((ISymbol)this).GetLexicalParent(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetClassParent(out ISymbol result) => ((ISymbol)this).GetClassParent(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetSymbolType(out ISymbol result) => ((ISymbol)this).GetSymbolType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetDataKind(out DataKind result) => ((ISymbol)this).GetDataKind(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLocationType(out LocationType result) => ((ISymbol)this).GetLocationType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetAddressSection(out uint result) => ((ISymbol)this).GetAddressSection(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetAddressOffset(out uint result) => ((ISymbol)this).GetAddressOffset(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetRelativeVirtualAddress(out uint result) => ((ISymbol)this).GetRelativeVirtualAddress(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetVirtualAddress(out ulong result) => ((ISymbol)this).GetVirtualAddress(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetRegisterID(out uint result) => ((ISymbol)this).GetRegisterID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetOffset(out int result) => ((ISymbol)this).GetOffset(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLength(out ulong result) => ((ISymbol)this).GetLength(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetSlot(out uint result) => ((ISymbol)this).GetSlot(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetVolatileType(out bool result) => ((ISymbol)this).GetVolatileType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetConstType(out bool result) => ((ISymbol)this).GetConstType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetUnalignedType(out bool result) => ((ISymbol)this).GetUnalignedType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetAccess(out Access result) => ((ISymbol)this).GetAccess(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLibraryName(out string result) => ((ISymbol)this).GetLibraryName(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetPlatform(out CpuType result) => ((ISymbol)this).GetPlatform(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLanguage(out CompileFlagLanguage result) => ((ISymbol)this).GetLanguage(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetEditAndContinueEnabled(out bool result) => ((ISymbol)this).GetEditAndContinueEnabled(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetFrontendMajor(out uint result) => ((ISymbol)this).GetFrontendMajor(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetFrontendMinor(out uint result) => ((ISymbol)this).GetFrontendMinor(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetFrontendBuild(out uint result) => ((ISymbol)this).GetFrontendBuild(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBackendMajor(out uint result) => ((ISymbol)this).GetBackendMajor(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBackendMinor(out uint result) => ((ISymbol)this).GetBackendMinor(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBackendBuild(out uint result) => ((ISymbol)this).GetBackendBuild(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetSourceFileName(out string result) => ((ISymbol)this).GetSourceFileName(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetUnused(out string result) => ((ISymbol)this).GetUnused(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetThunkOrdinal(out ThunkOrdinal result) => ((ISymbol)this).GetThunkOrdinal(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetThisAdjustor(out int result) => ((ISymbol)this).GetThisAdjustor(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetVirtualBaseOffset(out uint result) => ((ISymbol)this).GetVirtualBaseOffset(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsVirtual(out bool result) => ((ISymbol)this).GetIsVirtual(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsIntro(out bool result) => ((ISymbol)this).GetIsIntro(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsPure(out bool result) => ((ISymbol)this).GetIsPure(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetCallingConvention(out DiaSharp.CodeView.CallingConvention result) => ((ISymbol)this).GetCallingConvention(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetValue(out Variant result) => ((ISymbol)this).GetValue(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBaseType(out BasicType result) => ((ISymbol)this).GetBaseType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetToken(out uint result) => ((ISymbol)this).GetToken(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetTimestamp(out uint result) => ((ISymbol)this).GetTimestamp(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetGUID(out Guid result) => ((ISymbol)this).GetGUID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetSymbolsFileName(out string result) => ((ISymbol)this).GetSymbolsFileName(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsReference(out bool result) => ((ISymbol)this).GetIsReference(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetCount(out uint result) => ((ISymbol)this).GetCount(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBitPosition(out uint result) => ((ISymbol)this).GetBitPosition(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetArrayIndexType(out ISymbol result) => ((ISymbol)this).GetArrayIndexType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsPacked(out bool result) => ((ISymbol)this).GetIsPacked(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasConstructor(out bool result) => ((ISymbol)this).GetHasConstructor(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasOverloadedOperator(out bool result) => ((ISymbol)this).GetHasOverloadedOperator(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsNested(out bool result) => ((ISymbol)this).GetIsNested(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasNestedTypes(out bool result) => ((ISymbol)this).GetHasNestedTypes(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasAssignmentOperator(out bool result) => ((ISymbol)this).GetHasAssignmentOperator(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasCastOperator(out bool result) => ((ISymbol)this).GetHasCastOperator(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsScoped(out bool result) => ((ISymbol)this).GetIsScoped(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsVirtualBaseClass(out bool result) => ((ISymbol)this).GetIsVirtualBaseClass(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsIndirectVirtualBaseClass(out bool result) => ((ISymbol)this).GetIsIndirectVirtualBaseClass(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetVirtualBasePointerOffset(out int result) => ((ISymbol)this).GetVirtualBasePointerOffset(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetVirtualTableShape(out ISymbol result) => ((ISymbol)this).GetVirtualTableShape(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLexicalParentID(out uint result) => ((ISymbol)this).GetLexicalParentID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetClassParentID(out uint result) => ((ISymbol)this).GetClassParentID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetTypeID(out uint result) => ((ISymbol)this).GetTypeID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetArrayIndexTypeID(out uint result) => ((ISymbol)this).GetArrayIndexTypeID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetVirtualTableShapeID(out uint result) => ((ISymbol)this).GetVirtualTableShapeID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsCode(out bool result) => ((ISymbol)this).GetIsCode(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsFunction(out bool result) => ((ISymbol)this).GetIsFunction(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsManaged(out bool result) => ((ISymbol)this).GetIsManaged(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsMSIL(out bool result) => ((ISymbol)this).GetIsMSIL(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetVirtualBaseDisplacementIndex(out uint result) => ((ISymbol)this).GetVirtualBaseDisplacementIndex(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetUndecoratedName(out string result) => ((ISymbol)this).GetUndecoratedName(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetAge(out uint result) => ((ISymbol)this).GetAge(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetSignature(out uint result) => ((ISymbol)this).GetSignature(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsCompilerGenerated(out bool result) => ((ISymbol)this).GetIsCompilerGenerated(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsAddressTaken(out bool result) => ((ISymbol)this).GetIsAddressTaken(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetRank(out uint result) => ((ISymbol)this).GetRank(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLowerBound(out ISymbol result) => ((ISymbol)this).GetLowerBound(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetUpperBound(out ISymbol result) => ((ISymbol)this).GetUpperBound(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLowerBoundID(out uint result) => ((ISymbol)this).GetLowerBoundID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetUpperBoundID(out uint result) => ((ISymbol)this).GetUpperBoundID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetDataBytes(uint dataSize, out uint dataWritten, byte* buffer) => ((ISymbol)this).GetDataBytes(dataSize, out dataWritten, buffer);

		[SkipLocalsInit, PreserveSig]
		new int FindChildrenUnaware(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, out IEnumSymbols result) => ((ISymbol)this).FindChildrenUnaware(symbolTag, name, compareFlags, out result);

		[SkipLocalsInit, PreserveSig]
		new int FindChildren(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, out IEnumSymbols result) => ((ISymbol)this).FindChildren(symbolTag, name, compareFlags, out result);

		[SkipLocalsInit, PreserveSig]
		new int FindChildrenByAddress(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, uint sectionIndex, uint offset, out IEnumSymbols result) => ((ISymbol)this).FindChildrenByAddress(symbolTag, name, compareFlags, sectionIndex, offset, out result);

		[SkipLocalsInit, PreserveSig]
		new int FindChildrenByVA(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, ulong virtualAddress, out IEnumSymbols result) => ((ISymbol)this).FindChildrenByVA(symbolTag, name, compareFlags, virtualAddress, out result);

		[SkipLocalsInit, PreserveSig]
		new int FindChildrenByRVA(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, uint relativeVirtualAddress, out IEnumSymbols result) => ((ISymbol)this).FindChildrenByRVA(symbolTag, name, compareFlags, relativeVirtualAddress, out result);

		[SkipLocalsInit, PreserveSig]
		new int GetTargetSection(out uint result) => ((ISymbol)this).GetTargetSection(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetTargetOffset(out uint result) => ((ISymbol)this).GetTargetOffset(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetTargetRelativeVirtualAddress(out uint result) => ((ISymbol)this).GetTargetRelativeVirtualAddress(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetTargetVirtualAddress(out ulong result) => ((ISymbol)this).GetTargetVirtualAddress(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetMachineType(out ImageFileMachine result) => ((ISymbol)this).GetMachineType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetOemID(out uint result) => ((ISymbol)this).GetOemID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetOemSymbolID(out uint result) => ((ISymbol)this).GetOemSymbolID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetTypes(uint typeCount, out uint typesWritten, void** buffer) => ((ISymbol)this).GetTypes(typeCount, out typesWritten, buffer);

		[SkipLocalsInit, PreserveSig]
		new int GetTypeIDs(uint typeIDCount, out uint typeIDsWritten, uint* buffer) => ((ISymbol)this).GetTypeIDs(typeIDCount, out typeIDsWritten, buffer);

		[SkipLocalsInit, PreserveSig]
		new int GetObjectPointerType(out ISymbol result) => ((ISymbol)this).GetObjectPointerType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetUdtKind(out UdtKind result) => ((ISymbol)this).GetUdtKind(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetUndecoratedName(UndecorateOptions undecorateOptions, out string result) => ((ISymbol)this).GetUndecoratedName(undecorateOptions, out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsNoReturn(out bool result) => ((ISymbol)this).GetIsNoReturn(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasCustomCallingConvention(out bool result) => ((ISymbol)this).GetHasCustomCallingConvention(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetNoInline(out bool result) => ((ISymbol)this).GetNoInline(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasOptimizedCodeDebugInfo(out bool result) => ((ISymbol)this).GetHasOptimizedCodeDebugInfo(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsNotReached(out bool result) => ((ISymbol)this).GetIsNotReached(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasInterruptReturn(out bool result) => ((ISymbol)this).GetHasInterruptReturn(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasFarReturn(out bool result) => ((ISymbol)this).GetHasFarReturn(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsStatic(out bool result) => ((ISymbol)this).GetIsStatic(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasDebugInfo(out bool result) => ((ISymbol)this).GetHasDebugInfo(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsLTCG(out bool result) => ((ISymbol)this).GetIsLTCG(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsDataAligned(out bool result) => ((ISymbol)this).GetIsDataAligned(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasSecurityChecks(out bool result) => ((ISymbol)this).GetHasSecurityChecks(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetCompilerName(out string result) => ((ISymbol)this).GetCompilerName(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasAlloca(out bool result) => ((ISymbol)this).GetHasAlloca(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasSetJump(out bool result) => ((ISymbol)this).GetHasSetJump(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasLongJump(out bool result) => ((ISymbol)this).GetHasLongJump(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasInlAsm(out bool result) => ((ISymbol)this).GetHasInlAsm(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasEH(out bool result) => ((ISymbol)this).GetHasEH(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasSEH(out bool result) => ((ISymbol)this).GetHasSEH(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasEHa(out bool result) => ((ISymbol)this).GetHasEHa(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsNaked(out bool result) => ((ISymbol)this).GetIsNaked(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsAggregated(out bool result) => ((ISymbol)this).GetIsAggregated(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsSplit(out bool result) => ((ISymbol)this).GetIsSplit(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetContainer(out ISymbol result) => ((ISymbol)this).GetContainer(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetInliningSpecified(out bool result) => ((ISymbol)this).GetInliningSpecified(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetNoStackOrderingSpecified(out bool result) => ((ISymbol)this).GetNoStackOrderingSpecified(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetVirtualBaseTableType(out ISymbol result) => ((ISymbol)this).GetVirtualBaseTableType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasManagedCode(out bool result) => ((ISymbol)this).GetHasManagedCode(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsHotpatchable(out bool result) => ((ISymbol)this).GetIsHotpatchable(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsConvertedCIL(out bool result) => ((ISymbol)this).GetIsConvertedCIL(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsMSILNetmodule(out bool result) => ((ISymbol)this).GetIsMSILNetmodule(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasCTypes(out bool result) => ((ISymbol)this).GetHasCTypes(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsStripped(out bool result) => ((ISymbol)this).GetIsStripped(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetFrontendQFE(out uint result) => ((ISymbol)this).GetFrontendQFE(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBackendQFE(out uint result) => ((ISymbol)this).GetBackendQFE(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetWasInlined(out bool result) => ((ISymbol)this).GetWasInlined(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasStrictGSCheck(out bool result) => ((ISymbol)this).GetHasStrictGSCheck(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsCxxReturnUdt(out bool result) => ((ISymbol)this).GetIsCxxReturnUdt(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsConstructorVirtualBase(out bool result) => ((ISymbol)this).GetIsConstructorVirtualBase(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsRValueReference(out bool result) => ((ISymbol)this).GetIsRValueReference(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetUnmodifiedType(out ISymbol result) => ((ISymbol)this).GetUnmodifiedType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetFramePointerPresent(out bool result) => ((ISymbol)this).GetFramePointerPresent(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasSafeBuffers(out bool result) => ((ISymbol)this).GetHasSafeBuffers(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsIntrinsic(out bool result) => ((ISymbol)this).GetIsIntrinsic(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsSealed(out bool result) => ((ISymbol)this).GetIsSealed(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasHfaFloat(out bool result) => ((ISymbol)this).GetHasHfaFloat(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasHfaDouble(out bool result) => ((ISymbol)this).GetHasHfaDouble(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLiveRangeStartAddressSection(out uint result) => ((ISymbol)this).GetLiveRangeStartAddressSection(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLiveRangeStartAddressOffset(out uint result) => ((ISymbol)this).GetLiveRangeStartAddressOffset(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLiveRangeStartRelativeVirtualAddress(out uint result) => ((ISymbol)this).GetLiveRangeStartRelativeVirtualAddress(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLiveRangeCount(out uint result) => ((ISymbol)this).GetLiveRangeCount(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLiveRangeLength(out ulong result) => ((ISymbol)this).GetLiveRangeLength(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetOffsetInUdt(out uint result) => ((ISymbol)this).GetOffsetInUdt(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetParamBasePointerRegisterID(out uint result) => ((ISymbol)this).GetParamBasePointerRegisterID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetLocalBasePointerRegisterID(out uint result) => ((ISymbol)this).GetLocalBasePointerRegisterID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsLocationControlFlowDependent(out bool result) => ((ISymbol)this).GetIsLocationControlFlowDependent(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetStride(out uint result) => ((ISymbol)this).GetStride(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetNumberOfRows(out uint result) => ((ISymbol)this).GetNumberOfRows(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetNumberOfColumns(out uint result) => ((ISymbol)this).GetNumberOfColumns(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsMatrixRowMajor(out bool result) => ((ISymbol)this).GetIsMatrixRowMajor(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetNumericProperties(uint propertyCount, out uint countWritten, uint* buffer) => ((ISymbol)this).GetNumericProperties(propertyCount, out countWritten, buffer);

		[SkipLocalsInit, PreserveSig]
		new int GetModifierValues(uint propertyCount, out uint countWritten, ushort* buffer) => ((ISymbol)this).GetModifierValues(propertyCount, out countWritten, buffer);

		[SkipLocalsInit, PreserveSig]
		new int GetIsReturnValue(out bool result) => ((ISymbol)this).GetIsReturnValue(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsOptimizedAway(out bool result) => ((ISymbol)this).GetIsOptimizedAway(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBuiltInKind(out BuiltIn result) => ((ISymbol)this).GetBuiltInKind(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetRegisterType(out Register result) => ((ISymbol)this).GetRegisterType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBaseDataSlot(out uint result) => ((ISymbol)this).GetBaseDataSlot(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBaseDataOffset(out uint result) => ((ISymbol)this).GetBaseDataOffset(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetTextureSlot(out uint result) => ((ISymbol)this).GetTextureSlot(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetSamplerSlot(out uint result) => ((ISymbol)this).GetSamplerSlot(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetUavSlot(out uint result) => ((ISymbol)this).GetUavSlot(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetSizeInUdt(out uint result) => ((ISymbol)this).GetSizeInUdt(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetMemorySpaceKind(out MemorySpace result) => ((ISymbol)this).GetMemorySpaceKind(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetUnmodifiedTypeId(out uint result) => ((ISymbol)this).GetUnmodifiedTypeId(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetSubTypeId(out uint result) => ((ISymbol)this).GetSubTypeId(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetSubType(out ISymbol result) => ((ISymbol)this).GetSubType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetNumberOfModifiers(out uint result) => ((ISymbol)this).GetNumberOfModifiers(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetNumberOfRegisterIndices(out uint result) => ((ISymbol)this).GetNumberOfRegisterIndices(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsHLSLData(out bool result) => ((ISymbol)this).GetIsHLSLData(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsPointerToDataMember(out bool result) => ((ISymbol)this).GetIsPointerToDataMember(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsPointerToMemberFunction(out bool result) => ((ISymbol)this).GetIsPointerToMemberFunction(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsSingleInheritance(out bool result) => ((ISymbol)this).GetIsSingleInheritance(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsMultipleInheritance(out bool result) => ((ISymbol)this).GetIsMultipleInheritance(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsVirtualInheritance(out bool result) => ((ISymbol)this).GetIsVirtualInheritance(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetRestrictedType(out bool result) => ((ISymbol)this).GetRestrictedType(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsPointerBasedOnSymbolValue(out bool result) => ((ISymbol)this).GetIsPointerBasedOnSymbolValue(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBaseSymbol(out ISymbol result) => ((ISymbol)this).GetBaseSymbol(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBaseSymbolId(out uint result) => ((ISymbol)this).GetBaseSymbolId(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetObjectFileName(out string result) => ((ISymbol)this).GetObjectFileName(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsAcceleratorGroupSharedLocal(out bool result) => ((ISymbol)this).GetIsAcceleratorGroupSharedLocal(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsAcceleratorPointerTagLiveRange(out bool result) => ((ISymbol)this).GetIsAcceleratorPointerTagLiveRange(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsAcceleratorStubFunction(out bool result) => ((ISymbol)this).GetIsAcceleratorStubFunction(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetNumberOfAcceleratorPointerTags(out uint result) => ((ISymbol)this).GetNumberOfAcceleratorPointerTags(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsSDL(out bool result) => ((ISymbol)this).GetIsSDL(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsWinRTPointer(out bool result) => ((ISymbol)this).GetIsWinRTPointer(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsRefUdt(out bool result) => ((ISymbol)this).GetIsRefUdt(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsValueUdt(out bool result) => ((ISymbol)this).GetIsValueUdt(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsInterfaceUdt(out bool result) => ((ISymbol)this).GetIsInterfaceUdt(out result);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineFramesByAddress(uint sectionIndex, uint offset, out IEnumSymbols result) => ((ISymbol)this).FindInlineFramesByAddress(sectionIndex, offset, out result);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineFramesByRVA(uint relativeVirtualAddress, out IEnumSymbols result) => ((ISymbol)this).FindInlineFramesByRVA(relativeVirtualAddress, out result);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineFramesByVA(ulong virtualAddress, out IEnumSymbols result) => ((ISymbol)this).FindInlineFramesByVA(virtualAddress, out result);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineeLines(out IEnumLineNumbers result) => ((ISymbol)this).FindInlineeLines(out result);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineeLinesByAddress(uint sectionIndex, uint offset, uint length, out IEnumLineNumbers result) => ((ISymbol)this).FindInlineeLinesByAddress(sectionIndex, offset, length, out result);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineeLinesByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers result) => ((ISymbol)this).FindInlineeLinesByRVA(relativeVirtualAddress, length, out result);

		[SkipLocalsInit, PreserveSig]
		new int FindInlineeLinesByVA(ulong virtualAddress, uint length, out IEnumLineNumbers result) => ((ISymbol)this).FindInlineeLinesByVA(virtualAddress, length, out result);

		[SkipLocalsInit, PreserveSig]
		new int FindSymbolsForAcceleratorPointerTag(uint tagValue, out IEnumSymbols result) => ((ISymbol)this).FindSymbolsForAcceleratorPointerTag(tagValue, out result);

		[SkipLocalsInit, PreserveSig]
		new int FindSymbolsByRVAForAcceleratorPointerTag(uint tagValue, uint relativeVirtualAddress, out IEnumSymbols result) => ((ISymbol)this).FindSymbolsByRVAForAcceleratorPointerTag(tagValue, relativeVirtualAddress, out result);

		[SkipLocalsInit, PreserveSig]
		new int GetAcceleratorPointerTags(uint tagCount, out uint tagsWritten, uint* buffer) => ((ISymbol)this).GetAcceleratorPointerTags(tagCount, out tagsWritten, buffer);

		[SkipLocalsInit, PreserveSig]
		new int GetSourceLineOnTypeDefinition(out ILineNumber result) => ((ISymbol)this).GetSourceLineOnTypeDefinition(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsPGO(out bool result) => ((ISymbol)this).GetIsPGO(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasValidPGOCounts(out bool result) => ((ISymbol)this).GetHasValidPGOCounts(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsOptimizedForSpeed(out bool result) => ((ISymbol)this).GetIsOptimizedForSpeed(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetPGOEntryCount(out uint result) => ((ISymbol)this).GetPGOEntryCount(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetPGOEdgeCount(out uint result) => ((ISymbol)this).GetPGOEdgeCount(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetPGODynamicInstructionCount(out ulong result) => ((ISymbol)this).GetPGODynamicInstructionCount(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetStaticSize(out uint result) => ((ISymbol)this).GetStaticSize(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetFinalLiveStaticSize(out uint result) => ((ISymbol)this).GetFinalLiveStaticSize(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetPhaseName(out string result) => ((ISymbol)this).GetPhaseName(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetHasControlFlowCheck(out bool result) => ((ISymbol)this).GetHasControlFlowCheck(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsConstantExport(out bool result) => ((ISymbol)this).GetIsConstantExport(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsDataExport(out bool result) => ((ISymbol)this).GetIsDataExport(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetPrivateExport(out bool result) => ((ISymbol)this).GetPrivateExport(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetNoNameExport(out bool result) => ((ISymbol)this).GetNoNameExport(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetExportHasExplicitlyAssignedOrdinal(out bool result) => ((ISymbol)this).GetExportHasExplicitlyAssignedOrdinal(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetExportIsForwarder(out bool result) => ((ISymbol)this).GetExportIsForwarder(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetOrdinal(out uint result) => ((ISymbol)this).GetOrdinal(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetFrameSize(out uint result) => ((ISymbol)this).GetFrameSize(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetExceptionHandlerAddressSection(out uint result) => ((ISymbol)this).GetExceptionHandlerAddressSection(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetExceptionHandlerAddressOffset(out uint result) => ((ISymbol)this).GetExceptionHandlerAddressOffset(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetExceptionHandlerRelativeVirtualAddress(out uint result) => ((ISymbol)this).GetExceptionHandlerRelativeVirtualAddress(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetExceptionHandlerVirtualAddress(out ulong result) => ((ISymbol)this).GetExceptionHandlerVirtualAddress(out result);

		[SkipLocalsInit, PreserveSig]
		new int FindInputAssemblyFile(out IInputAssemblyFile result) => ((ISymbol)this).FindInputAssemblyFile(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetCharacteristics(out SectionCharacteristics result) => ((ISymbol)this).GetCharacteristics(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetCoffGroup(out ISymbol result) => ((ISymbol)this).GetCoffGroup(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBindID(out uint result) => ((ISymbol)this).GetBindID(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBindSpace(out uint result) => ((ISymbol)this).GetBindSpace(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetBindSlot(out uint result) => ((ISymbol)this).GetBindSlot(out result);

		[SkipLocalsInit, PreserveSig]
		new int GetIsObjectiveCClass(out bool value) => ((ISymbol2)this).GetIsObjectiveCClass(out value);

		[SkipLocalsInit, PreserveSig]
		new int GetIsObjectiveCCategory(out bool value) => ((ISymbol2)this).GetIsObjectiveCCategory(out value);

		[SkipLocalsInit, PreserveSig]
		new int GetIsObjectiveCProtocol(out bool value) => ((ISymbol2)this).GetIsObjectiveCProtocol(out value);

		[SkipLocalsInit, PreserveSig]
		new int GetInlinee(out ISymbol inlinee) => ((ISymbol3)this).GetInlinee(out inlinee);

		[SkipLocalsInit, PreserveSig]
		new int GetInlineeID(out uint ID) => ((ISymbol3)this).GetInlineeID(out ID);

		[SkipLocalsInit, PreserveSig]
		new int GetIsNoExcept(out bool noexcept) => ((ISymbol4)this).GetIsNoExcept(out noexcept);

		[SkipLocalsInit, PreserveSig]
		new int GetHasAbsoluteAddress(out bool absolute) => ((ISymbol5)this).GetHasAbsoluteAddress(out absolute);

		[SkipLocalsInit, PreserveSig]
		new int GetIsStaticMemberFunction(out bool isStatic) => ((ISymbol6)this).GetIsStaticMemberFunction(out isStatic);

		[SkipLocalsInit, PreserveSig]
		new int GetIsSignedReturn(out bool signed) => ((ISymbol7)this).GetIsSignedReturn(out signed);
	}
}