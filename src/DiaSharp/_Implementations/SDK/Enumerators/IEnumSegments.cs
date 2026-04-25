#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.Interop;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([169, 140, 54, 232, 209, 1, 157, 65, 172, 12, 227, 18, 53, 219, 218, 159]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IEnumSegments
{
	[SkipLocalsInit]
	int IEnumSegments.GetNewEnum(out IEnumVARIANT enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSegments));
		bool __invokeSucceeded = false;
		void* __enumerator_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[3])(__this, &__enumerator_native);

			__invokeSucceeded = true;

			enumerator = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToManaged(__enumerator_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<IEnumVARIANT>.Free(__enumerator_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSegments.GetCount(out int count)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSegments));

		fixed (int* __count_native = &count)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, int*, int>)__vtable_native[4])(__this, __count_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSegments.Item(uint index, out ISegment segment)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSegments));
		bool __invokeSucceeded = false;
		void* __segment_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, uint, void**, int>)__vtable_native[5])(__this, index, &__segment_native);

			__invokeSucceeded = true;

			segment = ComInterfaceMarshaller<ISegment>.ConvertToManaged(__segment_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<ISegment>.Free(__segment_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSegments.GetNext(uint segmentCount, void** segments, out uint segmentsFetched)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSegments));

		fixed (uint* __segmentsFetched_native = &segmentsFetched)
		{
			return ((delegate* unmanaged[MemberFunction]<void*, uint, void**, uint*, int>)__vtable_native[6])(__this, segmentCount, segments, __segmentsFetched_native);
		}
	}

	[SkipLocalsInit]
	int IEnumSegments.Skip(uint segmentCount)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSegments));

		return ((delegate* unmanaged[MemberFunction]<void*, uint, int>)__vtable_native[7])(__this, segmentCount);
	}

	[SkipLocalsInit]
	int IEnumSegments.Reset()
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSegments));

		return ((delegate* unmanaged[MemberFunction]<void*, int>)__vtable_native[8])(__this);
	}

	[SkipLocalsInit]
	int IEnumSegments.Clone(out IEnumSegments enumerator)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IEnumSegments));
		bool __invokeSucceeded = false;
		void* __enumerator_native = null;

		try
		{
			int __retVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int>)__vtable_native[9])(__this, &__enumerator_native);

			__invokeSucceeded = true;

			enumerator = ComInterfaceMarshaller<IEnumSegments>.ConvertToManaged(__enumerator_native)!;

			return __retVal;
		}
		finally
		{
			if (__invokeSucceeded) ComInterfaceMarshaller<IEnumSegments>.Free(__enumerator_native);
		}
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNewEnum(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSegments>(__this_native).GetNewEnum(out IEnumVARIANT enumerator);

			*__enumerator_native__param = ComInterfaceMarshaller<IEnumVARIANT>.ConvertToUnmanaged(enumerator);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetCount(ComWrappers.ComInterfaceDispatch* __this_native, int* __count_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSegments>(__this_native).GetCount(out *__count_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Item(ComWrappers.ComInterfaceDispatch* __this_native, uint index, void** __segment_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSegments>(__this_native).Item(index, out ISegment segment);

			*__segment_native__param = ComInterfaceMarshaller<ISegment>.ConvertToUnmanaged(segment);

			return __retVal;
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_GetNext(ComWrappers.ComInterfaceDispatch* __this_native, uint segmentCount, void** segments, uint* __segmentsFetched_native__param)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSegments>(__this_native).GetNext(segmentCount, segments, out *__segmentsFetched_native__param);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Skip(ComWrappers.ComInterfaceDispatch* __this_native, uint segmentCount)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSegments>(__this_native).Skip(segmentCount);
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Reset(ComWrappers.ComInterfaceDispatch* __this_native)
	{
		try
		{
			return ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSegments>(__this_native).Reset();
		}
		catch (Exception __exception)
		{
			return ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
		}
	}

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
	static internal int ABI_Clone(ComWrappers.ComInterfaceDispatch* __this_native, void** __enumerator_native__param)
	{
		try
		{
			int __retVal = ComWrappers.ComInterfaceDispatch.GetInstance<IEnumSegments>(__this_native).Clone(out IEnumSegments enumerator);

			*__enumerator_native__param = ComInterfaceMarshaller<IEnumSegments>.ConvertToUnmanaged(enumerator);

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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IEnumSegments), sizeof(void*) * 10);

		ComWrappers.GetIUnknownImpl(out ((nint*)vtable)[0], out ((nint*)vtable)[1], out ((nint*)vtable)[2]);

		vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_GetNewEnum;
		vtable[4] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int*, int>)&ABI_GetCount;
		vtable[5] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, int>)&ABI_Item;
		vtable[6] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, void**, uint*, int>)&ABI_GetNext;
		vtable[7] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, uint, int>)&ABI_Skip;
		vtable[8] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, int>)&ABI_Reset;
		vtable[9] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, void**, int>)&ABI_Clone;

		return vtable;
	}
}

namespace DiaSharp.SDK.Enumerators
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IEnumSegments
	{
	}
}