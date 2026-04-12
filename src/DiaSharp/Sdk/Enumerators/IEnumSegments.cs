using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumSegments
{
	int GetNewEnum( out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int Item(uint index, out ISegment segment);

	unsafe int GetNext(uint segmentCount, void** segments, out uint segmentsFetched);

	int Skip(uint segmentCount);

	int Reset();

	int Clone(out IEnumSegments enumerator);
}
