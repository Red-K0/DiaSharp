namespace DiaSharp.StackWalk;

[Guid("8222C490-507B-4BEF-B3BD-41DCA7B5934C")]
public partial interface IStackWalkHelper2 : IStackWalkHelper
{
	int GetPointerAuthenticationMask(ulong pointerValue, out ulong mask);
}
