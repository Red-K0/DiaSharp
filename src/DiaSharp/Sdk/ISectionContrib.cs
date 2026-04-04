using DiaSharp.SDK.Symbols;

namespace DiaSharp.SDK;

public partial interface ISectionContrib
{
	int GetCompiland(out ISymbol compiland);

	int GetAddressSection(out uint section);

	int GetAddressOffset(out uint offset);

	int GetRelativeVirtualAddress(out uint rva);

	int GetVirtualAddress(out ulong va);

	int GetLength(out uint length);

	int GetNotPaged([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetNoPad([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetHasCode([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetHasInitializedData([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetHasUninitializedData([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetIsInformational([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetIsRemoved([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetIsCOMDAT([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetIsDiscardable([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetNotCached([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetIsShareable([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetIsExecutable([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetIsReadable([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetIsWriteable([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetDataCRC(out uint crc);

	int GetRelocationsCRC(out uint crc);

	int GetCompilandID(out uint ID);

	int GetHas16BitCode([MarshalAs(UnmanagedType.Bool)] out bool value);
}
