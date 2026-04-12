namespace DiaSharp.StackWalk;

public partial interface IStackWalkHelper2 : IStackWalkHelper
{
	int GetPointerAuthenticationMask(ulong pointerValue, out ulong mask);
}
