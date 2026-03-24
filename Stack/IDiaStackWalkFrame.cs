using System.Runtime.InteropServices.Marshalling;
using DiaSharp.CodeView;
using DiaSharp.Enums;

namespace DiaSharp.Stack;

[GeneratedComInterface]
[Guid("07C590C1-438D-4F47-BDCD-4397BC81AD75")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaStackWalkFrame
{
	ulong get_registerValue(HostRegister index);

	void put_registerValue(HostRegister index, ulong value);

	[return: MarshalUsing(CountElementName = nameof(bytesRequested))]
	byte[] readMemory(MemoryType type, ulong va, uint bytesRequested, out uint bytesWritten);

	ulong searchForReturnAddress(IDiaFrameData frame);

	ulong searchForReturnAddressStart(IDiaFrameData frame, ulong startAddress);
}
