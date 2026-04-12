namespace DiaSharp.SDK.Enumerators;

[Guid("45CD1EB3-5C6C-43E3-B20A-A4D8035DE4E2")]
public partial interface IEnumSourceLink
{
	int Count(out uint count);

	int SizeOfNext(out uint size);

	unsafe int GetNext(uint bufferSize, out uint bytesWritten, byte* buffer);

	int Skip(uint byteCount);

	int Reset();

	int Clone(out IEnumSourceLink enumerator);
}
