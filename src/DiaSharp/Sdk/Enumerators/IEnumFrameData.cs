using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

[Guid("9FC77A4B-3C1C-44ed-A798-6C1DEEA53E1F")]
public partial interface IEnumFrameData
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int Item(uint index, out IFrameData frameData);

	unsafe int GetNext(uint frameCount, void** frames, out uint framesFetched);

	int Skip(uint dataCount);

	int Reset();

	int Clone(out IEnumFrameData enumerator);

	int FrameByRVA(uint relativeVirtualAddress, out IFrameData frameData);

	int FrameByVA(ulong virtualAddress, out IFrameData frameData);
}
