#pragma warning disable CS0612, CS0618, IDE0008
using DiaSharp.SDK.Enumerators;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([179, 30, 205, 69, 108, 92, 227, 67, 178, 10, 164, 216, 3, 93, 228, 226]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumSourceLink
{
	[SkipLocalsInit]
	int IEnumSourceLink.Count(out uint count)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink));
		Unsafe.SkipInit(out count);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __count_native = &count)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __count_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumSourceLink.SizeOfNext(out uint size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink));
		Unsafe.SkipInit(out size);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __size_native = &size)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[4])(__this, __size_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumSourceLink.GetNext(uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink));
		Unsafe.SkipInit(out bytesWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[5])(__this, bufferSize, __bytesWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumSourceLink.Skip(uint byteCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[6])(__this, byteCount);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumSourceLink.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[7])(__this);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IEnumSourceLink.Clone(out IEnumSourceLink enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out enumerator);
		void* __enumerator_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[8])(__this, &__enumerator_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			enumerator = ComInterfaceMarshaller<IEnumSourceLink>.ConvertToManaged(__enumerator_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSourceLink>.Free(__enumerator_native);
			}
		}

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Count(ComWrappers.ComInterfaceDispatch* __this_native, uint* __count_native__param)
	{
		IEnumSourceLink @this = default!;
		ref uint __count_native = ref *__count_native__param;
		uint count = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSourceLink>(__this_native);
			__retVal = @this.Count(out count);
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
	static internal int ABI_SizeOfNext(ComWrappers.ComInterfaceDispatch* __this_native, uint* __size_native__param)
	{
		IEnumSourceLink @this = default!;
		ref uint __size_native = ref *__size_native__param;
		uint size = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSourceLink>(__this_native);
			__retVal = @this.SizeOfNext(out size);
			// Marshal - Convert managed data to native data.
			__size_native = size;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint bufferSize, uint* __bytesWritten_native__param, byte* buffer)
	{
		IEnumSourceLink @this = default!;
		ref uint __bytesWritten_native = ref *__bytesWritten_native__param;
		uint bytesWritten = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSourceLink>(__this_native);
			__retVal = @this.GetNext(bufferSize, out bytesWritten, buffer);
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
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint byteCount)
	{
		int __retVal;

		try
		{
			IEnumSourceLink @this = default!;
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSourceLink>(__this_native);
			__retVal = @this.Skip(byteCount);
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
			IEnumSourceLink @this = default!;
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSourceLink>(__this_native);
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
		IEnumSourceLink @this = default!;
		ref void* __enumerator_native = ref *__enumerator_native__param;
		IEnumSourceLink enumerator = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSourceLink>(__this_native);
			__retVal = @this.Clone(out enumerator);
			// Marshal - Convert managed data to native data.
			__enumerator_native = ComInterfaceMarshaller<IEnumSourceLink>.ConvertToUnmanaged(enumerator);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumSourceLink), sizeof(void*) * 9);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_Count;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_SizeOfNext;
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, byte*, int>)&ABI_GetNext;
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int>)&ABI_Skip;
			vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Reset;
			vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK.Enumerators
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumSourceLink
	{
	}
}