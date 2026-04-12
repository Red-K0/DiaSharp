using DiaSharp.Native;
using DiaSharp.StackWalk;

namespace DiaSharp.SDK;

[Guid("A39184B7-6A36-42DE-8EEC-7DF9F3F59F33")]
public partial interface IFrameData
{
	int GetAddressSection(out uint section);

	int GetAddressOffset(out uint offset);

	int GetRelativeVirtualAddress(out uint rva);

	int GetVirtualAddress(out ulong virtualAddress);

	int GetBlockLength(out uint blockLength);

	int GetLocalsLength(out uint length);

	int GetParamsLength(out uint length);

	int GetMaxStack(out uint maxStack);

	int GetPrologueLength(out uint length);

	int GetSavedRegistersLength(out uint length);

	int GetProgram([MarshalAs(UnmanagedType.BStr)] out string name);

	int GetSystemExceptionHandling([MarshalAs(UnmanagedType.Bool)] out bool enabled);

	int GetCppExceptionHandling([MarshalAs(UnmanagedType.Bool)] out bool enabled);

	int GetIsFunctionStart([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetAllocatesBasePointer([MarshalAs(UnmanagedType.Bool)] out bool allocates);

	int GetFrameType(out StackFrameType type);

	int GetFunctionParent(out IFrameData parentData);

	int Execute(IStackWalkFrame stackFrame);
}