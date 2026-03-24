using System.ComponentModel;

namespace DiaSharp.CodeView;

/// <summary>
/// Specifies the calling convention for a function.
/// </summary>
/// <remarks>
/// The values in this enumeration are returned by a call to the IDiaSymbol::get_callingConvention method.
/// </remarks>
internal enum Call
{
	/// <summary>
	/// Near C calling convention. Arguments pushed right-to-left. Caller cleans the stack.
	/// </summary>
	NearC = 0x00,

	/// <summary>
	/// Far C calling convention. Arguments pushed right-to-left. Caller cleans the stack.
	/// </summary>
	FarC = 0x01,

	/// <summary>
	/// Near Pascal calling convention. Arguments pushed left-to-right. Callee cleans the stack.
	/// </summary>
	NearPascal = 0x02,

	/// <summary>
	/// Far Pascal calling convention. Arguments pushed left-to-right. Callee cleans the stack.
	/// </summary>
	FarPascal = 0x03,

	/// <summary>
	/// Near fastcall. Arguments pushed left-to-right with register usage. Callee cleans the stack.
	/// </summary>
	NearFast = 0x04,

	/// <summary>
	/// Far fastcall. Arguments pushed left-to-right with register usage. Callee cleans the stack.
	/// </summary>
	FarFast = 0x05,

	/// <summary>
	/// Skipped (unused) calling convention index.
	/// </summary>
	Skipped = 0x06,

	/// <summary>
	/// Near stdcall.
	/// </summary>
	NearStd = 0x07,

	/// <summary>
	/// Far stdcall.
	/// </summary>
	FarStd = 0x08,

	/// <summary>
	/// Near system call convention.
	/// </summary>
	NearSys = 0x09,

	/// <summary>
	/// Far system call convention.
	/// </summary>
	FarSys = 0x0A,

	/// <summary>
	/// Thiscall. The <see langword="this"/> pointer is passed in a register.
	/// </summary>
	ThisCall = 0x0B,

	/// <summary>
	/// MIPS calling convention.
	/// </summary>
	MipsCall = 0x0C,

	/// <summary>
	/// Generic calling convention sequence.
	/// </summary>
	Generic = 0x0D,

	/// <summary>
	/// Alpha calling convention.
	/// </summary>
	AlphaCall = 0x0E,

	/// <summary>
	/// PowerPC calling convention.
	/// </summary>
	PpcCall = 0x0F,

	/// <summary>
	/// Hitachi SuperH calling convention.
	/// </summary>
	ShCall = 0x10,

	/// <summary>
	/// ARM calling convention.
	/// </summary>
	ArmCall = 0x11,

	/// <summary>
	/// AM33 calling convention.
	/// </summary>
	Am33Call = 0x12,

	/// <summary>
	/// TriCore calling convention.
	/// </summary>
	TriCall = 0x13,

	/// <summary>
	/// Hitachi SuperH-5 calling convention.
	/// </summary>
	Sh5Call = 0x14,

	/// <summary>
	/// M32R calling convention.
	/// </summary>
	M32RCall = 0x15,

	/// <summary>
	/// Common Language Runtime calling convention.
	/// </summary>
	ClrCall = 0x16,

	/// <summary>
	/// Marker indicating the routine is always inlined and therefore has no calling convention.
	/// </summary>
	Inline = 0x17,

	/// <summary>
	/// Near vector calling convention. Arguments pushed left-to-right with register usage. Callee cleans the stack.
	/// </summary>
	NearVector = 0x18,

	/// <summary>
	/// First unused calling convention value.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	Reserved = 0x19
}