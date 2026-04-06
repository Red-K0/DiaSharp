#pragma warning disable CS0612, CS0618, IDE0008
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
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out enumerator);
		void* __enumerator_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[7])(__this, &__enumerator_native);
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
	int ITable.GetName(out string name)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out name);
		ushort* __name_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[8])(__this, &__name_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			name = Utf16StringMarshaller.ConvertToManaged(__name_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				Utf16StringMarshaller.Free(__name_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ITable.GetCount(out int count)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));
		Unsafe.SkipInit(out count);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (int* __count_native = &count)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[9])(__this, __count_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ITable.Item(uint index, out void* item)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));
		item = default;
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (void** __item_native = &item)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[10])(__this, index, __item_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ITable.Clone(out IEnumUnknown enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out enumerator);
		void* __enumerator_native = default;
		int __invokeRetVal = default!;

		try
		{
			{
				__invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__enumerator_native);
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

		return __invokeRetVal;
	}

	[SkipLocalsInit]
	int ITable.GetNext(uint elementCount, void** elements, out uint elementsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));
		Unsafe.SkipInit(out elementsFetched);
		int __invokeRetVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __elementsFetched_native = &elementsFetched)
		{
			__invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[4])(__this, elementCount, elements, __elementsFetched_native);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __invokeRetVal;
	}

	[SkipLocalsInit]
	int ITable.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));
		int __invokeRetVal;
		{
			__invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[5])(__this);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __invokeRetVal;
	}

	[SkipLocalsInit]
	int ITable.Skip(uint elementCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ITable));
		int __invokeRetVal;
		{
			__invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[6])(__this, elementCount);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __invokeRetVal;
	}

	int IEnumUnknown.Clone(out IEnumUnknown enumerator) => throw new UnreachableException();
	int IEnumUnknown.GetNext(uint elementCount, void** elements, out uint elementsFetched) => throw new UnreachableException();
	int IEnumUnknown.Reset() => throw new UnreachableException();
	int IEnumUnknown.Skip(uint elementCount) => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNewEnum(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		ITable @this = default!;
		ref void* __enumerator_native = ref *__enumerator_native__param;
		IEnumVARIANT enumerator = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ITable>(__this_native);
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
	static internal int ABI_GetName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __name_native__param)
	{
		ITable @this = default!;
		ref ushort* __name_native = ref *__name_native__param;
		string name = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ITable>(__this_native);
			__retVal = @this.GetName(out name);
			// Marshal - Convert managed data to native data.
			__name_native = Utf16StringMarshaller.ConvertToUnmanaged(name);
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
		ITable @this = default!;
		ref int __count_native = ref *__count_native__param;
		int count = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ITable>(__this_native);
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
	static internal int ABI_Item(ComWrappers.ComInterfaceDispatch* __this_native, uint index, void** __item_native__param)
	{
		ITable @this = default!;
		ref void* __item_native = ref *__item_native__param;
		void* item = default;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ITable>(__this_native);
			__retVal = @this.Item(index, out item);
			// Marshal - Convert managed data to native data.
			__item_native = item;
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ITable), sizeof(void*) * 11);
		{
			NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(IEnumUnknown).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 7));
		}

		{
			vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetNewEnum;
			vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetName;
			vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetCount;
			vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_Item;
		}

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