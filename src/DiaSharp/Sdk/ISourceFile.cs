using DiaSharp.CodeView;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.SDK;

[Guid("A2EF5353-F5A8-4eb3-90D2-CB526ACB3CDD")]
public partial interface ISourceFile
{
	int GetUniqueID(out uint id);

	int GetFileName([MarshalAs(UnmanagedType.BStr)] out string name);

	int GetChecksumType(out SourceChecksumType type);

	int GetCompilands(out IEnumSymbols compilands);

	unsafe int GetChecksum(uint bufferSize, out uint bytesWritten, byte* buffer);
}
