#pragma warning disable IDE0008, IDE0022

using DiaSharp.Storage;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([57, 1, 0, 0, 0, 0, 0, 0, 192, 0, 0, 0, 0, 0, 0, 70]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumStatPropertyStorage
{
	[SkipLocalsInit]
	int IEnumStatPropertyStorage.Clone(out IEnumStatPropertyStorage enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumStatPropertyStorage));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumStatPropertyStorage>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumStatPropertyStorage>.Free(__enumerator_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumStatPropertyStorage.GetNext(uint propertyCount, StatPropertyStorage* properties, out uint propertiesWritten)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumStatPropertyStorage));

		fixed (uint* __propertiesWritten_native = &propertiesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, StatPropertyStorage*, uint*, int>)__vtable_native[4])(__this, propertyCount, properties, __propertiesWritten_native);
		}
	}

	[SkipLocalsInit]
	int IEnumStatPropertyStorage.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumStatPropertyStorage));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[5])(__this);
	}

	[SkipLocalsInit]
	int IEnumStatPropertyStorage.Skip(uint propertyCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumStatPropertyStorage));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[6])(__this, propertyCount);
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumStatPropertyStorage>(__this_native).Clone(out IEnumStatPropertyStorage enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumStatPropertyStorage>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint propertyCount, StatPropertyStorage* properties, uint* __propertiesWritten_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumStatPropertyStorage>(__this_native).GetNext(propertyCount, properties, out *__propertiesWritten_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Reset(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumStatPropertyStorage>(__this_native).Reset();
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint propertyCount)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumStatPropertyStorage>(__this_native).Skip(propertyCount);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumStatPropertyStorage), sizeof(void*) * 7);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, StatPropertyStorage*, uint*, int>)&ABI_GetNext;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Reset;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int>)&ABI_Skip;

		return vtable;
	}
}

namespace DiaSharp.Storage
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumStatPropertyStorage
	{
	}
}