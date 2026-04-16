#pragma warning disable CS0612, CS0618, IDE0008
using DiaSharp.Interop;
using DiaSharp.SDK.Enumerators;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([30, 180, 203, 8, 166, 71, 135, 79, 146, 241, 28, 156, 135, 206, 208, 68]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumDebugStreams
{
	[SkipLocalsInit]
	int IEnumDebugStreams.GetNewEnum(out IEnumVARIANT enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreams));
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
	int IEnumDebugStreams.GetCount(out int count)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreams));
		Unsafe.SkipInit(out count);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (int* __count_native = &count)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[4])(__this, __count_native);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumDebugStreams.Item(uint index, out IEnumDebugStreamData data)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreams));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out data);
		void* __data_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[5])(__this, index, &__data_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			data = ComInterfaceMarshaller<IEnumDebugStreamData>.ConvertToManaged(__data_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumDebugStreamData>.Free(__data_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumDebugStreams.GetNext(uint streamCount, void** streams, out uint streamsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreams));
		Unsafe.SkipInit(out streamsFetched);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __streamsFetched_native = &streamsFetched)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[6])(__this, streamCount, streams, __streamsFetched_native);
		}

		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumDebugStreams.Skip(uint streamCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreams));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[7])(__this, streamCount);
		}

		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumDebugStreams.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreams));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[8])(__this);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumDebugStreams.Clone(out IEnumDebugStreams enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumDebugStreams));
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
			enumerator = ComInterfaceMarshaller<IEnumDebugStreams>.ConvertToManaged(__enumerator_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumDebugStreams>.Free(__enumerator_native);
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
		IEnumDebugStreams @this = default!;
		ref void* __enumerator_native = ref *__enumerator_native__param;
		IEnumVARIANT enumerator = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreams>(__this_native);
			@this.GetNewEnum(out enumerator);
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
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
		IEnumDebugStreams @this = default!;
		ref int __count_native = ref *__count_native__param;
		int count = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreams>(__this_native);
			@this.GetCount(out count);
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
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
	static internal int ABI_Item(ComWrappers.ComInterfaceDispatch* __this_native, uint index, void** __data_native__param)
	{
		IEnumDebugStreams @this = default!;
		ref void* __data_native = ref *__data_native__param;
		IEnumDebugStreamData data = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreams>(__this_native);
			@this.Item(index, out data);
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
			// Marshal - Convert managed data to native data.
			__data_native = ComInterfaceMarshaller<IEnumDebugStreamData>.ConvertToUnmanaged(data);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint streamCount, void** streams, uint* __streamsFetched_native__param)
	{
		IEnumDebugStreams @this = default!;
		ref uint __streamsFetched_native = ref *__streamsFetched_native__param;
		uint streamsFetched = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreams>(__this_native);
			@this.GetNext(streamCount, streams, out streamsFetched);
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
			// Marshal - Convert managed data to native data.
			__streamsFetched_native = streamsFetched;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint streamCount)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			IEnumDebugStreams @this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreams>(__this_native);
			@this.Skip(streamCount);
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
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
			IEnumDebugStreams @this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreams>(__this_native);
			@this.Reset();
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
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
		IEnumDebugStreams @this = default!;
		ref void* __enumerator_native = ref *__enumerator_native__param;
		IEnumDebugStreams enumerator = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumDebugStreams>(__this_native);
			@this.Clone(out enumerator);
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
			// Marshal - Convert managed data to native data.
			__enumerator_native = ComInterfaceMarshaller<IEnumDebugStreams>.ConvertToUnmanaged(enumerator);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumDebugStreams), sizeof(void*) * 10);
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
		}

		return vtable;
	}
}

namespace DiaSharp.SDK.Enumerators
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumDebugStreams
	{
	}
}