using DiaSharp.COM;
using DiaSharp.SDK;

namespace DiaSharp.Managed;

public class InputAssemblyFile(IInputAssemblyFile native) : ComObject<IInputAssemblyFile>(native)
{
	public uint? UniqueID => GetS<uint>(_native.GetUniqueID);

	public uint? Index => GetS<uint>(_native.GetIndex);

	public uint? Timestamp => GetS<uint>(_native.GetTimestamp);

	public bool? PDBAvailableAtILMerge => GetS<bool>(_native.GetWasPDBAvailableAtILMerge);

	public string? Filename => GetC<string>(_native.GetFilename);

	public unsafe byte[]? VersionBytes => GetA<byte>(_native.GetVersion);
}
