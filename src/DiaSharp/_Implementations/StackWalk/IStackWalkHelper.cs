#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.CodeView;
using DiaSharp.Native;
using DiaSharp.SDK;
using DiaSharp.SDK.Symbols;
using DiaSharp.StackWalk;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([27, 27, 248, 33, 187, 197, 163, 66, 188, 79, 204, 186, 167, 91, 159, 25]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IStackWalkHelper
{
	[SkipLocalsInit]
	int IStackWalkHelper.GetRegisterValue(HostRegister index, out ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));

		fixed (ulong* __value_native = &value)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, HostRegister, ulong*, int>)__vtable_native[3])(__this, index, __value_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper.PutRegisterValue(HostRegister index, ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));

		return ((delegate* unmanaged[MemberFunction]<void*, HostRegister, ulong, int>)__vtable_native[4])(__this, index, value);
	}

	[SkipLocalsInit]
	int IStackWalkHelper.ReadMemory(MemoryType type, ulong virtualAddress, uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, MemoryType, ulong, uint, uint*, byte*, int>)__vtable_native[5])(__this, type, virtualAddress, bufferSize, __bytesWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper.SearchForReturnAddress(IFrameData frame, out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
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
	int IStackWalkHelper.SearchForReturnAddressStart(IFrameData frame, ulong address, out ulong startAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		void* __frame_native = null;

		try
		{
			__frame_native = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frame);

			fixed (ulong* __startAddress_native = &startAddress)
			{
				return ((delegate* unmanaged[MemberFunction]<void*, void*, ulong, ulong*, int>)__vtable_native[7])(__this, __frame_native, address, __startAddress_native);
			}
		}
		finally
		{
			ComInterfaceMarshaller<IFrameData>.Free(__frame_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetFrameForVA(ulong virtualAddress, out IFrameData frame)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		bool __invokeSucceeded = false;
		void* __frame_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, void**, int>)__vtable_native[8])(__this, virtualAddress, &__frame_native);

			__invokeSucceeded = true;

			frame = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frame_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<IFrameData>.Free(__frame_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetSymbolForVA(ulong virtualAddress, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		bool __invokeSucceeded = false;
		void* __symbol_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, void**, int>)__vtable_native[9])(__this, virtualAddress, &__symbol_native);

			__invokeSucceeded = true;

			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetPDataForVA(ulong virtualAddress, uint bytesRequested, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint*, byte*, int>)__vtable_native[10])(__this, virtualAddress, bytesRequested, __bytesWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetImageForVA(ulong virtualAddressContext, out ulong imageAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));

		fixed (ulong* __imageAddress_native = &imageAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong, ulong*, int>)__vtable_native[11])(__this, virtualAddressContext, __imageAddress_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetAddressForVA(ulong virtualAddress, out uint equivalentSection, out uint fragmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));

		fixed (uint* __fragmentCount_native = &fragmentCount)
		fixed (uint* __equivalentSection_native = &equivalentSection)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong, uint*, uint*, int>)__vtable_native[12])(__this, virtualAddress, __equivalentSection_native, __fragmentCount_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetNumberOfFunctionFragmentsForVA(ulong functionAddress, uint functionSize, out uint fragmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));

		fixed (uint* __fragmentCount_native = &fragmentCount)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint*, int>)__vtable_native[13])(__this, functionAddress, functionSize, __fragmentCount_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetFunctionFragmentsForVA(ulong functionAddress, uint functionSize, uint fragmentCount, ulong* fragments, uint* fragmentLengths)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));

		return ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint, ulong*, uint*, int>)__vtable_native[14])(__this, functionAddress, functionSize, fragmentCount, fragments, fragmentLengths);
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetRegisterValue(ComWrappers.ComInterfaceDispatch* __this_native, HostRegister index, ulong* __value_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native).GetRegisterValue(index, out *__value_native__param);
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
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native).PutRegisterValue(index, value);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_ReadMemory(ComWrappers.ComInterfaceDispatch* __this_native, MemoryType type, ulong virtualAddress, uint bufferSize, uint* __bytesWritten_native__param, byte* buffer)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native).ReadMemory(type, virtualAddress, bufferSize, out *__bytesWritten_native__param, buffer);
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
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native).SearchForReturnAddress(ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frame_native)!, out *__address_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_SearchForReturnAddressStart(ComWrappers.ComInterfaceDispatch* __this_native, void* __frame_native, ulong address, ulong* __startAddress_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native).SearchForReturnAddressStart(ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frame_native)!, address, out *__startAddress_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFrameForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, void** __frame_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native).GetFrameForVA(virtualAddress, out IFrameData frame);

			*__frame_native__param = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frame);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSymbolForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, void** __symbol_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native).GetSymbolForVA(virtualAddress, out ISymbol symbol);

			*__symbol_native__param = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetPDataForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, uint bytesRequested, uint* __bytesWritten_native__param, byte* buffer)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native).GetPDataForVA(virtualAddress, bytesRequested, out *__bytesWritten_native__param, buffer);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetImageForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddressContext, ulong* __imageAddress_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native).GetImageForVA(virtualAddressContext, out *__imageAddress_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetAddressForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, uint* __equivalentSection_native__param, uint* __fragmentCount_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native).GetAddressForVA(virtualAddress, out *__equivalentSection_native__param, out *__fragmentCount_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNumberOfFunctionFragmentsForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong functionAddress, uint functionSize, uint* __fragmentCount_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native).GetNumberOfFunctionFragmentsForVA(functionAddress, functionSize, out *__fragmentCount_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFunctionFragmentsForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong functionAddress, uint functionSize, uint fragmentCount, ulong* fragments, uint* fragmentLengths)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native).GetFunctionFragmentsForVA(functionAddress, functionSize, fragmentCount, fragments, fragmentLengths);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IStackWalkHelper), sizeof(void*) * 15);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, HostRegister, ulong*, int>)&ABI_GetRegisterValue;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, HostRegister, ulong, int>)&ABI_PutRegisterValue;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, MemoryType, ulong, uint, uint*, byte*, int>)&ABI_ReadMemory;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, ulong*, int>)&ABI_SearchForReturnAddress;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, ulong, ulong*, int>)&ABI_SearchForReturnAddressStart;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, void**, int>)&ABI_GetFrameForVA;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, void**, int>)&ABI_GetSymbolForVA;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, uint, uint*, byte*, int>)&ABI_GetPDataForVA;
		vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, ulong*, int>)&ABI_GetImageForVA;
		vtable[12] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, uint*, uint*, int>)&ABI_GetAddressForVA;
		vtable[13] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, uint, uint*, int>)&ABI_GetNumberOfFunctionFragmentsForVA;
		vtable[14] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, uint, uint, ulong*, uint*, int>)&ABI_GetFunctionFragmentsForVA;

		return vtable;
	}
}

namespace DiaSharp.StackWalk
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IStackWalkHelper
	{
	}
}