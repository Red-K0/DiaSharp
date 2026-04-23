using DiaSharp.COM;
using DiaSharp.SDK;

namespace DiaSharp.Managed;

[SuppressMessage("Performance", "CA1819:Properties should not return arrays", Justification = "Readonly semantics are unnecessary.")]
public class InjectedSource(IInjectedSource native) : ComObject<IInjectedSource>(native)
{
	public uint? CRC => GetS<uint>(_native.GetCRC);

	public ulong? Length => GetS<ulong>(_native.GetLength);

	public string? Filename => GetC<string>(_native.GetFilename);

	public string? ObjectFilename => GetC<string>(_native.GetObjectFilename);

	public string? VirtualFilename => GetC<string>(_native.GetVirtualFilename);

	public uint? SourceCompression => GetS<uint>(_native.GetSourceCompression);

	public unsafe byte[]? Source => GetA<byte>(_native.GetSource);
}
