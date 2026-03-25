namespace DiaSharp.Enums;

/// <summary>
/// Specifies a combination of flags that control how a symbol is undecorated.
/// </summary>
[Flags]
public enum UndecorateOptions
{
	/// <summary>
	/// Enables full undecoration.
	/// </summary>
	Complete,

	/// <summary>
	/// Removes leading underscores from Microsoft extended keywords.
	/// </summary>
	NoLeadingUnderscores,

	/// <summary>
	/// Disables expansion of Microsoft extended keywords.
	/// </summary>
	NoMicrosoftKeywords,

	/// <summary>
	/// Disables expansion of return type for primary declaration.
	/// </summary>
	NoFunctionReturns,

	/// <summary>
	/// Disables expansion of the declaration model.
	/// </summary>
	NoAllocationModel,

	/// <summary>
	/// Disables expansion of the declaration language specifier.
	/// </summary>
	NoAllocationLanguage,

	/// <summary>
	/// RESERVED.
	/// </summary>
	Reserved1,

	/// <summary>
	/// RESERVED.
	/// </summary>
	Reserved2,

	/// <summary>
	/// Disables all modifiers on the <see langword="this"/> type.
	/// </summary>
	NoThisType,

	/// <summary>
	/// Disables expansion of access specifiers for members.
	/// </summary>
	NoAccessSpecifiers,

	/// <summary>
	/// Disables expansion of "throw-signatures" for functions and pointers to functions.
	/// </summary>
	NoThrowSignatures,

	/// <summary>
	/// Disables expansion of <see langword="static"/> or <see langword="virtual"/> members.
	/// </summary>
	NoMemberType,

	/// <summary>
	/// Disables expansion of the Microsoft model for UDT returns.
	/// </summary>
	NoReturnUdtModel,

	/// <summary>
	/// Undecorates 32-bit decorated names.
	/// </summary>
	Decode32Bit,

	/// <summary>
	/// Gets only the name for primary declaration; returns just [scope::]name. Expands template params.
	/// </summary>
	NameOnly,

	/// <summary>
	/// Input is just a type encoding; composes an abstract declarator.
	/// </summary>
	TypeOnly,

	/// <summary>
	/// The real template parameters are available.
	/// </summary>
	HaveParameters,

	/// <summary>
	/// Suppresses <see langword="enum"/>/<see langword="class"/>/<see langword="struct"/>/<see langword="union"/>.
	/// </summary>
	NoECSU,

	/// <summary>
	/// Suppresses check for valid identifier characters.
	/// </summary>
	NoValidIdentifierCheck,

	/// <summary>
	/// Does not include ptr64 in output.
	/// </summary>
	NoPtr64Output
}