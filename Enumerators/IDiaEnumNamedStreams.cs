using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("2B01F5E0-98DB-4824-A9A0-5192833BEF47")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumNamedStreams
{
	IEnumVARIANT get__NewEnum();

	[DispId(1)]
	int get_Count();

	[return: MarshalAs(UnmanagedType.BStr)]
	string Next();

	HRESULT Skip(uint celt);

	HRESULT Reset();

	IDiaEnumNamedStreams Clone();
};
