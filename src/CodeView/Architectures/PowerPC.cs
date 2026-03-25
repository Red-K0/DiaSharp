namespace DiaSharp.CodeView.Architectures;

/// <summary>
/// Specifies a target register on the AIM PowerPC architecture.
/// </summary>
/// <remarks>
/// Must be used in combination with <see cref="HostRegister"/> for full coverage, see implementation for more details.
/// </remarks>
public enum PowerPC
{
	#region General Registers (User Level)

	GPR0  = 1,
	GPR1  = 2,
	GPR2  = 3,
	GPR3  = 4,
	GPR4  = 5,
	GPR5  = 6,
	GPR6  = 7,
	GPR7  = 8,
	GPR8  = 9,
	GPR9  = 10,
	GPR10 = 11,
	GPR11 = 12,
	GPR12 = 13,
	GPR13 = 14,
	GPR14 = 15,
	GPR15 = 16,
	GPR16 = 17,
	GPR17 = 18,
	GPR18 = 19,
	GPR19 = 20,
	GPR20 = 21,
	GPR21 = 22,
	GPR22 = 23,
	GPR23 = 24,
	GPR24 = 25,
	GPR25 = 26,
	GPR26 = 27,
	GPR27 = 28,
	GPR28 = 29,
	GPR29 = 30,
	GPR30 = 31,
	GPR31 = 32,

	#endregion

	#region Condition Registers (User Level)

	CR  = 33,
	CR0 = 34,
	CR1 = 35,
	CR2 = 36,
	CR3 = 37,
	CR4 = 38,
	CR5 = 39,
	CR6 = 40,
	CR7 = 41,

	#endregion

	#region Floating Point Registers (User Level)

	FPR0  = 42,
	FPR1  = 43,
	FPR2  = 44,
	FPR3  = 45,
	FPR4  = 46,
	FPR5  = 47,
	FPR6  = 48,
	FPR7  = 49,
	FPR8  = 50,
	FPR9  = 51,
	FPR10 = 52,
	FPR11 = 53,
	FPR12 = 54,
	FPR13 = 55,
	FPR14 = 56,
	FPR15 = 57,
	FPR16 = 58,
	FPR17 = 59,
	FPR18 = 60,
	FPR19 = 61,
	FPR20 = 62,
	FPR21 = 63,
	FPR22 = 64,
	FPR23 = 65,
	FPR24 = 66,
	FPR25 = 67,
	FPR26 = 68,
	FPR27 = 69,
	FPR28 = 70,
	FPR29 = 71,
	FPR30 = 72,
	FPR31 = 73,

	FPSCR = 74,

	#endregion

	MSR = 75,

	#region Segment Registers (Supervisor Level)

	SR0  = 76,
	SR1  = 77,
	SR2  = 78,
	SR3  = 79,
	SR4  = 80,
	SR5  = 81,
	SR6  = 82,
	SR7  = 83,
	SR8  = 84,
	SR9  = 85,
	SR10 = 86,
	SR11 = 87,
	SR12 = 88,
	SR13 = 89,
	SR14 = 90,
	SR15 = 91,

	#endregion

	// For all of the special purpose registers add 100 to the SPR# that the Motorola/IBM documentation gives with the exception of any imaginary registers.

	#region Special Purpose Registers (User Level)

	PC   = 99,     // Imaginary register

	MQ   = 100,    // MPC601
	XER  = 101,
	RTCU = 104,    // MPC601
	RTCL = 105,    // MPC601
	LR   = 108,
	CTR  = 109,

	#region XER (Debugger Internal)

	COMPARE = 110,
	COUNT   = 111,

	#endregion

	#endregion

	#region Special Purpose Registers (Supervisor Level)

	DSISR  = 118,
	DAR    = 119,
	DEC    = 122,
	SDR1   = 125,
	SRR0   = 126,
	SRR1   = 127,
	SPRG0  = 372,
	SPRG1  = 373,
	SPRG2  = 374,
	SPRG3  = 375,
	ASR    = 280,    // 64-bit implementations only
	EAR    = 382,
	PVR    = 287,
	BAT0U  = 628,
	BAT0L  = 629,
	BAT1U  = 630,
	BAT1L  = 631,
	BAT2U  = 632,
	BAT2L  = 633,
	BAT3U  = 634,
	BAT3L  = 635,
	DBAT0U = 636,
	DBAT0L = 637,
	DBAT1U = 638,
	DBAT1L = 639,
	DBAT2U = 640,
	DBAT2L = 641,
	DBAT3U = 642,
	DBAT3L = 643,

	#region Implementation Dependent Registers

	// The definitions here are incomplete / questionable (via IBM/Motorola)

	PMR0  = 1044,   // MPC620,
	PMR1  = 1045,   // MPC620,
	PMR2  = 1046,   // MPC620,
	PMR3  = 1047,   // MPC620,
	PMR4  = 1048,   // MPC620,
	PMR5  = 1049,   // MPC620,
	PMR6  = 1050,   // MPC620,
	PMR7  = 1051,   // MPC620,
	PMR8  = 1052,   // MPC620,
	PMR9  = 1053,   // MPC620,
	PMR10 = 1054,   // MPC620,
	PMR11 = 1055,   // MPC620,
	PMR12 = 1056,   // MPC620,
	PMR13 = 1057,   // MPC620,
	PMR14 = 1058,   // MPC620,
	PMR15 = 1059,   // MPC620,

	DMISS = 1076,   // MPC603
	DCMP  = 1077,   // MPC603
	HASH1 = 1078,   // MPC603
	HASH2 = 1079,   // MPC603
	IMISS = 1080,   // MPC603
	ICMP  = 1081,   // MPC603
	RPA   = 1082,   // MPC603

	HID0  = 1108,   // MPC601, MPC603, MPC620
	HID1  = 1109,   // MPC601
	HID2  = 1110,   // MPC601, MPC603, MPC620 (IABR)
	HID3  = 1111,   // Not Defined
	HID4  = 1112,   // Not Defined
	HID5  = 1113,   // MPC601, MPC604, MPC620 (DABR)
	HID6  = 1114,   // Not Defined
	HID7  = 1115,   // Not Defined
	HID8  = 1116,   // MPC620 (BUSCSR)
	HID9  = 1117,   // MPC620 (L2CSR)
	HID10 = 1118,   // Not Defined
	HID11 = 1119,   // Not Defined
	HID12 = 1120,   // Not Defined
	HID13 = 1121,   // MPC604 (HCR)
	HID14 = 1122,   // Not Defined
	HID15 = 1123,   // MPC601, MPC604, MPC620 (PIR)

	#endregion

	#endregion
}
