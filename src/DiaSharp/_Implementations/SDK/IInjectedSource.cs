#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.SDK;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([220, 92, 96, 174, 5, 129, 35, 74, 183, 16, 50, 89, 241, 226, 97, 18]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IInjectedSource
{
	[SkipLocalsInit]
	int IInjectedSource.GetCRC(out uint crc)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInjectedSource));

		fixed (uint* __crc_native = &crc)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[3])(__this, __crc_native);
		}
	}

	[SkipLocalsInit]
	int IInjectedSource.GetLength(out ulong length)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInjectedSource));

		fixed (ulong* __length_native = &length)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, ulong*, int>)__vtable_native[4])(__this, __length_native);
		}
	}

	[SkipLocalsInit]
	int IInjectedSource.GetFilename(out string name)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInjectedSource));
		bool __invokeSucceeded = false;
		ushort* __name_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[5])(__this, &__name_native);

			__invokeSucceeded = true;

			name = BStrStringMarshaller.ConvertToManaged(__name_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) BStrStringMarshaller.Free(__name_native);
		}
	}

	[SkipLocalsInit]
	int IInjectedSource.GetObjectFilename(out string name)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInjectedSource));
		bool __invokeSucceeded = false;
		ushort* __name_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[6])(__this, &__name_native);

			__invokeSucceeded = true;

			name = BStrStringMarshaller.ConvertToManaged(__name_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) BStrStringMarshaller.Free(__name_native);
		}
	}

	[SkipLocalsInit]
	int IInjectedSource.GetVirtualFilename(out string name)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInjectedSource));
		bool __invokeSucceeded = false;
		ushort* __name_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int>)__vtable_native[7])(__this, &__name_native);

			__invokeSucceeded = true;

			name = BStrStringMarshaller.ConvertToManaged(__name_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) BStrStringMarshaller.Free(__name_native);
		}
	}

	[SkipLocalsInit]
	int IInjectedSource.GetSourceCompression(out uint compression)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInjectedSource));

		fixed (uint* __compression_native = &compression)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint*, int>)__vtable_native[8])(__this, __compression_native);
		}
	}

	[SkipLocalsInit]
	int IInjectedSource.GetSource(uint dataSize, out uint bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IInjectedSource));

		fixed (uint* __bytesWritten_native = &bytesWritten)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, uint*, byte*, int>)__vtable_native[9])(__this, dataSize, __bytesWritten_native, buffer);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCRC(ComWrappers.ComInterfaceDispatch* __this_native, uint* __crc_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IInjectedSource>(__this_native).GetCRC(out *__crc_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetLength(ComWrappers.ComInterfaceDispatch* __this_native, ulong* __length_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IInjectedSource>(__this_native).GetLength(out *__length_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetFilename(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __name_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IInjectedSource>(__this_native).GetFilename(out string name);

			*__name_native__param = BStrStringMarshaller.ConvertToUnmanaged(name);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetObjectFilename(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __name_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IInjectedSource>(__this_native).GetObjectFilename(out string name);

			*__name_native__param = BStrStringMarshaller.ConvertToUnmanaged(name);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetVirtualFilename(ComWrappers.ComInterfaceDispatch* __this_native, ushort** __name_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IInjectedSource>(__this_native).GetVirtualFilename(out string name);

			*__name_native__param = BStrStringMarshaller.ConvertToUnmanaged(name);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSourceCompression(ComWrappers.ComInterfaceDispatch* __this_native, uint* __compression_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IInjectedSource>(__this_native).GetSourceCompression(out *__compression_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetSource(ComWrappers.ComInterfaceDispatch* __this_native, uint dataSize, uint* __bytesWritten_native__param, byte* buffer)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IInjectedSource>(__this_native).GetSource(dataSize, out *__bytesWritten_native__param, buffer);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IInjectedSource), sizeof(void*) * 10);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetCRC;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong*, int>)&ABI_GetLength;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetFilename;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetObjectFilename;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ushort**, int>)&ABI_GetVirtualFilename;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint*, int>)&ABI_GetSourceCompression;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, uint*, byte*, int>)&ABI_GetSource;

		return vtable;
	}
}

namespace DiaSharp.SDK
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IInjectedSource
	{
	}
}