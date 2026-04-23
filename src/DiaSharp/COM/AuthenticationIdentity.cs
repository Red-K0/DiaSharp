namespace DiaSharp.COM;

/// <summary>
/// Contains a user name and password.
/// </summary>
/// <remarks>
/// COM does not persist the user's password information.
/// For applications that use passwords, please see the documentation on <see href="https://learn.microsoft.com/en-us/windows/win32/seccrypto/cryptography-portal">Cryptography</see> (CryptoAPI).
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct AuthenticationIdentity(char* user, uint userLength, char* domain, uint domainLength, char* password, uint passwordLength) : IEquatable<AuthenticationIdentity>
{
	/// <summary>
	/// The user's name.
	/// </summary>
	public readonly char* User = user;

	/// <summary>
	/// The length of <see cref="User"/>, without the terminating NULL.
	/// </summary>
	public readonly uint UserLength = userLength;

	/// <summary>
	/// The domain or workgroup name.
	/// </summary>
	public readonly char* Domain = domain;

	/// <summary>
	/// The length of <see cref="Domain"/>, without the terminating NULL.
	/// </summary>
	public readonly uint DomainLength = domainLength;

	/// <summary>
	/// The user's password in the domain or workgroup.
	/// </summary>
	public readonly char* Password = password;

	/// <summary>
	/// The length of <see cref="Password"/>, without the terminating NULL.
	/// </summary>
	public readonly uint PasswordLength = passwordLength;

	/// <summary>
	/// Indicates whether the provided strings are Unicode strings.
	/// </summary>
	public readonly IdentityFlags Flags = IdentityFlags.Unicode;

	public override readonly bool Equals(object? obj) => obj is AuthenticationIdentity id && this == id;

	public override readonly int GetHashCode() => Extensions.GetHashCode(in this);

	public static bool operator ==(AuthenticationIdentity left, AuthenticationIdentity right)
	{
		return Extensions.ValueEquals(&left, &right);
	}

	public static bool operator !=(AuthenticationIdentity left, AuthenticationIdentity right)
	{
		return !Extensions.ValueEquals(&left, &right);
	}

	public readonly bool Equals(AuthenticationIdentity other) => this == other;
}
