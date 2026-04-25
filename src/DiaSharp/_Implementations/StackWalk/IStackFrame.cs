#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.CodeView;
using DiaSharp.Native;
using DiaSharp.StackWalk;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([109, 201, 219, 94, 214, 205, 146, 71, 175, 190, 204, 137, 0, 125, 150, 16]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IStackFrame
{
	[SkipLocalsInit]
	int IStackFrame.GetAllocatesBasePointer(out bool allocates)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		int __allocates_native;

		int __retVal =((delegate * unmanaged[MemberFunction] < void *, int *, int >) __vtable_native[3])(__this, & __allocates_native);

		allocates = __allocates_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetBase(out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));

		fixed (ulong* __address_native = &address)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[4])(__this, __address_native);
		}
	}

	[SkipLocalsInit]
	int IStackFrame.GetCppExceptionHandling(out bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		int __enabled_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[5])(__this, &__enabled_native);

		enabled = __enabled_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetHasFunctionStart(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[6])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetLocalsLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));

		fixed (uint* __length_native = &length)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[7])(__this, __length_native);
		}
	}

	[SkipLocalsInit]
	int IStackFrame.GetParamsLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));

		fixed (uint* __length_native = &length)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[8])(__this, __length_native);
		}
	}

	[SkipLocalsInit]
	int IStackFrame.GetPrologueLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));

		fixed (uint* __length_native = &length)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[9])(__this, __length_native);
		}
	}

	[SkipLocalsInit]
	int IStackFrame.GetSavedRegistersLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));

		fixed (uint* __length_native = &length)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[10])(__this, __length_native);
		}
	}

	[SkipLocalsInit]
	int IStackFrame.GetLocalsBase(out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));

		fixed (ulong* __address_native = &address)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[11])(__this, __address_native);
		}
	}

	[SkipLocalsInit]
	int IStackFrame.GetMaxStack(out uint maxStack)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));

		fixed (uint* __maxStack_native = &maxStack)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[12])(__this, __maxStack_native);
		}
	}

	[SkipLocalsInit]
	int IStackFrame.GetRawLVarInstanceValue(void* instance, uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, void*, uint, uint*, byte*, int>)__vtable_native[13])(__this, instance, bufferSize, __bytesWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int IStackFrame.GetRegisterValue(HostRegister index, out ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));

		fixed (ulong* __value_native = &value)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, HostRegister, ulong*, int>)__vtable_native[14])(__this, index, __value_native);
		}
	}

	[SkipLocalsInit]
	int IStackFrame.GetReturnAddress(out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));

		fixed (ulong* __address_native = &address)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[15])(__this, __address_native);
		}
	}

	[SkipLocalsInit]
	int IStackFrame.GetSize(out uint size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));

		fixed (uint* __size_native = &size)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[16])(__this, __size_native);
		}
	}

	[SkipLocalsInit]
	int IStackFrame.GetSystemExceptionHandling(out bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		int __enabled_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[17])(__this, &__enabled_native);

		enabled = __enabled_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetFrameType(out StackFrameType type)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));

		fixed (StackFrameType* __type_native = &type)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, StackFrameType*, int>)__vtable_native[18])(__this, __type_native);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAllocatesBasePointer(ComWrappers.ComInterfaceDispatch* __this_native, int* __allocates_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetAllocatesBasePointer(out bool allocates);

			*__allocates_native__param = allocates ? 1 : 0;

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBase(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __address_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetBase(out *__address_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCppExceptionHandling(ComWrappers.ComInterfaceDispatch* __this_native, int* __enabled_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetCppExceptionHandling(out bool enabled);

			*__enabled_native__param = enabled ? 1 : 0;

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasFunctionStart(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetHasFunctionStart(out bool value);

			*__value_native__param = value ? 1 : 0;

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLocalsLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetLocalsLength(out *__length_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetParamsLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetParamsLength(out *__length_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetPrologueLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetPrologueLength(out *__length_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSavedRegistersLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetSavedRegistersLength(out *__length_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLocalsBase(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __address_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetLocalsBase(out *__address_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetMaxStack(ComWrappers.ComInterfaceDispatch* __this_native, uint* __maxStack_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetMaxStack(out *__maxStack_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRawLVarInstanceValue(ComWrappers.ComInterfaceDispatch* __this_native, void* instance, uint bufferSize, uint* __bytesWritten_native__param, byte* buffer)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetRawLVarInstanceValue(instance, bufferSize, out *__bytesWritten_native__param, buffer);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRegisterValue(ComWrappers.ComInterfaceDispatch* __this_native, HostRegister index, ulong* __value_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetRegisterValue(index, out *__value_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetReturnAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __address_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetReturnAddress(out *__address_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSize(ComWrappers.ComInterfaceDispatch* __this_native, uint* __size_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetSize(out *__size_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSystemExceptionHandling(ComWrappers.ComInterfaceDispatch* __this_native, int* __enabled_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetSystemExceptionHandling(out bool enabled);

			*__enabled_native__param = enabled ? 1 : 0;

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFrameType(ComWrappers.ComInterfaceDispatch* __this_native, StackFrameType* __type_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native).GetFrameType(out *__type_native__param);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IStackFrame), sizeof(void*) * 19);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetAllocatesBasePointer;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetBase;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetCppExceptionHandling;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasFunctionStart;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLocalsLength;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetParamsLength;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetPrologueLength;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetSavedRegistersLength;
		vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetLocalsBase;
		vtable[12] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetMaxStack;
		vtable[13] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, uint, uint*, byte*, int>)&ABI_GetRawLVarInstanceValue;
		vtable[14] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, HostRegister, ulong*, int>)&ABI_GetRegisterValue;
		vtable[15] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetReturnAddress;
		vtable[16] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetSize;
		vtable[17] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetSystemExceptionHandling;
		vtable[18] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, StackFrameType*, int>)&ABI_GetFrameType;

		return vtable;
	}
}

namespace DiaSharp.StackWalk
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IStackFrame
	{
	}
}