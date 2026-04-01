namespace DiaSharp.COM;

/// <summary>
/// Defines what the server authorizes.
/// </summary>
public enum Authorization
{
	/// <summary>
	/// The server performs no authorization.
	/// </summary>
	/// <remarks>
	/// Currently, <see cref="Authentication.WinNT"/>, <see cref="Authentication.GssSChannel"/>, and <see cref="Authentication.GssKerberos"/> all use only <see cref="None"/>.
	/// </remarks>
	None,

	/// <summary>
	/// The server performs authorization based on the client's principal name.
	/// </summary>
	Name,

	/// <summary>
	/// The server performs authorization checking using the client's DCE privilege attribute certificate (PAC) information, which is sent to the server with each remote procedure call made using the binding handle.
	/// Generally, access is checked against DCE access control lists (ACLs).
	/// </summary>
	Dce,

	/// <summary>
	/// DCOM can choose the authorization level using its normal security blanket negotiation algorithm.
	/// </summary>
	/// <remarks>
	/// For more information, see <see href="https://learn.microsoft.com/en-us/windows/win32/com/security-blanket-negotiation">Security Blanket Negotiation</see>.
	/// </remarks>
	Default = unchecked((int)0xFFFFFFFF)
}
