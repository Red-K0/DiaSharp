using System.ComponentModel;

namespace DiaSharp.COM;

/// <summary>
/// Specifies format information for a <see cref="AuthenticationIdentity"/> structure.
/// </summary>
public enum IdentityFlags
{
	/// <summary>
	/// Invalid.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	None = 0,

	/// <summary>
	/// The strings provided are ANSI strings.
	/// </summary>
	Ansi = 1,

	/// <summary>
	/// The strings provided are Unicode strings.
	/// </summary>
	Unicode = 2,
}
