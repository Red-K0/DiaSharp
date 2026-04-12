using DiaSharp.CodeView;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.StackWalk;

[Guid("5485216B-A54C-469F-9670-52B24D5229BB")]
public partial interface IStackWalker
{
	int GetEnumFrames(IStackWalkHelper helper, out IEnumStackFrames frames);

	int GetEnumFrames(CpuType cpuType, IStackWalkHelper helper, out IEnumStackFrames frames);
}
