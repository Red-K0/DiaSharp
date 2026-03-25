using System.Runtime.InteropServices.Marshalling;
using DiaSharp.CodeView;
using DiaSharp.Sdk.Enumerators;

namespace DiaSharp.StackWalk;

[GeneratedComInterface]
[Guid("5485216B-A54C-469F-9670-52B24D5229BB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IStackWalker
{
	IEnumStackFrames GetEnumFrames(IStackWalkHelper helper);

	IEnumStackFrames GetEnumFrames(CpuType cpuType, IStackWalkHelper helper);
}
