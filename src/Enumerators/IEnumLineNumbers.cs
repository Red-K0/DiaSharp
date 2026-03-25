using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("FE30E878-54AC-44F1-81BA-39DE940F6052")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumLineNumbers
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	ILineNumber Item(uint index);

	uint Next(uint lineCount, [MarshalUsing(CountElementName = nameof(lineCount))] out ILineNumber[] lines);

	void Skip(uint lineCount);

	void Reset();

	IEnumLineNumbers Clone();
}
