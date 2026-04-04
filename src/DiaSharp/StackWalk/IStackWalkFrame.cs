using DiaSharp.CodeView;
using DiaSharp.SDK;
using DiaSharp.Native;

namespace DiaSharp.StackWalk;

public partial interface IStackWalkFrame
{
	int GetRegisterValue(HostRegister index, out ulong value);

	int PutRegisterValue(HostRegister index, ulong value);

	unsafe int ReadMemory(MemoryType type, ulong virtualAddress, uint bytesRequested, out uint bytesWritten, byte* buffer);

	int SearchForReturnAddress(IFrameData frame, out ulong address);

	int SearchForReturnAddressStart(IFrameData frame, ulong address, out ulong start);
}
