using System.Runtime.InteropServices.Marshalling;
using DiaSharp.CodeView;
using DiaSharp.Enums;
using DiaSharp.Symbols;

namespace DiaSharp.Stack;

[GeneratedComInterface]
[Guid("21F81B1B-C5BB-42A3-BC4F-CCBAA75B9F19")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaStackWalkHelper
{
	ulong get_registerValue(HostRegister index);

	void put_registerValue(HostRegister index, ulong value);

	[return: MarshalUsing(CountElementName = nameof(bytesRequested))]
	byte[] readMemory(MemoryType type, ulong va, uint bytesRequested, out uint bytesWritten);

	ulong searchForReturnAddress(IDiaFrameData frame);

	ulong searchForReturnAddressStart(IDiaFrameData frame, ulong startAddress);

	IDiaFrameData frameForVA(ulong va);

	IDiaSymbol symbolForVA(ulong va);

	[return: MarshalUsing(CountElementName = nameof(bytesRequested))]
	byte[] pdataForVA(ulong va, uint bytesRequested, out uint bytesWritten);

	ulong imageForVA(ulong vaContext);

	void addressForVA(ulong va, out uint pISect, out uint pOffset);

	uint numberOfFunctionFragmentsForVA(ulong functionRVA, uint functionSize);

	void functionFragmentsForVA(
		ulong functionRVA,
		uint functionSize,
		uint fragmentCount,
		[MarshalUsing(CountElementName = nameof(fragmentCount))] out ulong[] fragments,
		[MarshalUsing(CountElementName = nameof(fragmentCount))] out uint[] fragmentLengths
	);
}
