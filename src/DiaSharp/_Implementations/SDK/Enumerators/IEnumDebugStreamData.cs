#pragma warning disable IDE0008, IDE0022

using DiaSharp.Interop;
using DiaSharp.SDK.Enumerators;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([232, 67, 105, 72, 135, 209, 107, 74, 163, 196, 41, 18, 89, 255, 246, 13]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumDebugStreamData
{
	[SkipLocalsInit]
	int IEnumDebugStreamData.GetNewEnum(out IEnumVARIANT enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreamData));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumVARIANT>.Free(__enumerator_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumDebugStreamData.GetCount(out int count)
	{
		var (__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreamData));

		fixed (int* __count_native = &count)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[4])(__this, __count_native);
		}
	}

	[SkipLocalsInit]
	int IEnumDebugStreamData.GetName(out string name)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreamData));
		ushort* __name_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[5])(__this, &__name_native);

		name = BStrStringMarshaller.ConvertToManaged(__name_native)!;

		BStrStringMarshaller.Free(__name_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumDebugStreamData.Item(uint index, uint bufferSize, uint* bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreamData));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint*, byte*, int>)__vtable_native[6])(__this, index, bufferSize, bytesWritten, buffer);
	}

	[SkipLocalsInit]
	int IEnumDebugStreamData.GetNext(uint dataCount, uint bufferSize, out uint bytesWritten, byte* dataBuffer, out uint elementsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreamData));

		fixed(uint* __elementsFetched_native = &elementsFetched)
		fixed(uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint*, byte*, uint*, int>)__vtable_native[7])(__this, dataCount, bufferSize, __bytesWritten_native, dataBuffer, __elementsFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumDebugStreamData.Skip(uint dataCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreamData));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[8])(__this, dataCount);
	}

	[SkipLocalsInit]
	int IEnumDebugStreamData.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreamData));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[9])(__this);
	}

	[SkipLocalsInit]
	int IEnumDebugStreamData.Clone(out IEnumDebugStreamData enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreamData));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[10])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumDebugStreamData>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumDebugStreamData>.Free(__enumerator_native);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNewEnum(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreamData>(__this_native).GetNewEnum(out IEnumVARIANT enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCount(ComWrappers.ComInterfaceDispatch* __this_native, int* __count_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreamData>(__this_native).GetCount(out *__count_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __name_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreamData>(__this_native).GetName(out string name);

		*__name_native__param = BStrStringMarshaller.ConvertToUnmanaged(name);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Item(ComWrappers.ComInterfaceDispatch* __this_native, uint index, uint bufferSize, uint* bytesWritten, byte* buffer)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreamData>(__this_native).Item(index, bufferSize, bytesWritten, buffer);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint dataCount, uint bufferSize, uint* __bytesWritten_native__param, byte* dataBuffer, uint* __elementsFetched_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreamData>(__this_native).GetNext(dataCount, bufferSize, out *__bytesWritten_native__param, dataBuffer, out *__elementsFetched_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint dataCount)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreamData>(__this_native).Skip(dataCount);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Reset(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreamData>(__this_native).Reset();
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreamData>(__this_native).Clone(out IEnumDebugStreamData enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumDebugStreamData>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumDebugStreamData), sizeof(void*) * 11);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetNewEnum;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetCount;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetName;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, uint*, byte*, int>)&ABI_Item;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, uint*, byte*, uint*, int>)&ABI_GetNext;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int>)&ABI_Skip;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Reset;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;

		return vtable;
	}
}

namespace DiaSharp.SDK.Enumerators
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumDebugStreamData
	{
	}
}