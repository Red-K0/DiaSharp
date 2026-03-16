namespace DiaSharp.CodeView.Architectures;

/// <summary>
/// Specifies a target register on the Mitsubushi/Renesas M32R architecture.
/// </summary>
/// <remarks>
/// Must be used in combination with <see cref="HostRegister"/> for full coverage, see implementation for more details.
/// </remarks>
public enum M32R
{
    R0  = 10,
    R1  = 11,
    R2  = 12,
    R3  = 13,
    R4  = 14,
    R5  = 15,
    R6  = 16,
    R7  = 17,
    R8  = 18,
    R9  = 19,
    R10 = 20,
    R11 = 21,

    /// <summary>
    /// Holds the global pointer, if used.
    /// </summary>
    R12 = 22,

    /// <summary>
    /// Holds the frame pointer, if allocated.
    /// </summary>
    R13 = 23,

    /// <summary>
    /// Link register.
    /// </summary>
    R14 = 24,

    /// <summary>
    /// Holds the stack pointer.
    /// </summary>
    R15 = 25,

    PSW  = 26,
    CBR  = 27,
    SPI  = 28,
    SPU  = 29,
    SPO  = 30,
    BPC  = 31,
    ACHI = 32,
    ACLO = 33,
    PC   = 34,
}
