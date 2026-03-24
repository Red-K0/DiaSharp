namespace DiaSharp.StructuredStorage;

using System.Runtime.InteropServices;

/// <summary>
/// The <see cref="PropertySpecifier"/> structure is used by many of the methods of <see cref="IDiaPropertyStorage"/> to specify a property either by its ID, or its associated string name.
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public readonly struct PropertySpecifier
{
	/// <summary>
	/// Indicates the union member used.
	/// </summary>
	[MarshalAs(UnmanagedType.Bool)]
	[FieldOffset(0)]
	public readonly bool IsID;

	/// <summary>
	/// Specifies the value of the property ID. Use either this value or the following <see cref="Name"/>, not both.
	/// </summary>
	[FieldOffset(4)]
	public readonly uint PropertyID;

	/// <summary>
	/// Specifies the string name of the property as a null-terminated Unicode string.
	/// </summary>
	[FieldOffset(4)]
	public unsafe readonly char* Name;
}