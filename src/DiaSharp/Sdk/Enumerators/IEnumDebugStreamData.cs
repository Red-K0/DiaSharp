using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

[Guid("486943E8-D187-4A6B-A3C4-291259FFF60D")]
public partial interface IEnumDebugStreamData
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int GetName([MarshalAs(UnmanagedType.BStr)] out string name);

	unsafe int Item(uint index, uint bufferSize, uint* bytesWritten, byte* buffer);

	unsafe int GetNext(uint dataCount, uint bufferSize, uint* bytesWritten, byte* dataBuffer, out uint elementsFetched);

	int Skip(uint dataCount);

	int Reset();

	int Clone(out IEnumDebugStreamData enumerator);
}
