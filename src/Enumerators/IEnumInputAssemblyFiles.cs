using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("1C7FF653-51F7-457E-8419-B20F57EF7E4D")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumInputAssemblyFiles
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	IInputAssemblyFile Item(uint index);

	uint GetNext(uint fileCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out IInputAssemblyFile[] files);

	void Skip(uint fileCount);

	void Reset();

	IEnumInputAssemblyFiles Clone();
}
