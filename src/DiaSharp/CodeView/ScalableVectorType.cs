namespace DiaSharp.CodeView;

/// <summary>
/// Defines types of scalable vector registers used in the ARM Scalable Vector Extension (SVE) architecture.
/// These registers enable advanced SIMD operations for high-performance computing on ARM processors.
/// </summary>
/// <remarks>
/// The <see cref="ScalableVectorType"/> enumeration defines the types of scalable vector registers used in ARM Scalable Vector Extension (SVE) architecture.
/// These registers are utilized for advanced SIMD operations in modern ARM processors.
/// </remarks>
public enum ScalableVectorType
{
	/// <summary>
	/// Not a scalable vector type.
	/// </summary>
	None,

	/// <summary>
	/// Represents a scalable vector Z data register (SVE_Z).
	/// </summary>
	Z,

	/// <summary>
	/// Represents a scalable vector predicate register (SVE_P).
	/// </summary>
	P
}
