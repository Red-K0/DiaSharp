namespace DiaSharp.CodeView.Architectures;

/// <summary>
/// Specifies a target register on the Motorola 68000 architecture.
/// </summary>
/// <remarks>
/// Must be used in combination with <see cref="HostRegister"/> for full coverage, see implementation for more details.
/// </remarks>
public enum M68K
{
    #region Core Integer Execution State (All 68K)

    D0 = 0,
    D1 = 1,
    D2 = 2,
    D3 = 3,
    D4 = 4,
    D5 = 5,
    D6 = 6,
    D7 = 7,

    A0 = 8,
    A1 = 9,
    A2 = 10,
    A3 = 11,
    A4 = 12,
    A5 = 13,
    A6 = 14,
    A7 = 15,

    CCR = 16,
    SR  = 17,

    USP = 18,
    MSP = 19,
    ISP = 25,

    PC = 26,

    #endregion

    #region Function Code / Cache / Vector Control (68010 → 68030 era)

    SFC = 20,
    DFC = 21,

    CACR = 22,
    VBR  = 23,
    CAAR = 24,

    #endregion

    #region Floating Point Unit (68881 / 68882 / 68040)

    FPCR  = 28,
    FPSR  = 29,
    FPIAR = 30,

    FP0 = 32,
    FP1 = 33,
    FP2 = 34,
    FP3 = 35,
    FP4 = 36,
    FP5 = 37,
    FP6 = 38,
    FP7 = 39,

    #endregion

    #region MMU Status / Transparent Translation (68030 / 68040)

    MMUSR030 = 41,
    MMUSR    = 42,

    URP = 43,

    DTT0 = 44,
    DTT1 = 45,
    ITT0 = 46,
    ITT1 = 47,

    #endregion

    #region PMMU Root + Translation Control (External PMMU / 68030-style)

    PSR  = 51,
    PCSR = 52,
    VAL  = 53,

    CRP = 54,
    SRP = 55,
    DRP = 56,

    TC = 57,
    AC = 58,

    SCC = 59,
    CAL = 60,

    TT0 = 61,
    TT1 = 62,

    #endregion

    #region Hardware Breakpoint / Debug Comparator Unit (CPU32 / ColdFire-style)

    BAD0 = 64,
    BAD1 = 65,
    BAD2 = 66,
    BAD3 = 67,
    BAD4 = 68,
    BAD5 = 69,
    BAD6 = 70,
    BAD7 = 71,

    BAC0 = 72,
    BAC1 = 73,
    BAC2 = 74,
    BAC3 = 75,
    BAC4 = 76,
    BAC5 = 77,
    BAC6 = 78,
    BAC7 = 79,

    #endregion
}
