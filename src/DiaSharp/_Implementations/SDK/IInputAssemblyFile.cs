#pragma warning disable CS0612, CS0618, IDE0008
using DiaSharp.SDK;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([176, 86, 254, 59, 12, 57, 99, 72, 148, 48, 31, 61, 8, 59, 118, 132]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IInputAssemblyFile
{
	[SkipLocalsInit]
	int IInputAssemblyFile.GetUniqueID(out uint ID)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInputAssemblyFile));
		Unsafe.SkipInit(out ID);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __ID_native = &ID)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __ID_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IInputAssemblyFile.GetIndex(out uint index)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInputAssemblyFile));
		Unsafe.SkipInit(out index);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __index_native = &index)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[4])(__this, __index_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IInputAssemblyFile.GetTimestamp(out uint timestamp)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInputAssemblyFile));
		Unsafe.SkipInit(out timestamp);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __timestamp_native = &timestamp)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[5])(__this, __timestamp_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IInputAssemblyFile.GetWasPDBAvailableAtILMerge(out bool available)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInputAssemblyFile));
		Unsafe.SkipInit(out available);
		int __available_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[6])(__this, &__available_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		available = __available_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IInputAssemblyFile.GetFilename(out string name)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInputAssemblyFile));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out name);
		ushort* __name_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[7])(__this, &__name_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			name = BStrStringMarshaller.ConvertToManaged(__name_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__name_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IInputAssemblyFile.GetVersion(uint bufferSize, out uint dataSize, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInputAssemblyFile));
		Unsafe.SkipInit(out dataSize);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __dataSize_native = &dataSize)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[8])(__this, bufferSize, __dataSize_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetUniqueID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __ID_native__param)
	{
		IInputAssemblyFile @this = default!;
		ref uint __ID_native = ref *__ID_native__param;
		uint ID = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IInputAssemblyFile>(__this_native);
			__retVal = @this.GetUniqueID(out ID);
			// Marshal - Convert managed data to native data.
			__ID_native = ID;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetIndex(ComWrappers.ComInterfaceDispatch* __this_native, uint* __index_native__param)
	{
		IInputAssemblyFile @this = default!;
		ref uint __index_native = ref *__index_native__param;
		uint index = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IInputAssemblyFile>(__this_native);
			__retVal = @this.GetIndex(out index);
			// Marshal - Convert managed data to native data.
			__index_native = index;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetTimestamp(ComWrappers.ComInterfaceDispatch* __this_native, uint* __timestamp_native__param)
	{
		IInputAssemblyFile @this = default!;
		ref uint __timestamp_native = ref *__timestamp_native__param;
		uint timestamp = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IInputAssemblyFile>(__this_native);
			__retVal = @this.GetTimestamp(out timestamp);
			// Marshal - Convert managed data to native data.
			__timestamp_native = timestamp;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetWasPDBAvailableAtILMerge(ComWrappers.ComInterfaceDispatch* __this_native, int* __available_native__param)
	{
		IInputAssemblyFile @this = default!;
		ref int __available_native = ref *__available_native__param;
		bool available = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IInputAssemblyFile>(__this_native);
			__retVal = @this.GetWasPDBAvailableAtILMerge(out available);
			// Marshal - Convert managed data to native data.
			__available_native = available ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetFilename(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __name_native__param)
	{
		IInputAssemblyFile @this = default!;
		ref ushort* __name_native = ref *__name_native__param;
		string name = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IInputAssemblyFile>(__this_native);
			__retVal = @this.GetFilename(out name);
			// Marshal - Convert managed data to native data.
			__name_native = BStrStringMarshaller.ConvertToUnmanaged(name);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetVersion(ComWrappers.ComInterfaceDispatch* __this_native, uint bufferSize, uint* __dataSize_native__param, byte* buffer)
	{
		IInputAssemblyFile @this = default!;
		ref uint __dataSize_native = ref *__dataSize_native__param;
		uint dataSize = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IInputAssemblyFile>(__this_native);
			__retVal = @this.GetVersion(bufferSize, out dataSize, buffer);
			// Marshal - Convert managed data to native data.
			__dataSize_native = dataSize;
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IInputAssemblyFile), sizeof(void*) * 9);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetUniqueID;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetIndex;
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetTimestamp;
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetWasPDBAvailableAtILMerge;
			vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetFilename;
			vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, byte*, int>)&ABI_GetVersion;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IInputAssemblyFile
	{
	}
}