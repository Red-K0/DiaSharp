#pragma warning disable IDE0008, IDE0022

using DiaSharp.SDK;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([176, 86, 254, 59, 12, 57, 99, 72, 148, 48, 31, 61, 8, 59, 118, 132]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IInputAssemblyFile
{
	[SkipLocalsInit]
	int IInputAssemblyFile.GetUniqueID(out uint id)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInputAssemblyFile));

		fixed (uint* __id_native = &id)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __id_native);
		}
	}

	[SkipLocalsInit]
	int IInputAssemblyFile.GetIndex(out uint index)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInputAssemblyFile));

		fixed (uint* __index_native = &index)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[4])(__this, __index_native);
		}
	}

	[SkipLocalsInit]
	int IInputAssemblyFile.GetTimestamp(out uint timestamp)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInputAssemblyFile));

		fixed (uint* __timestamp_native = &timestamp)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[5])(__this, __timestamp_native);
		}
	}

	[SkipLocalsInit]
	int IInputAssemblyFile.GetWasPDBAvailableAtILMerge(out bool available)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInputAssemblyFile));
		int __available_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[6])(__this, &__available_native);

		available = __available_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int IInputAssemblyFile.GetFilename(out string name)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInputAssemblyFile));
		ushort* __name_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[7])(__this, &__name_native);

		name = BStrStringMarshaller.ConvertToManaged(__name_native)!;

		BStrStringMarshaller.Free(__name_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IInputAssemblyFile.GetVersion(uint bufferSize, out uint dataSize, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInputAssemblyFile));

		fixed (uint* __dataSize_native = &dataSize)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[8])(__this, bufferSize, __dataSize_native, buffer);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetUniqueID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __id_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IInputAssemblyFile>(__this_native).GetUniqueID(out *__id_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIndex(ComWrappers.ComInterfaceDispatch* __this_native, uint* __index_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IInputAssemblyFile>(__this_native).GetIndex(out *__index_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetTimestamp(ComWrappers.ComInterfaceDispatch* __this_native, uint* __timestamp_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IInputAssemblyFile>(__this_native).GetTimestamp(out *__timestamp_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetWasPDBAvailableAtILMerge(ComWrappers.ComInterfaceDispatch* __this_native, int* __available_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IInputAssemblyFile>(__this_native).GetWasPDBAvailableAtILMerge(out bool available);

		*__available_native__param = available ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFilename(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __name_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IInputAssemblyFile>(__this_native).GetFilename(out string name);

		*__name_native__param = BStrStringMarshaller.ConvertToUnmanaged(name);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVersion(ComWrappers.ComInterfaceDispatch* __this_native, uint bufferSize, uint* __dataSize_native__param, byte* buffer)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IInputAssemblyFile>(__this_native).GetVersion(bufferSize, out *__dataSize_native__param, buffer);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IInputAssemblyFile), sizeof(void*) * 9);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetUniqueID;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetIndex;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetTimestamp;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetWasPDBAvailableAtILMerge;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetFilename;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, byte*, int>)&ABI_GetVersion;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IInputAssemblyFile
	{
	}
}