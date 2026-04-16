using DiaSharp.CodeView;
using DiaSharp.COM;
using DiaSharp.Managed.Enumerables;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed;

public class SourceFile(ISourceFile native) : ComObject<ISourceFile>(native)
{
	public uint UniqueID => GetProp<uint>(_native.GetUniqueID);

	public string FileName => GetProp<string>(_native.GetFileName);

	public SourceChecksumType ChecksumType => GetProp<SourceChecksumType>(_native.GetChecksumType);

	public IEnumerable<Symbol> Compilands => new SymbolEnumerable(GetProp<IEnumSymbols>(_native.GetCompilands));

	public unsafe ReadOnlySpan<byte> Checksum => GetProp<byte>(_native.GetChecksum);
}
