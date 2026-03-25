using System.ComponentModel;

namespace DiaSharp.StructuredStorage;

/// <summary>
/// Indicates whether the method should try to return a name in <see cref="StatsTag.Name"/>.
/// </summary>
/// <remarks>
/// The values are used in <see cref="IStream.Stat(out StatsTag, StatFlag)"/> to save memory when <see cref="StatsTag.Name"/> is not required.
/// </remarks>
public enum StatFlag
{
	/// <summary>
	/// Requests that the statistics include <see cref="StatsTag.Name"/>.
	/// </summary>
	Default,

	/// <summary>
	/// Requests that the statistics not include <see cref="StatsTag.Name"/>.
	/// </summary>
	/// <remarks>
	/// If the name is omitted, there is no need for the <see cref="IStream.Stat(out StatsTag, StatFlag)"/> methods to allocate and free memory for the string value of the name.
	/// This reduces time and resources used in an allocation and free operation.
	/// </remarks>
	NoName,

	/// <summary>
	/// Not implemented.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	NoOpen
}
