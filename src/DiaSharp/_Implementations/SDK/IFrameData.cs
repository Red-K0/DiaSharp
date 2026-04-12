#pragma warning disable CS0612, CS0618, IDE0008
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
		Unsafe.SkipInit(out section);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __section_native = &section)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __section_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetAddressOffset(out uint offset)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		Unsafe.SkipInit(out offset);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __offset_native = &offset)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[4])(__this, __offset_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetRelativeVirtualAddress(out uint rva)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		Unsafe.SkipInit(out rva);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __rva_native = &rva)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[5])(__this, __rva_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetVirtualAddress(out ulong virtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		Unsafe.SkipInit(out virtualAddress);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __virtualAddress_native = &virtualAddress)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[6])(__this, __virtualAddress_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetBlockLength(out uint blockLength)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		Unsafe.SkipInit(out blockLength);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __blockLength_native = &blockLength)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[7])(__this, __blockLength_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetLocalsLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
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
	int IFrameData.GetParamsLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
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
	int IFrameData.GetMaxStack(out uint maxStack)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		Unsafe.SkipInit(out maxStack);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __maxStack_native = &maxStack)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[10])(__this, __maxStack_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetPrologueLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		Unsafe.SkipInit(out length);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __length_native = &length)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[11])(__this, __length_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetSavedRegistersLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		Unsafe.SkipInit(out length);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __length_native = &length)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[12])(__this, __length_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetProgram(out string name)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out name);
		ushort* __name_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[13])(__this, &__name_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			name = BStrStringMarshaller.ConvertToManaged(__name_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__name_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetSystemExceptionHandling(out bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		Unsafe.SkipInit(out enabled);
		int __enabled_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[14])(__this, &__enabled_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		enabled = __enabled_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetCppExceptionHandling(out bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		Unsafe.SkipInit(out enabled);
		int __enabled_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[15])(__this, &__enabled_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		enabled = __enabled_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetIsFunctionStart(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[16])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetAllocatesBasePointer(out bool allocates)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		Unsafe.SkipInit(out allocates);
		int __allocates_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[17])(__this, &__allocates_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		allocates = __allocates_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.GetFrameType(out StackFrameType type)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
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

	[SkipLocalsInit]
	int IFrameData.GetFunctionParent(out IFrameData parentData)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out parentData);
		void* __parentData_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[19])(__this, &__parentData_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			parentData = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__parentData_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IFrameData>.Free(__parentData_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IFrameData.Execute(IStackWalkFrame stackFrame)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IFrameData));
		void* __stackFrame_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__stackFrame_native = ComInterfaceMarshaller<IStackWalkFrame>.ConvertToUnmanaged(stackFrame);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, int>)__vtable_native[20])(__this, __stackFrame_native);
			}

			GC.KeepAlive(this);
		}
		finally
		{
			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<IStackWalkFrame>.Free(__stackFrame_native);
		}

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetAddressSection(ComWrappers.ComInterfaceDispatch* __this_native, uint* __section_native__param)
	{
		IFrameData @this = default!;
		ref uint __section_native = ref *__section_native__param;
		uint section = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
			__retVal = @this.GetAddressSection(out section);
			// Marshal - Convert managed data to native data.
			__section_native = section;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetAddressOffset(ComWrappers.ComInterfaceDispatch* __this_native, uint* __offset_native__param)
	{
		IFrameData @this = default!;
		ref uint __offset_native = ref *__offset_native__param;
		uint offset = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
			__retVal = @this.GetAddressOffset(out offset);
			// Marshal - Convert managed data to native data.
			__offset_native = offset;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetRelativeVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __rva_native__param)
	{
		IFrameData @this = default!;
		ref uint __rva_native = ref *__rva_native__param;
		uint rva = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
			__retVal = @this.GetRelativeVirtualAddress(out rva);
			// Marshal - Convert managed data to native data.
			__rva_native = rva;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __virtualAddress_native__param)
	{
		IFrameData @this = default!;
		ref ulong __virtualAddress_native = ref *__virtualAddress_native__param;
		ulong virtualAddress = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
			__retVal = @this.GetVirtualAddress(out virtualAddress);
			// Marshal - Convert managed data to native data.
			__virtualAddress_native = virtualAddress;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetBlockLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __blockLength_native__param)
	{
		IFrameData @this = default!;
		ref uint __blockLength_native = ref *__blockLength_native__param;
		uint blockLength = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
			__retVal = @this.GetBlockLength(out blockLength);
			// Marshal - Convert managed data to native data.
			__blockLength_native = blockLength;
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
		IFrameData @this = default!;
		ref uint __length_native = ref *__length_native__param;
		uint length = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
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
		IFrameData @this = default!;
		ref uint __length_native = ref *__length_native__param;
		uint length = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
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
	static internal int ABI_GetMaxStack(ComWrappers.ComInterfaceDispatch* __this_native, uint* __maxStack_native__param)
	{
		IFrameData @this = default!;
		ref uint __maxStack_native = ref *__maxStack_native__param;
		uint maxStack = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
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
	static internal int ABI_GetPrologueLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		IFrameData @this = default!;
		ref uint __length_native = ref *__length_native__param;
		uint length = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
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
		IFrameData @this = default!;
		ref uint __length_native = ref *__length_native__param;
		uint length = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
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
	static internal int ABI_GetProgram(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __name_native__param)
	{
		IFrameData @this = default!;
		ref ushort* __name_native = ref *__name_native__param;
		string name = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
			__retVal = @this.GetProgram(out name);
			// Marshal - Convert managed data to native data.
			__name_native = BStrStringMarshaller.ConvertToUnmanaged(name);
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
		IFrameData @this = default!;
		ref int __enabled_native = ref *__enabled_native__param;
		bool enabled = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
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
	static internal int ABI_GetCppExceptionHandling(ComWrappers.ComInterfaceDispatch* __this_native, int* __enabled_native__param)
	{
		IFrameData @this = default!;
		ref int __enabled_native = ref *__enabled_native__param;
		bool enabled = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
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
	static internal int ABI_GetIsFunctionStart(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		IFrameData @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
			__retVal = @this.GetIsFunctionStart(out value);
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
	static internal int ABI_GetAllocatesBasePointer(ComWrappers.ComInterfaceDispatch* __this_native, int* __allocates_native__param)
	{
		IFrameData @this = default!;
		ref int __allocates_native = ref *__allocates_native__param;
		bool allocates = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
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
	static internal int ABI_GetFrameType(ComWrappers.ComInterfaceDispatch* __this_native, StackFrameType* __type_native__param)
	{
		IFrameData @this = default!;
		ref StackFrameType __type_native = ref *__type_native__param;
		StackFrameType type = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
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

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetFunctionParent(ComWrappers.ComInterfaceDispatch* __this_native, void** __parentData_native__param)
	{
		IFrameData @this = default!;
		ref void* __parentData_native = ref *__parentData_native__param;
		IFrameData parentData = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
			__retVal = @this.GetFunctionParent(out parentData);
			// Marshal - Convert managed data to native data.
			__parentData_native = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(parentData);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Execute(ComWrappers.ComInterfaceDispatch* __this_native, void* __stackFrame_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			IStackWalkFrame stackFrame = ComInterfaceMarshaller<IStackWalkFrame>.ConvertToManaged(__stackFrame_native)!;
			IFrameData @this = ComWrappers.ComInterfaceDispatch.GetInstance<IFrameData>(__this_native);
			__retVal = @this.Execute(stackFrame);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IFrameData), sizeof(void*) * 21);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
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
		}

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