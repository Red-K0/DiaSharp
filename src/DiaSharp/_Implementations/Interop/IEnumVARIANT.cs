#pragma warning disable CS0612, CS0618, IDE0008, CA1031, CA1031
using DiaSharp;
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
		bool __invokeSucceeded = false;
		void* __retVal_native = null;

		try
		{
			Marshal.ThrowExceptionForHR(((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__retVal_native));

			__invokeSucceeded = true;

			return ComInterfaceMarshaller<IEnumVARIANT>.ConvertToManaged(__retVal_native)!;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<IEnumVARIANT>.Free(__retVal_native);
		}
	}

	[SkipLocalsInit]
	uint IEnumVARIANT.GetNext(uint elementCount, void** elements)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumVARIANT));
		uint __retVal;

		Marshal.ThrowExceptionForHR(((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[4])(__this, elementCount, elements, &__retVal));

		return __retVal;
	}

	[SkipLocalsInit]
	void IEnumVARIANT.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumVARIANT));

		Marshal.ThrowExceptionForHR(((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[5])(__this));
	}

	[SkipLocalsInit]
	uint IEnumVARIANT.Skip()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumVARIANT));
		uint __retVal;

		Marshal.ThrowExceptionForHR(((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[6])(__this, &__retVal));

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __invokeRetValUnmanaged__param)
	{
		try
		{
			*__invokeRetValUnmanaged__param = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToUnmanaged(ComWrappers.ComInterfaceDispatch.GetInstance<IEnumVARIANT>(__this_native).Clone());

			return (int)KnownResult.S_OK;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint elementCount, void** elements, uint* __invokeRetValUnmanaged__param)
	{
		try
		{
			*__invokeRetValUnmanaged__param = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumVARIANT>(__this_native).GetNext(elementCount, elements);

			return (int)KnownResult.S_FALSE;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Reset(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		try
		{
			ComWrappers.ComInterfaceDispatch.GetInstance<IEnumVARIANT>(__this_native).Reset();

			return (int)KnownResult.S_OK;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint* __invokeRetValUnmanaged__param)
	{
		try
		{
			*__invokeRetValUnmanaged__param = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumVARIANT>(__this_native).Skip();

			return (int)KnownResult.S_OK;
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumVARIANT), sizeof(void*) * 7);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, uint*, int>)&ABI_GetNext;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Reset;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_Skip;

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