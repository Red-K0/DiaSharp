#pragma warning disable IDE0008, IDE0022

using DiaSharp.Interop;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([4, 4, 2, 0, 0, 0, 0, 0, 192, 0, 0, 0, 0, 0, 0, 70]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumVARIANT
{
	[SkipLocalsInit]
	int IEnumVARIANT.Clone(out IEnumVARIANT enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumVARIANT));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumVARIANT>.Free(__enumerator_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumVARIANT.GetNext(uint elementCount, void** elements, out uint elementsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumVARIANT));

		fixed (uint* __elementsFetched_native = &elementsFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[4])(__this, elementCount, elements, __elementsFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumVARIANT.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumVARIANT));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[5])(__this);
	}

	[SkipLocalsInit]
	int IEnumVARIANT.Skip(uint elementCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumVARIANT));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[6])(__this, elementCount);
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumVARIANT>(__this_native).Clone(out IEnumVARIANT enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint elementCount, void** elements, uint* __elementsFetched_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumVARIANT>(__this_native).GetNext(elementCount, elements, out *__elementsFetched_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Reset(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumVARIANT>(__this_native).Reset();
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint elementCount)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumVARIANT>(__this_native).Skip(elementCount);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumVARIANT), sizeof(void*) * 7);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, uint*, int>)&ABI_GetNext;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Reset;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int>)&ABI_Skip;

		return vtable;
	}
}

namespace DiaSharp.Interop
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumVARIANT
	{
	}
}