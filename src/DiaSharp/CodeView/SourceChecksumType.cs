namespace DiaSharp.CodeView;

/// <summary>
/// Specifies the type of source code checksum.
/// </summary>
public enum SourceChecksumType
{
	/// <summary>
	/// No source checksum available.
	/// </summary>
	None,

	/// <summary>
	/// Checksum generated with the MD5 hashing algorithm.
	/// </summary>
	MD5,

	/// <summary>
	/// Checksum generated with the SHA1 hashing algorithm.
	/// </summary>
	SHA1,

	/// <summary>
	/// Checksum generated with the 256-bit SHA hashing algorithm.
	/// </summary>
	SHA256
}
