namespace DiaSharp.CodeView;

/// <summary>
/// Specifies the target processor.
/// </summary>
/// <remarks>
/// The values in this enumeration are returned by a call to the Symbol::Getplatform method.
/// </remarks>
public enum CpuType
{
	Intel8080      = 0x00,
	Intel8086      = 0x01,
	Intel80286     = 0x02,
	Intel80386     = 0x03,
	Intel80486     = 0x04,
	Pentium        = 0x05,
	PentiumII      = 0x06,
	PentiumIII     = 0x07,

	MipsR4000      = 0x10,
	Mips16         = 0x11,
	Mips32         = 0x12,
	Mips64         = 0x13,
	MipsI          = 0x14,
	MipsII         = 0x15,
	MipsIII        = 0x16,
	MipsIV         = 0x17,
	MipsV          = 0x18,

	Motorola68000  = 0x20,
	Motorola68010  = 0x21,
	Motorola68020  = 0x22,
	Motorola68030  = 0x23,
	Motorola68040  = 0x24,

	Alpha21064     = 0x30,
	Alpha21164     = 0x31,
	Alpha21164A    = 0x32,
	Alpha21264     = 0x33,
	Alpha21364     = 0x34,

	PowerPc601     = 0x40,
	PowerPc603     = 0x41,
	PowerPc604     = 0x42,
	PowerPc620     = 0x43,
	PowerPcFp      = 0x44,
	PowerPcBe      = 0x45,

	Sh3            = 0x50,
	Sh3e           = 0x51,
	Sh3Dsp         = 0x52,
	Sh4            = 0x53,
	ShMedia        = 0x54,

	Arm3           = 0x60,
	Arm4           = 0x61,
	Arm4T          = 0x62,
	Arm5           = 0x63,
	Arm5T          = 0x64,
	Arm6           = 0x65,
	ArmXmac        = 0x66,
	ArmWmmx        = 0x67,
	Arm7           = 0x68,

	Omni           = 0x70,

	Ia64           = 0x80,
	Ia64_2         = 0x81,

	Cee            = 0x90,

	Am33           = 0xA0,
	M32R           = 0xB0,
	TriCore        = 0xC0,

	Amd64          = 0xD0,

	Ebc            = 0xE0,

	Thumb          = 0xF0,
	ArmNt          = 0xF4,
	Arm64          = 0xF6,
	HybridX86Arm64 = 0xF7,
	Arm64Ec        = 0xF8,
	Arm64X         = 0xF9,

	Unknown        = 0xFF,

	D3D11Shader    = 0x100
}