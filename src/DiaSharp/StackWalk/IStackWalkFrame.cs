using DiaSharp.CodeView;
using DiaSharp.SDK;
using DiaSharp.Native;

namespace DiaSharp.StackWalk;

[GeneratedComInterface]
[Guid("07C590C1-438D-4F47-BDCD-4397BC81AD75")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IStackWalkFrame
{
	ulong GetRegisterValue(HostRegister index);

	void PutRegisterValue(HostRegister index, ulong value);

	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] ReadMemory(MemoryType type, ulong virtualAddress, uint bytesRequested, out uint bytesWritten);

	ulong SearchForReturnAddress(IFrameData frame);

	ulong SearchForReturnAddressStart(IFrameData frame, ulong startAddress);
}
