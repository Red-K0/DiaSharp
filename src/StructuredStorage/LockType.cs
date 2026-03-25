namespace DiaSharp.StructuredStorage;

/// <summary>
/// Indicates the type of locking requested for the specified range of bytes.
/// </summary>
public enum LockType
{
	/// <summary>
	/// If this lock is granted, the specified range of bytes can be opened and read any number of times, but writing to the locked range is prohibited except for the owner that was granted this lock.
	/// </summary>
	Write,

	/// <summary>
	/// If this lock is granted, writing to the specified range of bytes is prohibited except by the owner that was granted this lock.
	/// </summary>
	Exclusive,

	/// <summary>
	/// If this lock is granted, no other <see cref="OnlyOnce"/> lock can be obtained on the range.
	/// </summary>
	/// <remarks>
	/// Usually this lock type is an alias for some other lock type. Thus, specific implementations can have additional behavior associated with this lock type.
	/// </remarks>
	OnlyOnce
}
