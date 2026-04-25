#pragma warning disable IDE0008, IDE0022

using DiaSharp.SDK;
using DiaSharp.SDK.Symbols;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([20, 235, 136, 179, 77, 190, 29, 66, 168, 161, 108, 247, 171, 5, 112, 134]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ILineNumber
{
	[SkipLocalsInit]
	int ILineNumber.GetCompiland(out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));
		void* __symbol_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__symbol_native);

		symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ILineNumber.GetSourceFile(out ISourceFile file)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));
		void* __file_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[4])(__this, &__file_native);

		file = ComInterfaceMarshaller<ISourceFile>.ConvertToManaged(__file_native)!;

		ComInterfaceMarshaller<ISourceFile>.Free(__file_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ILineNumber.GetLineNumber(out uint number)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));

		fixed (uint* __number_native = &number)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[5])(__this, __number_native);
		}
	}

	[SkipLocalsInit]
	int ILineNumber.GetLineNumberEnd(out uint number)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));

		fixed (uint* __number_native = &number)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[6])(__this, __number_native);
		}
	}

	[SkipLocalsInit]
	int ILineNumber.GetColumnNumber(out uint column)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));

		fixed (uint* __column_native = &column)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[7])(__this, __column_native);
		}
	}

	[SkipLocalsInit]
	int ILineNumber.GetColumnNumberEnd(out uint column)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));

		fixed (uint* __column_native = &column)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[8])(__this, __column_native);
		}
	}

	[SkipLocalsInit]
	int ILineNumber.GetSectionAddress(out uint sectionAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));

		fixed (uint* __sectionAddress_native = &sectionAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[9])(__this, __sectionAddress_native);
		}
	}

	[SkipLocalsInit]
	int ILineNumber.GetOffsetAddress(out uint offsetAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));

		fixed (uint* __offsetAddress_native = &offsetAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[10])(__this, __offsetAddress_native);
		}
	}

	[SkipLocalsInit]
	int ILineNumber.GetRelativeVirtualAddress(out uint relativeVirtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));

		fixed (uint* __rva_native = &relativeVirtualAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[11])(__this, __rva_native);
		}
	}

	[SkipLocalsInit]
	int ILineNumber.GetVirtualAddress(out ulong virtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));

		fixed (ulong* __va_native = &virtualAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[12])(__this, __va_native);
		}
	}

	[SkipLocalsInit]
	int ILineNumber.GetLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));

		fixed (uint* __length_native = &length)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[13])(__this, __length_native);
		}
	}

	[SkipLocalsInit]
	int ILineNumber.GetSourceFileID(out uint id)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));

		fixed (uint* __id_native = &id)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[14])(__this, __id_native);
		}
	}

	[SkipLocalsInit]
	int ILineNumber.GetStatement(out int statement)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));

		fixed (int* __statement_native = &statement)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[15])(__this, __statement_native);
		}
	}

	[SkipLocalsInit]
	int ILineNumber.GetCompilandID(out uint id)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ILineNumber));

		fixed (uint* __id_native = &id)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[16])(__this, __id_native);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCompiland(ComWrappers.ComInterfaceDispatch* __this_native, void** __symbol_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetCompiland(out ISymbol symbol);

		*__symbol_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSourceFile(ComWrappers.ComInterfaceDispatch* __this_native, void** __file_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetSourceFile(out ISourceFile file);

		*__file_native__param = ComInterfaceMarshaller<ISourceFile>.ConvertToUnmanaged(file);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLineNumber(ComWrappers.ComInterfaceDispatch* __this_native, uint* __number_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetLineNumber(out *__number_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLineNumberEnd(ComWrappers.ComInterfaceDispatch* __this_native, uint* __number_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetLineNumberEnd(out *__number_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetColumnNumber(ComWrappers.ComInterfaceDispatch* __this_native, uint* __column_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetColumnNumber(out *__column_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetColumnNumberEnd(ComWrappers.ComInterfaceDispatch* __this_native, uint* __column_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetColumnNumberEnd(out *__column_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSectionAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __sectionAddress_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetSectionAddress(out *__sectionAddress_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetOffsetAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __offsetAddress_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetOffsetAddress(out *__offsetAddress_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRelativeVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __rva_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetRelativeVirtualAddress(out *__rva_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __va_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetVirtualAddress(out *__va_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetLength(out *__length_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSourceFileID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __id_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetSourceFileID(out *__id_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetStatement(ComWrappers.ComInterfaceDispatch* __this_native, int* __statement_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetStatement(out *__statement_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCompilandID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __id_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ILineNumber>(__this_native).GetCompilandID(out *__id_native__param);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ILineNumber), sizeof(void*) * 17);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetCompiland;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetSourceFile;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLineNumber;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLineNumberEnd;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetColumnNumber;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetColumnNumberEnd;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetSectionAddress;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetOffsetAddress;
		vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetRelativeVirtualAddress;
		vtable[12] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetVirtualAddress;
		vtable[13] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLength;
		vtable[14] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetSourceFileID;
		vtable[15] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetStatement;
		vtable[16] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetCompilandID;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface ILineNumber
	{
	}
}