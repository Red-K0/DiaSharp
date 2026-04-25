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

		fixed (uint* __bytesRead_native = &bytesRead)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, byte*, uint, uint*, int>)__vtable_native[3])(__this, value, byteCount, __bytesRead_native);
		}
	}

	[SkipLocalsInit]
	int ISequentialStream.Write(byte* value, uint byteCount, out uint bytesWritten)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(ISequentialStream));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, byte*, uint, uint*, int>)__vtable_native[4])(__this, value, byteCount, __bytesWritten_native);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Read(ComWrappers.ComInterfaceDispatch* __this_native, byte* value, uint byteCount, uint* __bytesRead_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<ISequentialStream>(__this_native).Read(value, byteCount, out *__bytesRead_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Write(ComWrappers.ComInterfaceDispatch* __this_native, byte* value, uint byteCount, uint* __bytesWritten_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<ISequentialStream>(__this_native).Write(value, byteCount, out *__bytesWritten_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ISequentialStream), sizeof(void*) * 5);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, byte*, uint, uint*, int>)&ABI_Read;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, byte*, uint, uint*, int>)&ABI_Write;

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