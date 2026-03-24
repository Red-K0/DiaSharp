using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.StructuredStorage;

[GeneratedComInterface]
[Guid("00000139-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumStatPropertyStorage
{
	IEnumStatPropertyStorage Clone();

	uint Next(uint celt, [MarshalUsing(CountElementName = nameof(celt))] out StatPropertyStorage[] regelt);

	void Reset();

	void Skip(uint celt);
}
