using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Interop;

[GeneratedComInterface]
[Guid("00020404-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumVARIANT
{
	IEnumVARIANT Clone();

	uint GetNext(uint elementCount, [MarshalUsing(CountElementName = nameof(elementCount))] out IUnknown[] elements);

	void Reset();

	uint Skip();
}