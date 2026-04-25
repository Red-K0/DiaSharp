#pragma warning disable IDE0008, IDE0022

using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([2, 189, 69, 30, 69, 190, 113, 77, 186, 50, 14, 87, 108, 252, 213, 159]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumSymbolsByAddressEx
{
	[SkipLocalsInit]
	int IEnumSymbolsByAddressEx.GetSymbolByAddress(bool promoteBlockSymbols, uint sectionNumber, uint offset, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddressEx));
		bool __invokeSucceeded = false;
		void* __symbol_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int, uint, uint, void**, int>)__vtable_native[9])(__this, promoteBlockSymbols ? 1 : 0, sectionNumber, offset, &__symbol_native);

			__invokeSucceeded = true;

			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddressEx.GetSymbolByRVA(bool promoteBlockSymbols, uint relativeVirtualAddress, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddressEx));
		bool __invokeSucceeded = false;
		void* __symbol_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int, uint, void**, int>)__vtable_native[10])(__this, promoteBlockSymbols ? 1 : 0, relativeVirtualAddress, &__symbol_native);

			__invokeSucceeded = true;

			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddressEx.GetSymbolByVA(bool promoteBlockSymbols, ulong virtualAddress, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddressEx));
		bool __invokeSucceeded = false;
		void* __symbol_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int, ulong, void**, int>)__vtable_native[11])(__this, promoteBlockSymbols ? 1 : 0, virtualAddress, &__symbol_native);

			__invokeSucceeded = true;

			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddressEx.GetNext(bool promoteBlockSymbols, uint symbolCount, void** symbols, out uint symbolsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddressEx));

		fixed (uint* __symbolsFetched_native = &symbolsFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int, uint, void**, uint*, int>)__vtable_native[12])(__this, promoteBlockSymbols ? 1 : 0, symbolCount, symbols, __symbolsFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddressEx.GetPrevious(bool promoteBlockSymbols, uint symbolCount, void** symbols, out uint symbolsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddressEx));

		fixed (uint* __symbolsFetched_native = &symbolsFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int, uint, void**, uint*, int>)__vtable_native[13])(__this, promoteBlockSymbols ? 1 : 0, symbolCount, symbols, __symbolsFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddressEx.GetSymbolByAddress(uint sectionNumber, uint offset, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddressEx));
		bool __invokeSucceeded = false;
		void* __symbol_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, void**, int>)__vtable_native[3])(__this, sectionNumber, offset, &__symbol_native);

			__invokeSucceeded = true;

			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddressEx.GetSymbolByRVA(uint relativeVirtualAddress, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddressEx));
		bool __invokeSucceeded = false;
		void* __symbol_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[4])(__this, relativeVirtualAddress, &__symbol_native);

			__invokeSucceeded = true;

			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddressEx.GetSymbolByVA(ulong virtualAddress, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddressEx));
		bool __invokeSucceeded = false;
		void* __symbol_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, void**, int>)__vtable_native[5])(__this, virtualAddress, &__symbol_native);

			__invokeSucceeded = true;

			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddressEx.GetNext(uint symbolCount, void** symbols, out uint symbolsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddressEx));

		fixed (uint* __symbolsFetched_native = &symbolsFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[6])(__this, symbolCount, symbols, __symbolsFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddressEx.GetPrevious(uint symbolCount, void** symbols, out uint symbolsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddressEx));

		fixed (uint* __symbolsFetched_native = &symbolsFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[7])(__this, symbolCount, symbols, __symbolsFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddressEx.Clone(out IEnumSymbolsByAddress enumeator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddressEx));
		bool __invokeSucceeded = false;
		void* __enumeator_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[8])(__this, &__enumeator_native);

			__invokeSucceeded = true;

			enumeator = ComInterfaceMarshaller<IEnumSymbolsByAddress>.ConvertToManaged(__enumeator_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<IEnumSymbolsByAddress>.Free(__enumeator_native);
		}
	}

	int IEnumSymbolsByAddress.GetSymbolByAddress(uint sectionNumber, uint offset, out ISymbol symbol) => throw new UnreachableException();
	int IEnumSymbolsByAddress.GetSymbolByRVA(uint relativeVirtualAddress, out ISymbol symbol) => throw new UnreachableException();
	int IEnumSymbolsByAddress.GetSymbolByVA(ulong virtualAddress, out ISymbol symbol) => throw new UnreachableException();
	int IEnumSymbolsByAddress.GetNext(uint symbolCount, void** symbols, out uint symbolsFetched) => throw new UnreachableException();
	int IEnumSymbolsByAddress.GetPrevious(uint symbolCount, void** symbols, out uint symbolsFetched) => throw new UnreachableException();
	int IEnumSymbolsByAddress.Clone(out IEnumSymbolsByAddress enumeator) => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSymbolByAddress(ComWrappers.ComInterfaceDispatch* __this_native, int __promoteBlockSymbols_native, uint sectionNumber, uint offset, void** __symbol_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddressEx>(__this_native).GetSymbolByAddress(__promoteBlockSymbols_native != 0, sectionNumber, offset, out ISymbol symbol);

		*__symbol_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSymbolByRVA(ComWrappers.ComInterfaceDispatch* __this_native, int __promoteBlockSymbols_native, uint relativeVirtualAddress, void** __symbol_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddressEx>(__this_native).GetSymbolByRVA(__promoteBlockSymbols_native != 0, relativeVirtualAddress, out ISymbol symbol);

		*__symbol_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSymbolByVA(ComWrappers.ComInterfaceDispatch* __this_native, int __promoteBlockSymbols_native, ulong virtualAddress, void** __symbol_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddressEx>(__this_native).GetSymbolByVA(__promoteBlockSymbols_native != 0, virtualAddress, out ISymbol symbol);

		*__symbol_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, int __promoteBlockSymbols_native, uint symbolCount, void** symbols, uint* __symbolsFetched_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddressEx>(__this_native).GetNext(__promoteBlockSymbols_native != 0, symbolCount, symbols, out *__symbolsFetched_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Prev(ComWrappers.ComInterfaceDispatch* __this_native, int __promoteBlockSymbols_native, uint symbolCount, void** symbols, uint* __symbolsFetched_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddressEx>(__this_native).GetPrevious(__promoteBlockSymbols_native != 0, symbolCount, symbols, out *__symbolsFetched_native__param);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumSymbolsByAddressEx), sizeof(void*) * 14);

		NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(IEnumSymbolsByAddress).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 9));

		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int, uint, uint, void**, int>)&ABI_GetSymbolByAddress;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int, uint, void**, int>)&ABI_GetSymbolByRVA;
		vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int, ulong, void**, int>)&ABI_GetSymbolByVA;
		vtable[12] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int, uint, void**, uint*, int>)&ABI_GetNext;
		vtable[13] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int, uint, void**, uint*, int>)&ABI_Prev;

		return vtable;
	}
}

namespace DiaSharp.SDK.Enumerators
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public unsafe partial interface IEnumSymbolsByAddressEx
	{
		[SkipLocalsInit, PreserveSig]
		new int GetSymbolByAddress(uint sectionNumber, uint offset, out ISymbol symbol) => ((IEnumSymbolsByAddress)this).GetSymbolByAddress(sectionNumber, offset, out symbol);

		[SkipLocalsInit, PreserveSig]
		new int GetSymbolByRVA(uint relativeVirtualAddress, out ISymbol symbol) => ((IEnumSymbolsByAddress)this).GetSymbolByRVA(relativeVirtualAddress, out symbol);

		[SkipLocalsInit, PreserveSig]
		new int GetSymbolByVA(ulong virtualAddress, out ISymbol symbol) => ((IEnumSymbolsByAddress)this).GetSymbolByVA(virtualAddress, out symbol);

		[SkipLocalsInit, PreserveSig]
		new int GetNext(uint symbolCount, void** symbols, out uint symbolsFetched) => ((IEnumSymbolsByAddress)this).GetNext(symbolCount, symbols, out symbolsFetched);

		[SkipLocalsInit, PreserveSig]
		new int GetPrevious(uint symbolCount, void** symbols, out uint symbolsFetched) => ((IEnumSymbolsByAddress)this).GetPrevious(symbolCount, symbols, out symbolsFetched);

		[SkipLocalsInit, PreserveSig]
		new int Clone(out IEnumSymbolsByAddress enumeator) => ((IEnumSymbolsByAddress)this).Clone(out enumeator);
	}
}