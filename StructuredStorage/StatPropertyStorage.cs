using DiaSharp.Interop;

namespace DiaSharp.StructuredStorage;

/// <summary>
/// Contains data about a single property in a property set. This data is the property ID and type tag, and the optional string name that may be associated with the property.
/// </summary>
/// <remarks>
/// <see cref="IDiaPropertyStorage.Enum"/> supplies a pointer to the <see cref="IEnumStatPropertyStorage"/> interface on an enumerator object that can be used to enumerate the <see cref="StatPropertyStorage"/> structures for the properties in the current property set.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct StatPropertyStorage
{
	/// <summary>
	/// A wide-character null-terminated Unicode string that contains the optional string name associated with the property. May be <see langword="null"/>.
	/// </summary>
	/// <remarks>
	/// This member must be freed using <see cref="Marshal.FreeCoTaskMem(nint)"/>.
	/// </remarks>
	public readonly char* Name;

	/// <summary>
	/// An identifier that uniquely identifies the property within the property set. All properties within property sets must have unique property identifiers.
	/// </summary>
	public readonly uint PropertyID;

	/// <summary>
	/// The property type.
	/// </summary>
	public readonly VariantType Type;
}
