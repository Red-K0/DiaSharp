using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("9FC77A4B-3C1C-44ed-A798-6C1DEEA53E1F")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumFrameData
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	IFrameData Item(uint index);

	uint Next(uint dataCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out IFrameData[] frameDatas);

	void Skip(uint dataCount);

	void Reset();

	IEnumFrameData Clone();

	IFrameData FrameByRVA(uint relativeVirtualAddress);

	IFrameData FrameByVA(ulong virtualAddress);
}
