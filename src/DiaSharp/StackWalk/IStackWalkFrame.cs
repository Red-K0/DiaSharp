using DiaSharp.CodeView;
using DiaSharp.SDK;
using DiaSharp.Native;

namespace DiaSharp.StackWalk;

[Guid("07C590C1-438D-4F47-BDCD-4397BC81AD75")]
public partial interface IStackWalkFrame
{
	int GetRegisterValue(HostRegister index, out ulong value);

	int PutRegisterValue(HostRegister index, ulong value);

	unsafe int ReadMemory(MemoryType type, ulong virtualAddress, uint bytesRequested, out uint bytesWritten, byte* buffer);

	int SearchForReturnAddress(IFrameData frame, out ulong address);

	int SearchForReturnAddressStart(IFrameData frame, ulong address, out ulong start);
}
