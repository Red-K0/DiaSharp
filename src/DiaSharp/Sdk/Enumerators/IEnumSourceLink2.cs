namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumSourceLink2 : IEnumSourceLink
{
	int SizeOfNext(out ulong size);

	unsafe int GetNext(ulong bufferSize, out ulong bytesWritten, byte* buffer);
}
