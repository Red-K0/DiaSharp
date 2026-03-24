using DiaSharp.Enums;

namespace DiaSharp.CodeView;

/// <summary>
/// Specifies the scope of visibility (access level) of member functions and variables.
/// </summary>
/// <remarks>
/// <para> The C++ <see langword="friend"/> access specifier is not included here because it is typically used by non-member functions, which have access to both private and protected elements of a class. </para>
/// <para> Use the IDiaSymbol::get_symTag method to find symbols with <see cref="SymbolTag.Friend"/> access. </para>
/// </remarks>
public enum Access
{
	Private   = 0,
	Public    = 1,
	Protected = 2,
}
