namespace DiaSharp.COM;

/// <summary>
/// Indicates the amount of authority given to the server when it is impersonating the client.
/// </summary>
public enum ImpersonationLevel
{
	/// <summary>
	/// Tells DCOM to choose the impersonation level using its normal security blanket negotiation algorithm.
	/// </summary>
	/// <remarks>
	/// For more information, see <see href="https://learn.microsoft.com/en-us/windows/win32/com/security-blanket-negotiation">Security Blanket Negotiation</see>.
	/// </remarks>
	Default,

	/// <summary>
	/// The client is anonymous to the server. The server process can impersonate the client, but the impersonation token will not contain any information and cannot be used.
	/// </summary>
	Anonymous,

	/// <summary>
	/// The server can obtain the client's identity. The server can impersonate the client for ACL checking, but it cannot access system objects as the client.
	/// </summary>
	Identify,

	/// <summary>
	/// The server process can impersonate the client's security context while acting on behalf of the client. This level of impersonation can be used to access local resources such as files.
	/// </summary>
	/// <remarks>
	/// <para> When impersonating at this level, the impersonation token can only be passed across one machine boundary. </para>
	/// <para> <see cref="Authentication.GssSChannel"/> only supports this level of impersonation. </para>
	/// </remarks>
	Impersonate,

	/// <summary>
	/// The server process can:
	/// <list type="bullet">
	///		<item> Impersonate the client's security context while acting on its behalf. </item>
	///		<item> Make outgoing calls to other servers while acting on behalf of the client, using cloaking. </item>
	///		<item> Use the client's security context on other machines to access local and remote resources as the client. </item>
	/// </list>
	/// </summary>
	/// <remarks>
	/// When impersonating at this level, the impersonation token can be passed across any number of computer boundaries.
	/// </remarks>
	Delegate
}
