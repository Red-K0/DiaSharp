using System.ComponentModel;

namespace DiaSharp.Sdk;

/// <summary>
/// Specifies a combination of flags that control how a symbol is undecorated.
/// </summary>
[Flags]
public enum UndecorateOptions
{
	/// <summary>
	/// Enables full undecoration.
	/// </summary>
	None = 0x0000,

	/// <summary>
	/// Removes leading underscores from Microsoft extended keywords.
	/// </summary>
	NoLeadingUnderscores = 0x0001,

	/// <summary>
	/// Disables expansion of Microsoft extended keywords.
	/// </summary>
	NoMicrosoftKeywords = 0x0002,

	/// <summary>
	/// Disables expansion of return type for primary declaration.
	/// </summary>
	NoFunctionReturns = 0x0004,

	/// <summary>
	/// Disables expansion of the declaration model.
	/// </summary>
	NoAllocationModel = 0x0008,

	/// <summary>
	/// Disables expansion of the declaration language specifier.
	/// </summary>
	NoAllocationLanguage = 0x0010,

	/// <summary>
	/// Win32 RESERVED.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	NTT1 = 0x0020,

	/// <summary>
	/// Win32 RESERVED.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	NTT2 = 0x0040,

	/// <summary>
	/// Disables all modifiers on the <see langword="this"/> type.
	/// </summary>
	NoThisType = NTT1 | NTT2,

	/// <summary>
	/// Disables expansion of access specifiers for members.
	/// </summary>
	NoAccessSpecifiers = 0x0080,

	/// <summary>
	/// Disables expansion of "throw-signatures" for functions and pointers to functions.
	/// </summary>
	NoThrowSignatures = 0x0100,

	/// <summary>
	/// Disables expansion of <see langword="static"/> or <see langword="virtual"/> members.
	/// </summary>
	NoMemberType = 0x0200,

	/// <summary>
	/// Disables expansion of the Microsoft model for UDT returns.
	/// </summary>
	NoReturnUdtModel = 0x0400,

	/// <summary>
	/// Undecorates 32-bit decorated names.
	/// </summary>
	Decode32Bit = 0x0800,

	/// <summary>
	/// Gets only the name for primary declaration; returns just [scope::]name. Expands template params.
	/// </summary>
	NameOnly = 0x1000,

	/// <summary>
	/// Input is just a type encoding; composes an abstract declarator.
	/// </summary>
	TypeOnly = 0x2000,

	/// <summary>
	/// The real template parameters are available.
	/// </summary>
	HaveParameters = 0x4000,

	/// <summary>
	/// Suppresses <see langword="enum"/>/<see langword="class"/>/<see langword="struct"/>/<see langword="union"/>.
	/// </summary>
	NoECSU = 0x8000,

	/// <summary>
	/// Suppresses check for valid identifier characters.
	/// </summary>
	NoValidIdentifierCheck = 0x10000,

	/// <summary>
	/// Does not include ptr64 in output.
	/// </summary>
	NoPtr64Output = 0x20000
}