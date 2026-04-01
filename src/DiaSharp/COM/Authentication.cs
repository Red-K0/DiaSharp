namespace DiaSharp.COM;

/// <summary>
/// Defines authentication services by identifying the security package that provides the service, such as NTLMSSP, Kerberos, or Schannel.
/// </summary>
public enum Authentication
{
	/// <summary>
	/// No authentication.
	/// </summary>
	None = 0,

	/// <summary>
	/// DCE private key authentication.
	/// </summary>
	DcePrivate = 1,

	/// <summary>
	/// DCE public key authentication.
	/// </summary>
	DcePublic = 2,

	/// <summary>
	/// DEC public key authentication. Reserved for future use.
	/// </summary>
	DecPublic = 4,

	/// <summary>
	/// Snego security support provider.
	/// </summary>
	GssNegotiate = 9,

	/// <summary>
	/// NTLMSSP.
	/// </summary>
	WinNT = 10,

	/// <summary>
	/// Schannel security support provider. This authentication service supports SSL 2.0, SSL 3.0, TLS, and PCT.
	/// </summary>
	GssSChannel = 14,

	/// <summary>
	/// Kerberos security support provider.
	/// </summary>
	GssKerberos = 16,

	/// <summary>
	/// DPA security support provider.
	/// </summary>
	Dpa = 17,

	/// <summary>
	/// MSN security support provider.
	/// </summary>
	Msn = 18,

	/// <summary>
	/// Kernel security support provider.
	/// </summary>
	Kernel = 20,

	/// <summary>
	/// Digest security support provider.
	/// </summary>
	Digest = 21,

	/// <summary>
	/// NEGO extender security support provider.
	/// </summary>
	NegoExtender = 30,

	/// <summary>
	/// PKU2U security support provider.
	/// </summary>
	Pku2u = 31,

	/// <summary>
	/// MQ security support provider.
	/// </summary>
	MQ = 100,

	/// <summary>
	/// The system default authentication service.
	/// </summary>
	/// <remarks>
	/// <para> When this value is specified, COM uses its normal security blanket negotiation algorithm to pick an authentication service. </para>
	/// <para> For more information, see <see href="https://learn.microsoft.com/en-us/windows/win32/com/security-blanket-negotiation">Security Blanket Negotiation</see>. </para>
	/// </remarks>
	Default = unchecked((int)0xFFFFFFFF)
}
