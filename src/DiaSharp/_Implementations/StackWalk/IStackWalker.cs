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
		bool __invokeSucceeded = false;
		void* __helper_native = null;
		void* __frames_native = null;

		try
		{
			__helper_native = ComInterfaceMarshaller<IStackWalkHelper>.ConvertToUnmanaged(helper);

			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void**, int>)__vtable_native[3])(__this, __helper_native, &__frames_native);

			__invokeSucceeded = true;

			frames = ComInterfaceMarshaller<IEnumStackFrames>.ConvertToManaged(__frames_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<IEnumStackFrames>.Free(__frames_native);

			ComInterfaceMarshaller<IStackWalkHelper>.Free(__helper_native);
		}
	}

	[SkipLocalsInit]
	int IStackWalker.GetEnumFrames(CpuType cpuType, IStackWalkHelper helper, out IEnumStackFrames frames)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalker));
		bool __invokeSucceeded = false;
		void* __helper_native = null;
		void* __frames_native = null;

		try
		{
			__helper_native = ComInterfaceMarshaller<IStackWalkHelper>.ConvertToUnmanaged(helper);

			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, CpuType, void*, void**, int>)__vtable_native[4])(__this, cpuType, __helper_native, &__frames_native);

			__invokeSucceeded = true;

			frames = ComInterfaceMarshaller<IEnumStackFrames>.ConvertToManaged(__frames_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<IEnumStackFrames>.Free(__frames_native);

			ComInterfaceMarshaller<IStackWalkHelper>.Free(__helper_native);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetEnumFrames(ComWrappers.ComInterfaceDispatch* __this_native, void* __helper_native, void** __frames_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalker>(__this_native).GetEnumFrames(ComInterfaceMarshaller<IStackWalkHelper>.ConvertToManaged(__helper_native)!, out IEnumStackFrames frames);

			*__frames_native__param = ComInterfaceMarshaller<IEnumStackFrames>.ConvertToUnmanaged(frames);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetEnumFrames(ComWrappers.ComInterfaceDispatch* __this_native, CpuType cpuType, void* __helper_native, void** __frames_native__param)
	{
		try
		{
			int __retVal =ComWrappers.ComInterfaceDispatch.GetInstance<IStackWalker>(__this_native).GetEnumFrames(cpuType, ComInterfaceMarshaller<IStackWalkHelper>.ConvertToManaged(__helper_native)!, out IEnumStackFrames frames);

			*__frames_native__param = ComInterfaceMarshaller<IEnumStackFrames>.ConvertToUnmanaged(frames);

			return __retVal;
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IStackWalker), sizeof(void*) * 5);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, void**, int>)&ABI_GetEnumFrames;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, CpuType, void*, void**, int>)&ABI_GetEnumFrames;

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