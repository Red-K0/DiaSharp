namespace DiaSharp.COM;

/// <summary>
/// Indicates the amount of authentication provided to help protect the integrity of the data. Each level includes the protection provided by the previous levels.
/// </summary>
public enum AuthenticationLevel
{
	/// <summary>
	/// Tells DCOM to choose the authentication level using its normal security blanket negotiation algorithm.
	/// </summary>
	/// <remarks>
	/// For more information, see <see href="https://learn.microsoft.com/en-us/windows/win32/com/security-blanket-negotiation">Security Blanket Negotiation</see>.
	/// </remarks>
	Default,

	/// <summary>
	/// Performs no authentication.
	/// </summary>
	None,

	/// <summary>
	/// Authenticates the credentials of the client only when the client establishes a relationship with the server.
	/// </summary>
	/// <remarks>
	/// Datagram transports always use <see cref="Packet"/> instead.
	/// </remarks>
	Connect,

	/// <summary>
	/// Authenticates only at the beginning of each remote procedure call when the server receives the request.
	/// </summary>
	/// <remarks>
	/// Datagram transports always use <see cref="Packet"/> instead.
	/// </remarks>
	Call,

	/// <summary>
	/// Authenticates that all data received is from the expected client.
	/// </summary>
	Packet,

	/// <summary>
	/// Authenticates and verifies that none of the data transferred between client and server has been modified.
	/// </summary>
	PacketIntegrity,

	/// <summary>
	/// Authenticates all previous levels and encrypts the argument value of each remote procedure call.
	/// </summary>
	PacketPrivacy
}
