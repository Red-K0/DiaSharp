using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumDebugStreams
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int Item(uint index, out IEnumDebugStreamData data);

	unsafe int GetNext(uint streamCount, void** streams, out uint streamsFetched);

	int Skip(uint streamCount);

	int Reset();

	int Clone(out IEnumSymbolsByAddress enumerator);
}
