using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Interop;

[GeneratedComInterface]
[Guid("00000100-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumUnknown
{
	void Clone(out IEnumUnknown enumerator);

	void Next(uint elementCount, [MarshalUsing(CountElementName = nameof(elementCount))] out IUnknown[] elements, out uint fetchedElementCount);

	void Reset();

	void Skip(uint elementCount);
}
