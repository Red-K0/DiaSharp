#pragma warning disable CS0612, CS0618, IDE0008
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
		Unsafe.SkipInit(out allocates);
		int __allocates_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[3])(__this, &__allocates_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		allocates = __allocates_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetBase(out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out address);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __address_native = &address)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[4])(__this, __address_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetCppExceptionHandling(out bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out enabled);
		int __enabled_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[5])(__this, &__enabled_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		enabled = __enabled_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetHasFunctionStart(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[6])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetLocalsLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out length);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __length_native = &length)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[7])(__this, __length_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetParamsLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out length);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __length_native = &length)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[8])(__this, __length_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetPrologueLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out length);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __length_native = &length)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[9])(__this, __length_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetSavedRegistersLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out length);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __length_native = &length)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[10])(__this, __length_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetLocalsBase(out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out address);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __address_native = &address)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[11])(__this, __address_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetMaxStack(out uint maxStack)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out maxStack);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __maxStack_native = &maxStack)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[12])(__this, __maxStack_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetRawLVarInstanceValue(void* instance, uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out bytesWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, uint, uint*, byte*, int>)__vtable_native[13])(__this, instance, bufferSize, __bytesWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetRegisterValue(HostRegister index, out ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out value);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __value_native = &value)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, HostRegister, ulong*, int>)__vtable_native[14])(__this, index, __value_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetReturnAddress(out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out address);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __address_native = &address)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[15])(__this, __address_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetSize(out uint size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out size);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __size_native = &size)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[16])(__this, __size_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetSystemExceptionHandling(out bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out enabled);
		int __enabled_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[17])(__this, &__enabled_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		enabled = __enabled_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackFrame.GetFrameType(out StackFrameType type)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackFrame));
		Unsafe.SkipInit(out type);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (StackFrameType* __type_native = &type)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, StackFrameType*, int>)__vtable_native[18])(__this, __type_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetAllocatesBasePointer(ComWrappers.ComInterfaceDispatch* __this_native, int* __allocates_native__param)
	{
		IStackFrame @this = default!;
		ref int __allocates_native = ref *__allocates_native__param;
		bool allocates = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetAllocatesBasePointer(out allocates);
			// Marshal - Convert managed data to native data.
			__allocates_native = allocates ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetBase(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __address_native__param)
	{
		IStackFrame @this = default!;
		ref ulong __address_native = ref *__address_native__param;
		ulong address = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetBase(out address);
			// Marshal - Convert managed data to native data.
			__address_native = address;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetCppExceptionHandling(ComWrappers.ComInterfaceDispatch* __this_native, int* __enabled_native__param)
	{
		IStackFrame @this = default!;
		ref int __enabled_native = ref *__enabled_native__param;
		bool enabled = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetCppExceptionHandling(out enabled);
			// Marshal - Convert managed data to native data.
			__enabled_native = enabled ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetHasFunctionStart(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		IStackFrame @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetHasFunctionStart(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetLocalsLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		IStackFrame @this = default!;
		ref uint __length_native = ref *__length_native__param;
		uint length = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetLocalsLength(out length);
			// Marshal - Convert managed data to native data.
			__length_native = length;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetParamsLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		IStackFrame @this = default!;
		ref uint __length_native = ref *__length_native__param;
		uint length = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetParamsLength(out length);
			// Marshal - Convert managed data to native data.
			__length_native = length;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetPrologueLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		IStackFrame @this = default!;
		ref uint __length_native = ref *__length_native__param;
		uint length = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetPrologueLength(out length);
			// Marshal - Convert managed data to native data.
			__length_native = length;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetSavedRegistersLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		IStackFrame @this = default!;
		ref uint __length_native = ref *__length_native__param;
		uint length = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetSavedRegistersLength(out length);
			// Marshal - Convert managed data to native data.
			__length_native = length;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetLocalsBase(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __address_native__param)
	{
		IStackFrame @this = default!;
		ref ulong __address_native = ref *__address_native__param;
		ulong address = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetLocalsBase(out address);
			// Marshal - Convert managed data to native data.
			__address_native = address;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetMaxStack(ComWrappers.ComInterfaceDispatch* __this_native, uint* __maxStack_native__param)
	{
		IStackFrame @this = default!;
		ref uint __maxStack_native = ref *__maxStack_native__param;
		uint maxStack = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetMaxStack(out maxStack);
			// Marshal - Convert managed data to native data.
			__maxStack_native = maxStack;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetRawLVarInstanceValue(ComWrappers.ComInterfaceDispatch* __this_native, void* instance, uint bufferSize, uint* __bytesWritten_native__param, byte* buffer)
	{
		IStackFrame @this = default!;
		ref uint __bytesWritten_native = ref *__bytesWritten_native__param;
		uint bytesWritten = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetRawLVarInstanceValue(instance, bufferSize, out bytesWritten, buffer);
			// Marshal - Convert managed data to native data.
			__bytesWritten_native = bytesWritten;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetRegisterValue(ComWrappers.ComInterfaceDispatch* __this_native, HostRegister index, ulong* __value_native__param)
	{
		IStackFrame @this = default!;
		ref ulong __value_native = ref *__value_native__param;
		ulong value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetRegisterValue(index, out value);
			// Marshal - Convert managed data to native data.
			__value_native = value;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetReturnAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __address_native__param)
	{
		IStackFrame @this = default!;
		ref ulong __address_native = ref *__address_native__param;
		ulong address = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetReturnAddress(out address);
			// Marshal - Convert managed data to native data.
			__address_native = address;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetSize(ComWrappers.ComInterfaceDispatch* __this_native, uint* __size_native__param)
	{
		IStackFrame @this = default!;
		ref uint __size_native = ref *__size_native__param;
		uint size = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetSize(out size);
			// Marshal - Convert managed data to native data.
			__size_native = size;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetSystemExceptionHandling(ComWrappers.ComInterfaceDispatch* __this_native, int* __enabled_native__param)
	{
		IStackFrame @this = default!;
		ref int __enabled_native = ref *__enabled_native__param;
		bool enabled = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetSystemExceptionHandling(out enabled);
			// Marshal - Convert managed data to native data.
			__enabled_native = enabled ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetFrameType(ComWrappers.ComInterfaceDispatch* __this_native, StackFrameType* __type_native__param)
	{
		IStackFrame @this = default!;
		ref StackFrameType __type_native = ref *__type_native__param;
		StackFrameType type = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackFrame>(__this_native);
			__retVal = @this.GetFrameType(out type);
			// Marshal - Convert managed data to native data.
			__type_native = type;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IStackFrame), sizeof(void*) * 19);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
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
		}

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