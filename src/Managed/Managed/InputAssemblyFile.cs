using DiaSharp.COM;
using DiaSharp.SDK;

namespace DiaSharp.Managed;

public class InputAssemblyFile(IInputAssemblyFile native) : ComObject<IInputAssemblyFile>(native)
{
	public uint UniqueID => GetProp<uint>(_native.GetUniqueID);

	public uint Index => GetProp<uint>(_native.GetIndex);

	public uint Timestamp => GetProp<uint>(_native.GetTimestamp);

	public bool PDBAvailableAtILMerge => GetProp<bool>(_native.GetWasPDBAvailableAtILMerge);

	public string Filename => GetProp<string>(_native.GetFilename);

	public unsafe ReadOnlySpan<byte> VersionBytes => GetProp<byte>(_native.GetVersion);
}
