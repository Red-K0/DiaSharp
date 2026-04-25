#pragma warning disable IDE0008, IDE0022

using DiaSharp.SDK.Callbacks;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([202, 128, 63, 142, 23, 117, 42, 67, 186, 7, 40, 81, 52, 170, 234, 142]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IReadExeAtRVACallback
{
	[SkipLocalsInit]
	int IReadExeAtRVACallback.ReadExecutableAtRVA(uint relativeVirtualAddress, uint executableSize, uint* bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IReadExeAtRVACallback));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint*, byte*, int>)__vtable_native[3])(__this, relativeVirtualAddress, executableSize, bytesWritten, buffer);
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_ReadExecutableAtRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, uint executableSize, uint* bytesWritten, byte* buffer)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IReadExeAtRVACallback>(__this_native).ReadExecutableAtRVA(relativeVirtualAddress, executableSize, bytesWritten, buffer);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IReadExeAtRVACallback), sizeof(void*) * 4);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, uint*, byte*, int>)&ABI_ReadExecutableAtRVA;

		return vtable;
	}
}

namespace DiaSharp.SDK.Callbacks
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IReadExeAtRVACallback
	{
	}
}