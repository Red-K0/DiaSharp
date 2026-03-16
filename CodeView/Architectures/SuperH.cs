namespace DiaSharp.CodeView.Architectures;

/// <summary>
/// Specifies a target register on the Hitachi SuperH architecture.
/// </summary>
/// <remarks>
/// Must be used in combination with <see cref="HostRegister"/> for full coverage, see implementation for more details.
/// </remarks>
public enum SuperH
{
    #region General Purpose Registers

    IntR0  = 10,
    IntR1  = 11,
    IntR2  = 12,
    IntR3  = 13,
    IntR4  = 14,
    IntR5  = 15,
    IntR6  = 16,
    IntR7  = 17,
    IntR8  = 18,
    IntR9  = 19,
    IntR10 = 20,
    IntR11 = 21,
    IntR12 = 22,
    IntR13 = 23,
    IntFp  = 24,
    IntSp  = 25,
    Gbr    = 38,
    Pr     = 39,
    Mach   = 40,
    Macl   = 41,

    Pc     = 50,
    Sr     = 51,

    #endregion

    #region Breakpoint Control Registers

    BarA  = 60,
    BasrA = 61,
    BamrA = 62,
    BbrA  = 63,
    BarB  = 64,
    BasrB = 65,
    BamrB = 66,
    BbrB  = 67,
    BdrB  = 68,
    BdmrB = 69,
    Brcr  = 70,

    #endregion

    #region Additional Registers

    Fpscr = 75,
    Fpul  = 76,

    #region Floating Point Registers

    FpR0  = 80,
    FpR1  = 81,
    FpR2  = 82,
    FpR3  = 83,
    FpR4  = 84,
    FpR5  = 85,
    FpR6  = 86,
    FpR7  = 87,
    FpR8  = 88,
    FpR9  = 89,
    FpR10 = 90,
    FpR11 = 91,
    FpR12 = 92,
    FpR13 = 93,
    FpR14 = 94,
    FpR15 = 95,

    #endregion

    #region Extended Floating Point Registers

    XFpR0  = 96,
    XFpR1  = 97,
    XFpR2  = 98,
    XFpR3  = 99,
    XFpR4  = 100,
    XFpR5  = 101,
    XFpR6  = 102,
    XFpR7  = 103,
    XFpR8  = 104,
    XFpR9  = 105,
    XFpR10 = 106,
    XFpR11 = 107,
    XFpR12 = 108,
    XFpR13 = 109,
    XFpR14 = 110,
    XFpR15 = 111,

    #endregion

    #endregion
}
