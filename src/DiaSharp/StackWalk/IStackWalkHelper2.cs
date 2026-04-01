namespace DiaSharp.StackWalk;

[GeneratedComInterface]
[Guid("8222c490-507b-4bef-b3bd-41dca7b5934c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IStackWalkHelper2 : IStackWalkHelper
{
	ulong GetPointerAuthenticationMask(ulong pointerValue);
}
