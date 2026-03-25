namespace DiaSharp.StructuredStorage;

/// <summary>
/// Used in <see cref="StatStorage.Type"/> to indicate the type of the storage element. A storage element is a storage object, a stream object, or a byte-array object <see cref="LockBytes"/>.
/// </summary>
public enum StorageType
{
	/// <summary>
	/// Indicates that the storage element is a storage object.
	/// </summary>
	Storage,

	/// <summary>
	/// Indicates that the storage element is a stream object.
	/// </summary>
	Stream,

	/// <summary>
	/// Indicates that the storage element is a byte-array object.
	/// </summary>
	LockBytes,

	/// <summary>
	/// Indicates that the storage element is a property storage object.
	/// </summary>
	Property
}
