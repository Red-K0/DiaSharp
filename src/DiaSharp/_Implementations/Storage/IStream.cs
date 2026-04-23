#pragma warning disable CS0612, CS0618, IDE0008, CA1031
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
		Unsafe.SkipInit(out newPosition);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (ulong* __newPosition_native = &newPosition)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, long, SeekType, ulong*, int>)__vtable_native[5])(__this, offset, origin, __newPosition_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStream.SetSize(ulong newSize)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, int>)__vtable_native[6])(__this, newSize);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStream.CopyTo(IStream stream, ulong byteCount, out ulong bytesRead, out ulong newPosition)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));
		Unsafe.SkipInit(out bytesRead);
		Unsafe.SkipInit(out newPosition);
		void* __stream_native = default;
		int __retVal = default;
		try
		{
			// Marshal - Convert managed data to native data.
			__stream_native = ComInterfaceMarshaller<IStream>.ConvertToUnmanaged(stream);
			// Pin - Pin data in preparation for calling the P/Invoke.
			fixed (ulong* __newPosition_native = &newPosition)
			fixed (ulong* __bytesRead_native = &bytesRead)
			{
				__retVal = ((delegate* unmanaged[MemberFunction]<void*, void*, ulong, ulong*, ulong*, int>)__vtable_native[7])(__this, __stream_native, byteCount, __bytesRead_native, __newPosition_native);
			}

			GC.KeepAlive(this);
		}
		finally
		{
			// CleanupCallerAllocated - Perform cleanup of caller allocated resources.
			ComInterfaceMarshaller<IStream>.Free(__stream_native);
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IStream.Commit(CommitFlags flags)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, CommitFlags, int>)__vtable_native[8])(__this, flags);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStream.Revert()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[9])(__this);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStream.LockRegion(ulong offset, ulong byteCount, LockType lsockType)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, ulong, LockType, int>)__vtable_native[10])(__this, offset, byteCount, lsockType);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStream.UnlockRegion(ulong offset, ulong byteCount, LockType lockType)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, ulong, LockType, int>)__vtable_native[11])(__this, offset, byteCount, lockType);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStream.Stat(out StatStorage tag, StatName flag)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));
		Unsafe.SkipInit(out tag);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (StatStorage* __tag_native = &tag)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, StatStorage*, StatName, int>)__vtable_native[12])(__this, __tag_native, flag);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStream.Clone(out IStream stream)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));
		bool __invokeSucceeded = default!;
		Unsafe.SkipInit(out stream);
		void* __stream_native = default!;
		int __retVal = default;
		try
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[13])(__this, &__stream_native);

			__invokeSucceeded = true;
			GC.KeepAlive(this);
			// Unmarshal - Convert native data to managed data.
			stream = ComInterfaceMarshaller<IStream>.ConvertToManaged(__stream_native)!;
		}
		finally
		{
			if (__invokeSucceeded)
			{
				// CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
				ComInterfaceMarshaller<IStream>.Free(__stream_native);
			}
		}

		return __retVal;
	}

	[SkipLocalsInit]
	int IStream.Read(byte* buffer, uint byteCount, out uint bytesRead)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));
		Unsafe.SkipInit(out bytesRead);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __bytesRead_native = &bytesRead)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, byte*, uint, uint*, int>)__vtable_native[3])(__this, buffer, byteCount, __bytesRead_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	[SkipLocalsInit]
	int IStream.Write(byte* buffer, uint byteCount, out uint bytesWritten)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IStream));
		Unsafe.SkipInit(out bytesWritten);
		int __retVal;
		// Pin - Pin data in preparation for calling the P/Invoke.
		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, byte*, uint, uint*, int>)__vtable_native[4])(__this, buffer, byteCount, __bytesWritten_native);
		}

		GC.KeepAlive(this);
		return __retVal;
	}

	int ISequentialStream.Read(byte* value, uint byteCount, out uint bytesRead) => throw new UnreachableException();
	int ISequentialStream.Write(byte* value, uint byteCount, out uint bytesWritten) => throw new UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Seek(ComWrappers.ComInterfaceDispatch* __this_native, long offset, SeekType origin, ulong* __newPosition_native__param)
	{
		IStream @this = default!;
		ref ulong __newPosition_native = ref *__newPosition_native__param;
		ulong newPosition = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native);
			__retVal = @this.Seek(offset, origin, out newPosition);
			// Marshal - Convert managed data to native data.
			__newPosition_native = newPosition;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_SetSize(ComWrappers.ComInterfaceDispatch* __this_native, ulong newSize)
	{
		int __retVal;

		try
		{
			IStream @this = default!;
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native);
			__retVal = @this.SetSize(newSize);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_CopyTo(ComWrappers.ComInterfaceDispatch* __this_native, void* __stream_native, ulong byteCount, ulong* __bytesRead_native__param, ulong* __newPosition_native__param)
	{
		IStream @this = default!;
		IStream stream = default!;
		ref ulong __bytesRead_native = ref *__bytesRead_native__param;
		ulong bytesRead = default!;
		ref ulong __newPosition_native = ref *__newPosition_native__param;
		ulong newPosition = default!;
		int __retVal = default;

		try
		{
			// Unmarshal - Convert native data to managed data.
			stream = ComInterfaceMarshaller<IStream>.ConvertToManaged(__stream_native)!;
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native);
			__retVal = @this.CopyTo(stream, byteCount, out bytesRead, out newPosition);
			// Marshal - Convert managed data to native data.
			__newPosition_native = newPosition;
			__bytesRead_native = bytesRead;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Commit(ComWrappers.ComInterfaceDispatch* __this_native, CommitFlags flags)
	{
		int __retVal;

		try
		{
			IStream @this = default!;
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native);
			__retVal = @this.Commit(flags);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Revert(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		int __retVal;

		try
		{
			IStream @this = default!;
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native);
			__retVal = @this.Revert();
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_LockRegion(ComWrappers.ComInterfaceDispatch* __this_native, ulong offset, ulong byteCount, LockType lsockType)
	{
		int __retVal;

		try
		{
			IStream @this = default!;
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native);
			__retVal = @this.LockRegion(offset, byteCount, lsockType);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_UnlockRegion(ComWrappers.ComInterfaceDispatch* __this_native, ulong offset, ulong byteCount, LockType lockType)
	{
		int __retVal;

		try
		{
			IStream @this = default!;
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native);
			__retVal = @this.UnlockRegion(offset, byteCount, lockType);
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Stat(ComWrappers.ComInterfaceDispatch* __this_native, StatStorage* __tag_native__param, StatName flag)
	{
		IStream @this = default!;
		ref StatStorage __tag_native = ref *__tag_native__param;
		StatStorage tag = default!;
		int __retVal = default;
		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native);
			__retVal = @this.Stat(out tag, flag);
			// Marshal - Convert managed data to native data.
			__tag_native = tag;
		}
		catch (Exception __exception)
		{
			__retVal = ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}

		return __retVal;
	}

	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __stream_native__param)
	{
		IStream @this = default!;
		ref void* __stream_native = ref *__stream_native__param;
		IStream stream = default!;
		int __retVal = default;
		try
		{
			// Unmarshal - Convert native data to managed data.
			@this = ComWrappers.ComInterfaceDispatch.GetInstance<IStream>(__this_native);
			__retVal = @this.Clone(out stream);
			// Marshal - Convert managed data to native data.
			__stream_native = ComInterfaceMarshaller<IStream>.ConvertToUnmanaged(stream);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IStream), sizeof(void*) * 14);
		{
			NativeMemory.Copy(StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(ISequentialStream).TypeHandle)!.ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 5));
		}

		{
			vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, long, SeekType, ulong*, int>)&ABI_Seek;
			vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, int>)&ABI_SetSize;
			vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void*, ulong, ulong*, ulong*, int>)&ABI_CopyTo;
			vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, CommitFlags, int>)&ABI_Commit;
			vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Revert;
			vtable[10] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, ulong, LockType, int>)&ABI_LockRegion;
			vtable[11] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, ulong, LockType, int>)&ABI_UnlockRegion;
			vtable[12] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, StatStorage*, StatName, int>)&ABI_Stat;
			vtable[13] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;
		}

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