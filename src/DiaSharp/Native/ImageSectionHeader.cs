namespace DiaSharp.Native;

/// <summary>
/// Represents the image section header format.
/// </summary>
[StructLayout(LayoutKind.Explicit, Pack = 1)]
public unsafe struct ImageSectionHeader : IEquatable<ImageSectionHeader>
{
	/// <summary>
	/// An 8-byte, null-padded UTF-8 string. There is no terminating null character if the string is exactly eight characters long.
	/// </summary>
	/// <remarks>
	/// <para> For longer names, this member contains a forward slash (<c>/</c>) followed by an ASCII representation of a decimal number that is an offset into the string table. </para>
	/// <para> Executable images do not use a string table and do not support section names longer than eight characters. </para>
	/// </remarks>
	[FieldOffset(00)] public fixed byte Name[8];

	/// <summary>
	/// The file address.
	/// </summary>
	[FieldOffset(08)] public readonly uint PhysicalAddress;

	/// <summary>
	/// The total size of the section when loaded into memory, in bytes.
	/// </summary>
	/// <remarks>
	/// <para> If this value is greater than <see cref="SizeOfRawData"/>, the section is filled with zeroes. </para>
	/// <para> This field is valid only for executable images and should be set to 0 for object files. </para>
	/// </remarks>
	[FieldOffset(08)] public readonly uint VirtualSize;

	/// <summary>
	/// The address of the first byte of the section when loaded into memory, relative to the image base.
	/// </summary>
	/// <remarks>
	/// For object files, this is the address of the first byte before relocation is applied.
	/// </remarks>
	[FieldOffset(12)] public readonly uint VirtualAddress;

	/// <summary>
	/// The size of the initialized data on disk, in bytes. This value must be a multiple of the FileAlignment member of the Win32 IMAGE_OPTIONAL_HEADER structure.
	/// </summary>
	/// <remarks>
	/// <para> If this value is less than <see cref="VirtualSize"/>, the remainder of the section is filled with zeroes. </para>
	/// <para> If the section contains only uninitialized data, the member is zero. </para>
	/// </remarks>
	[FieldOffset(16)] public readonly uint SizeOfRawData;

	/// <summary>
	/// A file pointer to the first page within the COFF file. This value must be a multiple of the FileAlignment member of the Win32 IMAGE_OPTIONAL_HEADER structure.
	/// </summary>
	/// <remarks>
	/// If a section contains only uninitialized data, set this member is zero.
	/// </remarks>
	[FieldOffset(20)] public readonly uint PointerToRawData;

	/// <summary>
	/// A file pointer to the beginning of the relocation entries for the section.
	/// </summary>
	/// <remarks>
	/// If there are no relocations, this value is zero.
	/// </remarks>
	[FieldOffset(24)] public readonly uint PointerToRelocations;

	/// <summary>
	/// A file pointer to the beginning of the line-number entries for the section.
	/// </summary>
	/// <remarks>
	///  If there are no COFF line numbers, this value is zero.
	/// </remarks>
	[FieldOffset(28)] public readonly uint PointerToLinenumbers;

	/// <summary>
	/// The number of relocation entries for the section.
	/// </summary>
	/// <remarks>
	/// This value is zero for executable images.
	/// </remarks>
	[FieldOffset(32)] public readonly ushort NumberOfRelocations;

	/// <summary>
	/// The number of line-number entries for the section.
	/// </summary>
	[FieldOffset(34)] public readonly ushort NumberOfLinenumbers;

	/// <summary>
	/// The characteristics of the image.
	/// </summary>
	[FieldOffset(36)] public readonly SectionCharacteristics Characteristics;

	public override readonly bool Equals(object? obj) => obj is ImageSectionHeader header && this == header;

	public override readonly int GetHashCode() => Extensions.GetHashCode(in this);

	public static bool operator ==(ImageSectionHeader left, ImageSectionHeader right)
	{
		return Extensions.ValueEquals(&left, &right);
	}

	public static bool operator !=(ImageSectionHeader left, ImageSectionHeader right)
	{
		return !Extensions.ValueEquals(&left, &right);
	}

	public readonly bool Equals(ImageSectionHeader other) => this == other;
}
