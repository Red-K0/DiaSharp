namespace DiaSharp.SDK;

[Guid("AE605CDC-8105-4A23-B710-3259F1E26112")]
public partial interface IInjectedSource
{
	int GetCRC(out uint crc);

	int GetLength(out ulong length);

	int GetFilename([MarshalAs(UnmanagedType.BStr)] out string name);

	int GetObjectFilename([MarshalAs(UnmanagedType.BStr)] out string name);

	int GetVirtualFilename([MarshalAs(UnmanagedType.BStr)] out string name);

	int GetSourceCompression(out uint compression);

	unsafe int GetSource(uint dataSize, out uint bytesWritten, byte* buffer);
}
