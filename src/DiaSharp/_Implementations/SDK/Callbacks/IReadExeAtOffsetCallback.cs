#pragma warning disable CS0612, CS0618, IDE0008, CA1031
using DiaSharp.SDK.Callbacks;

file unsafe class InterfaceInformation : IIUnknownInterfaceType
{
	public static Guid Iid { get; } = new([28, 70, 122, 88, 11, 184, 84, 79, 145, 148, 80, 50, 88, 154, 99, 25]);

	public static void** ManagedVirtualMethodTable => field != null ? field : (field = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[DynamicInterfaceCastableImplementation]
file unsafe partial interface InterfaceImplementation : IReadExeAtOffsetCallback
{
	[SkipLocalsInit]
	int IReadExeAtOffsetCallback.ReadExecutableAt(ulong fileOffset, uint executableSize, uint* bytesWritten, byte* buffer)
	{
		var(__this, __vtable_native) = ((IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(IReadExeAtOffsetCallback));
		int __retVal;
		{
			__retVal = ((delegate* unmanaged[MemberFunction]<void*, ulong, uint, uint*, byte*, int>)__vtable_native[3])(__this, fileOffset, executableSize, bytesWritten, buffer);
		}

		// NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
		GC.KeepAlive(this);

		return __retVal;
	}
}

file unsafe partial interface InterfaceImplementation
{
	[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvMemberFunction) })]
	static internal int ABI_ReadExecutableAt(ComWrappers.ComInterfaceDispatch* __this_native, ulong fileOffset, uint executableSize, uint* bytesWritten, byte* buffer)
	{
		int __retVal;

		try
		{
			// Unmarshal - Convert native data to managed data.
			IReadExeAtOffsetCallback @this = ComWrappers.ComInterfaceDispatch.GetInstance<IReadExeAtOffsetCallback>(__this_native);
			__retVal = @this.ReadExecutableAt(fileOffset, executableSize, bytesWritten, buffer);
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
		void** vtable = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IReadExeAtOffsetCallback), sizeof(void*) * 4);
		{
			ComWrappers.GetIUnknownImpl(out nint v0, out nint v1, out nint v2);
			vtable[0] = (void*)v0;
			vtable[1] = (void*)v1;
			vtable[2] = (void*)v2;
		}

		{
			vtable[3] = (delegate* unmanaged[MemberFunction]<ComWrappers.ComInterfaceDispatch*, ulong, uint, uint*, byte*, int>)&ABI_ReadExecutableAt;
		}

		return vtable;
	}
}

namespace DiaSharp.SDK.Callbacks
{
	[IUnknownDerived<InterfaceInformation, InterfaceImplementation>]
	public partial interface IReadExeAtOffsetCallback
	{
	}
}