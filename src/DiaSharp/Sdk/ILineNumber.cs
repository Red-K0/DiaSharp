using DiaSharp.SDK.Symbols;

namespace DiaSharp.SDK;

public partial interface ILineNumber
{
	int GetCompiland(out ISymbol symbol);

	int GetSourceFile(out ISourceFile file);

	int GetLineNumber(out uint number);

	int GetLineNumberEnd(out uint number);

	int GetColumnNumber(out uint column);

	int GetColumnNumberEnd(out uint column);

	int GetSectionAddress(out uint sectionAddress);

	int GetOffsetAddress(out uint offsetAddress);

	int GetRelativeVirtualAddress(out uint rva);

	int GetVirtualAddress(out ulong va);

	int GetLength(out uint length);

	int GetSourceFileID(out uint id);

	int GetStatement(out int statement);

	int GetCompilandID(out uint id);
}
