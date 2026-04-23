namespace DiaSharp.COM;

/// <summary>
/// Contains the authentication settings used while making a remote activation request from the client computer to the server computer.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct AuthenticationInfo : IEquatable<AuthenticationInfo>
{
	/// <summary>
	/// The authentication service to be used, defaults to <see cref="Authentication.WinNT"/>.
	/// </summary>
	public Authentication AuthenticationService;

	/// <summary>
	/// The authorization service to be used.To use the NT authentication service, specify <see cref="Authorization.None"/>.
	/// </summary>
	public Authorization AuthorizationService;

	/// <summary>
	/// The server principal name to use with the authentication service. If you are using <see cref="Authentication.WinNT"/>, the principal name must be <see langword="null"/>.
	/// </summary>
	public char* ServerPrincipalName;

	/// <summary>
	/// The authentication level to be used.
	/// </summary>
	public AuthenticationLevel AuthenticationLevel;

	/// <summary>
	/// The impersonation level to be used. This value must be <see cref="ImpersonationLevel.Impersonate"/> or above.
	/// </summary>
	public ImpersonationLevel ImpersonationLevel;

	/// <summary>
	/// A pointer to a <see cref="AuthenticationIdentity"/> structure that establishes a nondefault client identity.
	/// </summary>
	/// <remarks>
	/// <para> If set to <see langword="null"/>, the actual identity of the client is used. Values of structure members are authentication-service specific. </para>
	/// <para> This value must be <see langword="null"/> if neither <see cref="Authentication.WinNT"/> or <see cref="Authentication.GssKerberos"/> are specified as the authorization service. </para>
	/// </remarks>
	public AuthenticationIdentity* AuthenticationIdentityData;

	/// <summary>
	/// Emulates the underlying <c>dwCapabilities</c> field, due to inherent <see langword="bool"/> behaviour. Must be set to <see langword="true"/> if Kerberos is required.
	/// </summary>
	public bool KerberosMutualAuth;

	public override readonly bool Equals(object? obj) => obj is AuthenticationInfo info && this == info;

	public override readonly int GetHashCode() => Extensions.GetHashCode(in this);

	public static bool operator ==(AuthenticationInfo left, AuthenticationInfo right)
	{
		return Extensions.ValueEquals(&left, &right);
	}

	public static bool operator !=(AuthenticationInfo left, AuthenticationInfo right)
	{
		return !Extensions.ValueEquals(&left, &right);
	}

	public readonly bool Equals(AuthenticationInfo other) => this == other;
}
