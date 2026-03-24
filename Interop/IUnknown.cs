using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Interop;

[GeneratedComInterface]
[Guid("00000000-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IUnknown
{
	uint AddRef();

	void QueryInterface(ref Guid riid, out nint valueObject);

	uint Release();
}
