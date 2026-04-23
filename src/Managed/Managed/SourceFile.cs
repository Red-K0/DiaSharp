using DiaSharp.CodeView;
using DiaSharp.COM;
using DiaSharp.Managed.Enumerables;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed;

[SuppressMessage("Performance", "CA1819:Properties should not return arrays", Justification = "Readonly semantics are unnecessary.")]
public class SourceFile(ISourceFile native) : ComObject<ISourceFile>(native)
{
	public uint? UniqueID => GetS<uint>(_native.GetUniqueID);

	public string? FileName => GetC<string>(_native.GetFileName);

	public SourceChecksumType? ChecksumType => GetS<SourceChecksumType>(_native.GetChecksumType);

	public IEnumerable<Symbol>? Compilands => TryGetC(_native.GetCompilands, out IEnumSymbols? native) ? new SymbolEnumerable(native) : null;

	public unsafe byte[]? Checksum => GetA<byte>(_native.GetChecksum);
}
