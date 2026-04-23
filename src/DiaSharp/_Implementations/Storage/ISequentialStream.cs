#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.Storage;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([48, 58, 115, 12, 28, 42, 206, 17, 173, 229, 0, 170, 0, 68, 119, 61]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : ISequentialStream
{
	[SkipLocalsInit]
	int ISequentialStream.Read(byte* value, uint byteCount, out uint bytesRead)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISequentialStream));
		Unsafe.SkipInit(out bytesRead);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __bytesRead_native = &bytesRead)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, byte*, uint, uint*, int>)__vtable_native[3])(__this, value, byteCount, __bytesRead_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int ISequentialStream.Write(byte* value, uint byteCount, out uint bytesWritten)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISequentialStream));
		Unsafe.SkipInit(out bytesWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, byte*, uint, uint*, int>)__vtable_native[4])(__this, value, byteCount, __bytesWritten_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Read(ComWrappers.ComInterfaceDispatch* __this_native, byte* value, uint byteCount, uint* __bytesRead_native__param)
	{
		ISequentialStream @this = default!;
		ref uint __bytesRead_native = ref *__bytesRead_native__param;
		uint bytesRead = default!;
		int __retVal = default;
		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISequentialStream>(__this_native);
			__retVal = @this.Read(value, byteCount, out bytesRead);
			// Marshal - Convert managed data to native data.
			__bytesRead_native = bytesRead;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Write(ComWrappers.ComInterfaceDispatch* __this_native, byte* value, uint byteCount, uint* __bytesWritten_native__param)
	{
		ISequentialStream @this = default!;
		ref uint __bytesWritten_native = ref *__bytesWritten_native__param;
		uint bytesWritten = default!;
		int __retVal = default;
		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<ISequentialStream>(__this_native);
			__retVal = @this.Write(value, byteCount, out bytesWritten);
			// Marshal - Convert managed data to native data.
			__bytesWritten_native = bytesWritten;
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ISequentialStream), sizeof(void*) * 5);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, byte*, uint, uint*, int>)&ABI_Read;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, byte*, uint, uint*, int>)&ABI_Write;
		}

		return vtable;
	}
}

namespace DiaSharp.Storage
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface ISequentialStream
	{
	}
}