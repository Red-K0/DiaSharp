namespace DiaSharp.Storage;

#pragma warning disable CA1711

public partial interface ISequentialStream
{
	int Read(out byte value, uint byteCount, out uint bytesRead);

	int Write(ref byte value, uint byteCount, out uint bytesWritten);
}

#pragma warning restore CA1711s