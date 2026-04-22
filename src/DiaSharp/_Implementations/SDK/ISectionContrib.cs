#pragma warning disable CS0612, CS0618, IDE0008
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
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out compiland);
		void* __compiland_native = default;
		int __retVal = default;

		try
		{
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__compiland_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			compiland = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__compiland_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__compiland_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetAddressSection(out uint section)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out section);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __section_native = &section)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[4])(__this, __section_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetAddressOffset(out uint offset)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out offset);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __offset_native = &offset)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[5])(__this, __offset_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetRelativeVirtualAddress(out uint relativeVirtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out relativeVirtualAddress);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __rva_native = &relativeVirtualAddress)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[6])(__this, __rva_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetVirtualAddress(out ulong virtualAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out virtualAddress);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __va_native = &virtualAddress)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[7])(__this, __va_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetLength(out uint length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out length);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __length_native = &length)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[8])(__this, __length_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetNotPaged(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[9])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetNoPad(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[10])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetHasCode(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[11])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetHasInitializedData(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[12])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetHasUninitializedData(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[13])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsInformational(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[14])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsRemoved(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[15])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsCOMDAT(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[16])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsDiscardable(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[17])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetNotCached(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[18])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsShareable(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[19])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsExecutable(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[20])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsReadable(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[21])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetIsWriteable(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[22])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetDataCRC(out uint crc)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out crc);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __crc_native = &crc)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[23])(__this, __crc_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetRelocationsCRC(out uint crc)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out crc);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __crc_native = &crc)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[24])(__this, __crc_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetCompilandID(out uint ID)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out ID);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __ID_native = &ID)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[25])(__this, __ID_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISectionContrib.GetHas16BitCode(out bool value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISectionContrib));
		Unsafe.SkipInit(out value);
		int __value_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[26])(__this, &__value_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		value = __value_native != 0;
		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetCompiland(ComWrappers.ComInterfaceDispatch* __this_native, void** __compiland_native__param)
	{
		ISectionContrib @this = default!;
		ref void* __compiland_native = ref *__compiland_native__param;
		ISymbol compiland = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetCompiland(out compiland);
			// Marshal - Convert managed data to native data.
			__compiland_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(compiland);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetAddressSection(ComWrappers.ComInterfaceDispatch* __this_native, uint* __section_native__param)
	{
		ISectionContrib @this = default!;
		ref uint __section_native = ref *__section_native__param;
		uint section = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetAddressSection(out section);
			// Marshal - Convert managed data to native data.
			__section_native = section;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetAddressOffset(ComWrappers.ComInterfaceDispatch* __this_native, uint* __offset_native__param)
	{
		ISectionContrib @this = default!;
		ref uint __offset_native = ref *__offset_native__param;
		uint offset = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetAddressOffset(out offset);
			// Marshal - Convert managed data to native data.
			__offset_native = offset;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetRelativeVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __rva_native__param)
	{
		ISectionContrib @this = default!;
		ref uint __rva_native = ref *__rva_native__param;
		uint relativeVirtualAddress = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetRelativeVirtualAddress(out relativeVirtualAddress);
			// Marshal - Convert managed data to native data.
			__rva_native = relativeVirtualAddress;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __va_native__param)
	{
		ISectionContrib @this = default!;
		ref ulong __va_native = ref *__va_native__param;
		ulong virtualAddress = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetVirtualAddress(out virtualAddress);
			// Marshal - Convert managed data to native data.
			__va_native = virtualAddress;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetLength(ComWrappers.ComInterfaceDispatch* __this_native, uint* __length_native__param)
	{
		ISectionContrib @this = default!;
		ref uint __length_native = ref *__length_native__param;
		uint length = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetLength(out length);
			// Marshal - Convert managed data to native data.
			__length_native = length;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNotPaged(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetNotPaged(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNoPad(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetNoPad(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetHasCode(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetHasCode(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetHasInitializedData(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetHasInitializedData(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetHasUninitializedData(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetHasUninitializedData(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetIsInformational(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetIsInformational(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetIsRemoved(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetIsRemoved(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetIsCOMDAT(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetIsCOMDAT(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetIsDiscardable(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetIsDiscardable(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNotCached(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetNotCached(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetIsShareable(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetIsShareable(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetIsExecutable(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetIsExecutable(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetIsReadable(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetIsReadable(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetIsWriteable(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetIsWriteable(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetDataCRC(ComWrappers.ComInterfaceDispatch* __this_native, uint* __crc_native__param)
	{
		ISectionContrib @this = default!;
		ref uint __crc_native = ref *__crc_native__param;
		uint crc = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetDataCRC(out crc);
			// Marshal - Convert managed data to native data.
			__crc_native = crc;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetRelocationsCRC(ComWrappers.ComInterfaceDispatch* __this_native, uint* __crc_native__param)
	{
		ISectionContrib @this = default!;
		ref uint __crc_native = ref *__crc_native__param;
		uint crc = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetRelocationsCRC(out crc);
			// Marshal - Convert managed data to native data.
			__crc_native = crc;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetCompilandID(ComWrappers.ComInterfaceDispatch* __this_native, uint* __ID_native__param)
	{
		ISectionContrib @this = default!;
		ref uint __ID_native = ref *__ID_native__param;
		uint ID = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetCompilandID(out ID);
			// Marshal - Convert managed data to native data.
			__ID_native = ID;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetHas16BitCode(ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
	{
		ISectionContrib @this = default!;
		ref int __value_native = ref *__value_native__param;
		bool value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISectionContrib>(__this_native);
			__retVal = @this.GetHas16BitCode(out value);
			// Marshal - Convert managed data to native data.
			__value_native = value ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ISectionContrib), sizeof(void*) * 27);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
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
		}

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