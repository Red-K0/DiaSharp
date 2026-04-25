#pragma warning disable IDE0008, IDE0022

using DiaSharp.Native;
using DiaSharp.SDK;
using DiaSharp.StackWalk;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([183, 132, 145, 163, 54, 106, 222, 66, 142, 236, 125, 249, 243, 245, 159, 51]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IFrameData
{
	[SkipLocalsInit]
	int IFrameData.GetAddressSection(out uint section)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));

		fixed (uint* __section_native = &section)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __section_native);
		}
	}

	[SkipLocalsInit]
	int IFrameData.GetAddressOffset(out uint offset)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));

		fixed (uint* __offset_native = &offset)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[4])(__this, __offset_native);
		}
	}

	[SkipLocalsInit]
	int IFrameData.GetRelativeVirtualAddress(out uint relativeVirtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));

		fixed (uint* __rva_native = &relativeVirtualAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[5])(__this, __rva_native);
		}
	}

	[SkipLocalsInit]
	int IFrameData.GetVirtualAddress(out ulong virtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));

		fixed (ulong* __virtualAddress_native = &virtualAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[6])(__this, __virtualAddress_native);
		}
	}

	[SkipLocalsInit]
	int IFrameData.GetBlockLength(out uint blockLength)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));

		fixed (uint* __blockLength_native = &blockLength)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[7])(__this, __blockLength_native);
		}
	}

	[SkipLocalsInit]
	int IFrameData.GetLocalsLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));

		fixed (uint* __length_native = &length)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[8])(__this, __length_native);
		}
	}

	[SkipLocalsInit]
	int IFrameData.GetParamsLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));

		fixed (uint* __length_native = &length)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[9])(__this, __length_native);
		}
	}

	[SkipLocalsInit]
	int IFrameData.GetMaxStack(out uint maxStack)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));

		fixed (uint* __maxStack_native = &maxStack)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[10])(__this, __maxStack_native);
		}
	}

	[SkipLocalsInit]
	int IFrameData.GetPrologueLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));

		fixed (uint* __length_native = &length)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[11])(__this, __length_native);
		}
	}

	[SkipLocalsInit]
	int IFrameData.GetSavedRegistersLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));

		fixed (uint* __length_native = &length)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[12])(__this, __length_native);
		}
	}

	[SkipLocalsInit]
	int IFrameData.GetProgram(out string name)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		ushort* __name_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[13])(__this, &__name_native);

		name = BStrStringMarshaller.ConvertToManaged(__name_native)!;

		BStrStringMarshaller.Free(__name_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetSystemExceptionHandling(out bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		int __enabled_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[14])(__this, &__enabled_native);

		enabled = __enabled_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetCppExceptionHandling(out bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		int __enabled_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[15])(__this, &__enabled_native);

		enabled = __enabled_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetIsFunctionStart(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[16])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetAllocatesBasePointer(out bool allocates)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		int __allocates_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[17])(__this, &__allocates_native);

		allocates = __allocates_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetFrameType(out StackFrameType type)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));

		fixed (StackFrameType* __type_native = &type)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, StackFrameType*, int>)__vtable_native[18])(__this, __type_native);
		}
	}

	[SkipLocalsInit]
	int IFrameData.GetFunctionParent(out IFrameData parentData)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		void* __parentData_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[19])(__this, &__parentData_native);

		parentData = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__parentData_native)!;

		ComInterfaceMarshaller<IFrameData>.Free(__parentData_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.Execute(IStackWalkFrame stackFrame)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));

		void* __stackFrame_native = ComInterfaceMarshaller<IStackWalkFrame>.ConvertToUnmanaged(stackFrame);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, int>)__vtable_native[20])(__this, __stackFrame_native);

		ComInterfaceMarshaller<IStackWalkFrame>.Free(__stackFrame_native);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAddressSection(ComWrappers.ComInterfaceDispatch* __this_native, uint* __section_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetAddressSection(out *__section_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAddressOffset(ComWrappers.ComInterfaceDispatch* __this_native, uint* __offset_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetAddressOffset(out *__offset_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRelativeVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __rva_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetRelativeVirtualAddress(out *__rva_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __virtualAddress_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetVirtualAddress(out *__virtualAddress_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBlockLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __blockLength_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetBlockLength(out *__blockLength_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLocalsLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetLocalsLength(out *__length_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetParamsLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetParamsLength(out *__length_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetMaxStack(ComWrappers.ComInterfaceDispatch* __this_native, uint* __maxStack_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetMaxStack(out *__maxStack_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetPrologueLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetPrologueLength(out *__length_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSavedRegistersLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetSavedRegistersLength(out *__length_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetProgram(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __name_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetProgram(out string name);

		*__name_native__param = BStrStringMarshaller.ConvertToUnmanaged(name);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSystemExceptionHandling(ComWrappers.ComInterfaceDispatch* __this_native, int* __enabled_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetSystemExceptionHandling(out bool enabled);

		*__enabled_native__param = enabled ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCppExceptionHandling(ComWrappers.ComInterfaceDispatch* __this_native, int* __enabled_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetCppExceptionHandling(out bool enabled);

		*__enabled_native__param = enabled ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsFunctionStart(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetIsFunctionStart(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAllocatesBasePointer(ComWrappers.ComInterfaceDispatch* __this_native, int* __allocates_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetAllocatesBasePointer(out bool allocates);

		*__allocates_native__param = allocates ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFrameType(ComWrappers.ComInterfaceDispatch* __this_native, StackFrameType* __type_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetFrameType(out *__type_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFunctionParent(ComWrappers.ComInterfaceDispatch* __this_native, void** __parentData_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).GetFunctionParent(out IFrameData parentData);

		*__parentData_native__param = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(parentData);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Execute(ComWrappers.ComInterfaceDispatch* __this_native, void* __stackFrame_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native).Execute(ComInterfaceMarshaller<IStackWalkFrame>.ConvertToManaged(__stackFrame_native)!);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IFrameData), sizeof(void*) * 21);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetAddressSection;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetAddressOffset;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetRelativeVirtualAddress;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetVirtualAddress;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetBlockLength;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLocalsLength;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetParamsLength;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetMaxStack;
		vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetPrologueLength;
		vtable[12] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetSavedRegistersLength;
		vtable[13] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetProgram;
		vtable[14] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetSystemExceptionHandling;
		vtable[15] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetCppExceptionHandling;
		vtable[16] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsFunctionStart;
		vtable[17] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetAllocatesBasePointer;
		vtable[18] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, StackFrameType*, int>)&ABI_GetFrameType;
		vtable[19] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetFunctionParent;
		vtable[20] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, int>)&ABI_Execute;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IFrameData
	{
	}
}