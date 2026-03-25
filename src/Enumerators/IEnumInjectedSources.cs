using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("D5612573-6925-4468-8883-98CDEC8C384A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumInjectedSources
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	IInjectedSource Item(uint index);

	uint GetNext(uint sourceCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out IInjectedSource[] sources);

	void Skip(uint sourceCount);

	void Reset();

	IEnumInjectedSources Clone();
}
