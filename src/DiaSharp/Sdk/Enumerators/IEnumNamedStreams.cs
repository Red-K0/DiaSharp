using DiaSharp.Interop;

namespace DiaSharp.Sdk.Enumerators;

[GeneratedComInterface]
[Guid("2B01F5E0-98DB-4824-A9A0-5192833BEF47")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumNamedStreams
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetNext();

	void Skip(uint streamCount);

	void Reset();

	IEnumNamedStreams Clone();
};
