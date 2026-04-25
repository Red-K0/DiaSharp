#pragma warning disable IDE0008, IDE0022

using DiaSharp.Interop;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([75, 122, 199, 159, 28, 60, 237, 68, 167, 152, 108, 29, 238, 165, 62, 31]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumFrameData
{
	[SkipLocalsInit]
	int IEnumFrameData.GetNewEnum(out IEnumVARIANT enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumVARIANT>.Free(__enumerator_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumFrameData.GetCount(out int count)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));

		fixed (int* __count_native = &count)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[4])(__this, __count_native);
		}
	}

	[SkipLocalsInit]
	int IEnumFrameData.Item(uint index, out IFrameData frameData)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		void* __frameData_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[5])(__this, index, &__frameData_native);

		frameData = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frameData_native)!;

		ComInterfaceMarshaller<IFrameData>.Free(__frameData_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumFrameData.GetNext(uint frameCount, void** frames, out uint framesFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));

		fixed (uint* __framesFetched_native = &framesFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[6])(__this, frameCount, frames, __framesFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumFrameData.Skip(uint dataCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[7])(__this, dataCount);
	}

	[SkipLocalsInit]
	int IEnumFrameData.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[8])(__this);
	}

	[SkipLocalsInit]
	int IEnumFrameData.Clone(out IEnumFrameData enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[9])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumFrameData>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumFrameData>.Free(__enumerator_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumFrameData.FrameByRVA(uint relativeVirtualAddress, out IFrameData frameData)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		void* __frameData_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[10])(__this, relativeVirtualAddress, &__frameData_native);

		frameData = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frameData_native)!;

		ComInterfaceMarshaller<IFrameData>.Free(__frameData_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumFrameData.FrameByVA(ulong virtualAddress, out IFrameData frameData)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		void* __frameData_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, void**, int>)__vtable_native[11])(__this, virtualAddress, &__frameData_native);

		frameData = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frameData_native)!;

		ComInterfaceMarshaller<IFrameData>.Free(__frameData_native);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNewEnum(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native).GetNewEnum(out IEnumVARIANT enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCount(ComWrappers.ComInterfaceDispatch* __this_native, int* __count_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native).GetCount(out *__count_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Item(ComWrappers.ComInterfaceDispatch* __this_native, uint index, void** __frameData_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native).Item(index, out IFrameData frameData);

		*__frameData_native__param = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frameData);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint frameCount, void** frames, uint* __framesFetched_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native).GetNext(frameCount, frames, out *__framesFetched_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint dataCount)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native).Skip(dataCount);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Reset(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native).Reset();
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native).Clone(out IEnumFrameData enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumFrameData>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FrameByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, void** __frameData_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native).FrameByRVA(relativeVirtualAddress, out IFrameData frameData);

		*__frameData_native__param = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frameData);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FrameByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, void** __frameData_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native).FrameByVA(virtualAddress, out IFrameData frameData);

		*__frameData_native__param = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frameData);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumFrameData), sizeof(void*) * 12);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetNewEnum;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetCount;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_Item;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, uint*, int>)&ABI_GetNext;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int>)&ABI_Skip;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Reset;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_FrameByRVA;
		vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, void**, int>)&ABI_FrameByVA;

		return vtable;
	}
}

namespace DiaSharp.SDK.Enumerators
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumFrameData
	{
	}
}