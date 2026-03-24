namespace DiaSharp.CodeView.Architectures;

/// <summary>
/// Specifies a target register on the Infineon TriCore architecture.
/// </summary>
/// <remarks>
/// Must be used in combination with <see cref="HostRegister"/> for full coverage, see implementation for more details.
/// </remarks>
public enum TriCore
{
	#region General Purpose Data Registers

	D0  = 10,
	D1  = 11,
	D2  = 12,
	D3  = 13,
	D4  = 14,
	D5  = 15,
	D6  = 16,
	D7  = 17,
	D8  = 18,
	D9  = 19,
	D10 = 20,
	D11 = 21,
	D12 = 22,
	D13 = 23,
	D14 = 24,
	D15 = 25,

	#endregion

	#region General Purpose Address Registers

	A0  = 26,
	A1  = 27,
	A2  = 28,
	A3  = 29,
	A4  = 30,
	A5  = 31,
	A6  = 32,
	A7  = 33,
	A8  = 34,
	A9  = 35,
	A10 = 36,
	A11 = 37,
	A12 = 38,
	A13 = 39,
	A14 = 40,
	A15 = 41,

	#endregion

	#region 64-bit Data Registers

	E0  = 42,
	E2  = 43,
	E4  = 44,
	E6  = 45,
	E8  = 46,
	E10 = 47,
	E12 = 48,
	E14 = 49,

	#endregion

	#region 64-bit Address Registers

	EA0  = 50,
	EA2  = 51,
	EA4  = 52,
	EA6  = 53,
	EA8  = 54,
	EA10 = 55,
	EA12 = 56,
	EA14 = 57,

	#endregion

	#region Program Status Registers

	PSW  = 58,
	PCXI = 59,
	PC   = 60,
	FCX  = 61,
	LCX  = 62,
	ISP  = 63,
	ICR  = 64,
	BIV  = 65,
	BTV  = 66,

	#endregion

	#region System Configuration Registers

	SYSCON = 67,
	DPRx_0 = 68,
	DPRx_1 = 69,
	DPRx_2 = 70,
	DPRx_3 = 71,
	DBGSSR = 72,
	EXEVT  = 73,
	SWEVT  = 74,
	CREVT  = 75,
	TRnEVT = 76,
	MMUCON = 77,
	ASI    = 78,

	#endregion

	#region Trap Protection Registers

	TVA = 79,
	TPA = 80,
	TPX = 81,
	TFA = 82,

	#endregion
}
