using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.StructuredStorage;

#pragma warning disable CA1711

[GeneratedComInterface]
[Guid("0000000C-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IStream : ISequentialStream
{
	ulong Seek(long offset, SeekType origin);

	void SetSize(ulong newSize);

	ulong CopyTo(IStream stream, ulong byteCount, out ulong bytesRead);

	void Commit(CommitFlags flags);

	void Revert();

	void LockRegion(ulong offset, ulong byteCount, LockType lockType);

	void UnlockRegion(ulong offset, ulong byteCount, LockType lockType);

	void Stat(out StatStorage tag, StatName flag);

	void Clone(out IStream stream);
}

#pragma warning restore CA1711