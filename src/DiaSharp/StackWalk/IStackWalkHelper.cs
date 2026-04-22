using DiaSharp.CodeView;
using DiaSharp.SDK;
using DiaSharp.SDK.Symbols;
using DiaSharp.Native;

namespace DiaSharp.StackWalk;

[Guid("21F81B1B-C5BB-42A3-BC4F-CCBAA75B9F19")]
public partial interface IStackWalkHelper
{
	int GetRegisterValue(HostRegister index, out ulong value);

	int PutRegisterValue(HostRegister index, ulong value);

	unsafe int ReadMemory(MemoryType type, ulong virtualAddress, uint bufferSize, out uint bytesWritten, byte* buffer);

	int SearchForReturnAddress(IFrameData frame, out ulong address);

	int SearchForReturnAddressStart(IFrameData frame, ulong address, out ulong startAddress);

	int GetFrameForVA(ulong virtualAddress, out IFrameData frame);

	int GetSymbolForVA(ulong virtualAddress, out ISymbol symbol);

	unsafe int GetPDataForVA(ulong virtualAddress, uint bytesRequested, out uint bytesWritten, byte* buffer);

	int GetImageForVA(ulong virtualAddressContext, out ulong imageAddress);

	int GetAddressForVA(ulong virtualAddress, out uint equivalentSection, out uint fragmentCount);

	int GetNumberOfFunctionFragmentsForVA(ulong functionAddress, uint functionSize, out uint fragmentCount);

	unsafe int GetFunctionFragmentsForVA(ulong functionAddress, uint functionSize, uint fragmentCount, ulong* fragments, uint* fragmentLengths);
}
