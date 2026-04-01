namespace DiaSharp.COM;

/// <summary>
/// Contains a user name and password.
/// </summary>
/// <remarks>
/// COM does not persist the user's password information.
/// For applications that use passwords, please see the documentation on <see href="https://learn.microsoft.com/en-us/windows/win32/seccrypto/cryptography-portal">Cryptography</see> (CryptoAPI).
/// </remarks>
public unsafe struct AuthenticationIdentity
{
	/// <summary>
	/// The user's name.
	/// </summary>
	public char* User;

	/// <summary>
	/// The length of <see cref="User"/>, without the terminating NULL.
	/// </summary>
	public uint UserLength;

	/// <summary>
	/// The domain or workgroup name.
	/// </summary>
	public char* Domain;

	/// <summary>
	/// The length of <see cref="Domain"/>, without the terminating NULL.
	/// </summary>
	public uint DomainLength;

	/// <summary>
	/// The user's password in the domain or workgroup.
	/// </summary>
	public char* Password;

	/// <summary>
	/// The length of <see cref="Password"/>, without the terminating NULL.
	/// </summary>
	public uint PasswordLength;

	/// <summary>
	/// Indicates whether the provided strings are Unicode strings.
	/// </summary>
	public IdentityFlags Flags;
}
