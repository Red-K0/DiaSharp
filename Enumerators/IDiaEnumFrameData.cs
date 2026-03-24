using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("9FC77A4B-3C1C-44ed-A798-6C1DEEA53E1F")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumFrameData
{
	IEnumVARIANT get__NewEnum();

	[DispId(1)]
	int get_Count();

	IDiaFrameData Item(uint index);

	uint Next(uint celt, [MarshalUsing(CountElementName = nameof(celt))] out IDiaFrameData[] rgelt);

	void Skip(uint celt);

	void Reset();

	IDiaEnumFrameData Clone();

	IDiaFrameData frameByRVA(uint relativeVirtualAddress);

	IDiaFrameData frameByVA(ulong virtualAddress);
}
