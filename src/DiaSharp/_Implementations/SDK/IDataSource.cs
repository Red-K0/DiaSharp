#pragma warning disable CS0612, CS0618, IDE0008
using DiaSharp.SDK;
using DiaSharp.Storage;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([95, 187, 241, 121, 110, 182, 229, 72, 182, 169, 21, 69, 195, 35, 202, 61]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IDataSource
{
	[SkipLocalsInit]
	int IDataSource.GetLastError(out string error)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out error);
		ushort* __error_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[3])(__this, &__error_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			error = BStrStringMarshaller.ConvertToManaged(__error_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__error_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSource.LoadDataFromPdb(string pdbPath)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (void* __pdbPath_native = &Utf16StringMarshaller.GetPinnableReference(pdbPath))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, int>)__vtable_native[4])(__this, (ushort*)__pdbPath_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSource.LoadAndValidateDataFromPdb(string pdbPath, Guid* pdbSignature, uint signature, uint age)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (void* __pdbPath_native = &Utf16StringMarshaller.GetPinnableReference(pdbPath))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, Guid*, uint, uint, int>)__vtable_native[5])(__this, (ushort*)__pdbPath_native, pdbSignature, signature, age);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSource.LoadDataForExe(string exePath, string searchPath, void* callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (void* __searchPath_native = &Utf16StringMarshaller.GetPinnableReference(searchPath))
		fixed (void* __exePath_native = &Utf16StringMarshaller.GetPinnableReference(exePath))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort*, void*, int>)__vtable_native[6])(__this, (ushort*)__exePath_native, (ushort*)__searchPath_native, callback);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSource.LoadDataFromIStream(IStream stream)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));
		void* __stream_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__stream_native = ComInterfaceMarshaller<IStream>.ConvertToUnmanaged(stream);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, int>)__vtable_native[7])(__this, __stream_native);
			}

			GC.KeepAlive(this);
		}
		finally
		{
			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<IStream>.Free(__stream_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSource.OpenSession(out ISession session)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out session);
		void* __session_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[8])(__this, &__session_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			session = ComInterfaceMarshaller<ISession>.ConvertToManaged(__session_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISession>.Free(__session_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSource.LoadDataFromCodeViewInfo(string executable, string searchPath, uint infoSize, byte* info, void* callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (void* __searchPath_native = &Utf16StringMarshaller.GetPinnableReference(searchPath))
		fixed (void* __executable_native = &Utf16StringMarshaller.GetPinnableReference(executable))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort*, uint, byte*, void*, int>)__vtable_native[9])(__this, (ushort*)__executable_native, (ushort*)__searchPath_native, infoSize, info, callback);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSource.LoadDataFromMiscInfo(string executable, string searchPath, uint exeTimestamp, uint debugTimestamp, uint exeSize, uint infoSize, byte* info, void* callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (void* __searchPath_native = &Utf16StringMarshaller.GetPinnableReference(searchPath))
		fixed (void* __executable_native = &Utf16StringMarshaller.GetPinnableReference(executable))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort*, uint, uint, uint, uint, byte*, void*, int>)__vtable_native[10])(__this, (ushort*)__executable_native, (ushort*)__searchPath_native, exeTimestamp, debugTimestamp, exeSize, infoSize, info, callback);
		}

		GC.KeepAlive(this);
		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetLastError(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __error_native__param)
	{
		IDataSource @this = default!;
		ref ushort* __error_native = ref *__error_native__param;
		string error = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native);
			__retVal = @this.GetLastError(out error);
			// Marshal - Convert managed data to native data.
			__error_native = BStrStringMarshaller.ConvertToUnmanaged(error);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_LoadDataFromPdb(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __pdbPath_native)
	{
		int __retVal;

		try
		{
			string pdbPath = Utf16StringMarshaller.ConvertToManaged(__pdbPath_native)!;
			// Unmarshal - Convert native data to managed data.
			IDataSource @this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native);
			__retVal = @this.LoadDataFromPdb(pdbPath);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_LoadAndValidateDataFromPdb(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __pdbPath_native, Guid* pdbSignature, uint signature, uint age)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			string pdbPath = Utf16StringMarshaller.ConvertToManaged(__pdbPath_native)!;
			IDataSource @this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native);
			__retVal = @this.LoadAndValidateDataFromPdb(pdbPath, pdbSignature, signature, age);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_LoadDataForExe(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __exePath_native, ushort* __searchPath_native, void* callback)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			string searchPath = Utf16StringMarshaller.ConvertToManaged(__searchPath_native)!;
			string exePath = Utf16StringMarshaller.ConvertToManaged(__exePath_native)!;
			IDataSource @this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native);
			__retVal = @this.LoadDataForExe(exePath, searchPath, callback);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_LoadDataFromIStream(ComWrappers.ComInterfaceDispatch* __this_native, void* __stream_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			IStream stream = ComInterfaceMarshaller<IStream>.ConvertToManaged(__stream_native)!;
			IDataSource @this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native);
			__retVal = @this.LoadDataFromIStream(stream);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_OpenSession(ComWrappers.ComInterfaceDispatch* __this_native, void** __session_native__param)
	{
		IDataSource @this = default!;
		ref void* __session_native = ref *__session_native__param;
		ISession session = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native);
			__retVal = @this.OpenSession(out session);
			// Marshal - Convert managed data to native data.
			__session_native = ComInterfaceMarshaller<ISession>.ConvertToUnmanaged(session);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_LoadDataFromCodeViewInfo(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __executable_native, ushort* __searchPath_native, uint infoSize, byte* info, void* callback)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			string searchPath = Utf16StringMarshaller.ConvertToManaged(__searchPath_native)!;
			string executable = Utf16StringMarshaller.ConvertToManaged(__executable_native)!;
			IDataSource @this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native);
			__retVal = @this.LoadDataFromCodeViewInfo(executable, searchPath, infoSize, info, callback);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_LoadDataFromMiscInfo(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __executable_native, ushort* __searchPath_native, uint exeTimestamp, uint debugTimestamp, uint exeSize, uint infoSize, byte* info, void* callback)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			string searchPath = Utf16StringMarshaller.ConvertToManaged(__searchPath_native)!;
			string executable = Utf16StringMarshaller.ConvertToManaged(__executable_native)!;
			IDataSource @this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native);
			__retVal = @this.LoadDataFromMiscInfo(executable, searchPath, exeTimestamp, debugTimestamp, exeSize, infoSize, info, callback);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IDataSource), sizeof(void*) * 11);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetLastError;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, int>)&ABI_LoadDataFromPdb;
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, Guid*, uint, uint, int>)&ABI_LoadAndValidateDataFromPdb;
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, ushort*, void*, int>)&ABI_LoadDataForExe;
			vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, int>)&ABI_LoadDataFromIStream;
			vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_OpenSession;
			vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, ushort*, uint, byte*, void*, int>)&ABI_LoadDataFromCodeViewInfo;
			vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, ushort*, uint, uint, uint, uint, byte*, void*, int>)&ABI_LoadDataFromMiscInfo;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IDataSource
	{
	}
}