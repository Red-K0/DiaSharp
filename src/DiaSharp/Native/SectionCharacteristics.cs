namespace DiaSharp.Native;

/// <summary>
/// Represents the image section header format.
/// </summary>
[Flags]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1028:Enum Storage should be Int32", Justification = "Larger values don't fit in an Int32")]
public enum SectionCharacteristics : uint
{
	/// <summary>
	/// The section should not be padded to the next boundary.
	/// </summary>
	[Obsolete("This flag is obsolete.")]
	NotPadded = 0x00000008,

	/// <summary>
	/// The section contains executable code.
	/// </summary>
	ContainsCode = 0x00000020,

	/// <summary>
	/// The section contains initialized data.
	/// </summary>
	ContainsInitializedData = 0x00000040,

	/// <summary>
	/// The section contains uninitialized data.
	/// </summary>
	ContainsUninitializedData = 0x00000080,

	/// <summary>
	/// Reserved.
	/// </summary>
	LinkerOther = 0x00000100,

	/// <summary>
	/// The section contains comments or other information.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	LinkerInfo = 0x00000200,

	/// <summary>
	/// The section will not become part of the image.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	LinkerRemove = 0x00000800,

	/// <summary>
	/// The section contains COMDAT data.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	LinkerCOMDAT = 0x00001000,

	/// <summary>
	/// Reset speculative exceptions handling bits in the TLB entries for this section.
	/// </summary>
	NoDeferSpeculativeExceptions = 0x00004000,

	/// <summary>
	/// The section contains data referenced through the global pointer.
	/// </summary>
	GlobalPointerRelative = 0x00008000,

	/// <summary>
	/// Reserved.
	/// </summary>
	Purgeable = 0x00020000,

	/// <summary>
	/// Reserved.
	/// </summary>
	Locked = 0x00040000,

	/// <summary>
	/// Reserved.
	/// </summary>
	Preloaded = 0x00080000,

	/// <summary>
	/// Align data on a 1-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo1Byte = 0x00100000,

	/// <summary>
	/// Align data on a 2-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo2Bytes = 0x00200000,

	/// <summary>
	/// Align data on a 4-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo4Bytes = 0x00300000,

	/// <summary>
	/// Align data on a 8-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo8Bytes = 0x00400000,

	/// <summary>
	/// Align data on a 16-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo16Bytes = 0x00500000,

	/// <summary>
	/// Align data on a 32-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo32Bytes = 0x00600000,

	/// <summary>
	/// Align data on a 64-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo64Bytes = 0x00700000,

	/// <summary>
	/// Align data on a 128-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo128Bytes = 0x00800000,

	/// <summary>
	/// Align data on a 256-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo256Bytes = 0x00900000,

	/// <summary>
	/// Align data on a 512-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo512Bytes = 0x00A00000,

	/// <summary>
	/// Align data on a 1024-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo1024Bytes = 0x00B00000,

	/// <summary>
	/// Align data on a 2048-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo2048Bytes = 0x00C00000,

	/// <summary>
	/// Align data on a 4096-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo4096Bytes = 0x00D00000,

	/// <summary>
	/// Align data on a 8192-byte boundary.
	/// </summary>
	/// <remarks>
	/// This is valid only for object files.
	/// </remarks>
	AlignTo8192Bytes = 0x00E00000,

	/// <summary>
	/// The section contains extended relocations, with a count of relocations for the section exceeding the 16 bits reserved in the section header.
	/// </summary>
	/// <remarks>
	/// <para> If the NumberOfRelocations field in the section header is <c>0xFFFF</c>, the actual relocation count is stored in the VirtualAddress field of the first relocation. </para>
	/// <para> It is an error if <see cref="ContainsExtendedRelocations"/> is set and there are fewer than <c>0xFFFF</c> relocations in the section. </para>
	/// </remarks>
	ContainsExtendedRelocations = 0x01000000,

	/// <summary>
	/// The section can be discarded as needed.
	/// </summary>
	Discardable = 0x02000000,

	/// <summary>
	/// The section cannot be cached.
	/// </summary>
	NotCached = 0x04000000,

	/// <summary>
	/// The section cannot be paged.
	/// </summary>
	NotPaged = 0x08000000,

	/// <summary>
	/// The section can be shared in memory.
	/// </summary>
	Shared = 0x10000000,

	/// <summary>
	/// The section can be executed as code.
	/// </summary>
	Executable = 0x20000000,

	/// <summary>
	/// The section can be read.
	/// </summary>
	Readable = 0x40000000,

	/// <summary>
	/// The section can be written to.
	/// </summary>
	Writeable = 0x80000000
}