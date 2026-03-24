using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Symbols;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("0CF4B60E-35B1-4C6C-BDD8-854B9C8E3857")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaSectionContrib
{
	[DispId(1)]
	IDiaSymbol get_compiland();

	[DispId(2)]
	uint get_addressSection();

	[DispId(3)]
	uint get_addressOffset();

	[DispId(4)]
	uint get_relativeVirtualAddress();

	[DispId(5)]
	ulong get_virtualAddress();

	[DispId(6)]
	uint get_length();

	[DispId(8)]
	int get_notPaged();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool get_nopad();

	[DispId(9)]
	int get_code();

	[DispId(10)]
	int get_initializedData();

	[DispId(11)]
	int get_uninitializedData();

	[DispId(12)]
	int get_remove();

	[DispId(13)]
	int get_comdat();

	[DispId(14)]
	int get_discardable();

	[DispId(15)]
	int get_notCached();

	[DispId(16)]
	int get_share();

	[DispId(17)]
	int get_execute();

	[DispId(18)]
	int get_read();

	[DispId(19)]
	int get_write();

	[DispId(20)]
	uint get_dataCrc();

	[DispId(21)]
	uint get_relocationsCrc();

	[DispId(22)]
	uint get_compilandId();

	[DispId(23)]
	int get_code16bit();
}
