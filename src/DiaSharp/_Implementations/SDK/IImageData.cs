#pragma warning disable IDE0008, IDE0022

using DiaSharp.SDK;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([210, 14, 228, 200, 217, 161, 33, 66, 134, 146, 60, 230, 97, 24, 75, 68]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IImageData
{
	[SkipLocalsInit]
	int IImageData.GetRelativeVirtualAddress(out uint relativeVirtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IImageData));

		fixed (uint* __rva_native = &relativeVirtualAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __rva_native);
		}
	}

	[SkipLocalsInit]
	int IImageData.GetVirtualAddress(out ulong virtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IImageData));

		fixed (ulong* __va_native = &virtualAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[4])(__this, __va_native);
		}
	}

	[SkipLocalsInit]
	int IImageData.GetImageBase(out ulong imageBase)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IImageData));

		fixed (ulong* __imageBase_native = &imageBase)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[5])(__this, __imageBase_native);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRelativeVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __rva_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IImageData>(__this_native).GetRelativeVirtualAddress(out *__rva_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __va_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IImageData>(__this_native).GetVirtualAddress(out *__va_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetImageBase(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __imageBase_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IImageData>(__this_native).GetImageBase(out *__imageBase_native__param);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IImageData), sizeof(void*) * 6);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetRelativeVirtualAddress;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetVirtualAddress;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetImageBase;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IImageData
	{
	}
}