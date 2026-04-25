using DiaSharp.CodeView;
using DiaSharp.CodeView.Hlsl;
using DiaSharp.Native;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;
using ImageFileMachine = DiaSharp.Native.ImageFileMachine;

#pragma warning disable IDE0008, IDE0022

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([47, 123, 120, 203, 108, 189, 53, 70, 186, 82, 147, 49, 38, 189, 45, 205]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ISymbol
{
	[SkipLocalsInit]
	int ISymbol.GetSymbolIndexID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetSymbolTag(out SymbolTag result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (SymbolTag* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, SymbolTag*, int>)__vtable_native[4])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		ushort* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[5])(__this, &__result_native);

		result = BStrStringMarshaller.ConvertToManaged(__result_native)!;

		BStrStringMarshaller.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetLexicalParent(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[6])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetClassParent(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[7])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetSymbolType(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[8])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetDataKind(out DataKind result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (DataKind* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, DataKind*, int>)__vtable_native[9])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetLocationType(out LocationType result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (LocationType* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, LocationType*, int>)__vtable_native[10])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetAddressSection(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[11])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetAddressOffset(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[12])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetRelativeVirtualAddress(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[13])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetVirtualAddress(out ulong result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (ulong* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[14])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetRegisterID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[15])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetOffset(out int result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (int* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[16])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetLength(out ulong result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (ulong* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[17])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetSlot(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[18])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetVolatileType(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[19])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetConstType(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[20])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetUnalignedType(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[21])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetAccess(out Access result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (Access* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, Access*, int>)__vtable_native[22])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetLibraryName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		ushort* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[23])(__this, &__result_native);

		result = BStrStringMarshaller.ConvertToManaged(__result_native)!;

		BStrStringMarshaller.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetPlatform(out CpuType result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (CpuType* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, CpuType*, int>)__vtable_native[24])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetLanguage(out CompileFlagLanguage result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (CompileFlagLanguage* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, CompileFlagLanguage*, int>)__vtable_native[25])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetEditAndContinueEnabled(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[26])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetFrontendMajor(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[27])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetFrontendMinor(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[28])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetFrontendBuild(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[29])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetBackendMajor(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[30])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetBackendMinor(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[31])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetBackendBuild(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[32])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetSourceFileName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		ushort* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[33])(__this, &__result_native);

		result = BStrStringMarshaller.ConvertToManaged(__result_native)!;

		BStrStringMarshaller.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetUnused(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		ushort* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[34])(__this, &__result_native);

		result = BStrStringMarshaller.ConvertToManaged(__result_native)!;

		BStrStringMarshaller.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetThunkOrdinal(out ThunkOrdinal result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (ThunkOrdinal* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ThunkOrdinal*, int>)__vtable_native[35])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetThisAdjustor(out int result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (int* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[36])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetVirtualBaseOffset(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[37])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetIsVirtual(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[38])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsIntro(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[39])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsPure(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[40])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetCallingConvention(out DiaSharp.CodeView.CallingConvention result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (DiaSharp.CodeView.CallingConvention* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, DiaSharp.CodeView.CallingConvention*, int>)__vtable_native[41])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetValue(out Variant result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (Variant* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, Variant*, int>)__vtable_native[42])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetBaseType(out BasicType result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (BasicType* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, BasicType*, int>)__vtable_native[43])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetToken(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[44])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetTimestamp(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[45])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetGUID(out Guid result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (Guid* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, Guid*, int>)__vtable_native[46])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetSymbolsFileName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		ushort* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[47])(__this, &__result_native);

		result = BStrStringMarshaller.ConvertToManaged(__result_native)!;

		BStrStringMarshaller.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsReference(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[48])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetCount(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[49])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetBitPosition(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[50])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetArrayIndexType(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[51])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsPacked(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[52])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasConstructor(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[53])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasOverloadedOperator(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[54])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsNested(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[55])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasNestedTypes(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[56])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasAssignmentOperator(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[57])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasCastOperator(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[58])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsScoped(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[59])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsVirtualBaseClass(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[60])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsIndirectVirtualBaseClass(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[61])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetVirtualBasePointerOffset(out int result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (int* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[62])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetVirtualTableShape(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[63])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetLexicalParentID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[64])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetClassParentID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[65])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetTypeID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[66])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetArrayIndexTypeID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[67])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetVirtualTableShapeID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[68])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetIsCode(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[69])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsFunction(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[70])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsManaged(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[71])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsMSIL(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[72])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetVirtualBaseDisplacementIndex(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[73])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetUndecoratedName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		ushort* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[74])(__this, &__result_native);

		result = BStrStringMarshaller.ConvertToManaged(__result_native)!;

		BStrStringMarshaller.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetAge(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[75])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetSignature(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[76])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetIsCompilerGenerated(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[77])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsAddressTaken(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[78])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetRank(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[79])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetLowerBound(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[80])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetUpperBound(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[81])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetLowerBoundID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[82])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetUpperBoundID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[83])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetDataBytes(uint dataSize, out uint dataWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __dataWritten_native = &dataWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[84])(__this, dataSize, __dataWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int ISymbol.FindChildrenUnaware(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, SymbolTag, ushort*, NameSearchOptions, void**, int>)__vtable_native[85])(__this, symbolTag, (ushort*)__name_native, compareFlags, &__result_native);
		}

		result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindChildren(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, SymbolTag, ushort*, NameSearchOptions, void**, int>)__vtable_native[86])(__this, symbolTag, (ushort*)__name_native, compareFlags, &__result_native);
		}

		result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindChildrenByAddress(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, uint sectionIndex, uint offset, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, SymbolTag, ushort*, NameSearchOptions, uint, uint, void**, int>)__vtable_native[87])(__this, symbolTag, (ushort*)__name_native, compareFlags, sectionIndex, offset, &__result_native);
		}

		result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindChildrenByVA(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, ulong virtualAddress, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, SymbolTag, ushort*, NameSearchOptions, ulong, void**, int>)__vtable_native[88])(__this, symbolTag, (ushort*)__name_native, compareFlags, virtualAddress, &__result_native);
		}

		result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindChildrenByRVA(SymbolTag symbolTag, string? name, NameSearchOptions compareFlags, uint relativeVirtualAddress, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal;

		fixed (void* __name_native = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, SymbolTag, ushort*, NameSearchOptions, uint, void**, int>)__vtable_native[89])(__this, symbolTag, (ushort*)__name_native, compareFlags, relativeVirtualAddress, &__result_native);
		}

		result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetTargetSection(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[90])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetTargetOffset(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[91])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetTargetRelativeVirtualAddress(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[92])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetTargetVirtualAddress(out ulong result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (ulong* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[93])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetMachineType(out ImageFileMachine result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (ImageFileMachine* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ImageFileMachine*, int>)__vtable_native[94])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetOemID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[95])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetOemSymbolID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[96])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetTypes(uint typeCount, out uint typesWritten, void** buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __typesWritten_native = &typesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, void**, int>)__vtable_native[97])(__this, typeCount, __typesWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetTypeIDs(uint typeIDCount, out uint typeIDsWritten, uint* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __typeIDsWritten_native = &typeIDsWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, uint*, int>)__vtable_native[98])(__this, typeIDCount, __typeIDsWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetObjectPointerType(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[99])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetUdtKind(out UdtKind result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (UdtKind* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, UdtKind*, int>)__vtable_native[100])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetUndecoratedName(UndecorateOptions undecorateOptions, out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		ushort* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, UndecorateOptions, ushort**, int>)__vtable_native[101])(__this, undecorateOptions, &__result_native);

		result = BStrStringMarshaller.ConvertToManaged(__result_native)!;

		BStrStringMarshaller.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsNoReturn(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[102])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasCustomCallingConvention(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[103])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetNoInline(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[104])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasOptimizedCodeDebugInfo(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[105])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsNotReached(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[106])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasInterruptReturn(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[107])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasFarReturn(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[108])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsStatic(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[109])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasDebugInfo(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[110])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsLTCG(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[111])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsDataAligned(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[112])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasSecurityChecks(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[113])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetCompilerName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		ushort* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[114])(__this, &__result_native);

		result = BStrStringMarshaller.ConvertToManaged(__result_native)!;

		BStrStringMarshaller.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasAlloca(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[115])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasSetJump(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[116])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasLongJump(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[117])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasInlAsm(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[118])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasEH(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[119])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasSEH(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[120])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasEHa(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[121])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsNaked(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[122])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsAggregated(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[123])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsSplit(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[124])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetContainer(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[125])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetInliningSpecified(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[126])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetNoStackOrderingSpecified(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[127])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetVirtualBaseTableType(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[128])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasManagedCode(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[129])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsHotpatchable(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[130])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsConvertedCIL(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[131])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsMSILNetmodule(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[132])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasCTypes(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[133])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsStripped(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[134])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetFrontendQFE(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[135])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetBackendQFE(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[136])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetWasInlined(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[137])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasStrictGSCheck(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[138])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsCxxReturnUdt(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[139])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsConstructorVirtualBase(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[140])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsRValueReference(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[141])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetUnmodifiedType(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[142])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetFramePointerPresent(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[143])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasSafeBuffers(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[144])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsIntrinsic(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[145])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsSealed(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[146])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasHfaFloat(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[147])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasHfaDouble(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[148])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetLiveRangeStartAddressSection(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[149])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetLiveRangeStartAddressOffset(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[150])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetLiveRangeStartRelativeVirtualAddress(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[151])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetLiveRangeCount(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[152])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetLiveRangeLength(out ulong result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (ulong* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[153])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetOffsetInUdt(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[154])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetParamBasePointerRegisterID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[155])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetLocalBasePointerRegisterID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[156])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetIsLocationControlFlowDependent(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[157])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetStride(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[158])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetNumberOfRows(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[159])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetNumberOfColumns(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[160])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetIsMatrixRowMajor(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[161])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetNumericProperties(uint propertyCount, out uint countWritten, uint* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __countWritten_native = &countWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, uint*, int>)__vtable_native[162])(__this, propertyCount, __countWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetModifierValues(uint propertyCount, out uint countWritten, ushort* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __countWritten_native = &countWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, ushort*, int>)__vtable_native[163])(__this, propertyCount, __countWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetIsReturnValue(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[164])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsOptimizedAway(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[165])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetBuiltInKind(out BuiltIn result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (BuiltIn* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, BuiltIn*, int>)__vtable_native[166])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetRegisterType(out Register result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (Register* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, Register*, int>)__vtable_native[167])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetBaseDataSlot(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[168])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetBaseDataOffset(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[169])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetTextureSlot(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[170])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetSamplerSlot(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[171])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetUavSlot(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[172])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetSizeInUdt(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[173])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetMemorySpaceKind(out MemorySpace result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (MemorySpace* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, MemorySpace*, int>)__vtable_native[174])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetUnmodifiedTypeId(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[175])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetSubTypeId(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[176])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetSubType(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[177])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetNumberOfModifiers(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[178])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetNumberOfRegisterIndices(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[179])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetIsHLSLData(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[180])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsPointerToDataMember(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[181])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsPointerToMemberFunction(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[182])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsSingleInheritance(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[183])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsMultipleInheritance(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[184])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsVirtualInheritance(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[185])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetRestrictedType(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[186])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsPointerBasedOnSymbolValue(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[187])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetBaseSymbol(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[188])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetBaseSymbolId(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[189])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetObjectFileName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		ushort* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[190])(__this, &__result_native);

		result = BStrStringMarshaller.ConvertToManaged(__result_native)!;

		BStrStringMarshaller.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsAcceleratorGroupSharedLocal(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[191])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsAcceleratorPointerTagLiveRange(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[192])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsAcceleratorStubFunction(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[193])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetNumberOfAcceleratorPointerTags(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[194])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetIsSDL(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[195])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsWinRTPointer(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[196])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsRefUdt(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[197])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsValueUdt(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[198])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsInterfaceUdt(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[199])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindInlineFramesByAddress(uint sectionIndex, uint offset, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, void**, int>)__vtable_native[200])(__this, sectionIndex, offset, &__result_native);

		result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindInlineFramesByRVA(uint relativeVirtualAddress, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[201])(__this, relativeVirtualAddress, &__result_native);

		result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindInlineFramesByVA(ulong virtualAddress, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, void**, int>)__vtable_native[202])(__this, virtualAddress, &__result_native);

		result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindInlineeLines(out IEnumLineNumbers result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[203])(__this, &__result_native);

		result = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindInlineeLinesByAddress(uint sectionIndex, uint offset, uint length, out IEnumLineNumbers result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, uint, void**, int>)__vtable_native[204])(__this, sectionIndex, offset, length, &__result_native);

		result = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindInlineeLinesByRVA(uint relativeVirtualAddress, uint length, out IEnumLineNumbers result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, void**, int>)__vtable_native[205])(__this, relativeVirtualAddress, length, &__result_native);

		result = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindInlineeLinesByVA(ulong virtualAddress, uint length, out IEnumLineNumbers result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, void**, int>)__vtable_native[206])(__this, virtualAddress, length, &__result_native);

		result = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumLineNumbers>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindSymbolsForAcceleratorPointerTag(uint tagValue, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[207])(__this, tagValue, &__result_native);

		result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.FindSymbolsByRVAForAcceleratorPointerTag(uint tagValue, uint relativeVirtualAddress, out IEnumSymbols result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, uint, void**, int>)__vtable_native[208])(__this, tagValue, relativeVirtualAddress, &__result_native);

		result = ComInterfaceMarshaller<IEnumSymbols>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IEnumSymbols>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetAcceleratorPointerTags(uint tagCount, out uint tagsWritten, uint* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __tagsWritten_native = &tagsWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, uint*, int>)__vtable_native[209])(__this, tagCount, __tagsWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetSourceLineOnTypeDefinition(out ILineNumber result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[210])(__this, &__result_native);

		result = ComInterfaceMarshaller<ILineNumber>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ILineNumber>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsPGO(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[211])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasValidPGOCounts(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[212])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsOptimizedForSpeed(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[213])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetPGOEntryCount(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[214])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetPGOEdgeCount(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[215])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetPGODynamicInstructionCount(out ulong result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (ulong* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[216])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetStaticSize(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[217])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetFinalLiveStaticSize(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[218])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetPhaseName(out string result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		ushort* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[219])(__this, &__result_native);

		result = BStrStringMarshaller.ConvertToManaged(__result_native)!;

		BStrStringMarshaller.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetHasControlFlowCheck(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[220])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsConstantExport(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[221])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetIsDataExport(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[222])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetPrivateExport(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[223])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetNoNameExport(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[224])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetExportHasExplicitlyAssignedOrdinal(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[225])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetExportIsForwarder(out bool result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		int __result_native;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[226])(__this, &__result_native);

		result = __result_native != 0;

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetOrdinal(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[227])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetFrameSize(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[228])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetExceptionHandlerAddressSection(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[229])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetExceptionHandlerAddressOffset(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[230])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetExceptionHandlerRelativeVirtualAddress(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[231])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetExceptionHandlerVirtualAddress(out ulong result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (ulong* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[232])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.FindInputAssemblyFile(out IInputAssemblyFile result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[233])(__this, &__result_native);

		result = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<IInputAssemblyFile>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetCharacteristics(out SectionCharacteristics result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (SectionCharacteristics* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, SectionCharacteristics*, int>)__vtable_native[234])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetCoffGroup(out ISymbol result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));
		void* __result_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[235])(__this, &__result_native);

		result = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__result_native)!;

		ComInterfaceMarshaller<ISymbol>.Free(__result_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int ISymbol.GetBindID(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[236])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetBindSpace(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[237])(__this, __result_native);
		}
	}

	[SkipLocalsInit]
	int ISymbol.GetBindSlot(out uint result)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISymbol));

		fixed (uint* __result_native = &result)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[238])(__this, __result_native);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSymbolIndexID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetSymbolIndexID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSymbolTag(ComWrappers.ComInterfaceDispatch* __this_native, SymbolTag* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetSymbolTag(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetName(out string result);

		*__result_native__param = BStrStringMarshaller.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLexicalParent(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLexicalParent(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetClassParent(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetClassParent(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSymbolType(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetSymbolType(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetDataKind(ComWrappers.ComInterfaceDispatch* __this_native, DataKind* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetDataKind(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLocationType(ComWrappers.ComInterfaceDispatch* __this_native, LocationType* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLocationType(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAddressSection(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetAddressSection(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAddressOffset(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetAddressOffset(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRelativeVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetRelativeVirtualAddress(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetVirtualAddress(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRegisterID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetRegisterID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetOffset(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetOffset(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLength(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLength(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSlot(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetSlot(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVolatileType(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetVolatileType(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetConstType(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetConstType(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetUnalignedType(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetUnalignedType(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAccess(ComWrappers.ComInterfaceDispatch* __this_native, Access* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetAccess(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLibraryName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLibraryName(out string result);

		*__result_native__param = BStrStringMarshaller.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetPlatform(ComWrappers.ComInterfaceDispatch* __this_native, CpuType* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetPlatform(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLanguage(ComWrappers.ComInterfaceDispatch* __this_native, CompileFlagLanguage* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLanguage(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetEditAndContinueEnabled(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetEditAndContinueEnabled(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFrontendMajor(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetFrontendMajor(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFrontendMinor(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetFrontendMinor(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFrontendBuild(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetFrontendBuild(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBackendMajor(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBackendMajor(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBackendMinor(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBackendMinor(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBackendBuild(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBackendBuild(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSourceFileName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetSourceFileName(out string result);

		*__result_native__param = BStrStringMarshaller.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetUnused(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetUnused(out string result);

		*__result_native__param = BStrStringMarshaller.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetThunkOrdinal(ComWrappers.ComInterfaceDispatch* __this_native, ThunkOrdinal* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetThunkOrdinal(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetThisAdjustor(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetThisAdjustor(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualBaseOffset(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetVirtualBaseOffset(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsVirtual(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsVirtual(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsIntro(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsIntro(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsPure(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsPure(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCallingConvention(ComWrappers.ComInterfaceDispatch* __this_native, DiaSharp.CodeView.CallingConvention* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetCallingConvention(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetValue(ComWrappers.ComInterfaceDispatch* __this_native, Variant* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetValue(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBaseType(ComWrappers.ComInterfaceDispatch* __this_native, BasicType* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBaseType(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetToken(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetToken(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetTimestamp(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetTimestamp(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetGUID(ComWrappers.ComInterfaceDispatch* __this_native, Guid* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetGUID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSymbolsFileName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetSymbolsFileName(out string result);

		*__result_native__param = BStrStringMarshaller.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsReference(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsReference(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCount(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetCount(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBitPosition(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBitPosition(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetArrayIndexType(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetArrayIndexType(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsPacked(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsPacked(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasConstructor(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasConstructor(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasOverloadedOperator(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasOverloadedOperator(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsNested(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsNested(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasNestedTypes(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasNestedTypes(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasAssignmentOperator(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasAssignmentOperator(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasCastOperator(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasCastOperator(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsScoped(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsScoped(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsVirtualBaseClass(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsVirtualBaseClass(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsIndirectVirtualBaseClass(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsIndirectVirtualBaseClass(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualBasePointerOffset(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetVirtualBasePointerOffset(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualTableShape(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetVirtualTableShape(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLexicalParentID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLexicalParentID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetClassParentID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetClassParentID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetTypeID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetTypeID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetArrayIndexTypeID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetArrayIndexTypeID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualTableShapeID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetVirtualTableShapeID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsCode(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsCode(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsFunction(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsFunction(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsManaged(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsManaged(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsMSIL(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsMSIL(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualBaseDisplacementIndex(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetVirtualBaseDisplacementIndex(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetUndecoratedName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetUndecoratedName(out string result);

		*__result_native__param = BStrStringMarshaller.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAge(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetAge(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSignature(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetSignature(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsCompilerGenerated(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsCompilerGenerated(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsAddressTaken(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsAddressTaken(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRank(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetRank(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLowerBound(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLowerBound(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetUpperBound(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetUpperBound(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLowerBoundID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLowerBoundID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetUpperBoundID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetUpperBoundID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetDataBytes(ComWrappers.ComInterfaceDispatch* __this_native, uint dataSize, uint* __dataWritten_native__param, byte* buffer)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetDataBytes(dataSize, out uint dataWritten, buffer);

		*__dataWritten_native__param = dataWritten;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindChildrenUnaware(ComWrappers.ComInterfaceDispatch* __this_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions compareFlags, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindChildrenUnaware(symbolTag, Utf16StringMarshaller.ConvertToManaged(__name_native), compareFlags, out IEnumSymbols result);

		*__result_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindChildren(ComWrappers.ComInterfaceDispatch* __this_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions compareFlags, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindChildren(symbolTag, Utf16StringMarshaller.ConvertToManaged(__name_native), compareFlags, out IEnumSymbols result);

		*__result_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindChildrenByAddress(ComWrappers.ComInterfaceDispatch* __this_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions compareFlags, uint sectionIndex, uint offset, void** __result_native__param)
	{
		int __retVal = 	ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindChildrenByAddress(symbolTag, Utf16StringMarshaller.ConvertToManaged(__name_native), compareFlags, sectionIndex, offset, out IEnumSymbols result);

		*__result_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindChildrenByVA(ComWrappers.ComInterfaceDispatch* __this_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions compareFlags, ulong virtualAddress, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindChildrenByVA(symbolTag, Utf16StringMarshaller.ConvertToManaged(__name_native), compareFlags, virtualAddress, out IEnumSymbols result);

		*__result_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindChildrenByRVA(ComWrappers.ComInterfaceDispatch* __this_native, SymbolTag symbolTag, ushort* __name_native, NameSearchOptions compareFlags, uint relativeVirtualAddress, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindChildrenByRVA(symbolTag, Utf16StringMarshaller.ConvertToManaged(__name_native), compareFlags, relativeVirtualAddress, out IEnumSymbols result);

		*__result_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetTargetSection(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetTargetSection(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetTargetOffset(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetTargetOffset(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetTargetRelativeVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetTargetRelativeVirtualAddress(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetTargetVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetTargetVirtualAddress(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetMachineType(ComWrappers.ComInterfaceDispatch* __this_native, ImageFileMachine* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetMachineType(out ImageFileMachine result);

		*__result_native__param = result;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetOemID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetOemID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetOemSymbolID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetOemSymbolID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetTypes(ComWrappers.ComInterfaceDispatch* __this_native, uint typeCount, uint* __typesWritten_native__param, void** buffer)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetTypes(typeCount, out uint typesWritten, buffer);

		*__typesWritten_native__param = typesWritten;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetTypeIDs(ComWrappers.ComInterfaceDispatch* __this_native, uint typeIDCount, uint* __typeIDsWritten_native__param, uint* buffer)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetTypeIDs(typeIDCount, out uint typeIDsWritten, buffer);

		*__typeIDsWritten_native__param = typeIDsWritten;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetObjectPointerType(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetObjectPointerType(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetUdtKind(ComWrappers.ComInterfaceDispatch* __this_native, UdtKind* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetUdtKind(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetUndecoratedName(ComWrappers.ComInterfaceDispatch* __this_native, UndecorateOptions undecorateOptions, ushort** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetUndecoratedName(undecorateOptions, out string result);

		*__result_native__param = BStrStringMarshaller.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsNoReturn(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsNoReturn(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasCustomCallingConvention(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasCustomCallingConvention(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNoInline(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetNoInline(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasOptimizedCodeDebugInfo(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasOptimizedCodeDebugInfo(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsNotReached(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsNotReached(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasInterruptReturn(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasInterruptReturn(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasFarReturn(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasFarReturn(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsStatic(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsStatic(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasDebugInfo(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasDebugInfo(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsLTCG(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsLTCG(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsDataAligned(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsDataAligned(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasSecurityChecks(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasSecurityChecks(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCompilerName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetCompilerName(out string result);

		*__result_native__param = BStrStringMarshaller.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasAlloca(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasAlloca(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasSetJump(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasSetJump(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasLongJump(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasLongJump(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasInlAsm(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasInlAsm(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasEH(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasEH(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasSEH(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasSEH(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasEHa(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasEHa(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsNaked(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsNaked(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsAggregated(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsAggregated(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsSplit(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsSplit(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetContainer(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetContainer(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetInliningSpecified(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetInliningSpecified(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNoStackOrderingSpecified(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetNoStackOrderingSpecified(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualBaseTableType(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetVirtualBaseTableType(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasManagedCode(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasManagedCode(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsHotpatchable(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsHotpatchable(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsConvertedCIL(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsConvertedCIL(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsMSILNetmodule(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsMSILNetmodule(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasCTypes(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasCTypes(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsStripped(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsStripped(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFrontendQFE(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetFrontendQFE(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBackendQFE(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBackendQFE(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetWasInlined(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetWasInlined(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasStrictGSCheck(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasStrictGSCheck(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsCxxReturnUdt(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsCxxReturnUdt(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsConstructorVirtualBase(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsConstructorVirtualBase(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsRValueReference(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsRValueReference(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetUnmodifiedType(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetUnmodifiedType(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFramePointerPresent(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetFramePointerPresent(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasSafeBuffers(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasSafeBuffers(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsIntrinsic(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsIntrinsic(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsSealed(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsSealed(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasHfaFloat(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasHfaFloat(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasHfaDouble(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasHfaDouble(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLiveRangeStartAddressSection(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLiveRangeStartAddressSection(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLiveRangeStartAddressOffset(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLiveRangeStartAddressOffset(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLiveRangeStartRelativeVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLiveRangeStartRelativeVirtualAddress(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLiveRangeCount(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLiveRangeCount(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLiveRangeLength(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLiveRangeLength(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetOffsetInUdt(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetOffsetInUdt(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetParamBasePointerRegisterID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetParamBasePointerRegisterID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLocalBasePointerRegisterID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetLocalBasePointerRegisterID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsLocationControlFlowDependent(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsLocationControlFlowDependent(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetStride(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetStride(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNumberOfRows(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetNumberOfRows(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNumberOfColumns(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetNumberOfColumns(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsMatrixRowMajor(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsMatrixRowMajor(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNumericProperties(ComWrappers.ComInterfaceDispatch* __this_native, uint propertyCount, uint* __countWritten_native__param, uint* buffer)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetNumericProperties(propertyCount, out uint countWritten, buffer);

		*__countWritten_native__param = countWritten;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetModifierValues(ComWrappers.ComInterfaceDispatch* __this_native, uint propertyCount, uint* __countWritten_native__param, ushort* buffer)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetModifierValues(propertyCount, out uint countWritten, buffer);

		*__countWritten_native__param = countWritten;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsReturnValue(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsReturnValue(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsOptimizedAway(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsOptimizedAway(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBuiltInKind(ComWrappers.ComInterfaceDispatch* __this_native, BuiltIn* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBuiltInKind(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRegisterType(ComWrappers.ComInterfaceDispatch* __this_native, Register* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetRegisterType(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBaseDataSlot(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBaseDataSlot(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBaseDataOffset(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBaseDataOffset(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetTextureSlot(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetTextureSlot(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSamplerSlot(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetSamplerSlot(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetUavSlot(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetUavSlot(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSizeInUdt(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetSizeInUdt(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetMemorySpaceKind(ComWrappers.ComInterfaceDispatch* __this_native, MemorySpace* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetMemorySpaceKind(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetUnmodifiedTypeId(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetUnmodifiedTypeId(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSubTypeId(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetSubTypeId(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSubType(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetSubType(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNumberOfModifiers(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetNumberOfModifiers(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNumberOfRegisterIndices(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetNumberOfRegisterIndices(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsHLSLData(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsHLSLData(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsPointerToDataMember(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsPointerToDataMember(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsPointerToMemberFunction(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsPointerToMemberFunction(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsSingleInheritance(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsSingleInheritance(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsMultipleInheritance(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsMultipleInheritance(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsVirtualInheritance(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsVirtualInheritance(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRestrictedType(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetRestrictedType(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsPointerBasedOnSymbolValue(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsPointerBasedOnSymbolValue(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBaseSymbol(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBaseSymbol(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBaseSymbolId(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBaseSymbolId(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetObjectFileName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetObjectFileName(out string result);

		*__result_native__param = BStrStringMarshaller.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsAcceleratorGroupSharedLocal(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsAcceleratorGroupSharedLocal(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsAcceleratorPointerTagLiveRange(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsAcceleratorPointerTagLiveRange(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsAcceleratorStubFunction(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsAcceleratorStubFunction(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNumberOfAcceleratorPointerTags(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetNumberOfAcceleratorPointerTags(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsSDL(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsSDL(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsWinRTPointer(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsWinRTPointer(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsRefUdt(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsRefUdt(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsValueUdt(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsValueUdt(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsInterfaceUdt(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsInterfaceUdt(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineFramesByAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint sectionIndex, uint offset, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindInlineFramesByAddress(sectionIndex, offset, out IEnumSymbols result);

		*__result_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineFramesByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindInlineFramesByRVA(relativeVirtualAddress, out IEnumSymbols result);

		*__result_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineFramesByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindInlineFramesByVA(virtualAddress, out IEnumSymbols result);

		*__result_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineeLines(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindInlineeLines(out IEnumLineNumbers result);

		*__result_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineeLinesByAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint sectionIndex, uint offset, uint length, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindInlineeLinesByAddress(sectionIndex, offset, length, out IEnumLineNumbers result);

		*__result_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineeLinesByRVA(ComWrappers.ComInterfaceDispatch* __this_native, uint relativeVirtualAddress, uint length, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindInlineeLinesByRVA(relativeVirtualAddress, length, out IEnumLineNumbers result);

		*__result_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInlineeLinesByVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, uint length, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindInlineeLinesByVA(virtualAddress, length, out IEnumLineNumbers result);

		*__result_native__param = ComInterfaceMarshaller<IEnumLineNumbers>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindSymbolsForAcceleratorPointerTag(ComWrappers.ComInterfaceDispatch* __this_native, uint tagValue, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindSymbolsForAcceleratorPointerTag(tagValue, out IEnumSymbols result);

		*__result_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindSymbolsByRVAForAcceleratorPointerTag(ComWrappers.ComInterfaceDispatch* __this_native, uint tagValue, uint relativeVirtualAddress, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindSymbolsByRVAForAcceleratorPointerTag(tagValue, relativeVirtualAddress, out IEnumSymbols result);

		*__result_native__param = ComInterfaceMarshaller<IEnumSymbols>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAcceleratorPointerTags(ComWrappers.ComInterfaceDispatch* __this_native, uint tagCount, uint* __tagsWritten_native__param, uint* buffer)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetAcceleratorPointerTags(tagCount, out uint tagsWritten, buffer);

		*__tagsWritten_native__param = tagsWritten;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSourceLineOnTypeDefinition(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetSourceLineOnTypeDefinition(out ILineNumber result);

		*__result_native__param = ComInterfaceMarshaller<ILineNumber>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsPGO(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsPGO(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasValidPGOCounts(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasValidPGOCounts(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsOptimizedForSpeed(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsOptimizedForSpeed(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetPGOEntryCount(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetPGOEntryCount(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetPGOEdgeCount(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetPGOEdgeCount(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetPGODynamicInstructionCount(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetPGODynamicInstructionCount(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetStaticSize(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetStaticSize(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFinalLiveStaticSize(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetFinalLiveStaticSize(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetPhaseName(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetPhaseName(out string result);

		*__result_native__param = BStrStringMarshaller.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetHasControlFlowCheck(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetHasControlFlowCheck(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsConstantExport(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsConstantExport(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetIsDataExport(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetIsDataExport(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetPrivateExport(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetPrivateExport(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNoNameExport(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetNoNameExport(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetExportHasExplicitlyAssignedOrdinal(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetExportHasExplicitlyAssignedOrdinal(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetExportIsForwarder(ComWrappers.ComInterfaceDispatch* __this_native, int* __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetExportIsForwarder(out bool result);

		*__result_native__param = result ? 1 : 0;

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetOrdinal(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetOrdinal(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFrameSize(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetFrameSize(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetExceptionHandlerAddressSection(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetExceptionHandlerAddressSection(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetExceptionHandlerAddressOffset(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetExceptionHandlerAddressOffset(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetExceptionHandlerRelativeVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetExceptionHandlerRelativeVirtualAddress(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetExceptionHandlerVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetExceptionHandlerVirtualAddress(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_FindInputAssemblyFile(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).FindInputAssemblyFile(out IInputAssemblyFile result);

		*__result_native__param = ComInterfaceMarshaller<IInputAssemblyFile>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCharacteristics(ComWrappers.ComInterfaceDispatch* __this_native, SectionCharacteristics* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetCharacteristics(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCoffGroup(ComWrappers.ComInterfaceDispatch* __this_native, void** __result_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetCoffGroup(out ISymbol result);

		*__result_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(result);

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBindID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBindID(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBindSpace(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBindSpace(out *__result_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetBindSlot(ComWrappers.ComInterfaceDispatch* __this_native, uint* __result_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<ISymbol>(__this_native).GetBindSlot(out *__result_native__param);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ISymbol), sizeof(void*) * 239);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetSymbolIndexID;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, SymbolTag*, int>)&ABI_GetSymbolTag;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetName;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetLexicalParent;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetClassParent;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetSymbolType;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, DataKind*, int>)&ABI_GetDataKind;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, LocationType*, int>)&ABI_GetLocationType;
		vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetAddressSection;
		vtable[12] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetAddressOffset;
		vtable[13] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetRelativeVirtualAddress;
		vtable[14] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetVirtualAddress;
		vtable[15] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetRegisterID;
		vtable[16] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetOffset;
		vtable[17] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetLength;
		vtable[18] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetSlot;
		vtable[19] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetVolatileType;
		vtable[20] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetConstType;
		vtable[21] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetUnalignedType;
		vtable[22] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, Access*, int>)&ABI_GetAccess;
		vtable[23] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetLibraryName;
		vtable[24] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, CpuType*, int>)&ABI_GetPlatform;
		vtable[25] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, CompileFlagLanguage*, int>)&ABI_GetLanguage;
		vtable[26] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetEditAndContinueEnabled;
		vtable[27] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetFrontendMajor;
		vtable[28] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetFrontendMinor;
		vtable[29] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetFrontendBuild;
		vtable[30] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetBackendMajor;
		vtable[31] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetBackendMinor;
		vtable[32] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetBackendBuild;
		vtable[33] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetSourceFileName;
		vtable[34] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetUnused;
		vtable[35] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ThunkOrdinal*, int>)&ABI_GetThunkOrdinal;
		vtable[36] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetThisAdjustor;
		vtable[37] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetVirtualBaseOffset;
		vtable[38] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsVirtual;
		vtable[39] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsIntro;
		vtable[40] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsPure;
		vtable[41] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, DiaSharp.CodeView.CallingConvention*, int>)&ABI_GetCallingConvention;
		vtable[42] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, Variant*, int>)&ABI_GetValue;
		vtable[43] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, BasicType*, int>)&ABI_GetBaseType;
		vtable[44] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetToken;
		vtable[45] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetTimestamp;
		vtable[46] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, Guid*, int>)&ABI_GetGUID;
		vtable[47] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetSymbolsFileName;
		vtable[48] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsReference;
		vtable[49] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetCount;
		vtable[50] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetBitPosition;
		vtable[51] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetArrayIndexType;
		vtable[52] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsPacked;
		vtable[53] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasConstructor;
		vtable[54] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasOverloadedOperator;
		vtable[55] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsNested;
		vtable[56] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasNestedTypes;
		vtable[57] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasAssignmentOperator;
		vtable[58] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasCastOperator;
		vtable[59] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsScoped;
		vtable[60] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsVirtualBaseClass;
		vtable[61] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsIndirectVirtualBaseClass;
		vtable[62] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetVirtualBasePointerOffset;
		vtable[63] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetVirtualTableShape;
		vtable[64] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLexicalParentID;
		vtable[65] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetClassParentID;
		vtable[66] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetTypeID;
		vtable[67] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetArrayIndexTypeID;
		vtable[68] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetVirtualTableShapeID;
		vtable[69] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsCode;
		vtable[70] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsFunction;
		vtable[71] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsManaged;
		vtable[72] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsMSIL;
		vtable[73] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetVirtualBaseDisplacementIndex;
		vtable[74] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetUndecoratedName;
		vtable[75] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetAge;
		vtable[76] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetSignature;
		vtable[77] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsCompilerGenerated;
		vtable[78] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsAddressTaken;
		vtable[79] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetRank;
		vtable[80] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetLowerBound;
		vtable[81] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetUpperBound;
		vtable[82] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLowerBoundID;
		vtable[83] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetUpperBoundID;
		vtable[84] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, byte*, int>)&ABI_GetDataBytes;
		vtable[85] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, SymbolTag, ushort*, NameSearchOptions, void**, int>)&ABI_FindChildrenUnaware;
		vtable[86] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, SymbolTag, ushort*, NameSearchOptions, void**, int>)&ABI_FindChildren;
		vtable[87] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, SymbolTag, ushort*, NameSearchOptions, uint, uint, void**, int>)&ABI_FindChildrenByAddress;
		vtable[88] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, SymbolTag, ushort*, NameSearchOptions, ulong, void**, int>)&ABI_FindChildrenByVA;
		vtable[89] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, SymbolTag, ushort*, NameSearchOptions, uint, void**, int>)&ABI_FindChildrenByRVA;
		vtable[90] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetTargetSection;
		vtable[91] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetTargetOffset;
		vtable[92] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetTargetRelativeVirtualAddress;
		vtable[93] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetTargetVirtualAddress;
		vtable[94] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ImageFileMachine*, int>)&ABI_GetMachineType;
		vtable[95] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetOemID;
		vtable[96] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetOemSymbolID;
		vtable[97] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, void**, int>)&ABI_GetTypes;
		vtable[98] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, uint*, int>)&ABI_GetTypeIDs;
		vtable[99] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetObjectPointerType;
		vtable[100] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, UdtKind*, int>)&ABI_GetUdtKind;
		vtable[101] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, UndecorateOptions, ushort**, int>)&ABI_GetUndecoratedName;
		vtable[102] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsNoReturn;
		vtable[103] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasCustomCallingConvention;
		vtable[104] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetNoInline;
		vtable[105] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasOptimizedCodeDebugInfo;
		vtable[106] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsNotReached;
		vtable[107] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasInterruptReturn;
		vtable[108] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasFarReturn;
		vtable[109] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsStatic;
		vtable[110] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasDebugInfo;
		vtable[111] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsLTCG;
		vtable[112] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsDataAligned;
		vtable[113] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasSecurityChecks;
		vtable[114] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetCompilerName;
		vtable[115] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasAlloca;
		vtable[116] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasSetJump;
		vtable[117] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasLongJump;
		vtable[118] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasInlAsm;
		vtable[119] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasEH;
		vtable[120] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasSEH;
		vtable[121] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasEHa;
		vtable[122] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsNaked;
		vtable[123] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsAggregated;
		vtable[124] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsSplit;
		vtable[125] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetContainer;
		vtable[126] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetInliningSpecified;
		vtable[127] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetNoStackOrderingSpecified;
		vtable[128] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetVirtualBaseTableType;
		vtable[129] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasManagedCode;
		vtable[130] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsHotpatchable;
		vtable[131] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsConvertedCIL;
		vtable[132] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsMSILNetmodule;
		vtable[133] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasCTypes;
		vtable[134] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsStripped;
		vtable[135] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetFrontendQFE;
		vtable[136] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetBackendQFE;
		vtable[137] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetWasInlined;
		vtable[138] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasStrictGSCheck;
		vtable[139] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsCxxReturnUdt;
		vtable[140] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsConstructorVirtualBase;
		vtable[141] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsRValueReference;
		vtable[142] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetUnmodifiedType;
		vtable[143] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetFramePointerPresent;
		vtable[144] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasSafeBuffers;
		vtable[145] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsIntrinsic;
		vtable[146] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsSealed;
		vtable[147] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasHfaFloat;
		vtable[148] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasHfaDouble;
		vtable[149] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLiveRangeStartAddressSection;
		vtable[150] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLiveRangeStartAddressOffset;
		vtable[151] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLiveRangeStartRelativeVirtualAddress;
		vtable[152] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLiveRangeCount;
		vtable[153] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetLiveRangeLength;
		vtable[154] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetOffsetInUdt;
		vtable[155] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetParamBasePointerRegisterID;
		vtable[156] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetLocalBasePointerRegisterID;
		vtable[157] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsLocationControlFlowDependent;
		vtable[158] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetStride;
		vtable[159] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetNumberOfRows;
		vtable[160] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetNumberOfColumns;
		vtable[161] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsMatrixRowMajor;
		vtable[162] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, uint*, int>)&ABI_GetNumericProperties;
		vtable[163] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, ushort*, int>)&ABI_GetModifierValues;
		vtable[164] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsReturnValue;
		vtable[165] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsOptimizedAway;
		vtable[166] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, BuiltIn*, int>)&ABI_GetBuiltInKind;
		vtable[167] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, Register*, int>)&ABI_GetRegisterType;
		vtable[168] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetBaseDataSlot;
		vtable[169] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetBaseDataOffset;
		vtable[170] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetTextureSlot;
		vtable[171] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetSamplerSlot;
		vtable[172] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetUavSlot;
		vtable[173] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetSizeInUdt;
		vtable[174] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, MemorySpace*, int>)&ABI_GetMemorySpaceKind;
		vtable[175] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetUnmodifiedTypeId;
		vtable[176] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetSubTypeId;
		vtable[177] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetSubType;
		vtable[178] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetNumberOfModifiers;
		vtable[179] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetNumberOfRegisterIndices;
		vtable[180] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsHLSLData;
		vtable[181] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsPointerToDataMember;
		vtable[182] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsPointerToMemberFunction;
		vtable[183] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsSingleInheritance;
		vtable[184] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsMultipleInheritance;
		vtable[185] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsVirtualInheritance;
		vtable[186] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetRestrictedType;
		vtable[187] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsPointerBasedOnSymbolValue;
		vtable[188] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetBaseSymbol;
		vtable[189] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetBaseSymbolId;
		vtable[190] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetObjectFileName;
		vtable[191] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsAcceleratorGroupSharedLocal;
		vtable[192] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsAcceleratorPointerTagLiveRange;
		vtable[193] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsAcceleratorStubFunction;
		vtable[194] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetNumberOfAcceleratorPointerTags;
		vtable[195] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsSDL;
		vtable[196] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsWinRTPointer;
		vtable[197] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsRefUdt;
		vtable[198] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsValueUdt;
		vtable[199] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsInterfaceUdt;
		vtable[200] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, void**, int>)&ABI_FindInlineFramesByAddress;
		vtable[201] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_FindInlineFramesByRVA;
		vtable[202] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, void**, int>)&ABI_FindInlineFramesByVA;
		vtable[203] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_FindInlineeLines;
		vtable[204] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, uint, void**, int>)&ABI_FindInlineeLinesByAddress;
		vtable[205] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, void**, int>)&ABI_FindInlineeLinesByRVA;
		vtable[206] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, uint, void**, int>)&ABI_FindInlineeLinesByVA;
		vtable[207] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_FindSymbolsForAcceleratorPointerTag;
		vtable[208] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint, void**, int>)&ABI_FindSymbolsByRVAForAcceleratorPointerTag;
		vtable[209] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, uint*, int>)&ABI_GetAcceleratorPointerTags;
		vtable[210] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetSourceLineOnTypeDefinition;
		vtable[211] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsPGO;
		vtable[212] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasValidPGOCounts;
		vtable[213] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsOptimizedForSpeed;
		vtable[214] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetPGOEntryCount;
		vtable[215] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetPGOEdgeCount;
		vtable[216] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetPGODynamicInstructionCount;
		vtable[217] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetStaticSize;
		vtable[218] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetFinalLiveStaticSize;
		vtable[219] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetPhaseName;
		vtable[220] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetHasControlFlowCheck;
		vtable[221] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsConstantExport;
		vtable[222] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsDataExport;
		vtable[223] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetPrivateExport;
		vtable[224] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetNoNameExport;
		vtable[225] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetExportHasExplicitlyAssignedOrdinal;
		vtable[226] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetExportIsForwarder;
		vtable[227] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetOrdinal;
		vtable[228] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetFrameSize;
		vtable[229] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetExceptionHandlerAddressSection;
		vtable[230] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetExceptionHandlerAddressOffset;
		vtable[231] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetExceptionHandlerRelativeVirtualAddress;
		vtable[232] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetExceptionHandlerVirtualAddress;
		vtable[233] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_FindInputAssemblyFile;
		vtable[234] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, SectionCharacteristics*, int>)&ABI_GetCharacteristics;
		vtable[235] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetCoffGroup;
		vtable[236] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetBindID;
		vtable[237] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetBindSpace;
		vtable[238] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetBindSlot;

		return vtable;
	}
}

namespace DiaSharp.SDK.Symbols
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface ISymbol
	{
	}
}