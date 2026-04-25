#pragma warning disable IDE0008, IDE0022

using DiaSharp.CodeView;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([83, 83, 239, 162, 168, 245, 179, 78, 144, 210, 203, 82, 106, 203, 60, 221]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ISourceFile
{
	[SkipLocalsInit]
	int ISourceFile.GetUniqueID(out uint id)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISourceFile));

		fixed (uint* __id_native = &id)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __id_native);
		}
	}

	[SkipLocalsInit]
	int ISourceFile.GetFileName(out string name)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISourceFile));
		ushort* __name_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[4])(__this, &__name_native);

		name = BStrStringMarshaller.ConvertToManaged(__name_native)!;

		BStrStringMarshaller.Free(__name_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISourceFile.GetChecksumType(out SourceChecksumType type)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISourceFile));

		fixed (SourceChecksumType* __type_native = &type)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, SourceChecksumType*, int>)__vtable_native[5])(__this, __type_native);
		}
	}

	[SkipLocalsInit]
	int ISourceFile.GetCompilands(out IEnumSymbols compilands)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISourceFile));
		void* __compilands_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[6])(__this, &__compilands_native);

		compilands = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__compilands_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__compilands_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISourceFile.GetChecksum(uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISourceFile));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[7])(__this, bufferSize, __bytesWritten_native, buffer);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetUniqueID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __id_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISourceFile>(__this_native).GetUniqueID(out *__id_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFileName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __name_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISourceFile>(__this_native).GetFileName(out string name);

		*__name_native__param = BStrStringMarshaller.ConvertToUnmanaged(name);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetChecksumType(ComWrappers.ComInterfaceDispatch* __this_native, SourceChecksumType* __type_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISourceFile>(__this_native).GetChecksumType(out *__type_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCompilands(ComWrappers.ComInterfaceDispatch* __this_native, void** __compilands_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISourceFile>(__this_native).GetCompilands(out IEnumSymbols compilands);

		*__compilands_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(compilands);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetChecksum(ComWrappers.ComInterfaceDispatch* __this_native, uint bufferSize, uint* __bytesWritten_native__param, byte* buffer)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISourceFile>(__this_native).GetChecksum(bufferSize, out *__bytesWritten_native__param, buffer);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ISourceFile), sizeof(void*) * 8);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetUniqueID;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetFileName;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, SourceChecksumType*, int>)&ABI_GetChecksumType;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetCompilands;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, byte*, int>)&ABI_GetChecksum;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface ISourceFile
	{
	}
}