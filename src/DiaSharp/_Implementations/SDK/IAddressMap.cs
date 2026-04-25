#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.Native;
using DiaSharp.SDK;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([122, 46, 42, 182, 122, 6, 163, 78, 181, 152, 4, 192, 151, 23, 80, 44]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IAddressMap
{
	[SkipLocalsInit]
	int IAddressMap.GetIsAddressMapEnabled(out bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));
		int __enabled_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[3])(__this, &__enabled_native);

		enabled = __enabled_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int IAddressMap.SetIsAddressMapEnabled(bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));

		return ((delegate* unmanaged[MemberFunction]<void*, int, int>)__vtable_native[4])(__this, enabled ? 1 : 0);
	}

	[SkipLocalsInit]
	int IAddressMap.GetIsRelativeVirtualAddressEnabled(out bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));
		int __enabled_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[5])(__this, &__enabled_native);

		enabled = __enabled_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int IAddressMap.SetIsRelativeVirtualAddressEnabled(bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));

		return ((delegate* unmanaged[MemberFunction]<void*, int, int>)__vtable_native[6])(__this, enabled ? 1 : 0);
	}

	[SkipLocalsInit]
	int IAddressMap.GetImageAlignment(out uint alignment)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));

		fixed (uint* __alignment_native = &alignment)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[7])(__this, __alignment_native);
		}
	}

	[SkipLocalsInit]
	int IAddressMap.SetImageAlignment(uint value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[8])(__this, value);
	}

	[SkipLocalsInit]
	int IAddressMap.SetImageHeaders(uint dataSize, ImageSectionHeader* data, bool originalHeaders)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, ImageSectionHeader*, int, int>)__vtable_native[9])(__this, dataSize, data, originalHeaders ? 1 : 0);
	}

	[SkipLocalsInit]
	int IAddressMap.SetAddressMap(uint dataSize, AddressMapEntry* data, bool imageToSymbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, AddressMapEntry*, int, int>)__vtable_native[10])(__this, dataSize, data, imageToSymbols ? 1 : 0);
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsAddressMapEnabled(ComWrappers.ComInterfaceDispatch* __this_native, int* __enabled_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native).GetIsAddressMapEnabled(out bool enabled);

			*__enabled_native__param = enabled ? 1 : 0;

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_SetIsAddressMapEnabled(ComWrappers.ComInterfaceDispatch* __this_native, int __enabled_native)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native).SetIsAddressMapEnabled(__enabled_native != 0);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsRelativeVirtualAddressEnabled(ComWrappers.ComInterfaceDispatch* __this_native, int* __enabled_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native).GetIsRelativeVirtualAddressEnabled(out bool enabled);

			*__enabled_native__param = enabled ? 1 : 0;

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_SetIsRelativeVirtualAddressEnabled(ComWrappers.ComInterfaceDispatch* __this_native, int __enabled_native)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native).SetIsRelativeVirtualAddressEnabled(__enabled_native != 0);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetImageAlignment(ComWrappers.ComInterfaceDispatch* __this_native, uint* __alignment_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native).GetImageAlignment(out *__alignment_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_SetImageAlignment(ComWrappers.ComInterfaceDispatch* __this_native, uint value)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native).SetImageAlignment(value);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_SetImageHeaders(ComWrappers.ComInterfaceDispatch* __this_native, uint dataSize, ImageSectionHeader* data, int __originalHeaders_native)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native).SetImageHeaders(dataSize, data, __originalHeaders_native != 0);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_SetAddressMap(ComWrappers.ComInterfaceDispatch* __this_native, uint dataSize, AddressMapEntry* data, int __imageToSymbols_native)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native).SetAddressMap(dataSize, data, __imageToSymbols_native != 0);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IAddressMap), sizeof(void*) * 11);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsAddressMapEnabled;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int, int>)&ABI_SetIsAddressMapEnabled;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsRelativeVirtualAddressEnabled;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int, int>)&ABI_SetIsRelativeVirtualAddressEnabled;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetImageAlignment;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int>)&ABI_SetImageAlignment;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, ImageSectionHeader*, int, int>)&ABI_SetImageHeaders;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, AddressMapEntry*, int, int>)&ABI_SetAddressMap;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IAddressMap
	{
	}
}