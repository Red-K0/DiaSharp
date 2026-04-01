using DiaSharp.StackWalk;

namespace DiaSharp.SDK.Enumerators;

[GeneratedComInterface]
[Guid("EC9D461D-CE74-4711-A020-7D8F9A1DD255")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumStackFrames
{
	uint GetNext(uint frameCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out IStackFrame[] frames);

	void Reset();
}
