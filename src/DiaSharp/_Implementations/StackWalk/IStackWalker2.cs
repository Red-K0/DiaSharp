#pragma warning disable IDE0008, IDE0022

using DiaSharp.CodeView;
using DiaSharp.SDK.Enumerators;
using DiaSharp.StackWalk;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([133, 88, 24, 124, 21, 160, 172, 76, 148, 17, 15, 79, 179, 155, 31, 58]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IStackWalker2
{
	[SkipLocalsInit]
	int IStackWalker2.GetEnumFrames(IStackWalkHelper helper, out IEnumStackFrames frames)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalker2));
		void* __frames_native = null;

		void* __helper_native = ComInterfaceMarshaller<IStackWalkHelper>.ConvertToUnmanaged(helper);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, void**, int>)__vtable_native[3])(__this, __helper_native, &__frames_native);

		frames = ComInterfaceMarshaller<IEnumStackFrames>.ConvertToManaged(__frames_native)!;

		ComInterfaceMarshaller<IEnumStackFrames>.Free(__frames_native);
		ComInterfaceMarshaller<IStackWalkHelper>.Free(__helper_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IStackWalker2.GetEnumFrames(CpuType cpuType, IStackWalkHelper helper, out IEnumStackFrames frames)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStackWalker2));
		void* __frames_native = null;

		void* __helper_native = ComInterfaceMarshaller<IStackWalkHelper>.ConvertToUnmanaged(helper);

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, CpuType, void*, void**, int>)__vtable_native[4])(__this, cpuType, __helper_native, &__frames_native);

		frames = ComInterfaceMarshaller<IEnumStackFrames>.ConvertToManaged(__frames_native)!;

		ComInterfaceMarshaller<IEnumStackFrames>.Free(__frames_native);
		ComInterfaceMarshaller<IStackWalkHelper>.Free(__helper_native);

		return __retVal;
	}

	int IStackWalker.GetEnumFrames(IStackWalkHelper helper, out IEnumStackFrames frames) => throw new UnreachableException();
	int IStackWalker.GetEnumFrames(CpuType cpuType, IStackWalkHelper helper, out IEnumStackFrames frames) => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IStackWalker2), sizeof(void*) * 5);

		NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(IStackWalker).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 5));

		return vtable;
	}
}

namespace DiaSharp.StackWalk
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IStackWalker2
	{
		[SkipLocalsInit, PreserveSig]
		new int GetEnumFrames(IStackWalkHelper helper, out IEnumStackFrames frames) => ((IStackWalker)this).GetEnumFrames(helper, out frames);

		[SkipLocalsInit, PreserveSig]
		new int GetEnumFrames(CpuType cpuType, IStackWalkHelper helper, out IEnumStackFrames frames) => ((IStackWalker)this).GetEnumFrames(cpuType, helper, out frames);
	}
}