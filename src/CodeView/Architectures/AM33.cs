namespace DiaSharp.CodeView.Architectures;

/// <summary>
/// Specifies a target register on the Panasonic MN103 (AM33) architecture.
/// </summary>
/// <remarks>
/// Must be used in combination with <see cref="HostRegister"/> for full coverage, see implementation for more details.
/// </remarks>
public enum AM33
{
	#region "Extended" (GPI) Registers

	E0 = 10,
	E1 = 11,
	E2 = 12,
	E3 = 13,
	E4 = 14,
	E5 = 15,
	E6 = 16,
	E7 = 17,

	#endregion

	#region Address Registers

	A0 = 20,
	A1 = 21,
	A2 = 22,
	A3 = 23,

	#endregion

	#region Integer Data Registers

	D0 = 30,
	D1 = 31,
	D2 = 32,
	D3 = 33,

	#endregion

	#region Single Data Registers

	FS0  = 40,
	FS1  = 41,
	FS2  = 42,
	FS3  = 43,
	FS4  = 44,
	FS5  = 45,
	FS6  = 46,
	FS7  = 47,
	FS8  = 48,
	FS9  = 49,
	FS10 = 50,
	FS11 = 51,
	FS12 = 52,
	FS13 = 53,
	FS14 = 54,
	FS15 = 55,
	FS16 = 56,
	FS17 = 57,
	FS18 = 58,
	FS19 = 59,
	FS20 = 60,
	FS21 = 61,
	FS22 = 62,
	FS23 = 63,
	FS24 = 64,
	FS25 = 65,
	FS26 = 66,
	FS27 = 67,
	FS28 = 68,
	FS29 = 69,
	FS30 = 70,
	FS31 = 71,

	#endregion

	#region Special purpose registers

	SP = 80,
	PC = 81,

	#region Multiply-Divide/Accumulate Registers

	MDR  = 82,
	MDRQ = 83,
	MCRH = 84,
	MCRL = 85,
	MCVF = 86,

	#endregion

	#region CPU Status Words

	EPSW = 87,
	FPCR = 88,

	#endregion

	#region Loop Buffer Registers

	LIR = 89,
	LAR = 90,

	#endregion

	#endregion
}
