#pragma warning disable CA1720

namespace DiaSharp.CodeView;

/// <summary>
/// Specifies a symbol's basic type.
/// </summary>
/// <remarks>
/// The values in this <see langword="enum"/> are returned by <see cref="SDK.Symbols.ISymbol.GetBaseType(out BasicType)"/>
/// </remarks>
public enum BasicType
{
	/// <summary>
	/// No basic type is specified.
	/// </summary>
	NoType = 0,
	
	/// <summary>
	/// Basic type is <see langword="void"/>.
	/// </summary>
	Void = 1,
	
	/// <summary>
	/// Basic type is a <see langword="byte"/> (C/C++ <see langword="char"/>).
	/// </summary>
	Byte = 2,
	
	/// <summary>
	/// Basic type is a <see langword="char"/>.
	/// </summary>
	WideChar = 3,
	
	/// <summary>
	/// Basic type is an <see langword="int"/> (16/32).
	/// </summary>
	Integer = 6,

	/// <summary>
	/// Basic type is a <see langword="uint"/> (16/32).
	/// </summary>
	UnsignedInteger = 7,

	/// <summary>
	/// Basic type is a <see langword="float"/>.
	/// </summary>
	Float = 8,

	/// <summary>
	/// Basic type is a <see langword="decimal"/>.
	/// </summary>
	Decimal = 9,
	
	/// <summary>
	/// Basic type is a Win32 BOOL.
	/// </summary>
	Boolean = 10,

	/// <summary>
	/// Basic type is an <see langword="int"/>.
	/// </summary>
	Long = 13,

	/// <summary>
	/// Basic type is a <see langword="uint"/>.
	/// </summary>
	UnsignedLong = 14,
	
	/// <summary>
	/// Basic type is a currency.
	/// </summary>
	Currency = 25,
	
	/// <summary>
	/// Basic type is a Win32 DATE.
	/// </summary>
	Date = 26,
	
	/// <summary>
	/// Basic type is a <see cref="Variant"/>.
	/// </summary>
	Variant = 27,
	
	/// <summary>
	/// Basic type is a complex number.
	/// </summary>
	Complex = 28,
	
	/// <summary>
	/// Basic type is a bit.
	/// </summary>
	Bit = 29,
	
	/// <summary>
	/// Basic type is a Win32 BSTR.
	/// </summary>
	BinaryString = 30,
	
	/// <summary>
	/// Basic type is an HRESULT.
	/// </summary>
	HRESULT = 31,

	/// <summary>
	/// Basic type is a UTF-16 character.
	/// </summary>
	Char16 = 32,

	/// <summary>
	/// Basic type is a UTF-32 character.
	/// </summary>
	Char32 = 33,

	/// <summary>
	/// Basic type is a UTF-8 character.
	/// </summary>
	Char8 = 34,

	/// <summary>
	/// Basic type is a scalable vector.
	/// </summary>
	Vector = 35,
}

#pragma warning restore CA1720