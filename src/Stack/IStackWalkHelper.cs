using System.Runtime.InteropServices.Marshalling;
using DiaSharp.CodeView;
using DiaSharp.Enums;
using DiaSharp.Symbols;

namespace DiaSharp.Stack;

[GeneratedComInterface]
[Guid("21F81B1B-C5BB-42A3-BC4F-CCBAA75B9F19")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IStackWalkHelper
{
	ulong GetRegisterValue(HostRegister index);

	void PutRegisterValue(HostRegister index, ulong value);

	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] ReadMemory(MemoryType type, ulong virtualAddress, uint bufferSize, out uint bytesWritten);

	ulong SearchForReturnAddress(IFrameData frame);

	ulong SearchForReturnAddressStart(IFrameData frame, ulong startAddress);

	IFrameData GetFrameForVA(ulong va);

	ISymbol GetSymbolForVA(ulong va);

	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] GetPDataForVA(ulong virtualAddress, uint bytesRequested, out uint bytesWritten);

	ulong GetImageForVA(ulong virtualAddressContext);

	uint GetAddressForVA(ulong virtualAddress, out uint equivalentSection);

	uint GetNumberOfFunctionFragmentsForVA(ulong functionAddress, uint functionSize);

	void GetFunctionFragmentsForVA(
		ulong functionAddress,
		uint functionSize,
		uint fragmentCount,
		[MarshalUsing(CountElementName = nameof(fragmentCount))] out ulong[] fragments,
		[MarshalUsing(CountElementName = nameof(fragmentCount))] out uint[] fragmentLengths
	);
}
