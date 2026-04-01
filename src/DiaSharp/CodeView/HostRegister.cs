namespace DiaSharp.CodeView;

/// <summary>
/// Specifies a target register. Unlike the implementation in the original cvconst.h, the registers here are split by ISA.
/// </summary>
/// <remarks>
/// See the <see cref="Architecture"/> namespace for more specialized enumerations, with specific values.
/// </remarks>
public enum HostRegister
{
	NOREG  = 0,
	PC     = 1,

	ERR    = 30000,
	TEB    = 30001,
	TIMER  = 30002,
	EFAD1  = 30003,
	EFAD2  = 30004,
	EFAD3  = 30005,
	VFRAME = 30006,
	HANDLE = 30007,
	PARAMS = 30008,
	LOCALS = 30009,
	TID    = 30010,
	ENV    = 30011,
	CMDLN  = 30012,
}
