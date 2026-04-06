#pragma warning disable CS0612, CS0618, IDE0008
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([156, 125, 75, 98, 234, 36, 33, 68, 157, 6, 59, 87, 116, 113, 193, 250]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumSymbolsByAddress
{
	[SkipLocalsInit]
	int IEnumSymbolsByAddress.GetSymbolByAddress(uint sectionNumber, uint offset, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddress));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbol);
		void* __symbol_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, void**, int>)__vtable_native[3])(__this, sectionNumber, offset, &__symbol_native);
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
	int IEnumSymbolsByAddress.GetSymbolByRVA(uint relativeVirtualAddress, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddress));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbol);
		void* __symbol_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[4])(__this, relativeVirtualAddress, &__symbol_native);
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
	int IEnumSymbolsByAddress.GetSymbolByVA(ulong virtualAddress, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddress));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbol);
		void* __symbol_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, void**, int>)__vtable_native[5])(__this, virtualAddress, &__symbol_native);
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
	int IEnumSymbolsByAddress.GetNext(uint symbolCount, void** symbols, out uint symbolsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddress));
		Unsafe.SkipInit(out symbolsFetched);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __symbolsFetched_native = &symbolsFetched)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[6])(__this, symbolCount, symbols, __symbolsFetched_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddress.Prev(uint symbolCount, void** symbols, out uint symbolsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddress));
		Unsafe.SkipInit(out symbolsFetched);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __symbolsFetched_native = &symbolsFetched)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[7])(__this, symbolCount, symbols, __symbolsFetched_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddress.Clone(out IEnumSymbolsByAddress enumeator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddress));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out enumeator);
		void* __enumeator_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[8])(__this, &__enumeator_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			enumeator = ComInterfaceMarshaller<IEnumSymbolsByAddress>.ConvertToManaged(__enumeator_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbolsByAddress>.Free(__enumeator_native);
			}
		}

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetSymbolByAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint sectionNumber, uint offset, void** __symbol_native__param)
	{
		IEnumSymbolsByAddress @this = default!;
		ref void* __symbol_native = ref *__symbol_native__param;
		ISymbol symbol = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddress>(__this_native);
			__retVal = @this.GetSymbolByAddress(sectionNumber, offset, out symbol);
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
	static internal int ABI_GetSymbolByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, void** __symbol_native__param)
	{
		IEnumSymbolsByAddress @this = default!;
		ref void* __symbol_native = ref *__symbol_native__param;
		ISymbol symbol = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddress>(__this_native);
			__retVal = @this.GetSymbolByRVA(relativeVirtualAddress, out symbol);
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
	static internal int ABI_GetSymbolByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, void** __symbol_native__param)
	{
		IEnumSymbolsByAddress @this = default!;
		ref void* __symbol_native = ref *__symbol_native__param;
		ISymbol symbol = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddress>(__this_native);
			__retVal = @this.GetSymbolByVA(virtualAddress, out symbol);
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
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint symbolCount, void** symbols, uint* __symbolsFetched_native__param)
	{
		IEnumSymbolsByAddress @this = default!;
		ref uint __symbolsFetched_native = ref *__symbolsFetched_native__param;
		uint symbolsFetched = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddress>(__this_native);
			__retVal = @this.GetNext(symbolCount, symbols, out symbolsFetched);
			// Marshal - Convert managed data to native data.
			__symbolsFetched_native = symbolsFetched;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Prev(ComWrappers.ComInterfaceDispatch* __this_native, uint symbolCount, void** symbols, uint* __symbolsFetched_native__param)
	{
		IEnumSymbolsByAddress @this = default!;
		ref uint __symbolsFetched_native = ref *__symbolsFetched_native__param;
		uint symbolsFetched = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddress>(__this_native);
			__retVal = @this.Prev(symbolCount, symbols, out symbolsFetched);
			// Marshal - Convert managed data to native data.
			__symbolsFetched_native = symbolsFetched;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumeator_native__param)
	{
		IEnumSymbolsByAddress @this = default!;
		ref void* __enumeator_native = ref *__enumeator_native__param;
		IEnumSymbolsByAddress enumeator = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddress>(__this_native);
			__retVal = @this.Clone(out enumeator);
			// Marshal - Convert managed data to native data.
			__enumeator_native = ComInterfaceMarshaller<IEnumSymbolsByAddress>.ConvertToUnmanaged(enumeator);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumSymbolsByAddress), sizeof(void*) * 9);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, void**, int>)&ABI_GetSymbolByAddress;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_GetSymbolByRVA;
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, void**, int>)&ABI_GetSymbolByVA;
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, uint*, int>)&ABI_GetNext;
			vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, uint*, int>)&ABI_Prev;
			vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK.Enumerators
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumSymbolsByAddress
	{
	}
}