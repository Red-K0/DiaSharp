#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.SDK.Callbacks;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([116, 160, 136, 70, 77, 90, 134, 68, 174, 168, 123, 144, 113, 29, 159, 124]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ILoadCallback2
{
	[SkipLocalsInit]
	int ILoadCallback2.RestrictOriginalPathAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[8])(__this);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int ILoadCallback2.RestrictReferencePathAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[9])(__this);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int ILoadCallback2.RestrictDBGAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[10])(__this);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int ILoadCallback2.RestrictSystemRootAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[11])(__this);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int ILoadCallback2.NotifyDebugDirectory(bool executable, uint dataSize, byte* data)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));
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
	int ILoadCallback2.NotifyOpenDebug(string debugPath, uint resultCode)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));
		ushort* __debugPath_native = default;
		int __retVal = default;
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
	int ILoadCallback2.NotifyOpenPDB(string pdbPath, uint resultCode)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));
		ushort* __pdbPath_native = default;
		int __retVal = default;
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
	int ILoadCallback2.RestrictRegistryAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[6])(__this);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}

	[SkipLocalsInit]
	int ILoadCallback2.RestrictSymbolServerAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[7])(__this);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}

	int ILoadCallback.NotifyDebugDirectory(bool executable, uint dataSize, byte* data) => throw new UnreachableException();
	int ILoadCallback.NotifyOpenDebug(string debugPath, uint resultCode) => throw new UnreachableException();
	int ILoadCallback.NotifyOpenPDB(string pdbPath, uint resultCode) => throw new UnreachableException();
	int ILoadCallback.RestrictRegistryAccess() => throw new UnreachableException();
	int ILoadCallback.RestrictSymbolServerAccess() => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_RestrictOriginalPathAccess(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			ILoadCallback2 @this = ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback2>(__this_native);
			__retVal = @this.RestrictOriginalPathAccess();
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_RestrictReferencePathAccess(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			ILoadCallback2 @this = ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback2>(__this_native);
			__retVal = @this.RestrictReferencePathAccess();
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_RestrictDBGAccess(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			ILoadCallback2 @this = ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback2>(__this_native);
			__retVal = @this.RestrictDBGAccess();
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_RestrictSystemRootAccess(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			ILoadCallback2 @this = ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback2>(__this_native);
			__retVal = @this.RestrictSystemRootAccess();
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ILoadCallback2), sizeof(void*) * 12);
		{
			NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(ILoadCallback).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 8));
		}

		{
			vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_RestrictOriginalPathAccess;
			vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_RestrictReferencePathAccess;
			vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_RestrictDBGAccess;
			vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_RestrictSystemRootAccess;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK.Callbacks
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface ILoadCallback2
	{
		[SkipLocalsInit]
		new unsafe int NotifyDebugDirectory(bool executable, uint dataSize, byte* data) => ((ILoadCallback)this).NotifyDebugDirectory(executable, dataSize, data);
		[SkipLocalsInit]
		new int NotifyOpenDebug(string debugPath, uint resultCode) => ((ILoadCallback)this).NotifyOpenDebug(debugPath, resultCode);
		[SkipLocalsInit]
		new int NotifyOpenPDB(string pdbPath, uint resultCode) => ((ILoadCallback)this).NotifyOpenPDB(pdbPath, resultCode);
		[SkipLocalsInit]
		new int RestrictRegistryAccess() => ((ILoadCallback)this).RestrictRegistryAccess();
		[SkipLocalsInit]
		new int RestrictSymbolServerAccess() => ((ILoadCallback)this).RestrictSymbolServerAccess();
	}
}