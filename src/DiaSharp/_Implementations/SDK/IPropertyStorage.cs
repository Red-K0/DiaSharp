#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.SDK;
using DiaSharp.Storage;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([156, 111, 65, 157, 132, 225, 178, 69, 164, 240, 206, 81, 127, 113, 158, 155]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IPropertyStorage
{
	[SkipLocalsInit]
	int IPropertyStorage.ReadMultiple(uint specifierCount, PropertySpecifier* specifiers, out void* propVariant)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));
		propVariant = default;
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (void** __propVariant_native = &propVariant)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, PropertySpecifier*, void**, int>)__vtable_native[3])(__this, specifierCount, specifiers, __propVariant_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IPropertyStorage.ReadPropertyNames(uint propertyIDCount, uint* propertyIDs, out string[] names)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out names);
		nint* __names_native = default;
		int __retVal = default;
		// Setup - Perform required setup.
		Unsafe.SkipInit(out int __names_native__numElements);

		try
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, nint**, int>)__vtable_native[4])(__this, propertyIDCount, propertyIDs, &__names_native);

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			__names_native__numElements = checked((int)propertyIDCount);
			names = ArrayMarshaller<string, nint>.AllocateContainerForManagedElements(__names_native, __names_native__numElements)!;
			{
				ReadOnlySpan<nint> __names_native__nativeSpan = ArrayMarshaller<string, nint>.GetUnmanagedValuesSource(__names_native, __names_native__numElements);
				Span<string> __names_native__managedSpan = ArrayMarshaller<string, nint>.GetManagedValuesDestination(names);
				for (int __i0 = 0; __i0 < __names_native__numElements; ++__i0)
				{
					__names_native__managedSpan[__i0] = BStrStringMarshaller.ConvertToManaged((ushort*)__names_native__nativeSpan[__i0])!;
				}
			}
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				{
					ReadOnlySpan<nint> __names_native__nativeSpan = ArrayMarshaller<string, nint>.GetUnmanagedValuesSource(__names_native, __names_native__numElements);
					for (int __i0 = 0; __i0 < __names_native__nativeSpan.Length; ++__i0)
					{
					    BStrStringMarshaller.Free((ushort*)__names_native__nativeSpan[__i0]);
					}
				}

				ArrayMarshaller<string, nint>.Free(__names_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IPropertyStorage.GetEnum(out IEnumStatPropertyStorage enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out enumerator);
		void* __enumerator_native = default;
		int __retVal = default;

		try
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[5])(__this, &__enumerator_native);

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			enumerator = ComInterfaceMarshaller<IEnumStatPropertyStorage>.ConvertToManaged(__enumerator_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumStatPropertyStorage>.Free(__enumerator_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IPropertyStorage.ReadUint(uint id, out uint value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));
		Unsafe.SkipInit(out value);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __value_native = &value)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, int>)__vtable_native[6])(__this, id, __value_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IPropertyStorage.ReadInt(out int value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));
		Unsafe.SkipInit(out value);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (int* __value_native = &value)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[7])(__this, __value_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IPropertyStorage.ReadBool(uint id, out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, int*, int>)__vtable_native[8])(__this, id, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IPropertyStorage.ReadUlong(uint id, out ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));
		Unsafe.SkipInit(out value);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __value_native = &value)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, ulong*, int>)__vtable_native[9])(__this, id, __value_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IPropertyStorage.ReadBStr(uint id, out string value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IPropertyStorage));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out value);
		ushort* __value_native = default;
		int __retVal = default;

		try
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, ushort**, int>)__vtable_native[10])(__this, id, &__value_native);

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			value = BStrStringMarshaller.ConvertToManaged(__value_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__value_native);
			}
		}

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_ReadMultiple(ComWrappers.ComInterfaceDispatch* __this_native, uint specifierCount, PropertySpecifier* specifiers, void** __PropVariant_native__param)
	{
		IPropertyStorage @this = default!;
		ref void* __PropVariant_native = ref *__PropVariant_native__param;
		void* PropVariant = default;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native);
			__retVal = @this.ReadMultiple(specifierCount, specifiers, out PropVariant);
			// Marshal - Convert managed data to native data.
			__PropVariant_native = PropVariant;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_ReadPropertyNames(ComWrappers.ComInterfaceDispatch* __this_native, uint propertyIDCount, uint* propertyIDs, nint** __names_native__param)
	{
		IPropertyStorage @this = default!;
		ref nint* __names_native = ref *__names_native__param;
		string[] names = default!;
		int __retVal = default;
		// Setup - Perform required setup.
		Unsafe.SkipInit(out int __names_native__numElements);

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native);
			__retVal = @this.ReadPropertyNames(propertyIDCount, propertyIDs, out names);
			// Marshal - Convert managed data to native data.
			__names_native = ArrayMarshaller<string, nint>.AllocateContainerForUnmanagedElements(names, out __names_native__numElements);
			{
				ReadOnlySpan<string> __names_native__managedSpan = ArrayMarshaller<string, nint>.GetManagedValuesSource(names);
				Span<nint> __names_native__nativeSpan = ArrayMarshaller<string, nint>.GetUnmanagedValuesDestination(__names_native, __names_native__numElements);
				__names_native__nativeSpan.Clear();
				for (int __i0 = 0; __i0 < __names_native__managedSpan.Length; ++__i0)
				{
					__names_native__nativeSpan[__i0] = (nint)BStrStringMarshaller.ConvertToUnmanaged(__names_native__managedSpan[__i0]);
				}
			}
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetEnum(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		IPropertyStorage @this = default!;
		ref void* __enumerator_native = ref *__enumerator_native__param;
		IEnumStatPropertyStorage enumerator = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native);
			__retVal = @this.GetEnum(out enumerator);
			// Marshal - Convert managed data to native data.
			__enumerator_native = ComInterfaceMarshaller<IEnumStatPropertyStorage>.ConvertToUnmanaged(enumerator);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_ReadUint(ComWrappers.ComInterfaceDispatch* __this_native, uint id, uint* __value_native__param)
	{
		IPropertyStorage @this = default!;
		ref uint __value_native = ref *__value_native__param;
		uint value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native);
			__retVal = @this.ReadUint(id, out value);
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
	static internal int ABI_ReadInt(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		IPropertyStorage @this = default!;
		ref int __value_native = ref *__value_native__param;
		int value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native);
			__retVal = @this.ReadInt(out value);
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
	static internal int ABI_ReadBool(ComWrappers.ComInterfaceDispatch* __this_native, uint id, int* __value_native__param)
	{
		IPropertyStorage @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native);
			__retVal = @this.ReadBool(id, out value);
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
	static internal int ABI_ReadUlong(ComWrappers.ComInterfaceDispatch* __this_native, uint id, ulong* __value_native__param)
	{
		IPropertyStorage @this = default!;
		ref ulong __value_native = ref *__value_native__param;
		ulong value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native);
			__retVal = @this.ReadUlong(id, out value);
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
	static internal int ABI_ReadBStr(ComWrappers.ComInterfaceDispatch* __this_native, uint id, ushort** __value_native__param)
	{
		IPropertyStorage @this = default!;
		ref ushort* __value_native = ref *__value_native__param;
		string value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IPropertyStorage>(__this_native);
			__retVal = @this.ReadBStr(id, out value);
			// Marshal - Convert managed data to native data.
			__value_native = BStrStringMarshaller.ConvertToUnmanaged(value);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IPropertyStorage), sizeof(void*) * 11);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, PropertySpecifier*, void**, int>)&ABI_ReadMultiple;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, nint**, int>)&ABI_ReadPropertyNames;
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetEnum;
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, int>)&ABI_ReadUint;
			vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_ReadInt;
			vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int*, int>)&ABI_ReadBool;
			vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, ulong*, int>)&ABI_ReadUlong;
			vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, ushort**, int>)&ABI_ReadBStr;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IPropertyStorage
	{
	}
}