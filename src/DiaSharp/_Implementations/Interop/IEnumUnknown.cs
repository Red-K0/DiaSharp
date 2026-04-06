#pragma warning disable CS0612, CS0618, IDE0008
using DiaSharp.Interop;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([0, 1, 0, 0, 0, 0, 0, 0, 192, 0, 0, 0, 0, 0, 0, 70]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumUnknown
{
	[SkipLocalsInit]
	int IEnumUnknown.Clone(out IEnumUnknown enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumUnknown));
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
			enumerator = ComInterfaceMarshaller<IEnumUnknown>.ConvertToManaged(__enumerator_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumUnknown>.Free(__enumerator_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumUnknown.GetNext(uint elementCount, void** elements, out uint elementsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumUnknown));
		Unsafe.SkipInit(out elementsFetched);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __elementsFetched_native = &elementsFetched)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[4])(__this, elementCount, elements, __elementsFetched_native);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumUnknown.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumUnknown));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[5])(__this);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumUnknown.Skip(uint elementCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumUnknown));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[6])(__this, elementCount);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		IEnumUnknown @this = default!;
		ref void* __enumerator_native = ref *__enumerator_native__param;
		IEnumUnknown enumerator = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumUnknown>(__this_native);
			@this.Clone(out enumerator);
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
			// Marshal - Convert managed data to native data.
			__enumerator_native = ComInterfaceMarshaller<IEnumUnknown>.ConvertToUnmanaged(enumerator);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint elementCount, void** elements, uint* __elementsFetched_native__param)
	{
		IEnumUnknown @this = default!;
		ref uint __elementsFetched_native = ref *__elementsFetched_native__param;
		uint elementsFetched = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumUnknown>(__this_native);
			@this.GetNext(elementCount, elements, out elementsFetched);
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
			// Marshal - Convert managed data to native data.
			__elementsFetched_native = elementsFetched;
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
			IEnumUnknown @this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumUnknown>(__this_native);
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
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint elementCount)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			IEnumUnknown @this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumUnknown>(__this_native);
			@this.Skip(elementCount);
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumUnknown), sizeof(void*) * 7);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, uint*, int>)&ABI_GetNext;
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Reset;
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int>)&ABI_Skip;
		}

		return vtable;
	}
}

namespace DiaSharp.Interop
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumUnknown
	{
	}
}