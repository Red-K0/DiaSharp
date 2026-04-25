#pragma warning disable IDE0008, IDE0022

using DiaSharp.Storage;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([12, 0, 0, 0, 0, 0, 0, 0, 192, 0, 0, 0, 0, 0, 0, 70]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IStream
{
	[SkipLocalsInit]
	int IStream.Seek(long offset, SeekType origin, out ulong newPosition)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));

		fixed (ulong* __newPosition_native = &newPosition)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, long, SeekType, ulong*, int>)__vtable_native[5])(__this, offset, origin, __newPosition_native);
		}
	}

	[SkipLocalsInit]
	int IStream.SetSize(ulong newSize)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));

		return ((delegate* unmanaged[MemberFunction]<void*, ulong, int>)__vtable_native[6])(__this, newSize);
	}

	[SkipLocalsInit]
	int IStream.CopyTo(IStream stream, ulong byteCount, out ulong bytesRead, out ulong newPosition)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));
		int __retVal;

		void* __stream_native = ComInterfaceMarshaller<IStream>.ConvertToUnmanaged(stream);

		fixed (ulong* __newPosition_native = &newPosition)
		fixed (ulong* __bytesRead_native = &bytesRead)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, ulong, ulong*, ulong*, int>)__vtable_native[7])(__this, __stream_native, byteCount, __bytesRead_native, __newPosition_native);
		}


		ComInterfaceMarshaller<IStream>.Free(__stream_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IStream.Commit(CommitFlags flags)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));

		return ((delegate* unmanaged[MemberFunction]<void*, CommitFlags, int>)__vtable_native[8])(__this, flags);
	}

	[SkipLocalsInit]
	int IStream.Revert()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[9])(__this);
	}

	[SkipLocalsInit]
	int IStream.LockRegion(ulong offset, ulong byteCount, LockType lsockType)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));

		return ((delegate* unmanaged[MemberFunction]<void*, ulong, ulong, LockType, int>)__vtable_native[10])(__this, offset, byteCount, lsockType);
	}

	[SkipLocalsInit]
	int IStream.UnlockRegion(ulong offset, ulong byteCount, LockType lockType)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));

		return ((delegate* unmanaged[MemberFunction]<void*, ulong, ulong, LockType, int>)__vtable_native[11])(__this, offset, byteCount, lockType);
	}

	[SkipLocalsInit]
	int IStream.Stat(out StatStorage tag, StatName flag)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));

		fixed (StatStorage* __tag_native = &tag)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, StatStorage*, StatName, int>)__vtable_native[12])(__this, __tag_native, flag);
		}
	}

	[SkipLocalsInit]
	int IStream.Clone(out IStream stream)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));
		void* __stream_native = null;

		int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[13])(__this, &__stream_native);

		stream = ComInterfaceMarshaller<IStream>.ConvertToManaged(__stream_native)!;

		ComInterfaceMarshaller<IStream>.Free(__stream_native);

		return __retVal;
	}

	[SkipLocalsInit]
	int IStream.Read(byte* buffer, uint byteCount, out uint bytesRead)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));

		fixed (uint* __bytesRead_native = &bytesRead)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, byte*, uint, uint*, int>)__vtable_native[3])(__this, buffer, byteCount, __bytesRead_native);
		}
	}

	[SkipLocalsInit]
	int IStream.Write(byte* buffer, uint byteCount, out uint bytesWritten)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, byte*, uint, uint*, int>)__vtable_native[4])(__this, buffer, byteCount, __bytesWritten_native);
		}
	}

	int ISequentialStream.Read(byte* value, uint byteCount, out uint bytesRead) => throw new UnreachableException();
	int ISequentialStream.Write(byte* value, uint byteCount, out uint bytesWritten) => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Seek(ComWrappers.ComInterfaceDispatch* __this_native, long offset, SeekType origin, ulong* __newPosition_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native).Seek(offset, origin, out *__newPosition_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_SetSize(ComWrappers.ComInterfaceDispatch* __this_native, ulong newSize)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native).SetSize(newSize);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_CopyTo(ComWrappers.ComInterfaceDispatch* __this_native, void* __stream_native, ulong byteCount, ulong* __bytesRead_native__param, ulong* __newPosition_native__param)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native).CopyTo(ComInterfaceMarshaller<IStream>.ConvertToManaged(__stream_native)!, byteCount, out *__bytesRead_native__param, out *__newPosition_native__param);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Commit(ComWrappers.ComInterfaceDispatch* __this_native, CommitFlags flags)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native).Commit(flags);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Revert(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native).Revert();
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_LockRegion(ComWrappers.ComInterfaceDispatch* __this_native, ulong offset, ulong byteCount, LockType lsockType)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native).LockRegion(offset, byteCount, lsockType);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_UnlockRegion(ComWrappers.ComInterfaceDispatch* __this_native, ulong offset, ulong byteCount, LockType lockType)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native).UnlockRegion(offset, byteCount, lockType);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Stat(ComWrappers.ComInterfaceDispatch* __this_native, StatStorage* __tag_native__param, StatName flag)
	{
		return ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native).Stat(out *__tag_native__param, flag);
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __stream_native__param)
	{
		int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native).Clone(out IStream stream);

		*__stream_native__param = ComInterfaceMarshaller<IStream>.ConvertToUnmanaged(stream);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	static internal void** CreateManagedVirtualFunctionTable()
	{
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IStream), sizeof(void*) * 14);

		NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(ISequentialStream).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 5));

		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, long, SeekType, ulong*, int>)&ABI_Seek;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, int>)&ABI_SetSize;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, ulong, ulong*, ulong*, int>)&ABI_CopyTo;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, CommitFlags, int>)&ABI_Commit;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Revert;
		vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, ulong, LockType, int>)&ABI_LockRegion;
		vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, ulong, LockType, int>)&ABI_UnlockRegion;
		vtable[12] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, StatStorage*, StatName, int>)&ABI_Stat;
		vtable[13] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;

		return vtable;
	}
}

namespace DiaSharp.Storage
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public unsafe partial interface IStream
	{
		[SkipLocalsInit, PreserveSig]
		new int Read(byte* value, uint byteCount, out uint bytesRead) => ((ISequentialStream)this).Read(value, byteCount, out bytesRead);

		[SkipLocalsInit, PreserveSig]
		new int Write(byte* value, uint byteCount, out uint bytesWritten) => ((ISequentialStream)this).Write(value, byteCount, out bytesWritten);
	}
}