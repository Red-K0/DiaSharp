namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumSourceLink
{
	int Count(out uint count);

	int SizeOfNext(out uint size);

	unsafe int GetNext(uint bufferSize, out uint bytesWritten, byte* buffer);

	int Skip(uint byteCount);

	int Reset();

	int Clone(out IEnumSourceLink enumerator);
}
