using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Stack;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("A39184B7-6A36-42DE-8EEC-7DF9F3F59F33")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IFrameData
{
	uint GetAddressSection();

	uint GetAddressOffset();

	uint GetRelativeVirtualAddress();

	ulong GetVirtualAddress();

	uint GetLengthBlock();

	uint GetLengthLocals();

	uint GetLengthParams();

	uint GetMaxStack();

	uint GetPrologueLength();

	uint GetSavedRegistersLength();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetProgram();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetSystemExceptionHandling();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetCppExceptionHandling();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetFunctionStart();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetAllocatesBasePointer();

	uint GetType();

	IFrameData GetFunctionParent();

	void Execute(IStackWalkFrame frame);
}