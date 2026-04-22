using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

[Guid("08CBB41E-47A6-4F87-92F1-1C9C87CED044")]
public partial interface IEnumDebugStreams
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int Item(uint index, out IEnumDebugStreamData data);

	unsafe int GetNext(uint streamCount, void** streams, out uint streamsFetched);

	int Skip(uint streamCount);

	int Reset();

	int Clone(out IEnumDebugStreams enumerator);
}
