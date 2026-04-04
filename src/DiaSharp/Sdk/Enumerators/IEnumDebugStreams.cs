using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumDebugStreams
{
	void GetNewEnum(out IEnumVARIANT enumerator);

	void GetCount(out int count);

	void Item(uint index, out IEnumDebugStreamData data);

	unsafe void GetNext(uint streamCount, void** streams, out uint streamsFetched);

	void Skip(uint streamCount);

	void Reset();

	void Clone(out IEnumSymbolsByAddress enumerator);
}
