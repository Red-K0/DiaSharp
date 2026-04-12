using DiaSharp.CodeView;
using DiaSharp.Native;

namespace DiaSharp.StackWalk;

[Guid("5EDBC96D-CDD6-4792-AFBE-CC89007D9610")]
public partial interface IStackFrame
{
	int GetAllocatesBasePointer([MarshalAs(UnmanagedType.Bool)] out bool allocates);

	int GetBase(out ulong address);

	int GetCppExceptionHandling([MarshalAs(UnmanagedType.Bool)] out bool enabled);

	int GetHasFunctionStart([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetLocalsLength(out uint length);

	int GetParamsLength(out uint length);

	int GetPrologueLength(out uint length);

	int GetSavedRegistersLength(out uint length);

	int GetLocalsBase(out ulong address);

	int GetMaxStack(out uint maxStack);

	unsafe int GetRawLVarInstanceValue(void* instance, uint bufferSize, out uint bytesWritten, byte* buffer);

	int GetRegisterValue(HostRegister index, out ulong value);

	int GetReturnAddress(out ulong address);

	int GetSize(out uint size);

	int GetSystemExceptionHandling([MarshalAs(UnmanagedType.Bool)] out bool enabled);

	int GetFrameType(out StackFrameType type);
}
