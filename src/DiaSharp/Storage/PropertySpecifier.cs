using DiaSharp.SDK;

namespace DiaSharp.Storage;

/// <summary>
/// The <see cref="PropertySpecifier"/> structure is used by many of the methods of <see cref="IPropertyStorage"/> to specify a property either by its id, or its associated string name.
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public readonly struct PropertySpecifier : IEquatable<PropertySpecifier>
{
	/// <summary>
	/// Indicates the union member used.
	/// </summary>
	[MarshalAs(UnmanagedType.Bool)]
	[FieldOffset(0)]
	public readonly bool IsID;

	/// <summary>
	/// Specifies the value of the property id. Use either this value or the following <see cref="Name"/>, not both.
	/// </summary>
	[FieldOffset(4)]
	public readonly uint PropertyID;

	/// <summary>
	/// Specifies the string name of the property as a null-terminated Unicode string.
	/// </summary>
	[FieldOffset(4)]
	public readonly unsafe char* Name;

	public override readonly bool Equals(object? obj) => obj is PropertySpecifier specifier && this == specifier;

	public override unsafe int GetHashCode() => Extensions.GetHashCode(in this);

	public static unsafe bool operator ==(PropertySpecifier left, PropertySpecifier right)
	{
		if (sizeof(nint) == 4) goto fastComp;

		if (left.IsID != right.IsID) return false;

		if (left.IsID) goto fastComp;

		return new ReadOnlySpan<byte>(&left, sizeof(PropertySpecifier)) == new ReadOnlySpan<byte>(&right, sizeof(PropertySpecifier));

	fastComp:
		return *(ulong*)&left == *(ulong*)&right;
	}

	public static unsafe bool operator !=(PropertySpecifier left, PropertySpecifier right)
	{
		if (sizeof(nint) == 4) goto fastComp;

		if (left.IsID != right.IsID) return true;

		if (left.IsID) goto fastComp;

		return new ReadOnlySpan<byte>(&left, sizeof(PropertySpecifier)) != new ReadOnlySpan<byte>(&right, sizeof(PropertySpecifier));

	fastComp:
		return *(ulong*)&left != *(ulong*)&right;
	}

	public bool Equals(PropertySpecifier other) => this == other;
}
