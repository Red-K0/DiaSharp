#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.CodeView;
using DiaSharp.Native;
using DiaSharp.SDK;
using DiaSharp.SDK.Symbols;
using DiaSharp.StackWalk;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([144, 196, 34, 130, 123, 80, 239, 75, 179, 189, 65, 220, 167, 181, 147, 76]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IStackWalkHelper2
{
	[SkipLocalsInit]
	int IStackWalkHelper2.GetPointerAuthenticationMask(ulong pointerValue, out ulong mask)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));

		fixed (ulong* __mask_native = &mask)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong, ulong*, int>)__vtable_native[15])(__this, pointerValue, __mask_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper2.GetRegisterValue(HostRegister index, out ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));

		fixed (ulong* __value_native = &value)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, HostRegister, ulong*, int>)__vtable_native[3])(__this, index, __value_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper2.PutRegisterValue(HostRegister index, ulong value)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));

		return ((delegate* unmanaged[MemberFunction]<void*, HostRegister, ulong, int>)__vtable_native[4])(__this, index, value);
	}

	[SkipLocalsInit]
	int IStackWalkHelper2.ReadMemory(MemoryType type, ulong virtualAddress, uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, MemoryType, ulong, uint, uint*, byte*, int>)__vtable_native[5])(__this, type, virtualAddress, bufferSize, __bytesWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper2.SearchForReturnAddress(IFrameData frame, out ulong address)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));
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
	int IStackWalkHelper2.SearchForReturnAddressStart(IFrameData frame, ulong address, out ulong startAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));
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
	int IStackWalkHelper2.GetFrameForVA(ulong virtualAddress, out IFrameData frame)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));
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
	int IStackWalkHelper2.GetSymbolForVA(ulong virtualAddress, out ISymbol symbol)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));
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
	int IStackWalkHelper2.GetPDataForVA(ulong virtualAddress, uint bytesRequested, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint*, byte*, int>)__vtable_native[10])(__this, virtualAddress, bytesRequested, __bytesWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper2.GetImageForVA(ulong virtualAddressContext, out ulong imageAddress)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));

		fixed (ulong* __imageAddress_native = &imageAddress)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong, ulong*, int>)__vtable_native[11])(__this, virtualAddressContext, __imageAddress_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper2.GetAddressForVA(ulong virtualAddress, out uint equivalentSection, out uint fragmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));

		fixed (uint* __fragmentCount_native = &fragmentCount)
		fixed (uint* __equivalentSection_native = &equivalentSection)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong, uint*, uint*, int>)__vtable_native[12])(__this, virtualAddress, __equivalentSection_native, __fragmentCount_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper2.GetNumberOfFunctionFragmentsForVA(ulong functionAddress, uint functionSize, out uint fragmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));

		fixed (uint* __fragmentCount_native = &fragmentCount)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint*, int>)__vtable_native[13])(__this, functionAddress, functionSize, __fragmentCount_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalkHelper2.GetFunctionFragmentsForVA(ulong functionAddress, uint functionSize, uint fragmentCount, ulong* fragments, uint* fragmentLengths)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalkHelper2));

		return ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint, ulong*, uint*, int>)__vtable_native[14])(__this, functionAddress, functionSize, fragmentCount, fragments, fragmentLengths);
	}

	int IStackWalkHelper.GetRegisterValue(HostRegister index, out ulong value) => throw new UnreachableException();
	int IStackWalkHelper.PutRegisterValue(HostRegister index, ulong value) => throw new UnreachableException();
	int IStackWalkHelper.ReadMemory(MemoryType type, ulong virtualAddress, uint bufferSize, out uint bytesWritten, byte* buffer) => throw new UnreachableException();
	int IStackWalkHelper.SearchForReturnAddress(IFrameData frame, out ulong address) => throw new UnreachableException();
	int IStackWalkHelper.SearchForReturnAddressStart(IFrameData frame, ulong address, out ulong startAddress) => throw new UnreachableException();
	int IStackWalkHelper.GetFrameForVA(ulong virtualAddress, out IFrameData frame) => throw new UnreachableException();
	int IStackWalkHelper.GetSymbolForVA(ulong virtualAddress, out ISymbol symbol) => throw new UnreachableException();
	int IStackWalkHelper.GetPDataForVA(ulong virtualAddress, uint bytesRequested, out uint bytesWritten, byte* buffer) => throw new UnreachableException();
	int IStackWalkHelper.GetImageForVA(ulong virtualAddressContext, out ulong imageAddress) => throw new UnreachableException();
	int IStackWalkHelper.GetAddressForVA(ulong virtualAddress, out uint equivalentSection, out uint fragmentCount) => throw new UnreachableException();
	int IStackWalkHelper.GetNumberOfFunctionFragmentsForVA(ulong functionAddress, uint functionSize, out uint fragmentCount) => throw new UnreachableException();
	int IStackWalkHelper.GetFunctionFragmentsForVA(ulong functionAddress, uint functionSize, uint fragmentCount, ulong* fragments, uint* fragmentLengths) => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetPointerAuthenticationMask(ComWrappers.ComInterfaceDispatch* __this_native, ulong pointerValue, ulong* __mask_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalkHelper2>(__this_native).GetPointerAuthenticationMask(pointerValue, out *__mask_native__param);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IStackWalkHelper2), sizeof(void*) * 16);

		NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(IStackWalkHelper).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 15));

		vtable[15] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, ulong*, int>)&ABI_GetPointerAuthenticationMask;

		return vtable;
	}
}

namespace DiaSharp.StackWalk
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public unsafe partial interface IStackWalkHelper2
	{

		[SkipLocalsInit, PreserveSig]
		new int GetRegisterValue(HostRegister index, out ulong value) => ((IStackWalkHelper)this).GetRegisterValue(index, out value);

		[SkipLocalsInit, PreserveSig]
		new int PutRegisterValue(HostRegister index, ulong value) => ((IStackWalkHelper)this).PutRegisterValue(index, value);

		[SkipLocalsInit, PreserveSig]
		new int ReadMemory(MemoryType type, ulong virtualAddress, uint bufferSize, out uint bytesWritten, byte* buffer) => ((IStackWalkHelper)this).ReadMemory(type, virtualAddress, bufferSize, out bytesWritten, buffer);

		[SkipLocalsInit, PreserveSig]
		new int SearchForReturnAddress(IFrameData frame, out ulong address) => ((IStackWalkHelper)this).SearchForReturnAddress(frame, out address);

		[SkipLocalsInit, PreserveSig]
		new int SearchForReturnAddressStart(IFrameData frame, ulong address, out ulong startAddress) => ((IStackWalkHelper)this).SearchForReturnAddressStart(frame, address, out startAddress);

		[SkipLocalsInit, PreserveSig]
		new int GetFrameForVA(ulong virtualAddress, out IFrameData frame) => ((IStackWalkHelper)this).GetFrameForVA(virtualAddress, out frame);

		[SkipLocalsInit, PreserveSig]
		new int GetSymbolForVA(ulong virtualAddress, out ISymbol symbol) => ((IStackWalkHelper)this).GetSymbolForVA(virtualAddress, out symbol);

		[SkipLocalsInit, PreserveSig]
		new int GetPDataForVA(ulong virtualAddress, uint bytesRequested, out uint bytesWritten, byte* buffer) => ((IStackWalkHelper)this).GetPDataForVA(virtualAddress, bytesRequested, out bytesWritten, buffer);

		[SkipLocalsInit, PreserveSig]
		new int GetImageForVA(ulong virtualAddressContext, out ulong imageAddress) => ((IStackWalkHelper)this).GetImageForVA(virtualAddressContext, out imageAddress);

		[SkipLocalsInit, PreserveSig]
		new int GetAddressForVA(ulong virtualAddress, out uint equivalentSection, out uint fragmentCount) => ((IStackWalkHelper)this).GetAddressForVA(virtualAddress, out equivalentSection, out fragmentCount);

		[SkipLocalsInit, PreserveSig]
		new int GetNumberOfFunctionFragmentsForVA(ulong functionAddress, uint functionSize, out uint fragmentCount) => ((IStackWalkHelper)this).GetNumberOfFunctionFragmentsForVA(functionAddress, functionSize, out fragmentCount);

		[SkipLocalsInit, PreserveSig]
		new int GetFunctionFragmentsForVA(ulong functionAddress, uint functionSize, uint fragmentCount, ulong* fragments, uint* fragmentLengths) => ((IStackWalkHelper)this).GetFunctionFragmentsForVA(functionAddress, functionSize, fragmentCount, fragments, fragmentLengths);
	}
}