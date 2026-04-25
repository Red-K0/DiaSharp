#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.CodeView;
using DiaSharp.SDK;
using DiaSharp.SDK.Callbacks;
using DiaSharp.SDK.Enumerators;
using DiaSharp.Storage;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([221, 200, 64, 210, 15, 26, 110, 69, 128, 166, 79, 29, 6, 191, 93, 244]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IDataSourceEx2
{
	[SkipLocalsInit]
	int IDataSourceEx2.FindNamedStreams(string name, NameSearchOptions searchOptions, out IEnumNamedStreams streams)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));
		bool __invokeSucceeded = false;
		void* __streams_native = null;
		int __retVal;

		scoped BStrStringMarshaller.ManagedToUnmanagedIn __name_native__marshaller = new();

		try
		{
			__name_native__marshaller.FromManaged(name, stackalloc byte[BStrStringMarshaller.ManagedToUnmanagedIn.BufferSize]);

			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, NameSearchOptions, void**, int>)__vtable_native[19])(__this, __name_native__marshaller.ToUnmanaged(), searchOptions, &__streams_native);

			__invokeSucceeded = true;

			streams = ComInterfaceMarshaller<IEnumNamedStreams>.ConvertToManaged(__streams_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<IEnumNamedStreams>.Free(__streams_native);

			__name_native__marshaller.Free();
		}
	}

	[SkipLocalsInit]
	int IDataSourceEx2.GetLastError(out string message)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));
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
	int IDataSourceEx2.LoadDataFromPDB(string pdbPath)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));

		fixed (void* __pdbPath_native = &Utf16StringMarshaller.GetPinnableReference(pdbPath))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, int>)__vtable_native[4])(__this, (ushort*)__pdbPath_native);
		}
	}

	[SkipLocalsInit]
	int IDataSourceEx2.LoadAndValidateDataFromPDB(string pdbPath, Guid* pdbSignature, uint signature, uint age)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));

		fixed (void* __pdbPath_native = &Utf16StringMarshaller.GetPinnableReference(pdbPath))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, Guid*, uint, uint, int>)__vtable_native[5])(__this, (ushort*)__pdbPath_native, pdbSignature, signature, age);
		}
	}

	[SkipLocalsInit]
	int IDataSourceEx2.LoadDataForExe(string exePath, string searchPath, void* callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));

		fixed (void* __searchPath_native = &Utf16StringMarshaller.GetPinnableReference(searchPath))
		fixed (void* __exePath_native = &Utf16StringMarshaller.GetPinnableReference(exePath))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort*, void*, int>)__vtable_native[6])(__this, (ushort*)__exePath_native, (ushort*)__searchPath_native, callback);
		}
	}

	[SkipLocalsInit]
	int IDataSourceEx2.LoadDataFromIStream(IStream stream)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));
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
	int IDataSourceEx2.OpenSession(out ISession session)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));
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
	int IDataSourceEx2.LoadDataFromCodeViewInfo(string executable, string searchPath, uint infoSize, byte* info, void* callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));

		fixed (void* __searchPath_native = &Utf16StringMarshaller.GetPinnableReference(searchPath))
		fixed (void* __executable_native = &Utf16StringMarshaller.GetPinnableReference(executable))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort*, uint, byte*, void*, int>)__vtable_native[9])(__this, (ushort*)__executable_native, (ushort*)__searchPath_native, infoSize, info, callback);
		}
	}

	[SkipLocalsInit]
	int IDataSourceEx2.LoadDataFromMiscInfo(string executable, string searchPath, uint exeTimestamp, uint debugTimestamp, uint exeSize, uint infoSize, byte* info, void* callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));

		fixed (void* __searchPath_native = &Utf16StringMarshaller.GetPinnableReference(searchPath))
		fixed (void* __executable_native = &Utf16StringMarshaller.GetPinnableReference(executable))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort*, uint, uint, uint, uint, byte*, void*, int>)__vtable_native[10])(__this, (ushort*)__executable_native, (ushort*)__searchPath_native, exeTimestamp, debugTimestamp, exeSize, infoSize, info, callback);
		}
	}

	[SkipLocalsInit]
	int IDataSourceEx2.LoadDataFromPDB(string pdbPath, bool prefetchPDB)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));

		fixed (void* __pdbPath_native = &Utf16StringMarshaller.GetPinnableReference(pdbPath))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, int, int>)__vtable_native[11])(__this, (ushort*)__pdbPath_native, prefetchPDB ? 1 : 0);
		}
	}

	[SkipLocalsInit]
	int IDataSourceEx2.LoadAndValidateDataFromPDB(string pdbPath, Guid* pdbSignature, uint signature, uint age, bool prefetchPDB)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));

		fixed (void* __pdbPath_native = &Utf16StringMarshaller.GetPinnableReference(pdbPath))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, Guid*, uint, uint, int, int>)__vtable_native[12])(__this, (ushort*)__pdbPath_native, pdbSignature, signature, age, prefetchPDB ? 1 : 0);
		}
	}

	[SkipLocalsInit]
	int IDataSourceEx2.LoadDataForExe(string executable, string searchPath, void* callback, bool prefetchPDB)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));

		fixed (void* __searchPath_native = &Utf16StringMarshaller.GetPinnableReference(searchPath))
		fixed (void* __executable_native = &Utf16StringMarshaller.GetPinnableReference(executable))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort*, void*, int, int>)__vtable_native[13])(__this, (ushort*)__executable_native, (ushort*)__searchPath_native, callback, prefetchPDB ? 1 : 0);
		}
	}

	[SkipLocalsInit]
	int IDataSourceEx2.LoadDataFromIStream(IStream stream, bool prefetchPDB)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));
		void* __stream_native = null;

		try
		{
			__stream_native = ComInterfaceMarshaller<IStream>.ConvertToUnmanaged(stream);

			return ((delegate* unmanaged[MemberFunction]<void*, void*, int, int>)__vtable_native[14])(__this, __stream_native, prefetchPDB ? 1 : 0);
		}
		finally
		{
			ComInterfaceMarshaller<IStream>.Free(__stream_native);
		}
	}

	[SkipLocalsInit]
	int IDataSourceEx2.GetStreamSize(string stream, out ulong size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));

		fixed (ulong* __size_native = &size)
		fixed (void* __stream_native = &Utf16StringMarshaller.GetPinnableReference(stream))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, ulong*, int>)__vtable_native[15])(__this, (ushort*)__stream_native, __size_native);
		}
	}

	[SkipLocalsInit]
	int IDataSourceEx2.GetStreamRawData(string stream, ulong byteOffset, ulong bufferSize, out ulong bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));

		fixed (ulong* __bytesWritten_native = &bytesWritten)
		fixed (void* __stream_native = &Utf16StringMarshaller.GetPinnableReference(stream))
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, ulong, ulong, ulong*, byte*, int>)__vtable_native[16])(__this, (ushort*)__stream_native, byteOffset, bufferSize, __bytesWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int IDataSourceEx2.SetMiniPDBErrorCallback(nint context, MiniPDBErrorCallback callback)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));

		return ((delegate* unmanaged[MemberFunction]<void*, nint, nint, int>)__vtable_native[17])(__this, context, callback != null ? Marshal.GetFunctionPointerForDelegate(callback) : default);
	}

	[SkipLocalsInit]
	int IDataSourceEx2.ValidatePDB(string pdbPath, Guid* pdbSignature, uint signature, uint age, out bool valid)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IDataSourceEx2));
		int __valid_native;
		int __retVal;

		fixed (void* __pdbPath_native = &Utf16StringMarshaller.GetPinnableReference(pdbPath))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, Guid*, uint, uint, int*, int>)__vtable_native[18])(__this, (ushort*)__pdbPath_native, pdbSignature, signature, age, &__valid_native);
		}

		valid = __valid_native != 0;

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
	int IDataSourceEx.LoadDataFromPDB(string pdbPath, bool prefetchPDB) => throw new UnreachableException();
	int IDataSourceEx.LoadAndValidateDataFromPDB(string pdbPath, Guid* pdbSignature, uint signature, uint age, bool prefetchPDB) => throw new UnreachableException();
	int IDataSourceEx.LoadDataForExe(string executable, string searchPath, void* callback, bool prefetchPDB) => throw new UnreachableException();
	int IDataSourceEx.LoadDataFromIStream(IStream stream, bool prefetchPDB) => throw new UnreachableException();
	int IDataSourceEx.GetStreamSize(string stream, out ulong size) => throw new UnreachableException();
	int IDataSourceEx.GetStreamRawData(string stream, ulong byteOffset, ulong bufferSize, out ulong bytesWritten, byte* buffer) => throw new UnreachableException();
	int IDataSourceEx.SetMiniPDBErrorCallback(nint context, MiniPDBErrorCallback callback) => throw new UnreachableException();
	int IDataSourceEx.ValidatePDB(string pdbPath, Guid* pdbSignature, uint signature, uint age, out bool valid) => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindNamedStreams(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __name_native, NameSearchOptions searchOptions, void** __streams_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IDataSourceEx2>(__this_native).FindNamedStreams(BStrStringMarshaller.ConvertToManaged(__name_native)!, searchOptions, out IEnumNamedStreams streams);

			*__streams_native__param = ComInterfaceMarshaller<IEnumNamedStreams>.ConvertToUnmanaged(streams);

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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IDataSourceEx2), sizeof(void*) * 20);

		NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(IDataSourceEx).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 19));

		vtable[19] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, NameSearchOptions, void**, int>)&ABI_FindNamedStreams;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public unsafe partial interface IDataSourceEx2
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

		[SkipLocalsInit, PreserveSig]
		new int LoadDataFromPDB(string pdbPath, bool prefetchPDB) => ((IDataSourceEx)this).LoadDataFromPDB(pdbPath, prefetchPDB);

		[SkipLocalsInit, PreserveSig]
		new int LoadAndValidateDataFromPDB(string pdbPath, Guid* pdbSignature, uint signature, uint age, bool prefetchPDB) => ((IDataSourceEx)this).LoadAndValidateDataFromPDB(pdbPath, pdbSignature, signature, age, prefetchPDB);

		[SkipLocalsInit, PreserveSig]
		new int LoadDataForExe(string executable, string searchPath, void* callback, bool prefetchPDB) => ((IDataSourceEx)this).LoadDataForExe(executable, searchPath, callback, prefetchPDB);

		[SkipLocalsInit, PreserveSig]
		new int LoadDataFromIStream(IStream stream, bool prefetchPDB) => ((IDataSourceEx)this).LoadDataFromIStream(stream, prefetchPDB);

		[SkipLocalsInit, PreserveSig]
		new int GetStreamSize(string stream, out ulong size) => ((IDataSourceEx)this).GetStreamSize(stream, out size);

		[SkipLocalsInit, PreserveSig]
		new int GetStreamRawData(string stream, ulong byteOffset, ulong bufferSize, out ulong bytesWritten, byte* buffer) => ((IDataSourceEx)this).GetStreamRawData(stream, byteOffset, bufferSize, out bytesWritten, buffer);

		[SkipLocalsInit, PreserveSig]
		new int SetMiniPDBErrorCallback(nint context, MiniPDBErrorCallback callback) => ((IDataSourceEx)this).SetMiniPDBErrorCallback(context, callback);

		[SkipLocalsInit, PreserveSig]
		new int ValidatePDB(string pdbPath, Guid* pdbSignature, uint signature, uint age, out bool valid) => ((IDataSourceEx)this).ValidatePDB(pdbPath, pdbSignature, signature, age, out valid);
	}
}