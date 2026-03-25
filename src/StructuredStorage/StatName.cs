using System.ComponentModel;

namespace DiaSharp.StructuredStorage;

/// <summary>
/// Indicates whether the method should try to return a name in <see cref="StatStorage.Name"/>.
/// </summary>
/// <remarks>
/// The values are used in <see cref="IStream.Stat(out StatStorage, StatName)"/> to save memory when <see cref="StatStorage.Name"/> is not required.
/// </remarks>
public enum StatName
{
	/// <summary>
	/// Requests that the statistics include <see cref="StatStorage.Name"/>.
	/// </summary>
	Include,

	/// <summary>
	/// Requests that the statistics not include <see cref="StatStorage.Name"/>.
	/// </summary>
	/// <remarks>
	/// If the name is omitted, there is no need for the <see cref="IStream.Stat(out StatStorage, StatName)"/> methods to allocate and free memory for the string value of the name.
	/// This reduces time and resources used in an allocation and free operation.
	/// </remarks>
	Omit,

	/// <summary>
	/// Not implemented.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	NoOpen
}
