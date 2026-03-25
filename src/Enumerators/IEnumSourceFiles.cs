using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("10F3DBD9-664F-4469-B808-9471C7A50538")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumSourceFiles
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	ISourceFile Item(uint index);

	uint Next(uint fileCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out ISourceFile[] files);

	void Skip(uint fileCount);

	void Reset();

	IEnumSourceFiles Clone();
}
