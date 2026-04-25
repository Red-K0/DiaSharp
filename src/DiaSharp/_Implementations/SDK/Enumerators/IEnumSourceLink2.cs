#pragma warning disable IDE0008, IDE0022

using DiaSharp.SDK.Enumerators;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([81, 129, 109, 19, 231, 173, 4, 71, 175, 19, 50, 64, 128, 118, 46, 143]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumSourceLink2
{
	[SkipLocalsInit]
	int IEnumSourceLink2.SizeOfNext(out ulong size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink2));

		fixed (ulong* __size_native = &size)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[9])(__this, __size_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSourceLink2.GetNext(ulong bufferSize, out ulong bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink2));

		fixed (ulong* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong, ulong*, byte*, int>)__vtable_native[10])(__this, bufferSize, __bytesWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int IEnumSourceLink2.Count(out uint count)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink2));

		fixed (uint* __count_native = &count)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __count_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSourceLink2.SizeOfNext(out uint size)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink2));

		fixed (uint* __size_native = &size)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[4])(__this, __size_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSourceLink2.GetNext(uint bufferSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink2));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[5])(__this, bufferSize, __bytesWritten_native, buffer);
		}
	}

	[SkipLocalsInit]
	int IEnumSourceLink2.Skip(uint byteCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink2));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[6])(__this, byteCount);
	}

	[SkipLocalsInit]
	int IEnumSourceLink2.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink2));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[7])(__this);
	}

	[SkipLocalsInit]
	int IEnumSourceLink2.Clone(out IEnumSourceLink enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSourceLink2));
		void* __enumerator_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[8])(__this, &__enumerator_native);

		enumerator = ComInterfaceMarshaller<IEnumSourceLink>.ConvertToManaged(__enumerator_native)!;

		ComInterfaceMarshaller<IEnumSourceLink>.Free(__enumerator_native);

		return __retVal;
	}

	int IEnumSourceLink.Count(out uint count) => throw new UnreachableException();
	int IEnumSourceLink.SizeOfNext(out uint size) => throw new UnreachableException();
	int IEnumSourceLink.GetNext(uint bufferSize, out uint bytesWritten, byte* buffer) => throw new UnreachableException();
	int IEnumSourceLink.Skip(uint byteCount) => throw new UnreachableException();
	int IEnumSourceLink.Reset() => throw new UnreachableException();
	int IEnumSourceLink.Clone(out IEnumSourceLink enumerator) => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_SizeOfNext(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __size_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSourceLink2>(__this_native).SizeOfNext(out *__size_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, ulong bufferSize, ulong* __bytesWritten_native__param, byte* buffer)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSourceLink2>(__this_native).GetNext(bufferSize, out *__bytesWritten_native__param, buffer);
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumSourceLink2), sizeof(void*) * 11);

		NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(IEnumSourceLink).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 9));

		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_SizeOfNext;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, ulong*, byte*, int>)&ABI_GetNext;

		return vtable;
	}
}

namespace DiaSharp.SDK.Enumerators
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public unsafe partial interface IEnumSourceLink2
	{
		[SkipLocalsInit, PreserveSig]
		new int Count(out uint count) => ((IEnumSourceLink)this).Count(out count);

		[SkipLocalsInit, PreserveSig]
		new int SizeOfNext(out uint size) => ((IEnumSourceLink)this).SizeOfNext(out size);

		[SkipLocalsInit, PreserveSig]
		new int GetNext(uint bufferSize, out uint bytesWritten, byte* buffer) => ((IEnumSourceLink)this).GetNext(bufferSize, out bytesWritten, buffer);

		[SkipLocalsInit, PreserveSig]
		new int Skip(uint byteCount) => ((IEnumSourceLink)this).Skip(byteCount);

		[SkipLocalsInit, PreserveSig]
		new int Reset() => ((IEnumSourceLink)this).Reset();

		[SkipLocalsInit, PreserveSig]
		new int Clone(out IEnumSourceLink enumerator) => ((IEnumSourceLink)this).Clone(out enumerator);
	}
}