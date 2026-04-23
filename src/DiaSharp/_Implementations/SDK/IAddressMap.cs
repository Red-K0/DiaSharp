#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.Native;
using DiaSharp.SDK;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([122, 46, 42, 182, 122, 6, 163, 78, 181, 152, 4, 192, 151, 23, 80, 44]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IAddressMap
{
	[SkipLocalsInit]
	int IAddressMap.GetIsAddressMapEnabled(out bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));
		Unsafe.SkipInit(out enabled);
		int __enabled_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[3])(__this, &__enabled_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		enabled = __enabled_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IAddressMap.SetIsAddressMapEnabled(bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));
		int __enabled_native;
		int __retVal;
		// Marshal - Convert managed data to native data.
		__enabled_native = enabled ? 1 : 0;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int, int>)__vtable_native[4])(__this, __enabled_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IAddressMap.GetIsRelativeVirtualAddressEnabled(out bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));
		Unsafe.SkipInit(out enabled);
		int __enabled_native;
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[5])(__this, &__enabled_native);
		}

		GC.KeepAlive(this);
		// Unmarshal - Convert native data to managed data.
		enabled = __enabled_native != 0;
		return __retVal;
	}

	[SkipLocalsInit]
	int IAddressMap.SetIsRelativeVirtualAddressEnabled(bool enabled)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));
		int __enabled_native;
		int __retVal;
		// Marshal - Convert managed data to native data.
		__enabled_native = enabled ? 1 : 0;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int, int>)__vtable_native[6])(__this, __enabled_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IAddressMap.GetImageAlignment(out uint alignment)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));
		Unsafe.SkipInit(out alignment);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __alignment_native = &alignment)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[7])(__this, __alignment_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IAddressMap.SetImageAlignment(uint value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[8])(__this, value);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IAddressMap.SetImageHeaders(uint dataSize, ImageSectionHeader* data, bool originalHeaders)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));
		int __originalHeaders_native;
		int __retVal;
		// Marshal - Convert managed data to native data.
		__originalHeaders_native = originalHeaders ? 1 : 0;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, ImageSectionHeader*, int, int>)__vtable_native[9])(__this, dataSize, data, __originalHeaders_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IAddressMap.SetAddressMap(uint dataSize, AddressMapEntry* data, bool imageToSymbols)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IAddressMap));
		int __imageToSymbols_native;
		int __retVal;
		// Marshal - Convert managed data to native data.
		__imageToSymbols_native = imageToSymbols ? 1 : 0;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, AddressMapEntry*, int, int>)__vtable_native[10])(__this, dataSize, data, __imageToSymbols_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetIsAddressMapEnabled(ComWrappers.ComInterfaceDispatch* __this_native, int* __enabled_native__param)
	{
		IAddressMap @this = default!;
		ref int __enabled_native = ref *__enabled_native__param;
		bool enabled = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native);
			__retVal = @this.GetIsAddressMapEnabled(out enabled);
			// Marshal - Convert managed data to native data.
			__enabled_native = enabled ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_SetIsAddressMapEnabled(ComWrappers.ComInterfaceDispatch* __this_native, int __enabled_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			bool enabled = __enabled_native != 0;
			IAddressMap @this = ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native);
			__retVal = @this.SetIsAddressMapEnabled(enabled);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetIsRelativeVirtualAddressEnabled(ComWrappers.ComInterfaceDispatch* __this_native, int* __enabled_native__param)
	{
		IAddressMap @this = default!;
		ref int __enabled_native = ref *__enabled_native__param;
		bool enabled = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native);
			__retVal = @this.GetIsRelativeVirtualAddressEnabled(out enabled);
			// Marshal - Convert managed data to native data.
			__enabled_native = enabled ? 1 : 0;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_SetIsRelativeVirtualAddressEnabled(ComWrappers.ComInterfaceDispatch* __this_native, int __enabled_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			bool enabled = __enabled_native != 0;
			IAddressMap @this = ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native);
			__retVal = @this.SetIsRelativeVirtualAddressEnabled(enabled);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetImageAlignment(ComWrappers.ComInterfaceDispatch* __this_native, uint* __alignment_native__param)
	{
		IAddressMap @this = default!;
		ref uint __alignment_native = ref *__alignment_native__param;
		uint alignment = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native);
			__retVal = @this.GetImageAlignment(out alignment);
			// Marshal - Convert managed data to native data.
			__alignment_native = alignment;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_SetImageAlignment(ComWrappers.ComInterfaceDispatch* __this_native, uint value)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			IAddressMap @this = ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native);
			__retVal = @this.SetImageAlignment(value);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_SetImageHeaders(ComWrappers.ComInterfaceDispatch* __this_native, uint dataSize, ImageSectionHeader* data, int __originalHeaders_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			bool originalHeaders = __originalHeaders_native != 0;
			IAddressMap @this = ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native);
			__retVal = @this.SetImageHeaders(dataSize, data, originalHeaders);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_SetAddressMap(ComWrappers.ComInterfaceDispatch* __this_native, uint dataSize, AddressMapEntry* data, int __imageToSymbols_native)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			bool imageToSymbols = __imageToSymbols_native != 0;
			IAddressMap @this = ComWrappers.ComInterfaceDispatch.GetInstance<IAddressMap>(__this_native);
			__retVal = @this.SetAddressMap(dataSize, data, imageToSymbols);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IAddressMap), sizeof(void*) * 11);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsAddressMapEnabled;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int, int>)&ABI_SetIsAddressMapEnabled;
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetIsRelativeVirtualAddressEnabled;
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int, int>)&ABI_SetIsRelativeVirtualAddressEnabled;
			vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetImageAlignment;
			vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int>)&ABI_SetImageAlignment;
			vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, ImageSectionHeader*, int, int>)&ABI_SetImageHeaders;
			vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, AddressMapEntry*, int, int>)&ABI_SetAddressMap;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IAddressMap
	{
	}
}