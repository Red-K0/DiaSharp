namespace DiaSharp.Storage;

#pragma warning disable CA1711

[Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
public partial interface ISequentialStream
{
	unsafe int Read(byte* buffer, uint byteCount, out uint bytesRead);

	unsafe int Write(byte* buffer, uint byteCount, out uint bytesWritten);
}

#pragma warning restore CA1711s