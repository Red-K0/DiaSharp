using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Stack;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("A39184B7-6A36-42DE-8EEC-7DF9F3F59F33")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaFrameData
{
	[DispId(2)]
	uint get_addressSection();

	[DispId(3)]
	uint get_addressOffset();

	[DispId(4)]
	uint get_relativeVirtualAddress();

	[DispId(5)]
	ulong get_virtualAddress();

	[DispId(6)]
	uint get_lengthBlock();

	[DispId(7)]
	uint get_lengthLocals();

	[DispId(8)]
	uint get_lengthParams();

	[DispId(9)]
	uint get_maxStack();

	[DispId(10)]
	uint get_lengthProlog();

	[DispId(11)]
	uint get_lengthSavedRegisters();

	[DispId(12)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_program();

	[DispId(13)]
	int get_systemExceptionHandling();

	[DispId(14)]
	int get_cplusplusExceptionHandling();

	[DispId(15)]
	int get_functionStart();

	[DispId(16)]
	int get_allocatesBasePointer();

	[DispId(17)]
	uint get_type();

	[DispId(18)]
	IDiaFrameData get_functionParent();

	void execute(IDiaStackWalkFrame frame);
}