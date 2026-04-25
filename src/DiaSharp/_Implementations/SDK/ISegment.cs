#pragma warning disable IDE0008, IDE0022

using DiaSharp.SDK;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([132, 183, 117, 7, 91, 199, 73, 68, 132, 139, 183, 189, 49, 89, 84, 91]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ISegment
{
	[SkipLocalsInit]
	int ISegment.GetFrame(out uint frame)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISegment));

		fixed (uint* __frame_native = &frame)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __frame_native);
		}
	}

	[SkipLocalsInit]
	int ISegment.GetOffset(out uint offset)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISegment));

		fixed (uint* __offset_native = &offset)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[4])(__this, __offset_native);
		}
	}

	[SkipLocalsInit]
	int ISegment.GetLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISegment));

		fixed (uint* __length_native = &length)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[5])(__this, __length_native);
		}
	}

	[SkipLocalsInit]
	int ISegment.GetRead(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISegment));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[6])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISegment.GetWrite(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISegment));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[7])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISegment.GetExecute(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISegment));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[8])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISegment.GetAddressSection(out uint section)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISegment));

		fixed (uint* __section_native = &section)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[9])(__this, __section_native);
		}
	}

	[SkipLocalsInit]
	int ISegment.GetRelativeVirtualAddress(out uint relativeVirtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISegment));

		fixed (uint* __rva_native = &relativeVirtualAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[10])(__this, __rva_native);
		}
	}

	[SkipLocalsInit]
	int ISegment.GetVirtualAddress(out ulong virtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISegment));

		fixed (ulong* __va_native = &virtualAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[11])(__this, __va_native);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFrame(ComWrappers.ComInterfaceDispatch* __this_native, uint* __frame_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISegment>(__this_native).GetFrame(out *__frame_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetOffset(ComWrappers.ComInterfaceDispatch* __this_native, uint* __offset_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISegment>(__this_native).GetOffset(out *__offset_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISegment>(__this_native).GetLength(out *__length_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRead(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISegment>(__this_native).GetRead(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetWrite(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISegment>(__this_native).GetWrite(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetExecute(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISegment>(__this_native).GetExecute(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAddressSection(ComWrappers.ComInterfaceDispatch* __this_native, uint* __section_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISegment>(__this_native).GetAddressSection(out *__section_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRelativeVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __rva_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISegment>(__this_native).GetRelativeVirtualAddress(out *__rva_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __va_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISegment>(__this_native).GetVirtualAddress(out *__va_native__param);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ISegment), sizeof(void*) * 12);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetFrame;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetOffset;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLength;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetRead;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetWrite;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetExecute;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetAddressSection;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetRelativeVirtualAddress;
		vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetVirtualAddress;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface ISegment
	{
	}
}