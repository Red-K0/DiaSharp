namespace DiaSharp.COM.Exceptions;

#pragma warning disable CA1032
public sealed class ClassNotRegisteredException(Guid classID, Type? requestedInterface, ClassContext classContext) : COMException(CreateMessage(classID, requestedInterface, classContext), HResultValue)
{
	public Guid ClassID { get; } = classID;

	public Type? RequestedInterface { get; } = requestedInterface;

	public ClassContext ClassContext { get; } = classContext;

	public const int HResultValue = unchecked((int)0x80040154);

	private static string CreateMessage(Guid classID, Type? type, ClassContext context)
	{
		string typeName = type is null ? "Unknown interface" : type.FullName!;

		return $"""
				COM class "{classID}" is not registered for activation.
				Requested interface: "{typeName}".
				ClassContext: "{context}".
				""";

	}
}
#pragma warning restore CA1032