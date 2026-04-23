#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.CodeView;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([83, 83, 239, 162, 168, 245, 179, 78, 144, 210, 203, 82, 106, 203, 60, 221]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ISourceFile
{
	[SkipLocalsInit]
	int ISourceFile.GetUniqueID(out uint id)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISourceFile));
		Unsafe.SkipInit(out id);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __ID_native = &id)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __ID_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISourceFile.GetFileName(out string name)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISourceFile));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out name);
		ushort* __name_native = default;
		int __retVal = default;

		try
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[4])(__this, &__name_native);

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
	int ISourceFile.GetChecksumType(out SourceChecksumType type)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISourceFile));
		Unsafe.SkipInit(out type);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (SourceChecksumType* __type_native = &type)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, SourceChecksumType*, int>)__vtable_native[5])(__this, __type_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISourceFile.GetCompilands(out IEnumSymbols compilands)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISourceFile));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out compilands);
		void* __compilands_native = default;
		int __retVal = default;

		try
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[6])(__this, &__compilands_native);

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			compilands = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__compilands_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumSymbols>.Free(__compilands_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISourceFile.GetChecksum(uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISourceFile));
		Unsafe.SkipInit(out bytesWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[7])(__this, bufferSize, __bytesWritten_native, buffer);
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
		ISourceFile @this = default!;
		ref uint __ID_native = ref *__ID_native__param;
		uint id = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISourceFile>(__this_native);
			__retVal = @this.GetUniqueID(out id);
			// Marshal - Convert managed data to native data.
			__ID_native = id;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetFileName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __name_native__param)
	{
		ISourceFile @this = default!;
		ref ushort* __name_native = ref *__name_native__param;
		string name = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISourceFile>(__this_native);
			__retVal = @this.GetFileName(out name);
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
	static internal int ABI_GetChecksumType(ComWrappers.ComInterfaceDispatch* __this_native, SourceChecksumType* __type_native__param)
	{
		ISourceFile @this = default!;
		ref SourceChecksumType __type_native = ref *__type_native__param;
		SourceChecksumType type = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISourceFile>(__this_native);
			__retVal = @this.GetChecksumType(out type);
			// Marshal - Convert managed data to native data.
			__type_native = type;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetCompilands(ComWrappers.ComInterfaceDispatch* __this_native, void** __compilands_native__param)
	{
		ISourceFile @this = default!;
		ref void* __compilands_native = ref *__compilands_native__param;
		IEnumSymbols compilands = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISourceFile>(__this_native);
			__retVal = @this.GetCompilands(out compilands);
			// Marshal - Convert managed data to native data.
			__compilands_native = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(compilands);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetChecksum(ComWrappers.ComInterfaceDispatch* __this_native, uint bufferSize, uint* __bytesWritten_native__param, byte* buffer)
	{
		ISourceFile @this = default!;
		ref uint __bytesWritten_native = ref *__bytesWritten_native__param;
		uint bytesWritten = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISourceFile>(__this_native);
			__retVal = @this.GetChecksum(bufferSize, out bytesWritten, buffer);
			// Marshal - Convert managed data to native data.
			__bytesWritten_native = bytesWritten;
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ISourceFile), sizeof(void*) * 8);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetUniqueID;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetFileName;
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, SourceChecksumType*, int>)&ABI_GetChecksumType;
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetCompilands;
			vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, byte*, int>)&ABI_GetChecksum;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface ISourceFile
	{
	}
}