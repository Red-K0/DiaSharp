namespace DiaSharp.Native;

/// <summary>
/// Describes possible machine architectures.
/// </summary>
public enum ImageFileMachine
{
	/// <summary> Unknown. </summary>
	Unknown = 0x0000,

	/// <summary> Interacts with the host and not a WOW64 guest. </summary>
	TargetHost = 0x0001,

	/// <summary> Intel 386. </summary>
	Intel386 = 0x014C,

	/// <summary> MIPS big-endian. </summary>
	R3000BE = 0x0160,

	/// <summary> MIPS little-endian. </summary>
	R3000LE = 0x0162,

	/// <summary> MIPS little-endian. </summary>
	R4000 = 0x0166,

	/// <summary> MIPS little-endian. </summary>
	R10000 = 0x0168,

	/// <summary> MIPS little-endian WCE v2. </summary>
	WceMipsV2 = 0x0169,

	/// <summary> ALPHA_AXP. </summary>
	AlphaAXP   = 0x0184,

	/// <summary> SuperH 3 little-endian. </summary>
	SuperH3 = 0x01A2,

	/// <summary> SuperH 3 DSP little-endian. </summary>
	SuperH3DSP = 0x01A3,

	/// <summary> SuperH 3 SE little-endian. </summary>
	SuperH3E = 0x01A4,

	/// <summary> SuperH 4 little-endian. </summary>
	SuperH4 = 0x01A6,

	/// <summary> SuperH 5. </summary>
	SuperH5 = 0x01A8,

	/// <summary> ARM little-endian. </summary>
	Arm = 0x01C0,

	/// <summary> ARM Thumb/Thumb-2 little-endian. </summary>
	Thumb = 0x01C2,

	/// <summary> ARM Thumb-2 little-endian. </summary>
	ArmNT = 0x01C4,

	/// <summary> TAM33BD Architecture. </summary>
	AM33 = 0x01D3,

	/// <summary> IBM PowerPC little-endian. </summary>
	PowerPC = 0x01F0,

	/// <summary> IBM PowerPC Floating Point little-endian. </summary>
	PowerPCFP = 0x01F1,

	/// <summary> Intel 64. </summary>
	Intel64 = 0x0200,

	/// <summary> MIPS (16-bit). </summary>
	Mips16 = 0x0266,

	/// <summary> ALPHA64. </summary>
	Alpha64 = 0x0284,

	/// <summary> MIPS with FPU. </summary>
	MipsFPU = 0x0366,

	/// <summary> MIPS with FPU (16-bit). </summary>
	MipsFPU16 = 0x0466,

	/// <summary> Infineon TriCore. </summary>
	TriCore = 0x0520,

	/// <summary> Chromium Embedded Framework. </summary>
	CEF = 0x0CEF,

	/// <summary> EFI Bytecode. </summary>
	EBC = 0x0EBC,

	/// <summary> AMD64 (K8). </summary>
	AMD64 = 0x8664,

	/// <summary> M32R little-endian. </summary>
	M32R = 0x9041,

	/// <summary> ARM64 little-endian. </summary>
	Arm64 = 0xAA64,

	/// <summary> Common Language Runtime. </summary>
	CEE = 0xC0EE
}