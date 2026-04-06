#pragma warning disable CS0612, CS0618, IDE0008
using DiaSharp.Interop;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([75, 122, 199, 159, 28, 60, 237, 68, 167, 152, 108, 29, 238, 165, 62, 31]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumFrameData
{
	[SkipLocalsInit]
	int IEnumFrameData.GetNewEnum(out IEnumVARIANT enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out enumerator);
		void* __enumerator_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__enumerator_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			enumerator = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToManaged(__enumerator_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumVARIANT>.Free(__enumerator_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumFrameData.GetCount(out int count)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		Unsafe.SkipInit(out count);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (int* __count_native = &count)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[4])(__this, __count_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumFrameData.Item(uint index, out IFrameData frameData)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out frameData);
		void* __frameData_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[5])(__this, index, &__frameData_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			frameData = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frameData_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IFrameData>.Free(__frameData_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumFrameData.GetNext(uint frameCount, void** frames, out uint framesFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		Unsafe.SkipInit(out framesFetched);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __framesFetched_native = &framesFetched)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[6])(__this, frameCount, frames, __framesFetched_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumFrameData.Skip(uint dataCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[7])(__this, dataCount);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumFrameData.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[8])(__this);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumFrameData.Clone(out IEnumFrameData enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out enumerator);
		void* __enumerator_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[9])(__this, &__enumerator_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			enumerator = ComInterfaceMarshaller<IEnumFrameData>.ConvertToManaged(__enumerator_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumFrameData>.Free(__enumerator_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumFrameData.FrameByRVA(uint relativeVirtualAddress, out IFrameData frameData)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out frameData);
		void* __frameData_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[10])(__this, relativeVirtualAddress, &__frameData_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			frameData = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frameData_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IFrameData>.Free(__frameData_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumFrameData.FrameByVA(ulong virtualAddress, out IFrameData frameData)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumFrameData));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out frameData);
		void* __frameData_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, void**, int>)__vtable_native[11])(__this, virtualAddress, &__frameData_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			frameData = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frameData_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IFrameData>.Free(__frameData_native);
			}
		}

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNewEnum(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		IEnumFrameData @this = default!;
		ref void* __enumerator_native = ref *__enumerator_native__param;
		IEnumVARIANT enumerator = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native);
			__retVal = @this.GetNewEnum(out enumerator);
			// Marshal - Convert managed data to native data.
			__enumerator_native = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToUnmanaged(enumerator);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetCount(ComWrappers.ComInterfaceDispatch* __this_native, int* __count_native__param)
	{
		IEnumFrameData @this = default!;
		ref int __count_native = ref *__count_native__param;
		int count = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native);
			__retVal = @this.GetCount(out count);
			// Marshal - Convert managed data to native data.
			__count_native = count;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Item(ComWrappers.ComInterfaceDispatch* __this_native, uint index, void** __frameData_native__param)
	{
		IEnumFrameData @this = default!;
		ref void* __frameData_native = ref *__frameData_native__param;
		IFrameData frameData = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native);
			__retVal = @this.Item(index, out frameData);
			// Marshal - Convert managed data to native data.
			__frameData_native = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frameData);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint frameCount, void** frames, uint* __framesFetched_native__param)
	{
		IEnumFrameData @this = default!;
		ref uint __framesFetched_native = ref *__framesFetched_native__param;
		uint framesFetched = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native);
			__retVal = @this.GetNext(frameCount, frames, out framesFetched);
			// Marshal - Convert managed data to native data.
			__framesFetched_native = framesFetched;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint dataCount)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			IEnumFrameData @this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native);
			__retVal = @this.Skip(dataCount);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Reset(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			IEnumFrameData @this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native);
			__retVal = @this.Reset();
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		IEnumFrameData @this = default!;
		ref void* __enumerator_native = ref *__enumerator_native__param;
		IEnumFrameData enumerator = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native);
			__retVal = @this.Clone(out enumerator);
			// Marshal - Convert managed data to native data.
			__enumerator_native = ComInterfaceMarshaller<IEnumFrameData>.ConvertToUnmanaged(enumerator);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FrameByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, void** __frameData_native__param)
	{
		IEnumFrameData @this = default!;
		ref void* __frameData_native = ref *__frameData_native__param;
		IFrameData frameData = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native);
			__retVal = @this.FrameByRVA(relativeVirtualAddress, out frameData);
			// Marshal - Convert managed data to native data.
			__frameData_native = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frameData);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_FrameByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, void** __frameData_native__param)
	{
		IEnumFrameData @this = default!;
		ref void* __frameData_native = ref *__frameData_native__param;
		IFrameData frameData = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumFrameData>(__this_native);
			__retVal = @this.FrameByVA(virtualAddress, out frameData);
			// Marshal - Convert managed data to native data.
			__frameData_native = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frameData);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumFrameData), sizeof(void*) * 12);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetNewEnum;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetCount;
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_Item;
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, uint*, int>)&ABI_GetNext;
			vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int>)&ABI_Skip;
			vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Reset;
			vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;
			vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_FrameByRVA;
			vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, void**, int>)&ABI_FrameByVA;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK.Enumerators
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumFrameData
	{
	}
}