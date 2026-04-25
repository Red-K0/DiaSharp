#pragma warning disable IDE0008, IDE0022

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

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[8])(__this);
	}

	[SkipLocalsInit]
	int ILoadCallback2.RestrictReferencePathAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[9])(__this);
	}

	[SkipLocalsInit]
	int ILoadCallback2.RestrictDBGAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[10])(__this);
	}

	[SkipLocalsInit]
	int ILoadCallback2.RestrictSystemRootAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[11])(__this);
	}

	[SkipLocalsInit]
	int ILoadCallback2.NotifyDebugDirectory(bool executable, uint dataSize, byte* data)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));

		return ((delegate* unmanaged[MemberFunction]<void*, int, uint, byte*, int>)__vtable_native[3])(__this, executable ? 1 : 0, dataSize, data);
	}

	[SkipLocalsInit]
	int ILoadCallback2.NotifyOpenDebug(string debugPath, uint resultCode)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));

		scoped BStrStringMarshaller.ManagedToUnmanagedIn __debugPath_native__marshaller = new();

		__debugPath_native__marshaller.FromManaged(debugPath, stackalloc byte[BStrStringMarshaller.ManagedToUnmanagedIn.BufferSize]);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, uint, int>)__vtable_native[4])(__this, __debugPath_native__marshaller.ToUnmanaged(), resultCode);

		__debugPath_native__marshaller.Free();

		return __retVal;
	}

	[SkipLocalsInit]
	int ILoadCallback2.NotifyOpenPDB(string pdbPath, uint resultCode)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));

		scoped BStrStringMarshaller.ManagedToUnmanagedIn __pdbPath_native__marshaller = new();

		__pdbPath_native__marshaller.FromManaged(pdbPath, stackalloc byte[BStrStringMarshaller.ManagedToUnmanagedIn.BufferSize]);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, uint, int>)__vtable_native[5])(__this, __pdbPath_native__marshaller.ToUnmanaged(), resultCode);

		__pdbPath_native__marshaller.Free();

		return __retVal;
	}

	[SkipLocalsInit]
	int ILoadCallback2.RestrictRegistryAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[6])(__this);
	}

	[SkipLocalsInit]
	int ILoadCallback2.RestrictSymbolServerAccess()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILoadCallback2));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[7])(__this);
	}

	int ILoadCallback.NotifyDebugDirectory(bool executable, uint dataSize, byte* data) => throw new UnreachableException();
	int ILoadCallback.NotifyOpenDebug(string debugPath, uint resultCode) => throw new UnreachableException();
	int ILoadCallback.NotifyOpenPDB(string pdbPath, uint resultCode) => throw new UnreachableException();
	int ILoadCallback.RestrictRegistryAccess() => throw new UnreachableException();
	int ILoadCallback.RestrictSymbolServerAccess() => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_RestrictOriginalPathAccess(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback2>(__this_native).RestrictOriginalPathAccess();
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_RestrictReferencePathAccess(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback2>(__this_native).RestrictReferencePathAccess();
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_RestrictDBGAccess(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback2>(__this_native).RestrictDBGAccess();
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_RestrictSystemRootAccess(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILoadCallback2>(__this_native).RestrictSystemRootAccess();
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ILoadCallback2), sizeof(void*) * 12);

		NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(ILoadCallback).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 8));

		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_RestrictOriginalPathAccess;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_RestrictReferencePathAccess;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_RestrictDBGAccess;
		vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_RestrictSystemRootAccess;

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