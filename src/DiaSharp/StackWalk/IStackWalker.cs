using DiaSharp.CodeView;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.StackWalk;

public partial interface IStackWalker
{
	int GetEnumFrames(IStackWalkHelper helper, out IEnumStackFrames frames);

	int GetEnumFrames(CpuType cpuType, IStackWalkHelper helper, out IEnumStackFrames frames);
}
