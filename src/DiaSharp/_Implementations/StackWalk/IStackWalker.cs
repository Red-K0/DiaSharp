#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.CodeView;
using DiaSharp.SDK.Enumerators;
using DiaSharp.StackWalk;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([107, 33, 133, 84, 76, 165, 159, 70, 150, 112, 82, 178, 77, 82, 41, 187]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IStackWalker
{
	[SkipLocalsInit]
	int IStackWalker.GetEnumFrames(IStackWalkHelper helper, out IEnumStackFrames frames)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalker));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out frames);
		void* __helper_native = default;
		void* __frames_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__helper_native = ComInterfaceMarshaller<IStackWalkHelper>.ConvertToUnmanaged(helper);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void**, int>)__vtable_native[3])(__this, __helper_native, &__frames_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			frames = ComInterfaceMarshaller<IEnumStackFrames>.ConvertToManaged(__frames_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumStackFrames>.Free(__frames_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<IStackWalkHelper>.Free(__helper_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalker.GetEnumFrames(CpuType cpuType, IStackWalkHelper helper, out IEnumStackFrames frames)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalker));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out frames);
		void* __helper_native = default;
		void* __frames_native = default;
		int __retVal = default;

		try
		{
			// Marshal - Convert managed data to native data.
			__helper_native = ComInterfaceMarshaller<IStackWalkHelper>.ConvertToUnmanaged(helper);
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, CpuType, void*, void**, int>)__vtable_native[4])(__this, cpuType, __helper_native, &__frames_native);
			}

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			frames = ComInterfaceMarshaller<IEnumStackFrames>.ConvertToManaged(__frames_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IEnumStackFrames>.Free(__frames_native);
			}

			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<IStackWalkHelper>.Free(__helper_native);
		}

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetEnumFrames(ComWrappers.ComInterfaceDispatch* __this_native, void* __helper_native, void** __frames_native__param)
	{
		IStackWalker @this = default!;
		IStackWalkHelper helper = default!;
		ref void* __frames_native = ref *__frames_native__param;
		IEnumStackFrames frames = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			helper = ComInterfaceMarshaller<IStackWalkHelper>.ConvertToManaged(__helper_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalker>(__this_native);
			__retVal = @this.GetEnumFrames(helper, out frames);
			// Marshal - Convert managed data to native data.
			__frames_native = ComInterfaceMarshaller<IEnumStackFrames>.ConvertToUnmanaged(frames);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_GetEnumFrames(ComWrappers.ComInterfaceDispatch* __this_native, CpuType cpuType, void* __helper_native, void** __frames_native__param)
	{
		IStackWalker @this = default!;
		IStackWalkHelper helper = default!;
		ref void* __frames_native = ref *__frames_native__param;
		IEnumStackFrames frames = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			helper = ComInterfaceMarshaller<IStackWalkHelper>.ConvertToManaged(__helper_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalker>(__this_native);
			__retVal = @this.GetEnumFrames(cpuType, helper, out frames);
			// Marshal - Convert managed data to native data.
			__frames_native = ComInterfaceMarshaller<IEnumStackFrames>.ConvertToUnmanaged(frames);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IStackWalker), sizeof(void*) * 5);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, void**, int>)&ABI_GetEnumFrames;
			vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, CpuType, void*, void**, int>)&ABI_GetEnumFrames;
		}

		return vtable;
	}
}

namespace DiaSharp.StackWalk
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IStackWalker
	{
	}
}