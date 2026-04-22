using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.Managed;

public class LineNumber(ILineNumber native) : ComObject<ILineNumber>(native)
{
	public Symbol? Compiland => TryGetC(_native.GetCompiland, out ISymbol? native) ? new(native) : null;

	public SourceFile? SourceFile => TryGetC(_native.GetSourceFile, out ISourceFile? native) ? new(native) : null;

	public uint? Line => GetS<uint>(_native.GetLineNumber);

	public uint? LineEnd => GetS<uint>(_native.GetLineNumberEnd);

	public uint? ColumnNumber => GetS<uint>(_native.GetColumnNumber);

	public uint? ColumnNumberEnd => GetS<uint>(_native.GetColumnNumberEnd);

	public uint? SectionAddress => GetS<uint>(_native.GetSectionAddress);

	public uint? OffsetAddress => GetS<uint>(_native.GetOffsetAddress);

	public uint? RelativeVirtualAddress => GetS<uint>(_native.GetRelativeVirtualAddress);

	public ulong? VirtualAddress => GetS<ulong>(_native.GetVirtualAddress);

	public uint? Length => GetS<uint>(_native.GetLength);

	public uint? SourceFileID => GetS<uint>(_native.GetSourceFileID);

	public int? Statement => GetS<int>(_native.GetStatement);

	public uint? CompilandID => GetS<uint>(_native.GetCompilandID);
}