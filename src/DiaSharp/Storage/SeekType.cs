namespace DiaSharp.Storage;

/// <summary>
/// Specifies the origin from which to calculate the new seek-pointer location, in <see cref="IStream.Seek(long, DiaSharp.Storage.SeekType, out ulong)"/>.
/// The new seek position is calculated using this value and the offset parameter.
/// </summary>
public enum SeekType
{
	/// <summary>
	/// The new seek pointer is an offset relative to the beginning of the stream.
	/// </summary>
	/// <remarks>
	/// In this case, the offset parameter is the new seek position relative to the beginning of the stream.
	/// </remarks>
	Start,

	/// <summary>
	/// The new seek pointer is an offset relative to the current seek pointer location.
	/// </summary>
	/// <remarks>
	/// In this case, the pffset parameter is the signed displacement from the current seek position.
	/// </remarks>
	Current,

	/// <summary>
	/// The new seek pointer is an offset relative to the end of the stream.
	/// </summary>
	/// <remarks>
	/// In this case, the offset parameter is the new seek position relative to the end of the stream.
	/// </remarks>
	End
}
