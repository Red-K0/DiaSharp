#pragma warning disable CS0612, CS0618, IDE0008
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
	int IImageData.GetRelativeVirtualAddress(out uint rva)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IImageData));
		Unsafe.SkipInit(out rva);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __rva_native = &rva)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __rva_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IImageData.GetVirtualAddress(out ulong va)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IImageData));
		Unsafe.SkipInit(out va);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __va_native = &va)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[4])(__this, __va_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IImageData.GetImageBase(out ulong imageBase)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IImageData));
		Unsafe.SkipInit(out imageBase);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __imageBase_native = &imageBase)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[5])(__this, __imageBase_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetRelativeVirtualAddress(ComWrappers.ComInterfaceDispatch* __this_native, uint* __rva_native__param)
	{
		IImageData @this = default!;
		ref uint __rva_native = ref *__rva_native__param;
		uint rva = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IImageData>(__this_native);
			__retVal = @this.GetRelativeVirtualAddress(out rva);
			// Marshal - Convert managed data to native data.
			__rva_native = rva;
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
		IImageData @this = default!;
		ref ulong __va_native = ref *__va_native__param;
		ulong va = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IImageData>(__this_native);
			__retVal = @this.GetVirtualAddress(out va);
			// Marshal - Convert managed data to native data.
			__va_native = va;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetImageBase(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __imageBase_native__param)
	{
		IImageData @this = default!;
		ref ulong __imageBase_native = ref *__imageBase_native__param;
		ulong imageBase = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IImageData>(__this_native);
			__retVal = @this.GetImageBase(out imageBase);
			// Marshal - Convert managed data to native data.
			__imageBase_native = imageBase;
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IImageData), sizeof(void*) * 6);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetRelativeVirtualAddress;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetVirtualAddress;
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetImageBase;
		}

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