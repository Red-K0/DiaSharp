namespace DiaSharp.Storage;

#pragma warning disable CA1711

public partial interface IStream : ISequentialStream
{
	int Seek(long offset, SeekType origin, out ulong newPosition);

	int SetSize(ulong newSize);

	int CopyTo(IStream stream, ulong byteCount, out ulong bytesRead, out ulong newPosition);

	int Commit(CommitFlags flags);

	int Revert();

	int LockRegion(ulong offset, ulong byteCount, LockType lsockType);

	int UnlockRegion(ulong offset, ulong byteCount, LockType lockType);

	int Stat(out StatStorage tag, StatName flag);

	int Clone(out IStream stream);
}

#pragma warning restore CA1711