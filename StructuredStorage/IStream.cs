using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.StructuredStorage;

[GeneratedComInterface]
[Guid("0000000C-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IStream : ISequentialStream
{
	new void Read(out byte value, uint byteCount, out uint bytesRead);

	new void Write(ref byte value, uint byteCount, out uint bytesWritten);

	void Seek(long offset, SeekType origin, out ulong newPosition);

	void SetSize(ulong newSize);

	void CopyTo(IStream stream, ulong byteCount, out ulong bytesRead, out ulong bytesWritten);

	void Commit(CommitFlags flags);

	void Revert();

	void LockRegion(ulong offset, ulong byteCount, LockType lockType);

	void UnlockRegion(ulong offset, ulong byteCount, LockType lockType);

	void Stat(out StatsTag tag, StatFlag flag);

	void Clone(out IStream stream);
}
