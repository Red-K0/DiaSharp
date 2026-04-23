#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.SDK;
using DiaSharp.SDK.Callbacks;
using DiaSharp.Storage;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([105, 235, 33, 26, 42, 150, 196, 75, 139, 211, 104, 23, 151, 211, 139, 35]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IDataSourceEx
{
	[SkipLocalsInit]
	int IDataSourceEx.LoadDataFromPDB(string pdbPath, bool prefetchPDB)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
		int __prefetchPDB_native;
		int __retVal;
		// Marshal - Convert managed data to native data.
		__prefetchPDB_native = prefetchPDB ? 1 : 0;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (void* __pdbPath_native = &Utf16StringMarshaller.GetPinnableReference(pdbPath))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, int, int>)__vtable_native[11])(__this, (ushort*)__pdbPath_native, __prefetchPDB_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSourceEx.LoadAndValidateDataFromPDB(string pdbPath, Guid* pdbSignature, uint signature, uint age, bool prefetchPDB)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
		int __prefetchPDB_native;
		int __retVal;
		// Marshal - Convert managed data to native data.
		__prefetchPDB_native = prefetchPDB ? 1 : 0;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (void* __pdbPath_native = &Utf16StringMarshaller.GetPinnableReference(pdbPath))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, Guid*, uint, uint, int, int>)__vtable_native[12])(__this, (ushort*)__pdbPath_native, pdbSignature, signature, age, __prefetchPDB_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSourceEx.LoadDataForExe(string executable, string searchPath, void* callback, bool prefetchPDB)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
		int __prefetchPDB_native;
		int __retVal;
		// Marshal - Convert managed data to native data.
		__prefetchPDB_native = prefetchPDB ? 1 : 0;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (void* __searchPath_native = &Utf16StringMarshaller.GetPinnableReference(searchPath))
		fixed (void* __executable_native = &Utf16StringMarshaller.GetPinnableReference(executable))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort*, void*, int, int>)__vtable_native[13])(__this, (ushort*)__executable_native, (ushort*)__searchPath_native, callback, __prefetchPDB_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSourceEx.LoadDataFromIStream(IStream stream, bool prefetchPDB)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
		void* __stream_native = default;
		int __prefetchPDB_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__prefetchPDB_native = prefetchPDB ? 1 : 0;
			__stream_native = ComInterfaceMarshaller<IStream>.ConvertToUnmanaged(stream);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, int, int>)__vtable_native[14])(__this, __stream_native, __prefetchPDB_native);
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
	int IDataSourceEx.GetStreamSize(string stream, out ulong size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
		Unsafe.SkipInit(out size);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __size_native = &size)
		fixed (void* __stream_native = &Utf16StringMarshaller.GetPinnableReference(stream))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, ulong*, int>)__vtable_native[15])(__this, (ushort*)__stream_native, __size_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSourceEx.GetStreamRawData(string stream, ulong byteOffset, ulong bufferSize, out ulong bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
		Unsafe.SkipInit(out bytesWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __bytesWritten_native = &bytesWritten)
		fixed (void* __stream_native = &Utf16StringMarshaller.GetPinnableReference(stream))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, ulong, ulong, ulong*, byte*, int>)__vtable_native[16])(__this, (ushort*)__stream_native, byteOffset, bufferSize, __bytesWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSourceEx.SetMiniPDBErrorCallback(nint context, MiniPDBErrorCallback callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
		nint __callback_native;
		int __retVal;
		// Marshal - Convert managed data to native data.
		__callback_native = callback != null ? Marshal.GetFunctionPointerForDelegate(callback) : default;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, nint, nint, int>)__vtable_native[17])(__this, context, __callback_native);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(callback);
		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSourceEx.ValidatePDB(string pdbPath, Guid* pdbSignature, uint signature, uint age, out bool valid)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
		Unsafe.SkipInit(out valid);
		int __valid_native;
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (void* __pdbPath_native = &Utf16StringMarshaller.GetPinnableReference(pdbPath))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, Guid*, uint, uint, int*, int>)__vtable_native[18])(__this, (ushort*)__pdbPath_native, pdbSignature, signature, age, &__valid_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		valid = __valid_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSourceEx.GetLastError(out string message)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out message);
		ushort* __message_native = default;
		int __retVal = default;

		try
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[3])(__this, &__message_native);

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			message = BStrStringMarshaller.ConvertToManaged(__message_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				BStrStringMarshaller.Free(__message_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IDataSourceEx.LoadDataFromPDB(string pdbPath)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
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
	int IDataSourceEx.LoadAndValidateDataFromPDB(string pdbPath, Guid* pdbSignature, uint signature, uint age)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
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
	int IDataSourceEx.LoadDataForExe(string exePath, string searchPath, void* callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
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
	int IDataSourceEx.LoadDataFromIStream(IStream stream)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
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
	int IDataSourceEx.OpenSession(out ISession session)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out session);
		void* __session_native = default;
		int __retVal = default;

		try
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[8])(__this, &__session_native);

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
	int IDataSourceEx.LoadDataFromCodeViewInfo(string executable, string searchPath, uint infoSize, byte* info, void* callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
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
	int IDataSourceEx.LoadDataFromMiscInfo(string executable, string searchPath, uint exeTimestamp, uint debugTimestamp, uint exeSize, uint infoSize, byte* info, void* callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx));
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

	int IDataSource.GetLastError(out string message) => throw new UnreachableException();
	int IDataSource.LoadDataFromPDB(string pdbPath) => throw new UnreachableException();
	int IDataSource.LoadAndValidateDataFromPDB(string pdbPath, Guid* pdbSignature, uint signature, uint age) => throw new UnreachableException();
	int IDataSource.LoadDataForExe(string exePath, string searchPath, void* callback) => throw new UnreachableException();
	int IDataSource.LoadDataFromIStream(IStream stream) => throw new UnreachableException();
	int IDataSource.OpenSession(out ISession session) => throw new UnreachableException();
	int IDataSource.LoadDataFromCodeViewInfo(string executable, string searchPath, uint infoSize, byte* info, void* callback) => throw new UnreachableException();
	int IDataSource.LoadDataFromMiscInfo(string executable, string searchPath, uint exeTimestamp, uint debugTimestamp, uint exeSize, uint infoSize, byte* info, void* callback) => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_LoadDataFromPDB(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __pdbPath_native, int __prefetchPDB_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			bool prefetchPDB = __prefetchPDB_native != 0;
			string pdbPath = Utf16StringMarshaller.ConvertToManaged(__pdbPath_native)!;
			IDataSourceEx @this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSourceEx>(__this_native);
			__retVal = @this.LoadDataFromPDB(pdbPath, prefetchPDB);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_LoadAndValidateDataFromPDB(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __pdbPath_native, Guid* pdbSignature, uint signature, uint age, int __prefetchPDB_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			bool prefetchPDB = __prefetchPDB_native != 0;
			string pdbPath = Utf16StringMarshaller.ConvertToManaged(__pdbPath_native)!;
			IDataSourceEx @this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSourceEx>(__this_native);
			__retVal = @this.LoadAndValidateDataFromPDB(pdbPath, pdbSignature, signature, age, prefetchPDB);
			// Marshal - Convert managed data to native data.
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_LoadDataForExe(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __executable_native, ushort* __searchPath_native, void* callback, int __prefetchPDB_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			bool prefetchPDB = __prefetchPDB_native != 0;
			string searchPath = Utf16StringMarshaller.ConvertToManaged(__searchPath_native)!;
			string executable = Utf16StringMarshaller.ConvertToManaged(__executable_native)!;
			IDataSourceEx @this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSourceEx>(__this_native);
			__retVal = @this.LoadDataForExe(executable, searchPath, callback, prefetchPDB);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_LoadDataFromIStream(ComWrappers.ComInterfaceDispatch* __this_native, void* __stream_native, int __prefetchPDB_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			bool prefetchPDB = __prefetchPDB_native != 0;
			IStream stream = ComInterfaceMarshaller<IStream>.ConvertToManaged(__stream_native)!;
			IDataSourceEx @this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSourceEx>(__this_native);
			__retVal = @this.LoadDataFromIStream(stream, prefetchPDB);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetStreamSize(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __stream_native, ulong* __size_native__param)
	{
		IDataSourceEx @this = default!;
		string stream = default!;
		ref ulong __size_native = ref *__size_native__param;
		ulong size = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			stream = Utf16StringMarshaller.ConvertToManaged(__stream_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSourceEx>(__this_native);
			__retVal = @this.GetStreamSize(stream, out size);
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
	static internal int ABI_GetStreamRawData(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __stream_native, ulong byteOffset, ulong bufferSize, ulong* __bytesWritten_native__param, byte* buffer)
	{
		IDataSourceEx @this = default!;
		string stream = default!;
		ref ulong __bytesWritten_native = ref *__bytesWritten_native__param;
		ulong bytesWritten = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			stream = Utf16StringMarshaller.ConvertToManaged(__stream_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSourceEx>(__this_native);
			__retVal = @this.GetStreamRawData(stream, byteOffset, bufferSize, out bytesWritten, buffer);
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
	static internal int ABI_SetMiniPDBErrorCallback(ComWrappers.ComInterfaceDispatch* __this_native, nint context, nint __callback_native)
	{
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			MiniPDBErrorCallback callback = __callback_native != default ? Marshal.GetDelegateForFunctionPointer<MiniPDBErrorCallback>(__callback_native) : default!;
			IDataSourceEx @this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSourceEx>(__this_native);
			__retVal = @this.SetMiniPDBErrorCallback(context, callback);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_ValidatePDB(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __pdbPath_native, Guid* pdbSignature, uint signature, uint age, int* __valid_native__param)
	{
		IDataSourceEx @this = default!;
		string pdbPath = default!;
		ref int __valid_native = ref *__valid_native__param;
		bool valid = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			pdbPath = Utf16StringMarshaller.ConvertToManaged(__pdbPath_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSourceEx>(__this_native);
			__retVal = @this.ValidatePDB(pdbPath, pdbSignature, signature, age, out valid);
			// Marshal - Convert managed data to native data.
			__valid_native = valid ? 1 : 0;
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IDataSourceEx), sizeof(void*) * 19);
		{
			NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(IDataSource).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 11));
		}

		{
			vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, int, int>)&ABI_LoadDataFromPDB;
			vtable[12] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, Guid*, uint, uint, int, int>)&ABI_LoadAndValidateDataFromPDB;
			vtable[13] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, ushort*, void*, int, int>)&ABI_LoadDataForExe;
			vtable[14] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, int, int>)&ABI_LoadDataFromIStream;
			vtable[15] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, ulong*, int>)&ABI_GetStreamSize;
			vtable[16] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, ulong, ulong, ulong*, byte*, int>)&ABI_GetStreamRawData;
			vtable[17] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, nint, nint, int>)&ABI_SetMiniPDBErrorCallback;
			vtable[18] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, Guid*, uint, uint, int*, int>)&ABI_ValidatePDB;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public unsafe partial interface IDataSourceEx
	{

		[SkipLocalsInit, PreserveSig]
		new int GetLastError(out string message) => ((IDataSource)this).GetLastError(out message);

		[SkipLocalsInit, PreserveSig]
		new int LoadDataFromPDB(string pdbPath) => ((IDataSource)this).LoadDataFromPDB(pdbPath);

		[SkipLocalsInit, PreserveSig]
		new int LoadAndValidateDataFromPDB(string pdbPath, Guid* pdbSignature, uint signature, uint age) => ((IDataSource)this).LoadAndValidateDataFromPDB(pdbPath, pdbSignature, signature, age);

		[SkipLocalsInit, PreserveSig]
		new int LoadDataForExe(string exePath, string searchPath, void* callback) => ((IDataSource)this).LoadDataForExe(exePath, searchPath, callback);

		[SkipLocalsInit, PreserveSig]
		new int LoadDataFromIStream(IStream stream) => ((IDataSource)this).LoadDataFromIStream(stream);

		[SkipLocalsInit, PreserveSig]
		new int OpenSession(out ISession session) => ((IDataSource)this).OpenSession(out session);

		[SkipLocalsInit, PreserveSig]
		new int LoadDataFromCodeViewInfo(string executable, string searchPath, uint infoSize, byte* info, void* callback) => ((IDataSource)this).LoadDataFromCodeViewInfo(executable, searchPath, infoSize, info, callback);

		[SkipLocalsInit, PreserveSig]
		new int LoadDataFromMiscInfo(string executable, string searchPath, uint exeTimestamp, uint debugTimestamp, uint exeSize, uint infoSize, byte* info, void* callback) => ((IDataSource)this).LoadDataFromMiscInfo(executable, searchPath, exeTimestamp, debugTimestamp, exeSize, infoSize, info, callback);
	}
}