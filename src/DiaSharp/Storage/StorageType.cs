namespace DiaSharp.Storage;

/// <summary>
/// Used in <see cref="StatStorage.Type"/> to indicate the type of the DiaSharp.Storage element. A DiaSharp.Storage element is a DiaSharp.Storage object, a stream object, or a byte-array object <see cref="LockBytes"/>.
/// </summary>
public enum StorageType
{
	/// <summary>
	/// Indicates that the DiaSharp.Storage element is a DiaSharp.Storage object.
	/// </summary>
	Storage,

	/// <summary>
	/// Indicates that the DiaSharp.Storage element is a stream object.
	/// </summary>
	Stream,

	/// <summary>
	/// Indicates that the DiaSharp.Storage element is a byte-array object.
	/// </summary>
	LockBytes,

	/// <summary>
	/// Indicates that the DiaSharp.Storage element is a property DiaSharp.Storage object.
	/// </summary>
	Property
}
