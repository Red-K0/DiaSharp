namespace DiaSharp.SDK.Enumerators;

[Guid("136D8151-ADE7-4704-AF13-324080762E8F")]
public partial interface IEnumSourceLink2 : IEnumSourceLink
{
	int SizeOfNext(out ulong size);

	unsafe int GetNext(ulong bufferSize, out ulong bytesWritten, byte* buffer);
}
