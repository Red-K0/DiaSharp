namespace DiaSharp.COM;

/// <summary>
/// Represents an interface in a query for multiple interfaces.
/// </summary>
/// <remarks>
/// <para>
/// To optimize network performance, most remote activation functions take an array of <see cref="MultiQueryInterface"/> structures, rather than a single IID and output pointer.
/// This allows a set of pointers to interfaces to be returned from the same object in a single round-trip to the server.
/// </para>
/// <para>
/// In network scenarios, requesting multiple interfaces at the time of object construction can save considerable time over using a number of calls to QueryInterface for unique interfaces.
/// Each call would otherwise require a round-trip to the server.
/// </para>
/// </remarks>
public unsafe struct MultiQueryInterface
{
	/// <summary>
	/// A pointer to an interface identifier.
	/// </summary>
	public readonly Guid* InterfaceID;

	/// <summary>
	/// A pointer to the interface requested in <see cref="InterfaceID"/>. This member must be <see langword="null"/> on input.
	/// </summary>
	public void* InterfacePointer;

	/// <summary>
	/// The return value of the QueryInterface call to locate the requested interface. This member must be 0 on input.
	/// </summary>
	public uint HResult;
}
