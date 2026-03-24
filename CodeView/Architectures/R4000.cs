namespace DiaSharp.CodeView.Architectures;

/// <summary>
/// Specifies a target register on the MIPS R4000 architecture.
/// </summary>
/// <remarks>
/// Must be used in combination with <see cref="HostRegister"/> for full coverage, see implementation for more details.
/// </remarks>
public enum R4000
{
	#region Integer Registers

	IntZERO = 10,
	IntAT   = 11,
	IntV0   = 12,
	IntV1   = 13,
	IntA0   = 14,
	IntA1   = 15,
	IntA2   = 16,
	IntA3   = 17,
	IntT0   = 18,
	IntT1   = 19,
	IntT2   = 20,
	IntT3   = 21,
	IntT4   = 22,
	IntT5   = 23,
	IntT6   = 24,
	IntT7   = 25,
	IntS0   = 26,
	IntS1   = 27,
	IntS2   = 28,
	IntS3   = 29,
	IntS4   = 30,
	IntS5   = 31,
	IntS6   = 32,
	IntS7   = 33,
	IntT8   = 34,
	IntT9   = 35,
	IntKT0  = 36,
	IntKT1  = 37,
	IntGP   = 38,
	IntSP   = 39,
	IntS8   = 40,
	IntRA   = 41,
	IntLO   = 42,
	IntHI   = 43,

	#endregion

	Fir = 50,
	Psr = 51,

	#region Floating Point Registers

	FltF0  = 60,
	FltF1  = 61,
	FltF2  = 62,
	FltF3  = 63,
	FltF4  = 64,
	FltF5  = 65,
	FltF6  = 66,
	FltF7  = 67,
	FltF8  = 68,
	FltF9  = 69,
	FltF10 = 70,
	FltF11 = 71,
	FltF12 = 72,
	FltF13 = 73,
	FltF14 = 74,
	FltF15 = 75,
	FltF16 = 76,
	FltF17 = 77,
	FltF18 = 78,
	FltF19 = 79,
	FltF20 = 80,
	FltF21 = 81,
	FltF22 = 82,
	FltF23 = 83,
	FltF24 = 84,
	FltF25 = 85,
	FltF26 = 86,
	FltF27 = 87,
	FltF28 = 88,
	FltF29 = 89,
	FltF30 = 90,
	FltF31 = 91,
	FltFsr = 92

	#endregion
}
