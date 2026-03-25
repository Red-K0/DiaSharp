namespace DiaSharp.CodeView.Architecture;

/// <summary>
/// Specifies a target register on the ARM architecture.
/// </summary>
/// <remarks>
/// Must be used in combination with <see cref="HostRegister"/> for full coverage, see implementation for more details.
/// </remarks>
public enum ARM
{
	NOREG = 0,

	#region ARM Standard Registers

	R0   = 10,
	R1   = 11,
	R2   = 12,
	R3   = 13,
	R4   = 14,
	R5   = 15,
	R6   = 16,
	R7   = 17,
	R8   = 18,
	R9   = 19,
	R10  = 20,

	/// <summary>
	/// Typically holds the frame pointer, if allocated.
	/// </summary>
	R11  = 21,
	R12  = 22,
	SP   = 23,
	LR   = 24,
	PC   = 25,
	CPSR = 26,

	/// <summary>
	/// DSP co-processor 0 40-bit accumulator.
	/// </summary>
	ACC0 = 27,

	#endregion

	#region ARM VFP10 support

	FPSCR = 40,
	FPEXC = 41,

	FS0   = 50,
	FS1   = 51,
	FS2   = 52,
	FS3   = 53,
	FS4   = 54,
	FS5   = 55,
	FS6   = 56,
	FS7   = 57,
	FS8   = 58,
	FS9   = 59,
	FS10  = 60,
	FS11  = 61,
	FS12  = 62,
	FS13  = 63,
	FS14  = 64,
	FS15  = 65,
	FS16  = 66,
	FS17  = 67,
	FS18  = 68,
	FS19  = 69,
	FS20  = 70,
	FS21  = 71,
	FS22  = 72,
	FS23  = 73,
	FS24  = 74,
	FS25  = 75,
	FS26  = 76,
	FS27  = 77,
	FS28  = 78,
	FS29  = 79,
	FS30  = 80,
	FS31  = 81,

	#endregion

	#region VFP Floating Point Extra Control Registers

	FPEXTRA0 = 90,
	FPEXTRA1 = 91,
	FPEXTRA2 = 92,
	FPEXTRA3 = 93,
	FPEXTRA4 = 94,
	FPEXTRA5 = 95,
	FPEXTRA6 = 96,
	FPEXTRA7 = 97,

	#endregion

	#region XSCALE Concan Co-Processor Registers

	WR0  = 128,
	WR1  = 129,
	WR2  = 130,
	WR3  = 131,
	WR4  = 132,
	WR5  = 133,
	WR6  = 134,
	WR7  = 135,
	WR8  = 136,
	WR9  = 137,
	WR10 = 138,
	WR11 = 139,
	WR12 = 140,
	WR13 = 141,
	WR14 = 142,
	WR15 = 143,

	#endregion

	#region XSCALE Concan Co-Processor Control Registers

	WCID  = 144,
	WCON  = 145,
	WCSSF = 146,
	WCASF = 147,
	WC4   = 148,
	WC5   = 149,
	WC6   = 150,
	WC7   = 151,
	WCGR0 = 152,
	WCGR1 = 153,
	WCGR2 = 154,
	WCGR3 = 155,
	WC12  = 156,
	WC13  = 157,
	WC14  = 158,
	WC15  = 159,

	#endregion

	#region ARM VFPv3/Neon Extended Floating Point

	FS32 = 200,
	FS33 = 201,
	FS34 = 202,
	FS35 = 203,
	FS36 = 204,
	FS37 = 205,
	FS38 = 206,
	FS39 = 207,
	FS40 = 208,
	FS41 = 209,
	FS42 = 210,
	FS43 = 211,
	FS44 = 212,
	FS45 = 213,
	FS46 = 214,
	FS47 = 215,
	FS48 = 216,
	FS49 = 217,
	FS50 = 218,
	FS51 = 219,
	FS52 = 220,
	FS53 = 221,
	FS54 = 222,
	FS55 = 223,
	FS56 = 224,
	FS57 = 225,
	FS58 = 226,
	FS59 = 227,
	FS60 = 228,
	FS61 = 229,
	FS62 = 230,
	FS63 = 231,

	#endregion

	#region ARM Double-Precision Floating Point

	ND0  = 300,
	ND1  = 301,
	ND2  = 302,
	ND3  = 303,
	ND4  = 304,
	ND5  = 305,
	ND6  = 306,
	ND7  = 307,
	ND8  = 308,
	ND9  = 309,
	ND10 = 310,
	ND11 = 311,
	ND12 = 312,
	ND13 = 313,
	ND14 = 314,
	ND15 = 315,
	ND16 = 316,
	ND17 = 317,
	ND18 = 318,
	ND19 = 319,
	ND20 = 320,
	ND21 = 321,
	ND22 = 322,
	ND23 = 323,
	ND24 = 324,
	ND25 = 325,
	ND26 = 326,
	ND27 = 327,
	ND28 = 328,
	ND29 = 329,
	ND30 = 330,
	ND31 = 331,

	#endregion

	#region ARM Extended-Precision Floating Point

	NQ0  = 400,
	NQ1  = 401,
	NQ2  = 402,
	NQ3  = 403,
	NQ4  = 404,
	NQ5  = 405,
	NQ6  = 406,
	NQ7  = 407,
	NQ8  = 408,
	NQ9  = 409,
	NQ10 = 410,
	NQ11 = 411,
	NQ12 = 412,
	NQ13 = 413,
	NQ14 = 414,
	NQ15 = 415

	#endregion
}
