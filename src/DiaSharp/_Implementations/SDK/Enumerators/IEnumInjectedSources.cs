#pragma warning disable IDE0008, IDE0022

using DiaSharp.Interop;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([115, 37, 97, 213, 37, 105, 104, 68, 136, 131, 152, 205, 236, 140, 56, 74]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumInjectedSources
{
	[SkipLocalsInit]
	int IEnumInjectedSources.GetNewEnum(out IEnumVARIANT enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumInjectedSources));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumVARIANT>.Free(__enumerator_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumInjectedSources.GetCount(out int count)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumInjectedSources));

		fixed (int* __count_native = &count)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[4])(__this, __count_native);
		}
	}

	[SkipLocalsInit]
	int IEnumInjectedSources.Item(uint index, out IInjectedSource source)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumInjectedSources));
		void* __source_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[5])(__this, index, &__source_native);

		source = ComInterfaceMarshaller<IInjectedSource>.ConvertToManaged(__source_native)!;

		ComInterfaceMarshaller<IInjectedSource>.Free(__source_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumInjectedSources.GetNext(uint sourceCount, void** sources, out uint sourcesFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumInjectedSources));

		fixed (uint* __sourcesFetched_native = &sourcesFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[6])(__this, sourceCount, sources, __sourcesFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumInjectedSources.Skip(uint sourceCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumInjectedSources));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[7])(__this, sourceCount);
	}

	[SkipLocalsInit]
	int IEnumInjectedSources.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumInjectedSources));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[8])(__this);
	}

	[SkipLocalsInit]
	int IEnumInjectedSources.Clone(out IEnumInjectedSources enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumInjectedSources));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[9])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumInjectedSources>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumInjectedSources>.Free(__enumerator_native);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNewEnum(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumInjectedSources>(__this_native).GetNewEnum(out IEnumVARIANT enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCount(ComWrappers.ComInterfaceDispatch* __this_native, int* __count_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumInjectedSources>(__this_native).GetCount(out *__count_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Item(ComWrappers.ComInterfaceDispatch* __this_native, uint index, void** __source_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumInjectedSources>(__this_native).Item(index, out IInjectedSource source);

		*__source_native__param = ComInterfaceMarshaller<IInjectedSource>.ConvertToUnmanaged(source);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint sourceCount, void** sources, uint* __sourcesFetched_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumInjectedSources>(__this_native).GetNext(sourceCount, sources, out *__sourcesFetched_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint sourceCount)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumInjectedSources>(__this_native).Skip(sourceCount);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Reset(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumInjectedSources>(__this_native).Reset();
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumInjectedSources>(__this_native).Clone(out IEnumInjectedSources enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumInjectedSources>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumInjectedSources), sizeof(void*) * 10);

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
	public partial interface IEnumInjectedSources
	{
	}
}