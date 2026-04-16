using DiaSharp.COM;
using DiaSharp.SDK;

namespace DiaSharp.Managed;

public class InjectedSource(IInjectedSource native) : ComObject<IInjectedSource>(native)
{
	public uint CRC => GetProp<uint>(_native.GetCRC);

	public ulong Length => GetProp<ulong>(_native.GetLength);

	public string Filename => GetProp<string>(_native.GetFilename);

	public string ObjectFilename => GetProp<string>(_native.GetObjectFilename);

	public string VirtualFilename => GetProp<string>(_native.GetVirtualFilename);

	public uint SourceCompression => GetProp<uint>(_native.GetSourceCompression);

	public unsafe ReadOnlySpan<byte> Source => GetProp<byte>(_native.GetSource);
}
