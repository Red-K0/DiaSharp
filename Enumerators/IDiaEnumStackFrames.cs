using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Stack;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("EC9D461D-CE74-4711-A020-7D8F9A1DD255")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumStackFrames
{
	uint Next(uint elementCount, [MarshalUsing(CountElementName = nameof(elementCount))] out IDiaStackFrame[] elements);

	void Reset();
}
