#pragma warning disable CS0612, CS0618, IDE0008, CA1031
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
	int IDataSource.GetLastError(out string message)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));
		bool __invokeSucceeded = false;
		ushort* __message_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[3])(__this, &__message_native);

			__invokeSucceeded = true;

			message = BStrStringMarshaller.ConvertToManaged(__message_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) BStrStringMarshaller.Free(__message_native);
		}
	}

	[SkipLocalsInit]
	int IDataSource.LoadDataFromPDB(string pdbPath)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));

		fixed (void* __pdbPath_native = &Utf16StringMarshaller.GetPinnableReference(pdbPath))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, int>)__vtable_native[4])(__this, (ushort*)__pdbPath_native);
		}
	}

	[SkipLocalsInit]
	int IDataSource.LoadAndValidateDataFromPDB(string pdbPath, Guid* pdbSignature, uint signature, uint age)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));

		fixed (void* __pdbPath_native = &Utf16StringMarshaller.GetPinnableReference(pdbPath))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, Guid*, uint, uint, int>)__vtable_native[5])(__this, (ushort*)__pdbPath_native, pdbSignature, signature, age);
		}
	}

	[SkipLocalsInit]
	int IDataSource.LoadDataForExe(string exePath, string searchPath, void* callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));

		fixed (void* __searchPath_native = &Utf16StringMarshaller.GetPinnableReference(searchPath))
		fixed (void* __exePath_native = &Utf16StringMarshaller.GetPinnableReference(exePath))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort*, void*, int>)__vtable_native[6])(__this, (ushort*)__exePath_native, (ushort*)__searchPath_native, callback);
		}
	}

	[SkipLocalsInit]
	int IDataSource.LoadDataFromIStream(IStream stream)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));
		void* __stream_native = null;

		try
		{
			__stream_native = ComInterfaceMarshaller<IStream>.ConvertToUnmanaged(stream);

			return ((delegate* unmanaged[MemberFunction]<void*, void*, int>)__vtable_native[7])(__this, __stream_native);
		}
		finally
		{
			ComInterfaceMarshaller<IStream>.Free(__stream_native);
		}
	}

	[SkipLocalsInit]
	int IDataSource.OpenSession(out ISession session)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));
		bool __invokeSucceeded = false;
		void* __session_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[8])(__this, &__session_native);

			__invokeSucceeded = true;

			session = ComInterfaceMarshaller<ISession>.ConvertToManaged(__session_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<ISession>.Free(__session_native);
		}
	}

	[SkipLocalsInit]
	int IDataSource.LoadDataFromCodeViewInfo(string executable, string searchPath, uint infoSize, byte* info, void* callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));

		fixed (void* __searchPath_native = &Utf16StringMarshaller.GetPinnableReference(searchPath))
		fixed (void* __executable_native = &Utf16StringMarshaller.GetPinnableReference(executable))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort*, uint, byte*, void*, int>)__vtable_native[9])(__this, (ushort*)__executable_native, (ushort*)__searchPath_native, infoSize, info, callback);
		}
	}

	[SkipLocalsInit]
	int IDataSource.LoadDataFromMiscInfo(string executable, string searchPath, uint exeTimestamp, uint debugTimestamp, uint exeSize, uint infoSize, byte* info, void* callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSource));

		fixed (void* __searchPath_native = &Utf16StringMarshaller.GetPinnableReference(searchPath))
		fixed (void* __executable_native = &Utf16StringMarshaller.GetPinnableReference(executable))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort*, uint, uint, uint, uint, byte*, void*, int>)__vtable_native[10])(__this, (ushort*)__executable_native, (ushort*)__searchPath_native, exeTimestamp, debugTimestamp, exeSize, infoSize, info, callback);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLastError(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __message_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native).GetLastError(out string message);

			*__message_native__param = BStrStringMarshaller.ConvertToUnmanaged(message);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_LoadDataFromPDB(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __pdbPath_native)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native).LoadDataFromPDB(Utf16StringMarshaller.ConvertToManaged(__pdbPath_native)!);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_LoadAndValidateDataFromPDB(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __pdbPath_native, Guid* pdbSignature, uint signature, uint age)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native).LoadAndValidateDataFromPDB(Utf16StringMarshaller.ConvertToManaged(__pdbPath_native)!, pdbSignature, signature, age);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_LoadDataForExe(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __exePath_native, ushort* __searchPath_native, void* callback)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native).LoadDataForExe(Utf16StringMarshaller.ConvertToManaged(__exePath_native)!, Utf16StringMarshaller.ConvertToManaged(__searchPath_native)!, callback);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_LoadDataFromIStream(ComWrappers.ComInterfaceDispatch* __this_native, void* __stream_native)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native).LoadDataFromIStream(ComInterfaceMarshaller<IStream>.ConvertToManaged(__stream_native)!);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_OpenSession(ComWrappers.ComInterfaceDispatch* __this_native, void** __session_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native).OpenSession(out ISession session);

			*__session_native__param = ComInterfaceMarshaller<ISession>.ConvertToUnmanaged(session);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_LoadDataFromCodeViewInfo(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __executable_native, ushort* __searchPath_native, uint infoSize, byte* info, void* callback)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native).LoadDataFromCodeViewInfo(Utf16StringMarshaller.ConvertToManaged(__executable_native)!, Utf16StringMarshaller.ConvertToManaged(__searchPath_native)!, infoSize, info, callback);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_LoadDataFromMiscInfo(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __executable_native, ushort* __searchPath_native, uint exeTimestamp, uint debugTimestamp, uint exeSize, uint infoSize, byte* info, void* callback)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IDataSource>(__this_native).LoadDataFromMiscInfo(Utf16StringMarshaller.ConvertToManaged(__executable_native)!, Utf16StringMarshaller.ConvertToManaged(__searchPath_native)!, exeTimestamp, debugTimestamp, exeSize, infoSize, info, callback);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IDataSource), sizeof(void*) * 11);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetLastError;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, int>)&ABI_LoadDataFromPDB;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, Guid*, uint, uint, int>)&ABI_LoadAndValidateDataFromPDB;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, ushort*, void*, int>)&ABI_LoadDataForExe;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, int>)&ABI_LoadDataFromIStream;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_OpenSession;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, ushort*, uint, byte*, void*, int>)&ABI_LoadDataFromCodeViewInfo;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, ushort*, uint, uint, uint, uint, byte*, void*, int>)&ABI_LoadDataFromMiscInfo;

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