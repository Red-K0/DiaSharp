namespace DiaSharp.Structs;

/// <summary>
/// Describes the numeric value of a discriminated union's tag.
/// </summary>
/// <remarks>
/// A <see cref="TagValue"/> can represent various values relating to discriminated or tagged unions, like Rust's <see langword="enum"/> variants.<br/>
/// An alternative way to think about the layout of a <see cref="TagValue"/> could be something like this:
/// </remarks>
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 17)]
public readonly struct TagValue
{
	[FieldOffset(00)]
	public readonly UInt128 Value128;
	
	[FieldOffset(08)]
	public readonly ulong Value64;
	
	[FieldOffset(12)]
	public readonly uint Value32;
	
	[FieldOffset(14)]
	public readonly ushort Value16;
	
	[FieldOffset(15)]
	public readonly byte Value8;

	/// <summary>
	/// The size in bytes of <see cref="Value"/>. Must be one of 1, 2, 4, 8, 16, or 0 if this value is empty.
	/// </summary>
	[FieldOffset(16)]
	public readonly byte ValueSize;
}
