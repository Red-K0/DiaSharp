namespace DiaSharp.Storage;

public enum AccessMode
{
	/// <summary>
	/// Indicates that the object is read-only, meaning that modifications cannot be made.
	/// For example, the <see cref="ISequentialStream.Read(out byte, uint)"/> method may be called, but the <see cref="ISequentialStream.Write(ref byte, uint)"/> method may not.
	/// </summary>
	Read,

	/// <summary>
	/// Enables you to save changes to the object, but does not permit access to its data.
	/// </summary>
	Write,

	/// <summary>
	/// Enables access and modification of object data.
	/// For example, it is possible to call both <see cref="IStream.Read(out byte, uint)"/> and <see cref="IStream.Write(ref byte, uint)"/>.
	/// </summary>
	/// <remarks>
	/// Be aware that this constant is not a simple binary OR operation of the <see cref="Read"/> and <see cref="Write"/> elements.
	/// </remarks>
	ReadWrite
}
