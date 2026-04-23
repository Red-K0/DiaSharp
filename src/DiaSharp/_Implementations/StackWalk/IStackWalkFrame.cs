#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.CodeView;
using DiaSharp.Native;
using DiaSharp.SDK;
using DiaSharp.StackWalk;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([193, 144, 197, 7, 141, 67, 71, 79, 189, 205, 67, 151, 188, 129, 173, 117]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IStackWalkFrame
{
	[SkipLocalsInit]
	int IStackWalkFrame.GetRegisterValue(HostRegister index, out ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkFrame));
		Unsafe.SkipInit(out value);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __value_native = &value)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, HostRegister, ulong*, int>)__vtable_native[3])(__this, index, __value_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkFrame.PutRegisterValue(HostRegister index, ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkFrame));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, HostRegister, ulong, int>)__vtable_native[4])(__this, index, value);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkFrame.ReadMemory(MemoryType type, ulong virtualAddress, uint bytesRequested, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkFrame));
		Unsafe.SkipInit(out bytesWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, MemoryType, ulong, uint, uint*, byte*, int>)__vtable_native[5])(__this, type, virtualAddress, bytesRequested, __bytesWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkFrame.SearchForReturnAddress(IFrameData frame, out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkFrame));
		Unsafe.SkipInit(out address);
		void* __frame_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__frame_native = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frame);
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (ulong* __address_native = &address)
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, ulong*, int>)__vtable_native[6])(__this, __frame_native, __address_native);
			}

			GC.KeepAlive(this);
		}
		finally
		{
			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<IFrameData>.Free(__frame_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkFrame.SearchForReturnAddressStart(IFrameData frame, ulong address, out ulong start)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkFrame));
		Unsafe.SkipInit(out start);
		void* __frame_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__frame_native = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frame);
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (ulong* __start_native = &start)
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, ulong, ulong*, int>)__vtable_native[7])(__this, __frame_native, address, __start_native);
			}

			GC.KeepAlive(this);
		}
		finally
		{
			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<IFrameData>.Free(__frame_native);
		}

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetRegisterValue(ComWrappers.ComInterfaceDispatch* __this_native, HostRegister index, ulong* __value_native__param)
	{
		IStackWalkFrame @this = default!;
		ref ulong __value_native = ref *__value_native__param;
		ulong value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkFrame>(__this_native);
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
	static internal int ABI_PutRegisterValue(ComWrappers.ComInterfaceDispatch* __this_native, HostRegister index, ulong value)
	{
		int __retVal;

		try
		{
			IStackWalkFrame @this = default!;
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkFrame>(__this_native);
			__retVal = @this.PutRegisterValue(index, value);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_ReadMemory(ComWrappers.ComInterfaceDispatch* __this_native, MemoryType type, ulong virtualAddress, uint bytesRequested, uint* __bytesWritten_native__param, byte* buffer)
	{
		IStackWalkFrame @this = default!;
		ref uint __bytesWritten_native = ref *__bytesWritten_native__param;
		uint bytesWritten = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkFrame>(__this_native);
			__retVal = @this.ReadMemory(type, virtualAddress, bytesRequested, out bytesWritten, buffer);
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
	static internal int ABI_SearchForReturnAddress(ComWrappers.ComInterfaceDispatch* __this_native, void* __frame_native, ulong* __address_native__param)
	{
		IStackWalkFrame @this = default!;
		IFrameData frame = default!;
		ref ulong __address_native = ref *__address_native__param;
		ulong address = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			frame = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frame_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkFrame>(__this_native);
			__retVal = @this.SearchForReturnAddress(frame, out address);
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
	static internal int ABI_SearchForReturnAddressStart(ComWrappers.ComInterfaceDispatch* __this_native, void* __frame_native, ulong address, ulong* __start_native__param)
	{
		IStackWalkFrame @this = default!;
		IFrameData frame = default!;
		ref ulong __start_native = ref *__start_native__param;
		ulong start = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			frame = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frame_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkFrame>(__this_native);
			__retVal = @this.SearchForReturnAddressStart(frame, address, out start);
			// Marshal - Convert managed data to native data.
			__start_native = start;
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IStackWalkFrame), sizeof(void*) * 8);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, HostRegister, ulong*, int>)&ABI_GetRegisterValue;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, HostRegister, ulong, int>)&ABI_PutRegisterValue;
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, MemoryType, ulong, uint, uint*, byte*, int>)&ABI_ReadMemory;
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, ulong*, int>)&ABI_SearchForReturnAddress;
			vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, ulong, ulong*, int>)&ABI_SearchForReturnAddressStart;
		}

		return vtable;
	}
}

namespace DiaSharp.StackWalk
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IStackWalkFrame
	{
	}
}