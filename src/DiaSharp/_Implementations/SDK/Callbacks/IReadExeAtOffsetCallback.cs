#pragma warning disable IDE0008, IDE0022

using DiaSharp.SDK.Callbacks;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([28, 70, 122, 88, 11, 184, 84, 79, 145, 148, 80, 50, 88, 154, 99, 25]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IReadExeAtOffsetCallback
{
	[SkipLocalsInit]
	int IReadExeAtOffsetCallback.ReadExecutableAt(ulong fileOffset, uint executableSize, uint* bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IReadExeAtOffsetCallback));

		return ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint*, byte*, int>)__vtable_native[3])(__this, fileOffset, executableSize, bytesWritten, buffer);
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_ReadExecutableAt(ComWrappers.ComInterfaceDispatch* __this_native, ulong fileOffset, uint executableSize, uint* bytesWritten, byte* buffer)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IReadExeAtOffsetCallback>(__this_native).ReadExecutableAt(fileOffset, executableSize, bytesWritten, buffer);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IReadExeAtOffsetCallback), sizeof(void*) * 4);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, uint, uint*, byte*, int>)&ABI_ReadExecutableAt;

		return vtable;
	}
}

namespace DiaSharp.SDK.Callbacks
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IReadExeAtOffsetCallback
	{
	}
}