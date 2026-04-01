namespace DiaSharp.COM.Exceptions;

public sealed class AggregateUnsupportedException(Guid classID, Type? requestedInterface) : COMException(CreateMessage(classID, requestedInterface), HResultValue)
{
	public Guid ClassID { get; } = classID;

	public Type? RequestedInterface { get; } = requestedInterface;

	public const int HResultValue = unchecked((int)0x80040110);

	private static string CreateMessage(Guid classID, Type? type)
	{
		string typeName = type is null ? "Unknown interface" : type.FullName!;

		return $"The COM class \"{classID}\" ({typeName}) cannot be created as part of an aggregate.";
	}
}
