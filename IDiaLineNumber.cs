using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Symbols;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("B388EB14-BE4D-421D-A8A1-6CF7AB057086")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaLineNumber
{
	[DispId(1)]
	IDiaSymbol get_compiland();

	[DispId(2)]
	IDiaSourceFile get_sourceFile();

	[DispId(3)]
	uint get_lineNumber();

	[DispId(4)]
	uint get_lineNumberEnd();

	[DispId(5)]
	uint get_columnNumber();

	[DispId(6)]
	uint get_columnNumberEnd();

	[DispId(7)]
	uint get_addressSection();

	[DispId(8)]
	uint get_addressOffset();

	[DispId(9)]
	uint get_relativeVirtualAddress();

	[DispId(10)]
	ulong get_virtualAddress();

	[DispId(11)]
	uint get_length();

	[DispId(12)]
	uint get_sourceFileId();

	[DispId(13)]
	int get_statement();

	[DispId(14)]
	uint get_compilandId();
}
