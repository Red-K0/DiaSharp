#pragma warning disable IDE0008, IDE0022

using DiaSharp.SDK;
using DiaSharp.SDK.Symbols;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([14, 182, 244, 12, 177, 53, 108, 76, 189, 216, 133, 75, 156, 142, 56, 87]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ISectionContrib
{
	[SkipLocalsInit]
	int ISectionContrib.GetCompiland(out ISymbol compiland)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		void* __compiland_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__compiland_native);

		compiland = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__compiland_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__compiland_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetAddressSection(out uint section)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));

		fixed (uint* __section_native = &section)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[4])(__this, __section_native);
		}
	}

	[SkipLocalsInit]
	int ISectionContrib.GetAddressOffset(out uint offset)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));

		fixed (uint* __offset_native = &offset)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[5])(__this, __offset_native);
		}
	}

	[SkipLocalsInit]
	int ISectionContrib.GetRelativeVirtualAddress(out uint relativeVirtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));

		fixed (uint* __rva_native = &relativeVirtualAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[6])(__this, __rva_native);
		}
	}

	[SkipLocalsInit]
	int ISectionContrib.GetVirtualAddress(out ulong virtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));

		fixed (ulong* __va_native = &virtualAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[7])(__this, __va_native);
		}
	}

	[SkipLocalsInit]
	int ISectionContrib.GetLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));

		fixed (uint* __length_native = &length)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[8])(__this, __length_native);
		}
	}

	[SkipLocalsInit]
	int ISectionContrib.GetNotPaged(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[9])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetNoPad(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[10])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetHasCode(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[11])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetHasInitializedData(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[12])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetHasUninitializedData(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[13])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsInformational(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[14])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsRemoved(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[15])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsCOMDAT(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[16])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsDiscardable(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[17])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetNotCached(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[18])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsShareable(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[19])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsExecutable(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[20])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsReadable(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[21])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsWriteable(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[22])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetDataCRC(out uint crc)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));

		fixed (uint* __crc_native = &crc)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[23])(__this, __crc_native);
		}
	}

	[SkipLocalsInit]
	int ISectionContrib.GetRelocationsCRC(out uint crc)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));

		fixed (uint* __crc_native = &crc)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[24])(__this, __crc_native);
		}
	}

	[SkipLocalsInit]
	int ISectionContrib.GetCompilandID(out uint id)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));

		fixed (uint* __id_native = &id)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[25])(__this, __id_native);
		}
	}

	[SkipLocalsInit]
	int ISectionContrib.GetHas16BitCode(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		int __value_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[26])(__this, &__value_native);

		value = __value_native != 0;

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCompiland(ComWrappers.ComInterfaceDispatch* __this_native, void** __compiland_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetCompiland(out ISymbol compiland);

		*__compiland_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(compiland);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAddressSection(ComWrappers.ComInterfaceDispatch* __this_native, uint* __section_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetAddressSection(out *__section_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAddressOffset(ComWrappers.ComInterfaceDispatch* __this_native, uint* __offset_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetAddressOffset(out *__offset_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRelativeVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __rva_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetRelativeVirtualAddress(out *__rva_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __va_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetVirtualAddress(out *__va_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetLength(out *__length_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNotPaged(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetNotPaged(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNoPad(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetNoPad(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasCode(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetHasCode(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasInitializedData(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetHasInitializedData(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasUninitializedData(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetHasUninitializedData(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsInformational(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetIsInformational(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsRemoved(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetIsRemoved(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsCOMDAT(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetIsCOMDAT(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsDiscardable(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetIsDiscardable(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNotCached(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetNotCached(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsShareable(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetIsShareable(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsExecutable(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetIsExecutable(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsReadable(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetIsReadable(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsWriteable(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetIsWriteable(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetDataCRC(ComWrappers.ComInterfaceDispatch* __this_native, uint* __crc_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetDataCRC(out *__crc_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRelocationsCRC(ComWrappers.ComInterfaceDispatch* __this_native, uint* __crc_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetRelocationsCRC(out *__crc_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCompilandID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __id_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetCompilandID(out *__id_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHas16BitCode(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native).GetHas16BitCode(out bool value);

		*__value_native__param = value ? 1 : 0;

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ISectionContrib), sizeof(void*) * 27);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetCompiland;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetAddressSection;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetAddressOffset;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetRelativeVirtualAddress;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetVirtualAddress;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLength;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetNotPaged;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetNoPad;
		vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasCode;
		vtable[12] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasInitializedData;
		vtable[13] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasUninitializedData;
		vtable[14] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsInformational;
		vtable[15] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsRemoved;
		vtable[16] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsCOMDAT;
		vtable[17] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsDiscardable;
		vtable[18] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetNotCached;
		vtable[19] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsShareable;
		vtable[20] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsExecutable;
		vtable[21] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsReadable;
		vtable[22] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsWriteable;
		vtable[23] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetDataCRC;
		vtable[24] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetRelocationsCRC;
		vtable[25] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetCompilandID;
		vtable[26] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHas16BitCode;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface ISectionContrib
	{
	}
}