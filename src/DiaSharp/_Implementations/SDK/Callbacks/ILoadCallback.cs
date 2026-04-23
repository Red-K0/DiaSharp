#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.SDK.Callbacks;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([130, 219, 42, 195, 244, 115, 27, 66, 149, 213, 164, 112, 110, 223, 93, 190]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ILoadCallback
{
	[SkipLocalsInit]
	int ILoadCallback.NotifyDebugDirectory(bool executable, uint dataSize, byte* data)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback));
		int __executable_native;
		int __retVal;
		// Marshal - Convert managed data to native data.
		__executable_native = executable ? 1 : 0;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int, uint, byte*, int>)__vtable_native[3])(__this, __executable_native, dataSize, data);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int ILoadCallback.NotifyOpenDebug(string debugPath, uint resultCode)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback));
		ushort* __debugPath_native = default;
		int __retVal;
		// Setup - Perform required setup.
		scoped BStrStringMarshaller.ManagedToUnmanagedIn __debugPath_native__marshaller = new();

		try
		{
			// Marshal - Convert managed data to native data.
			__debugPath_native__marshaller.FromManaged(debugPath, stackalloc byte[BStrStringMarshaller.ManagedToUnmanagedIn.BufferSize]);
			{
				// PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
				__debugPath_native = __debugPath_native__marshaller.ToUnmanaged();
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, uint, int>)__vtable_native[4])(__this, __debugPath_native, resultCode);
			}

			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			GC.KeepAlive(this);
		}
		finally
		{
			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			__debugPath_native__marshaller.Free();
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ILoadCallback.NotifyOpenPDB(string pdbPath, uint resultCode)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback));
		ushort* __pdbPath_native = default;
		int __retVal;
		// Setup - Perform required setup.
		scoped BStrStringMarshaller.ManagedToUnmanagedIn __pdbPath_native__marshaller = new();

		try
		{
			// Marshal - Convert managed data to native data.
			__pdbPath_native__marshaller.FromManaged(pdbPath, stackalloc byte[BStrStringMarshaller.ManagedToUnmanagedIn.BufferSize]);
			{
				// PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
				__pdbPath_native = __pdbPath_native__marshaller.ToUnmanaged();
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, uint, int>)__vtable_native[5])(__this, __pdbPath_native, resultCode);
			}

			// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
			GC.KeepAlive(this);
		}
		finally
		{
			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			__pdbPath_native__marshaller.Free();
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ILoadCallback.RestrictRegistryAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[6])(__this);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int ILoadCallback.RestrictSymbolServerAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[7])(__this);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_NotifyDebugDirectory(ComWrappers.ComInterfaceDispatch* __this_native, int __executable_native, uint dataSize, byte* data)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			bool executable = __executable_native != 0;
			ILoadCallback @this = ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback>(__this_native);
			__retVal = @this.NotifyDebugDirectory(executable, dataSize, data);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_NotifyOpenDebug(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __debugPath_native, uint resultCode)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			string debugPath = BStrStringMarshaller.ConvertToManaged(__debugPath_native)!;
			ILoadCallback @this = ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback>(__this_native);
			__retVal = @this.NotifyOpenDebug(debugPath, resultCode);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_NotifyOpenPDB(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __pdbPath_native, uint resultCode)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			string pdbPath = BStrStringMarshaller.ConvertToManaged(__pdbPath_native)!;
			ILoadCallback @this = ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback>(__this_native);
			__retVal = @this.NotifyOpenPDB(pdbPath, resultCode);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_RestrictRegistryAccess(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			ILoadCallback @this = ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback>(__this_native);
			__retVal = @this.RestrictRegistryAccess();
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_RestrictSymbolServerAccess(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			ILoadCallback @this = ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback>(__this_native);
			__retVal = @this.RestrictSymbolServerAccess();
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ILoadCallback), sizeof(void*) * 8);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int, uint, byte*, int>)&ABI_NotifyDebugDirectory;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, uint, int>)&ABI_NotifyOpenDebug;
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, uint, int>)&ABI_NotifyOpenPDB;
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_RestrictRegistryAccess;
			vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_RestrictSymbolServerAccess;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK.Callbacks
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface ILoadCallback
	{
	}
}