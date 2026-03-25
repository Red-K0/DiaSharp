namespace DiaSharp.Enums;

/// <summary>
/// Indicates the kind of location information contained in a symbol.
/// </summary>
/// <remarks>
/// <para> The properties available to the Symbol interface depend on the symbol's location within the image file. </para>
/// <para> For more information, see <see href="https://learn.microsoft.com/en-us/visualstudio/debugger/debug-interface-access/symbol-locations">Symbol Locations</see>. </para>
/// </remarks>
public enum LocationType
{
	/// <summary>
	/// Location information is unavailable.
	/// </summary>
	Null,

	/// <summary>
	/// Location is static.
	/// </summary>
	Static,

	/// <summary>
	/// Location is in thread local storage.
	/// </summary>
	ThreadLocal,

	/// <summary>
	/// Location is register-relative.
	/// </summary>
	RegisterRelative,

	/// <summary>
	/// Location is this-relative.
	/// </summary>
	ThisRelative,

	/// <summary>
	/// Location is in a register.
	/// </summary>
	Enregesitered,

	/// <summary>
	/// Location is in a bit field.
	/// </summary>
	BitField,

	/// <summary>
	/// Location is a Microsoft Intermediate Language (MSIL) slot.
	/// </summary>
	MsilSlot,

	/// <summary>
	/// Location is MSIL-relative.
	/// </summary>
	MsilRelative,

	/// <summary>
	/// Location is in metadata.
	/// </summary>
	Metadata,

	/// <summary>
	/// Location is in a constant value.
	/// </summary>
	Constant,

	/// <summary>
	/// Location is register-relative, and an alias for part of a user defined type (UDT).
	/// </summary>
	RegisterRelativeIndirect,

	/// <summary>
	/// The number of location types in this enumeration.
	/// </summary>
	TypeMax
}
