#pragma warning disable CA1031

using DiaSharp.Storage;

namespace DiaSharp.COM;

sealed internal class ComStream : IStream
{
	public ComStream(Stream stream)
	{
		ArgumentNullException.ThrowIfNull(stream);

		_stream = stream;
	}

	private readonly Stream _stream;

	public unsafe int Read(byte* buffer, uint byteCount, out uint bytesRead)
	{
		Span<byte> span = new(buffer, checked((int)byteCount));

		int read = _stream.Read(span);

		bytesRead = (uint)read;

		return 0;
	}

	public unsafe int Write(byte* buffer, uint byteCount, out uint bytesWritten)
	{
		ReadOnlySpan<byte> span = new(buffer, checked((int)byteCount));

		_stream.Write(span);

		bytesWritten = byteCount;

		return 0;
	}

	public int Seek(long offset, SeekType origin, out ulong newPosition)
	{
		long position = _stream.Seek(offset, (SeekOrigin)origin);

		newPosition = (ulong)position;

		return 0;
	}

	public int SetSize(ulong newSize)
	{
		try
		{
			_stream.SetLength(checked((long)newSize));
			return 0;
		}
		catch (Exception ex)
		{
			return Marshal.GetHRForException(ex);
		}
	}

	public int CopyTo(IStream stream, ulong byteCount, out ulong bytesRead, out ulong bytesWritten)
	{
		const int BufferSize = 81920;

		bytesRead = 0;
		bytesWritten = 0;

		byte[] buffer = new byte[BufferSize];

		try
		{
			while (bytesRead < byteCount)
			{
				int toRead = (int)Math.Min(BufferSize, (long)(byteCount - bytesRead)), read = _stream.Read(buffer, 0, toRead);

				if (read == 0) break;

				bytesRead += (ulong)read;

				unsafe
				{
					fixed (byte* p = buffer)
					{
						int hr = stream.Write(p, (uint)read, out uint written);

						if (hr < 0) return hr;

						bytesWritten += written;
					}
				}
			}

			return 0;
		}
		catch (Exception ex)
		{
			return Marshal.GetHRForException(ex);
		}
	}

	public int Commit(CommitFlags flags)
	{
		try
		{
			_stream.Flush();
			return 0;
		}
		catch (Exception ex)
		{
			return Marshal.GetHRForException(ex);
		}
	}

	public int Revert() => unchecked((int)KnownResult.E_NOTIMPL);

	public int LockRegion(ulong offset, ulong byteCount, LockType lsockType) => unchecked((int)KnownResult.E_NOTIMPL);

	public int UnlockRegion(ulong offset, ulong byteCount, LockType lockType) => unchecked((int)KnownResult.E_NOTIMPL);

	public int Stat(out StatStorage tag, StatName flag)
	{
		tag = new StatStorage
		{
			Size = _stream.CanSeek ? (ulong)_stream.Length : 0,
			Type = StorageType.Stream
		};

		return 0;
	}

	public int Clone(out IStream stream)
	{
		stream = null!;
		return unchecked((int)KnownResult.E_NOTIMPL);
	}
}

#pragma warning restore CA1031