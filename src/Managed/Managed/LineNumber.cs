using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.Managed;

public class LineNumber(ILineNumber native) : ComObject<ILineNumber>(native)
{
	public Symbol Compiland => new(GetProp<ISymbol>(_native.GetCompiland));

	public SourceFile SourceFile => new(GetProp<ISourceFile>(_native.GetSourceFile));

	public uint Line => GetProp<uint>(_native.GetLineNumber);

	public uint LineEnd => GetProp<uint>(_native.GetLineNumberEnd);

	public uint ColumnNumber => GetProp<uint>(_native.GetColumnNumber);

	public uint ColumnNumberEnd => GetProp<uint>(_native.GetColumnNumberEnd);

	public uint SectionAddress => GetProp<uint>(_native.GetSectionAddress);

	public uint OffsetAddress => GetProp<uint>(_native.GetOffsetAddress);

	public uint RelativeVirtualAddress => GetProp<uint>(_native.GetRelativeVirtualAddress);

	public ulong VirtualAddress => GetProp<ulong>(_native.GetVirtualAddress);

	public uint Length => GetProp<uint>(_native.GetLength);

	public uint SourceFileID => GetProp<uint>(_native.GetSourceFileID);

	public int Statement => GetProp<int>(_native.GetStatement);

	public uint CompilandID => GetProp< uint>(_native.GetCompilandID);
}