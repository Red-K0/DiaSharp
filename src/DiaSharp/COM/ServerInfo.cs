namespace DiaSharp.COM;

/// <summary>
///		Identifies a remote computer resource to the activation functions.
/// </summary>
/// <remarks>
/// <para>
///		This structure is used primarily to identify a remote system in object creation functions, resources are named using the naming scheme of the network transport.
///		By default, all UNC and DNS names are allowed.
/// </para>
/// <para>
///		If <see cref="AuthenticationInfo"/> is <see langword="null"/>, <see href="https://learn.microsoft.com/en-us/windows/win32/com/snego">Snego</see> will be used to negotiate a compatible service.
///		However, a non-<see langword="null"/> structure can be specified for <see cref="AuthenticationInfo"/> to meet any one of the following needs:
///		<list type="bullet">
///			<item> To specify a different client identity for remote activations. The specified identity will be used for the launch permission check on the server rather than the real client identity. </item>
///			<item> To specify that Kerberos, rather than NTLMSSP, is used for machine remote activation. A non-default client identity may or may not be specified. </item>
///			<item> To request unsecure activation. </item>
///			<item> To specify a proprietary authentication service. </item>
///		</list>
///		If <see cref="AuthenticationInfo"/> is not <see langword="null"/>, those values will be used to specify the authentication settings for the remote call.
///		These settings will be passed to the <c>RpcBindingSetAuthInfoEx</c> function.
/// </para>
/// <para>
///		If the <see cref="AuthenticationInfo"/> parameter is <see langword="null"/>, then <see cref="AuthenticationInfo.AuthenticationLevel"/> can be overridden.
///		The overriding value is either:
///		<list type="bullet">
///			<item> The authentication level set by the <c>CoInitializeSecurity</c> function, if called. This is typically called at some point by the .NET runtime, outside of application code. </item>
///			<item> The authentication level specified under the AppID registry key, if it exists. </item>
///		</list>
/// </para>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct ServerInfo(char* name, AuthenticationInfo info) : IEquatable<ServerInfo>
{
	private readonly uint _reserved1;

	/// <summary>
	/// The name of the computer.
	/// </summary>
	public readonly char* Name = name;

	/// <summary>
	/// A pointer to a <see cref="AuthenticationInfo"/> structure to override the default activation security for machine remote activations.
	/// </summary>
	/// <remarks>
	/// If set to <see langword="null"/>, indicates that default values should be used.
	/// </remarks>
	public readonly AuthenticationInfo AuthenticationInfo = info;

	private readonly uint _reserved2;

	public override readonly bool Equals(object? obj) => obj is ServerInfo info && this == info;

	public override readonly int GetHashCode() => Extensions.GetHashCode(in this);

	public static bool operator ==(ServerInfo left, ServerInfo right)
	{
		return Extensions.ValueEquals(&left, &right);
	}

	public static bool operator !=(ServerInfo left, ServerInfo right)
	{
		return !Extensions.ValueEquals(&left, &right);
	}

	public readonly bool Equals(ServerInfo other) => this == other;
}
