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

		return ((delegate* unmanaged[MemberFunction]<void*, int, uint, byte*, int>)__vtable_native[3])(__this, executable ? 1 : 0, dataSize, data);
	}

	[SkipLocalsInit]
	int ILoadCallback.NotifyOpenDebug(string debugPath, uint resultCode)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback));

		scoped BStrStringMarshaller.ManagedToUnmanagedIn __debugPath_native__marshaller = new();

		try
		{
			__debugPath_native__marshaller.FromManaged(debugPath, stackalloc byte[BStrStringMarshaller.ManagedToUnmanagedIn.BufferSize]);

			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, uint, int>)__vtable_native[4])(__this, __debugPath_native__marshaller.ToUnmanaged(), resultCode);
		}
		finally
		{
			__debugPath_native__marshaller.Free();
		}
	}

	[SkipLocalsInit]
	int ILoadCallback.NotifyOpenPDB(string pdbPath, uint resultCode)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback));

		scoped BStrStringMarshaller.ManagedToUnmanagedIn __pdbPath_native__marshaller = new();

		try
		{
			__pdbPath_native__marshaller.FromManaged(pdbPath, stackalloc byte[BStrStringMarshaller.ManagedToUnmanagedIn.BufferSize]);

			return ((delegate* unmanaged[MemberFunction]<void*, ushort*, uint, int>)__vtable_native[5])(__this, __pdbPath_native__marshaller.ToUnmanaged(), resultCode);
		}
		finally
		{
			__pdbPath_native__marshaller.Free();
		}
	}

	[SkipLocalsInit]
	int ILoadCallback.RestrictRegistryAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[6])(__this);
	}

	[SkipLocalsInit]
	int ILoadCallback.RestrictSymbolServerAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[7])(__this);
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_NotifyDebugDirectory(ComWrappers.ComInterfaceDispatch* __this_native, int __executable_native, uint dataSize, byte* data)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback>(__this_native).NotifyDebugDirectory(__executable_native != 0, dataSize, data);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_NotifyOpenDebug(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __debugPath_native, uint resultCode)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback>(__this_native).NotifyOpenDebug(BStrStringMarshaller.ConvertToManaged(__debugPath_native)!, resultCode);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_NotifyOpenPDB(ComWrappers.ComInterfaceDispatch* __this_native, ushort* __pdbPath_native, uint resultCode)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback>(__this_native).NotifyOpenPDB(BStrStringMarshaller.ConvertToManaged(__pdbPath_native)!, resultCode);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_RestrictRegistryAccess(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback>(__this_native).RestrictRegistryAccess();
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_RestrictSymbolServerAccess(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback>(__this_native).RestrictSymbolServerAccess();
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ILoadCallback), sizeof(void*) * 8);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int, uint, byte*, int>)&ABI_NotifyDebugDirectory;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, uint, int>)&ABI_NotifyOpenDebug;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort*, uint, int>)&ABI_NotifyOpenPDB;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_RestrictRegistryAccess;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_RestrictSymbolServerAccess;

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