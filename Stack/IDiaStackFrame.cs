using System.Runtime.InteropServices.Marshalling;
using DiaSharp.CodeView;

namespace DiaSharp.Stack;

[GeneratedComInterface]
[Guid("5EDBC96D-CDD6-4792-AFBE-CC89007D9610")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaStackFrame
{
	[DispId(1)]
	uint get_type();

	[DispId(2)]
	ulong get_base();

	[DispId(3)]
	uint get_size();

	[DispId(4)]
	ulong get_returnAddress();

	[DispId(5)]
	ulong get_localsBase();

	[DispId(6)]
	uint get_lengthLocals();

	[DispId(7)]
	uint get_lengthParams();

	[DispId(8)]
	uint get_lengthProlog();

	[DispId(9)]
	uint get_lengthSavedRegisters();

	[DispId(10)]
	int get_systemExceptionHandling();

	[DispId(11)]
	int get_cplusplusExceptionHandling();

	[DispId(12)]
	int get_functionStart();

	[DispId(13)]
	int get_allocatesBasePointer();

	[DispId(14)]
	uint get_maxStack();

	[DispId(15)]
	ulong get_registerValue(HostRegister index);
}
