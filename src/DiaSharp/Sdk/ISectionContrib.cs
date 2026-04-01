using DiaSharp.SDK.Symbols;

namespace DiaSharp.SDK;

[GeneratedComInterface]
[Guid("0CF4B60E-35B1-4C6C-BDD8-854B9C8E3857")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISectionContrib
{
	ISymbol GetCompiland();

	uint GetAddressSection();

	uint GetAddressOffset();

	uint GetRelativeVirtualAddress();

	ulong GetVirtualAddress();

	uint GetLength();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetNotPaged();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetNoPad();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetCode();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetInitializedData();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetUninitializedData();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetInformational();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetRemove();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetCOMDAT();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetDiscardable();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetNotCached();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetShare();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetExecute();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetRead();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetWrite();

	uint GetDataCRC();

	uint GetRelocationsCRC();

	uint GetCompilandID();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetCode16bit();
}
