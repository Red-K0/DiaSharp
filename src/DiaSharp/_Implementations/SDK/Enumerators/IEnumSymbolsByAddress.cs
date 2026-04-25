#pragma warning disable CS0612, CS0618, IDE0008, CA1031
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
	int IEnumSymbolsByAddress.GetSymbolByRVA(uint relativeVirtualAddress, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddress));
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
	int IEnumSymbolsByAddress.GetSymbolByVA(ulong virtualAddress, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddress));
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
	int IEnumSymbolsByAddress.GetNext(uint symbolCount, void** symbols, out uint symbolsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddress));

		fixed (uint* __symbolsFetched_native = &symbolsFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[6])(__this, symbolCount, symbols, __symbolsFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddress.GetPrevious(uint symbolCount, void** symbols, out uint symbolsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddress));

		fixed (uint* __symbolsFetched_native = &symbolsFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[7])(__this, symbolCount, symbols, __symbolsFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbolsByAddress.Clone(out IEnumSymbolsByAddress enumeator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbolsByAddress));
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
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSymbolByAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint sectionNumber, uint offset, void** __symbol_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddress>(__this_native).GetSymbolByAddress(sectionNumber, offset, out ISymbol symbol);

			*__symbol_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSymbolByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, void** __symbol_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddress>(__this_native).GetSymbolByRVA(relativeVirtualAddress, out ISymbol symbol);

			*__symbol_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSymbolByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, void** __symbol_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddress>(__this_native).GetSymbolByVA(virtualAddress, out ISymbol symbol);

			*__symbol_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint symbolCount, void** symbols, uint* __symbolsFetched_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddress>(__this_native).GetNext(symbolCount, symbols, out uint symbolsFetched);

			*__symbolsFetched_native__param = symbolsFetched;

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Prev(ComWrappers.ComInterfaceDispatch* __this_native, uint symbolCount, void** symbols, uint* __symbolsFetched_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddress>(__this_native).GetPrevious(symbolCount, symbols, out *__symbolsFetched_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumeator_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbolsByAddress>(__this_native).Clone(out IEnumSymbolsByAddress enumeator);

			*__enumeator_native__param = ComInterfaceMarshaller<IEnumSymbolsByAddress>.ConvertToUnmanaged(enumeator);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumSymbolsByAddress), sizeof(void*) * 9);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, void**, int>)&ABI_GetSymbolByAddress;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_GetSymbolByRVA;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, void**, int>)&ABI_GetSymbolByVA;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, uint*, int>)&ABI_GetNext;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, uint*, int>)&ABI_Prev;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;

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