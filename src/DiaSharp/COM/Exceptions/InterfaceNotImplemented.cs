namespace DiaSharp.COM.Exceptions;

#pragma warning disable CA1032
public sealed class InterfaceNotImplementedException(Guid classId, Type requestedInterface) : COMException(CreateMessage(classId, requestedInterface), HResultValue)
{
	public Guid ClassId { get; } = classId;

	public Type RequestedInterface { get; } = requestedInterface;

	public const int HResultValue = unchecked((int)0x80004002);

	private static string CreateMessage(Guid clsid, Type type) => $"E_NOINTERFACE (0x80004002). COM class {clsid} does not implement the requested interface {type.FullName}.";
}
#pragma warning restore CA1032