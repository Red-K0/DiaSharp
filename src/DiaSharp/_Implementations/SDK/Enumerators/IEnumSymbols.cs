#pragma warning disable IDE0008, IDE0022

using DiaSharp.Interop;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([72, 44, 183, 202, 59, 68, 245, 72, 155, 11, 66, 240, 130, 10, 178, 154]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumSymbols
{
	[SkipLocalsInit]
	int IEnumSymbols.GetNewEnum(out IEnumVARIANT enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbols));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumVARIANT>.Free(__enumerator_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumSymbols.GetCount(out int count)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbols));

		fixed (int* __count_native = &count)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[4])(__this, __count_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbols.Item(uint index, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbols));
		void* __symbol_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[5])(__this, index, &__symbol_native);

		symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumSymbols.GetNext(uint symbolCount, void** symbols, out uint symbolsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbols));

		fixed (uint* __symbolsFetched_native = &symbolsFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[6])(__this, symbolCount, symbols, __symbolsFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSymbols.Skip(uint symbolCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbols));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[7])(__this, symbolCount);
	}

	[SkipLocalsInit]
	int IEnumSymbols.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbols));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[8])(__this);
	}

	[SkipLocalsInit]
	int IEnumSymbols.Clone(out IEnumSymbols enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSymbols));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[9])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__enumerator_native);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNewEnum(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbols>(__this_native).GetNewEnum(out IEnumVARIANT enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCount(ComWrappers.ComInterfaceDispatch* __this_native, int* __count_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbols>(__this_native).GetCount(out *__count_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Item(ComWrappers.ComInterfaceDispatch* __this_native, uint index, void** __symbol_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbols>(__this_native).Item(index, out ISymbol symbol);

		*__symbol_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint symbolCount, void** symbols, uint* __symbolsFetched_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbols>(__this_native).GetNext(symbolCount, symbols, out *__symbolsFetched_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint symbolCount)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbols>(__this_native).Skip(symbolCount);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Reset(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbols>(__this_native).Reset();
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSymbols>(__this_native).Clone(out IEnumSymbols enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumSymbols), sizeof(void*) * 10);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetNewEnum;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetCount;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_Item;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, uint*, int>)&ABI_GetNext;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int>)&ABI_Skip;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Reset;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;

		return vtable;
	}
}

namespace DiaSharp.SDK.Enumerators
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumSymbols
	{
	}
}