using System.ComponentModel;

namespace DiaSharp.StructuredStorage;

/// <summary>
/// Contains statistical data about an open storage, stream, or byte-array object. This structure is used in the <see cref="IStream"/> interface.
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 8)]
public unsafe struct StatStorage : IEquatable<StatStorage>
{
	/// <summary>
	/// A pointer to a null-terminated Unicode string that contains the name. Space for this string is allocated by the method called and freed by the caller (for more information, see <see cref="Marshal.FreeCoTaskMem(nint)"/>).
	/// </summary>
	/// <remarks>
	/// To not return this member, specify the <see cref="StatName.Omit"/> value when you call <see cref="IStream.Stat(out StatStorage, StatName)"/>.
	/// </remarks>
	public char* Name;

	/// <summary>
	/// Indicates the type of storage object.
	/// </summary>
	public StorageType Type;

	/// <summary>
	/// Specifies the size, in bytes, of the stream or byte array.
	/// </summary>
	public ulong Size;

	/// <summary>
	/// Indicates the last modification time for this storage, stream, or byte array.
	/// </summary>
	public ulong LastModifiedAt;

	/// <summary>
	/// Indicates the creation time for this storage, stream, or byte array.
	/// </summary>
	public ulong CreatedAt;

	/// <summary>
	/// Indicates the last access time for this storage, stream, or byte array.
	/// </summary>
	public ulong LastAccessedAt;

	/// <summary>
	/// Indicates the access mode specified when the object was opened.
	/// </summary>
	/// <remarks>
	/// This member is only valid in calls to Stat methods.
	/// </remarks>
	public AccessMode AccessMode;

	/// <summary>
	/// Indicates the types of region locking supported by the stream or byte array.
	/// </summary>
	/// <remarks>
	/// This member is not used for storage objects.
	/// </remarks>
	public LockType LocksSupported;

	/// <summary>
	/// Indicates the class identifier for the storage object; set to <see cref="Guid.Empty"/> for new storage objects.
	/// </summary>
	/// <remarks>
	/// This member is not used for streams or byte arrays.
	/// </remarks>
	public Guid ClassID;

	/// <summary>
	/// Indicates the current state bits of the storage object; that is, the value most recently set by the Win32 <c>IStorage::SetStateBits</c> method.
	/// </summary>
	/// <remarks>
	/// This member is not valid for streams or byte arrays.
	/// </remarks>
	public uint StateBits;

	/// <summary>
	/// Reserved for future use.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public uint reserved;

	public override readonly bool Equals(object? obj) => obj is StatStorage storage && this == storage;

	public override int GetHashCode()
	{
		HashCode code = new();

		fixed (StatStorage* storage = &this) code.AddBytes(new(storage, sizeof(StatStorage)));

		return code.ToHashCode();
	}

	public static bool operator ==(StatStorage left, StatStorage right)
	{
		return new ReadOnlySpan<byte>(&left, sizeof(StatStorage)) == new ReadOnlySpan<byte>(&right, sizeof(StatStorage));
	}

	public static bool operator !=(StatStorage left, StatStorage right)
	{
		return new ReadOnlySpan<byte>(&left, sizeof(StatStorage)) != new ReadOnlySpan<byte>(&right, sizeof(StatStorage));
	}

	public readonly bool Equals(StatStorage other) => this == other;

}
