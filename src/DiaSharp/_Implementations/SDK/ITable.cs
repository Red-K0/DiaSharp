#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.Interop;
using DiaSharp.SDK;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([119, 251, 89, 74, 172, 171, 155, 70, 163, 11, 158, 204, 133, 191, 239, 20]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ITable
{
	[SkipLocalsInit]
	int ITable.GetNewEnum(out IEnumVARIANT enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));
		bool __invokeSucceeded = false;
		void* __enumerator_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[7])(__this, &__enumerator_native);

			__invokeSucceeded = true;

			enumerator = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToManaged(__enumerator_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<IEnumVARIANT>.Free(__enumerator_native);
		}
	}

	[SkipLocalsInit]
	int ITable.GetName(out string name)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));
		bool __invokeSucceeded = false;
		ushort* __name_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[8])(__this, &__name_native);

			__invokeSucceeded = true;

			name = Utf16StringMarshaller.ConvertToManaged(__name_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) Utf16StringMarshaller.Free(__name_native);
		}
	}

	[SkipLocalsInit]
	int ITable.GetCount(out int count)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));

		fixed (int* __count_native = &count)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[9])(__this, __count_native);
		}
	}

	[SkipLocalsInit]
	int ITable.Item(uint index, out void* item)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));
		
		fixed (void** __item_native = &item)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[10])(__this, index, __item_native);
		}
	}

	[SkipLocalsInit]
	int ITable.Clone(out IEnumUnknown enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));
		bool __invokeSucceeded = false;
		void* __enumerator_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__enumerator_native);

			__invokeSucceeded = true;

			enumerator = ComInterfaceMarshaller<IEnumUnknown>.ConvertToManaged(__enumerator_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<IEnumUnknown>.Free(__enumerator_native);
		}
	}

	[SkipLocalsInit]
	int ITable.GetNext(uint elementCount, void** elements, out uint elementsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));

		fixed (uint* __elementsFetched_native = &elementsFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[4])(__this, elementCount, elements, __elementsFetched_native);
		}
	}

	[SkipLocalsInit]
	int ITable.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[5])(__this);
	}

	[SkipLocalsInit]
	int ITable.Skip(uint elementCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[6])(__this, elementCount);
	}

	int IEnumUnknown.Clone(out IEnumUnknown enumerator) => throw new UnreachableException();
	int IEnumUnknown.GetNext(uint elementCount, void** elements, out uint elementsFetched) => throw new UnreachableException();
	int IEnumUnknown.Reset() => throw new UnreachableException();
	int IEnumUnknown.Skip(uint elementCount) => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNewEnum(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ITable>(__this_native).GetNewEnum(out IEnumVARIANT enumerator);

			*__enumerator_native__param = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToUnmanaged(enumerator);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __name_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ITable>(__this_native).GetName(out string name);

			*__name_native__param = Utf16StringMarshaller.ConvertToUnmanaged(name);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCount(ComWrappers.ComInterfaceDispatch* __this_native, int* __count_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<ITable>(__this_native).GetCount(out *__count_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Item(ComWrappers.ComInterfaceDispatch* __this_native, uint index, void** __item_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ITable>(__this_native).Item(index, out void* item);

			*__item_native__param = item;

			return __retVal;
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ITable), sizeof(void*) * 11);

		NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(IEnumUnknown).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 7));

		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetNewEnum;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetName;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetCount;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_Item;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface ITable
	{
		[SkipLocalsInit]
		new int Clone(out IEnumUnknown enumerator) => ((IEnumUnknown)this).Clone(out enumerator);
		[SkipLocalsInit]
		new unsafe int GetNext(uint elementCount, void** elements, out uint elementsFetched) => ((IEnumUnknown)this).GetNext(elementCount, elements, out elementsFetched);
		[SkipLocalsInit]
		new int Reset() => ((IEnumUnknown)this).Reset();
		[SkipLocalsInit]
		new int Skip(uint elementCount) => ((IEnumUnknown)this).Skip(elementCount);
	}
}