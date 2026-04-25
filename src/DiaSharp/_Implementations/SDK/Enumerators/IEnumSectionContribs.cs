#pragma warning disable IDE0008, IDE0022

using DiaSharp.Interop;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([178, 222, 148, 25, 130, 44, 29, 75, 165, 127, 175, 244, 36, 213, 74, 104]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumSectionContribs
{
	[SkipLocalsInit]
	int IEnumSectionContribs.GetNewEnum(out IEnumVARIANT enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSectionContribs));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumVARIANT>.Free(__enumerator_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumSectionContribs.GetCount(out int count)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSectionContribs));

		fixed (int* __count_native = &count)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[4])(__this, __count_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSectionContribs.Item(uint index, out ISectionContrib contrib)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSectionContribs));
		void* __contrib_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[5])(__this, index, &__contrib_native);

		contrib = ComInterfaceMarshaller<ISectionContrib>.ConvertToManaged(__contrib_native)!;

		ComInterfaceMarshaller<ISectionContrib>.Free(__contrib_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumSectionContribs.GetNext(uint contribCount, void** contribs, out uint contribsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSectionContribs));

		fixed (uint* __contribsFetched_native = &contribsFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[6])(__this, contribCount, contribs, __contribsFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSectionContribs.Skip(uint contribCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSectionContribs));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[7])(__this, contribCount);
	}

	[SkipLocalsInit]
	int IEnumSectionContribs.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSectionContribs));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[8])(__this);
	}

	[SkipLocalsInit]
	int IEnumSectionContribs.Clone(out IEnumSectionContribs enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSectionContribs));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[9])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumSectionContribs>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumSectionContribs>.Free(__enumerator_native);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNewEnum(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSectionContribs>(__this_native).GetNewEnum(out IEnumVARIANT enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCount(ComWrappers.ComInterfaceDispatch* __this_native, int* __count_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSectionContribs>(__this_native).GetCount(out *__count_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Item(ComWrappers.ComInterfaceDispatch* __this_native, uint index, void** __contrib_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSectionContribs>(__this_native).Item(index, out ISectionContrib contrib);

		*__contrib_native__param = ComInterfaceMarshaller<ISectionContrib>.ConvertToUnmanaged(contrib);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint contribCount, void** contribs, uint* __contribsFetched_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSectionContribs>(__this_native).GetNext(contribCount, contribs, out *__contribsFetched_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint contribCount)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSectionContribs>(__this_native).Skip(contribCount);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Reset(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSectionContribs>(__this_native).Reset();
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSectionContribs>(__this_native).Clone(out IEnumSectionContribs enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumSectionContribs>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumSectionContribs), sizeof(void*) * 10);

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
	public partial interface IEnumSectionContribs
	{
	}
}