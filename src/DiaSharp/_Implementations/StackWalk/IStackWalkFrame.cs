#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.CodeView;
using DiaSharp.Native;
using DiaSharp.SDK;
using DiaSharp.StackWalk;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([193, 144, 197, 7, 141, 67, 71, 79, 189, 205, 67, 151, 188, 129, 173, 117]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IStackWalkFrame
{
	[SkipLocalsInit]
	int IStackWalkFrame.GetRegisterValue(HostRegister index, out ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkFrame));

		fixed (ulong* __value_native = &value)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, HostRegister, ulong*, int>)__vtable_native[3])(__this, index, __value_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkFrame.PutRegisterValue(HostRegister index, ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkFrame));

		return ((delegate* unmanaged[MemberFunction]<void*, HostRegister, ulong, int>)__vtable_native[4])(__this, index, value);
	}

	[SkipLocalsInit]
	int IStackWalkFrame.ReadMemory(MemoryType type, ulong virtualAddress, uint bytesRequested, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkFrame));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, MemoryType, ulong, uint, uint*, byte*, int>)__vtable_native[5])(__this, type, virtualAddress, bytesRequested, __bytesWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int IStackWalkFrame.SearchForReturnAddress(IFrameData frame, out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkFrame));
		void* __frame_native = null;

		try
		{
			__frame_native = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frame);

			fixed (ulong* __address_native = &address)
			{
				return ((delegate* unmanaged[MemberFunction]<void*, void*, ulong*, int>)__vtable_native[6])(__this, __frame_native, __address_native);
			}
		}
		finally
		{
			ComInterfaceMarshaller<IFrameData>.Free(__frame_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkFrame.SearchForReturnAddressStart(IFrameData frame, ulong address, out ulong start)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkFrame));
		void* __frame_native = null;

		try
		{
			__frame_native = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frame);

			fixed (ulong* __start_native = &start)
			{
				return ((delegate* unmanaged[MemberFunction]<void*, void*, ulong, ulong*, int>)__vtable_native[7])(__this, __frame_native, address, __start_native);
			}
		}
		finally
		{
			ComInterfaceMarshaller<IFrameData>.Free(__frame_native);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRegisterValue(ComWrappers.ComInterfaceDispatch* __this_native, HostRegister index, ulong* __value_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkFrame>(__this_native).GetRegisterValue(index, out *__value_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_PutRegisterValue(ComWrappers.ComInterfaceDispatch* __this_native, HostRegister index, ulong value)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkFrame>(__this_native).PutRegisterValue(index, value);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_ReadMemory(ComWrappers.ComInterfaceDispatch* __this_native, MemoryType type, ulong virtualAddress, uint bytesRequested, uint* __bytesWritten_native__param, byte* buffer)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkFrame>(__this_native).ReadMemory(type, virtualAddress, bytesRequested, out *__bytesWritten_native__param, buffer);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_SearchForReturnAddress(ComWrappers.ComInterfaceDispatch* __this_native, void* __frame_native, ulong* __address_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkFrame>(__this_native).SearchForReturnAddress(ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frame_native)!, out *__address_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_SearchForReturnAddressStart(ComWrappers.ComInterfaceDispatch* __this_native, void* __frame_native, ulong address, ulong* __start_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkFrame>(__this_native).SearchForReturnAddressStart(ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frame_native)!, address, out *__start_native__param);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IStackWalkFrame), sizeof(void*) * 8);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, HostRegister, ulong*, int>)&ABI_GetRegisterValue;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, HostRegister, ulong, int>)&ABI_PutRegisterValue;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, MemoryType, ulong, uint, uint*, byte*, int>)&ABI_ReadMemory;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, ulong*, int>)&ABI_SearchForReturnAddress;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, ulong, ulong*, int>)&ABI_SearchForReturnAddressStart;

		return vtable;
	}
}

namespace DiaSharp.StackWalk
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IStackWalkFrame
	{
	}
}