namespace DiaSharp.Sdk.Symbols;

/// <summary>
/// Describes the variety of a user-defined type (UDT).
/// </summary>
/// <remarks>
/// The values in this enumeration are returned by the Symbol::GetudtKind method.
/// </remarks>
public enum UdtKind
{
	/// <summary>
	/// UDT is a structure.
	/// </summary>
	Struct,

	/// <summary>
	/// UDT is a class.
	/// </summary>
	Class,

	/// <summary>
	/// UDT is a union.
	/// </summary>
	Union,

	/// <summary>
	/// UDT is an interface.
	/// </summary>
	Interface,

	/// <summary>
	/// UDT is a tagged union.
	/// </summary>
	TaggedUnion
}
