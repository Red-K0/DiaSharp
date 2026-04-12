namespace DiaSharp.Storage;

#pragma warning disable CA1711

public partial interface ISequentialStream
{
	unsafe int Read(byte* buffer, uint byteCount, out uint bytesRead);

	unsafe int Write(byte* buffer, uint byteCount, out uint bytesWritten);
}

#pragma warning restore CA1711s