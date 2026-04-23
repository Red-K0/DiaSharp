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
		Unsafe.SkipInit(out value);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __value_native = &value)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, HostRegister, ulong*, int>)__vtable_native[3])(__this, index, __value_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkHelper.PutRegisterValue(HostRegister index, ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, HostRegister, ulong, int>)__vtable_native[4])(__this, index, value);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkHelper.ReadMemory(MemoryType type, ulong virtualAddress, uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		Unsafe.SkipInit(out bytesWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, MemoryType, ulong, uint, uint*, byte*, int>)__vtable_native[5])(__this, type, virtualAddress, bufferSize, __bytesWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkHelper.SearchForReturnAddress(IFrameData frame, out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		Unsafe.SkipInit(out address);
		void* __frame_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__frame_native = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frame);
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (ulong* __address_native = &address)
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, ulong*, int>)__vtable_native[6])(__this, __frame_native, __address_native);
			}

			GC.KeepAlive(this);
		}
		finally
		{
			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<IFrameData>.Free(__frame_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkHelper.SearchForReturnAddressStart(IFrameData frame, ulong address, out ulong startAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		Unsafe.SkipInit(out startAddress);
		void* __frame_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__frame_native = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frame);
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (ulong* __startAddress_native = &startAddress)
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, ulong, ulong*, int>)__vtable_native[7])(__this, __frame_native, address, __startAddress_native);
			}

			GC.KeepAlive(this);
		}
		finally
		{
			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<IFrameData>.Free(__frame_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetFrameForVA(ulong virtualAddress, out IFrameData frame)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out frame);
		void* __frame_native = default;
		int __retVal = default;

		try
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, void**, int>)__vtable_native[8])(__this, virtualAddress, &__frame_native);

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			frame = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frame_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IFrameData>.Free(__frame_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetSymbolForVA(ulong virtualAddress, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out symbol);
		void* __symbol_native = default;
		int __retVal = default;

		try
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, void**, int>)__vtable_native[9])(__this, virtualAddress, &__symbol_native);

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			symbol = ComInterfaceMarshaller<ISymbol>.ConvertToManaged(__symbol_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<ISymbol>.Free(__symbol_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetPDataForVA(ulong virtualAddress, uint bytesRequested, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		Unsafe.SkipInit(out bytesWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint*, byte*, int>)__vtable_native[10])(__this, virtualAddress, bytesRequested, __bytesWritten_native, buffer);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetImageForVA(ulong virtualAddressContext, out ulong imageAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		Unsafe.SkipInit(out imageAddress);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __imageAddress_native = &imageAddress)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, ulong*, int>)__vtable_native[11])(__this, virtualAddressContext, __imageAddress_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetAddressForVA(ulong virtualAddress, out uint equivalentSection, out uint fragmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		Unsafe.SkipInit(out equivalentSection);
		Unsafe.SkipInit(out fragmentCount);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __fragmentCount_native = &fragmentCount)
		fixed (uint* __equivalentSection_native = &equivalentSection)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint*, uint*, int>)__vtable_native[12])(__this, virtualAddress, __equivalentSection_native, __fragmentCount_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetNumberOfFunctionFragmentsForVA(ulong functionAddress, uint functionSize, out uint fragmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		Unsafe.SkipInit(out fragmentCount);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __fragmentCount_native = &fragmentCount)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint*, int>)__vtable_native[13])(__this, functionAddress, functionSize, __fragmentCount_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalkHelper.GetFunctionFragmentsForVA(ulong functionAddress, uint functionSize, uint fragmentCount, ulong* fragments, uint* fragmentLengths)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint, ulong*, uint*, int>)__vtable_native[14])(__this, functionAddress, functionSize, fragmentCount, fragments, fragmentLengths);
		}

		GC.KeepAlive(this);
		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetRegisterValue(ComWrappers.ComInterfaceDispatch* __this_native, HostRegister index, ulong* __value_native__param)
	{
		IStackWalkHelper @this = default!;
		ref ulong __value_native = ref *__value_native__param;
		ulong value = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native);
			__retVal = @this.GetRegisterValue(index, out value);
			// Marshal - Convert managed data to native data.
			__value_native = value;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_PutRegisterValue(ComWrappers.ComInterfaceDispatch* __this_native, HostRegister index, ulong value)
	{
		int __retVal;

		try
		{
			IStackWalkHelper @this = default!;
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native);
			__retVal = @this.PutRegisterValue(index, value);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_ReadMemory(ComWrappers.ComInterfaceDispatch* __this_native, MemoryType type, ulong virtualAddress, uint bufferSize, uint* __bytesWritten_native__param, byte* buffer)
	{
		IStackWalkHelper @this = default!;
		ref uint __bytesWritten_native = ref *__bytesWritten_native__param;
		uint bytesWritten = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native);
			__retVal = @this.ReadMemory(type, virtualAddress, bufferSize, out bytesWritten, buffer);
			// Marshal - Convert managed data to native data.
			__bytesWritten_native = bytesWritten;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_SearchForReturnAddress(ComWrappers.ComInterfaceDispatch* __this_native, void* __frame_native, ulong* __address_native__param)
	{
		IStackWalkHelper @this = default!;
		IFrameData frame = default!;
		ref ulong __address_native = ref *__address_native__param;
		ulong address = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			frame = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frame_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native);
			__retVal = @this.SearchForReturnAddress(frame, out address);
			// Marshal - Convert managed data to native data.
			__address_native = address;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_SearchForReturnAddressStart(ComWrappers.ComInterfaceDispatch* __this_native, void* __frame_native, ulong address, ulong* __startAddress_native__param)
	{
		IStackWalkHelper @this = default!;
		IFrameData frame = default!;
		ref ulong __startAddress_native = ref *__startAddress_native__param;
		ulong startAddress = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			frame = ComInterfaceMarshaller<IFrameData>.ConvertToManaged(__frame_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native);
			__retVal = @this.SearchForReturnAddressStart(frame, address, out startAddress);
			// Marshal - Convert managed data to native data.
			__startAddress_native = startAddress;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetFrameForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, void** __frame_native__param)
	{
		IStackWalkHelper @this = default!;
		ref void* __frame_native = ref *__frame_native__param;
		IFrameData frame = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native);
			__retVal = @this.GetFrameForVA(virtualAddress, out frame);
			// Marshal - Convert managed data to native data.
			__frame_native = ComInterfaceMarshaller<IFrameData>.ConvertToUnmanaged(frame);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetSymbolForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, void** __symbol_native__param)
	{
		IStackWalkHelper @this = default!;
		ref void* __symbol_native = ref *__symbol_native__param;
		ISymbol symbol = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native);
			__retVal = @this.GetSymbolForVA(virtualAddress, out symbol);
			// Marshal - Convert managed data to native data.
			__symbol_native = ComInterfaceMarshaller<ISymbol>.ConvertToUnmanaged(symbol);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetPDataForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, uint bytesRequested, uint* __bytesWritten_native__param, byte* buffer)
	{
		IStackWalkHelper @this = default!;
		ref uint __bytesWritten_native = ref *__bytesWritten_native__param;
		uint bytesWritten = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native);
			__retVal = @this.GetPDataForVA(virtualAddress, bytesRequested, out bytesWritten, buffer);
			// Marshal - Convert managed data to native data.
			__bytesWritten_native = bytesWritten;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetImageForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddressContext, ulong* __imageAddress_native__param)
	{
		IStackWalkHelper @this = default!;
		ref ulong __imageAddress_native = ref *__imageAddress_native__param;
		ulong imageAddress = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native);
			__retVal = @this.GetImageForVA(virtualAddressContext, out imageAddress);
			// Marshal - Convert managed data to native data.
			__imageAddress_native = imageAddress;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetAddressForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong virtualAddress, uint* __equivalentSection_native__param, uint* __fragmentCount_native__param)
	{
		IStackWalkHelper @this = default!;
		ref uint __equivalentSection_native = ref *__equivalentSection_native__param;
		uint equivalentSection = default!;
		ref uint __fragmentCount_native = ref *__fragmentCount_native__param;
		uint fragmentCount = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native);
			__retVal = @this.GetAddressForVA(virtualAddress, out equivalentSection, out fragmentCount);
			// Marshal - Convert managed data to native data.
			__fragmentCount_native = fragmentCount;
			__equivalentSection_native = equivalentSection;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetNumberOfFunctionFragmentsForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong functionAddress, uint functionSize, uint* __fragmentCount_native__param)
	{
		IStackWalkHelper @this = default!;
		ref uint __fragmentCount_native = ref *__fragmentCount_native__param;
		uint fragmentCount = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native);
			__retVal = @this.GetNumberOfFunctionFragmentsForVA(functionAddress, functionSize, out fragmentCount);
			// Marshal - Convert managed data to native data.
			__fragmentCount_native = fragmentCount;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetFunctionFragmentsForVA(ComWrappers.ComInterfaceDispatch* __this_native, ulong functionAddress, uint functionSize, uint fragmentCount, ulong* fragments, uint* fragmentLengths)
	{
		int __retVal;

		try
		{
			IStackWalkHelper @this = default!;
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper>(__this_native);
			__retVal = @this.GetFunctionFragmentsForVA(functionAddress, functionSize, fragmentCount, fragments, fragmentLengths);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IStackWalkHelper), sizeof(void*) * 15);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
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
		}

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