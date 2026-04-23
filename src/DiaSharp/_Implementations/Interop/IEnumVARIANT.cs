#pragma warning disable CS0612, CS0618, IDE0008, CA1031, CA1031
using DiaSharp.Interop;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([4, 4, 2, 0, 0, 0, 0, 0, 192, 0, 0, 0, 0, 0, 0, 70]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumVARIANT
{
	[SkipLocalsInit]
	IEnumVARIANT IEnumVARIANT.Clone()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumVARIANT));
		bool __invokeSucceeded = default!;
		IEnumVARIANT __retVal = default!;
		void* __retVal_native = default;
		int __invokeRetVal = default!;

		try
		{
			__invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__retVal_native);

			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			Marshal.ThrowExceptionForHR(__invokeRetVal);
			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			__retVal = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToManaged(__retVal_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumVARIANT>.Free(__retVal_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	uint IEnumVARIANT.GetNext(uint elementCount, void** elements)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumVARIANT));
		uint __retVal;
		int __invokeRetVal;
		{
			__invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[4])(__this, elementCount, elements, &__retVal);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		Marshal.ThrowExceptionForHR(__invokeRetVal);
		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	void IEnumVARIANT.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumVARIANT));
		int __invokeRetVal;
		{
			__invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[5])(__this);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		Marshal.ThrowExceptionForHR(__invokeRetVal);
		GC.KeepAlive(this);
	}

	[SkipLocalsInit]
	uint IEnumVARIANT.Skip()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumVARIANT));
		uint __retVal;
		int __invokeRetVal;
		{
			__invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[6])(__this, &__retVal);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		Marshal.ThrowExceptionForHR(__invokeRetVal);
		GC.KeepAlive(this);
		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __invokeRetValUnmanaged__param)
	{
		IEnumVARIANT @this = default!;
		ref void* __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
		IEnumVARIANT __invokeRetVal = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumVARIANT>(__this_native);
			__invokeRetVal = @this.Clone();
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
			// Marshal - Convert managed data to native data.
			__invokeRetValUnmanaged = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToUnmanaged(__invokeRetVal);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint elementCount, void** elements, uint* __invokeRetValUnmanaged__param)
	{
		IEnumVARIANT @this = default!;
		ref uint __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
		uint __invokeRetVal = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumVARIANT>(__this_native);
			__invokeRetVal = @this.GetNext(elementCount, elements);
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
			// Marshal - Convert managed data to native data.
			__invokeRetValUnmanaged = __invokeRetVal;
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
			IEnumVARIANT @this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumVARIANT>(__this_native);
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
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint* __invokeRetValUnmanaged__param)
	{
		IEnumVARIANT @this = default!;
		ref uint __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
		uint __invokeRetVal = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumVARIANT>(__this_native);
			__invokeRetVal = @this.Skip();
			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			__retVal = 0; // S_OK
			// Marshal - Convert managed data to native data.
			__invokeRetValUnmanaged = __invokeRetVal;
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumVARIANT), sizeof(void*) * 7);
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
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_Skip;
		}

		return vtable;
	}
}

namespace DiaSharp.Interop
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumVARIANT
	{
	}
}