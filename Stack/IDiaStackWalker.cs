using System.Runtime.InteropServices.Marshalling;
using DiaSharp.CodeView;
using DiaSharp.Enumerators;

namespace DiaSharp.Stack;

[GeneratedComInterface]
[Guid("5485216B-A54C-469F-9670-52B24D5229BB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaStackWalker
{
	IDiaEnumStackFrames getEnumFrames(IDiaStackWalkHelper pHelper);

	IDiaEnumStackFrames getEnumFrames2(CpuType cpuid, IDiaStackWalkHelper pHelper);
}
