#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.Storage;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([57, 1, 0, 0, 0, 0, 0, 0, 192, 0, 0, 0, 0, 0, 0, 70]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumStatPropertyStorage
{
	[SkipLocalsInit]
	int IEnumStatPropertyStorage.Clone(out IEnumStatPropertyStorage enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumStatPropertyStorage));
		bool __invokeSucceeded = false;
		void* __enumerator_native = null;
		int __retVal;

		try
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__enumerator_native);

			__invokeSucceeded = true;

			enumerator = ComInterfaceMarshaller<IEnumStatPropertyStorage>.ConvertToManaged(__enumerator_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<IEnumStatPropertyStorage>.Free(__enumerator_native);
		}
	}

	[SkipLocalsInit]
	int IEnumStatPropertyStorage.GetNext(uint propertyCount, StatPropertyStorage* properties, out uint propertiesWritten)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumStatPropertyStorage));

		fixed (uint* __propertiesWritten_native = &propertiesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, StatPropertyStorage*, uint*, int>)__vtable_native[4])(__this, propertyCount, properties, __propertiesWritten_native);
		}
	}

	[SkipLocalsInit]
	int IEnumStatPropertyStorage.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumStatPropertyStorage));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[5])(__this);
	}

	[SkipLocalsInit]
	int IEnumStatPropertyStorage.Skip(uint propertyCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumStatPropertyStorage));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[6])(__this, propertyCount);
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumStatPropertyStorage>(__this_native).Clone(out IEnumStatPropertyStorage enumerator);

			*__enumerator_native__param = ComInterfaceMarshaller<IEnumStatPropertyStorage>.ConvertToUnmanaged(enumerator);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint propertyCount, StatPropertyStorage* properties, uint* __propertiesWritten_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumStatPropertyStorage>(__this_native).GetNext(propertyCount, properties, out *__propertiesWritten_native__param);
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
			return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumStatPropertyStorage>(__this_native).Reset();
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint propertyCount)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumStatPropertyStorage>(__this_native).Skip(propertyCount);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumStatPropertyStorage), sizeof(void*) * 7);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, StatPropertyStorage*, uint*, int>)&ABI_GetNext;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Reset;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int>)&ABI_Skip;

		return vtable;
	}
}

namespace DiaSharp.Storage
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumStatPropertyStorage
	{
	}
}