using DiaSharp.Sdk.Symbols;

namespace DiaSharp.Sdk;

[GeneratedComInterface]
[Guid("B388EB14-BE4D-421D-A8A1-6CF7AB057086")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ILineNumber
{
	ISymbol GetCompiland();

	ISourceFile GetSourceFile();

	uint GetLineNumber();

	uint GetLineNumberEnd();

	uint GetColumnNumber();

	uint GetColumnNumberEnd();

	uint GetAddressSection();

	uint GetAddressOffset();

	uint GetRelativeVirtualAddress();

	ulong GetVirtualAddress();

	uint GetLength();

	uint GetSourceFileID();

	int GetStatement();

	uint GetCompilandID();
}
