namespace DiaSharp.CodeView.Architectures;

/// <summary>
/// Specifies a target register on the Alpha AXP architecture.
/// </summary>
/// <remarks>
/// Must be used in combination with <see cref="HostRegister"/> for full coverage, see implementation for more details.
/// </remarks>
public enum AlphaAXP
{
    #region Floating Point Registers

    FltF0  = 10,
    FltF1  = 11,
    FltF2  = 12,
    FltF3  = 13,
    FltF4  = 14,
    FltF5  = 15,
    FltF6  = 16,
    FltF7  = 17,
    FltF8  = 18,
    FltF9  = 19,
    FltF10 = 20,
    FltF11 = 21,
    FltF12 = 22,
    FltF13 = 23,
    FltF14 = 24,
    FltF15 = 25,
    FltF16 = 26,
    FltF17 = 27,
    FltF18 = 28,
    FltF19 = 29,
    FltF20 = 30,
    FltF21 = 31,
    FltF22 = 32,
    FltF23 = 33,
    FltF24 = 34,
    FltF25 = 35,
    FltF26 = 36,
    FltF27 = 37,
    FltF28 = 38,
    FltF29 = 39,
    FltF30 = 40,
    FltF31 = 41,

    #endregion

    #region Integer Registers

    IntV0   = 42,
    IntT0   = 43,
    IntT1   = 44,
    IntT2   = 45,
    IntT3   = 46,
    IntT4   = 47,
    IntT5   = 48,
    IntT6   = 49,
    IntT7   = 50,
    IntS0   = 51,
    IntS1   = 52,
    IntS2   = 53,
    IntS3   = 54,
    IntS4   = 55,
    IntS5   = 56,
    IntFP   = 57,
    IntA0   = 58,
    IntA1   = 59,
    IntA2   = 60,
    IntA3   = 61,
    IntA4   = 62,
    IntA5   = 63,
    IntT8   = 64,
    IntT9   = 65,
    IntT10  = 66,
    IntT11  = 67,
    IntRA   = 68,
    IntT12  = 69,
    IntAT   = 70,
    IntGP   = 71,
    IntSP   = 72,
    IntZERO = 73,

    #endregion

    #region Control Registers

    Fpcr     = 74,
    Fir      = 75,
    Psr      = 76,
    FltFsr   = 77,
    SoftFpcr = 78,

    #endregion
}
