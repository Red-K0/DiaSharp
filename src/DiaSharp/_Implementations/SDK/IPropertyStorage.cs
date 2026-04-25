#pragma warning disable IDE0008, IDE0022

using DiaSharp.SDK;
using DiaSharp.Storage;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([156, 111, 65, 157, 132, 225, 178, 69, 164, 240, 206, 81, 127, 113, 158, 155]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IPropertyStorage
{
	[SkipLocalsInit]
	int IPropertyStorage.ReadMultiple(uint specifierCount, PropertySpecifier* specifiers, out void* propVariant)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));

		fixed (void** __propVariant_native = &propVariant)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, PropertySpecifier*, void**, int>)__vtable_native[3])(__this, specifierCount, specifiers, __propVariant_native);
		}
	}

	[SkipLocalsInit]
	int IPropertyStorage.ReadPropertyNames(uint propertyIDCount, uint* propertyIDs, out string[] names)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));
		nint* __names_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, nint**, int>)__vtable_native[4])(__this, propertyIDCount, propertyIDs, &__names_native);

		names = ArrayMarshaller<string, nint>.AllocateContainerForManagedElements(__names_native, (int)propertyIDCount)!;

		ReadOnlySpan<nint> __names_native__nativeSpan = ArrayMarshaller<string, nint>.GetUnmanagedValuesSource(__names_native, (int)propertyIDCount);

		Span<string> __names_native__managedSpan = ArrayMarshaller<string, nint>.GetManagedValuesDestination(names);

		for (int i = 0; i < (int)propertyIDCount; i++)
		{
			__names_native__managedSpan[i] = BStrStringMarshaller.ConvertToManaged((ushort*)__names_native__nativeSpan[i])!;

			BStrStringMarshaller.Free((ushort*)__names_native__nativeSpan[i]);
		}

		ArrayMarshaller<string, nint>.Free(__names_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IPropertyStorage.GetEnum(out IEnumStatPropertyStorage enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[5])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumStatPropertyStorage>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumStatPropertyStorage>.Free(__enumerator_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IPropertyStorage.ReadUint(uint id, out uint value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));

		fixed (uint* __value_native = &value)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, int>)__vtable_native[6])(__this, id, __value_native);
		}
	}

	[SkipLocalsInit]
	int IPropertyStorage.ReadInt(out int value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));

		fixed (int* __value_native = &value)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[7])(__this, __value_native);
		}
	}

	[SkipLocalsInit]
	int IPropertyStorage.ReadBool(uint id, out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, int*, int>)__vtable_native[8])(__this, id, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int IPropertyStorage.ReadUlong(uint id, out ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));

		fixed (ulong* __value_native = &value)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, ulong*, int>)__vtable_native[9])(__this, id, __value_native);
		}
	}

	[SkipLocalsInit]
	int IPropertyStorage.ReadBStr(uint id, out string value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));
		ushort* __value_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, ushort**, int>)__vtable_native[10])(__this, id, &__value_native);

		value = BStrStringMarshaller.ConvertToManaged(__value_native)!;

		BStrStringMarshaller.Free(__value_native);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_ReadMultiple(ComWrappers.ComInterfaceDispatch* __this_native, uint specifierCount, PropertySpecifier* specifiers, void** __propVariant_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native).ReadMultiple(specifierCount, specifiers, out *__propVariant_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_ReadPropertyNames(ComWrappers.ComInterfaceDispatch* __this_native, uint propertyIDCount, uint* propertyIDs, nint** __names_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native).ReadPropertyNames(propertyIDCount, propertyIDs, out string[] names);

		*__names_native__param = ArrayMarshaller<string, nint>.AllocateContainerForUnmanagedElements(names, out int __names_native__numElements);

		ReadOnlySpan<string> __names_native__managedSpan = ArrayMarshaller<string, nint>.GetManagedValuesSource(names);

		Span<nint> __names_native__nativeSpan = ArrayMarshaller<string, nint>.GetUnmanagedValuesDestination(*__names_native__param, __names_native__numElements);

		__names_native__nativeSpan.Clear();

		for (int i = 0; i < __names_native__managedSpan.Length; i++)
		{
			__names_native__nativeSpan[i] = (nint)BStrStringMarshaller.ConvertToUnmanaged(__names_native__managedSpan[i]);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetEnum(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native).GetEnum(out IEnumStatPropertyStorage enumerator);

		*__enumerator_native__param = ComInterfaceMarshaller<IEnumStatPropertyStorage>.ConvertToUnmanaged(enumerator);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_ReadUint(ComWrappers.ComInterfaceDispatch* __this_native, uint id, uint* __value_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native).ReadUint(id, out *__value_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_ReadInt(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native).ReadInt(out *__value_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_ReadBool(ComWrappers.ComInterfaceDispatch* __this_native, uint id, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native).ReadBool(id, out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_ReadUlong(ComWrappers.ComInterfaceDispatch* __this_native, uint id, ulong* __value_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native).ReadUlong(id, out *__value_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_ReadBStr(ComWrappers.ComInterfaceDispatch* __this_native, uint id, ushort** __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native).ReadBStr(id, out string value);

		*__value_native__param = BStrStringMarshaller.ConvertToUnmanaged(value);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IPropertyStorage), sizeof(void*) * 11);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, PropertySpecifier*, void**, int>)&ABI_ReadMultiple;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, nint**, int>)&ABI_ReadPropertyNames;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetEnum;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, int>)&ABI_ReadUint;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_ReadInt;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int*, int>)&ABI_ReadBool;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, ulong*, int>)&ABI_ReadUlong;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, ushort**, int>)&ABI_ReadBStr;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IPropertyStorage
	{
	}
}