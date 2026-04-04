using DiaSharp.CodeView;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.SDK;

public partial interface ISourceFile
{
	int GetUniqueID(out uint ID);

	int GetFileName([MarshalAs(UnmanagedType.BStr)] out string name);

	int GetChecksumType(out SourceChecksumType type);

	int GetCompilands(out IEnumSymbols compilands);

	unsafe int GetChecksum(uint bufferSize, out uint bytesWritten, byte* buffer);
}
