using DiaSharp.CodeView;
using DiaSharp.Interop;
using DiaSharp.Native;

namespace DiaSharp.StackWalk;

[GeneratedComInterface]
[Guid("5EDBC96D-CDD6-4792-AFBE-CC89007D9610")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IStackFrame
{
	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetAllocatesBasePointer();

	ulong GetBase();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetCppExceptionHandling();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasFunctionStart();

	uint GetLocalsLength();

	uint GetParamsLength();

	uint GetPrologueLength();

	uint GetSavedRegistersLength();

	ulong GetLocalsBase();

	uint GetMaxStack();

	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] GetRawLVarInstanceValue(IUnknown instance, uint bufferSize, out uint bytesWritten);

	ulong GetRegisterValue(HostRegister index);

	ulong GetReturnAddress();

	uint GetSize();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetSystemExceptionHandling();

	StackFrameType GetFrameType();
}
