using DiaSharp.Interop;
using DiaSharp.Sdk.Symbols;

namespace DiaSharp.Sdk.Enumerators;

[GeneratedComInterface]
[Guid("CAB72C48-443B-48F5-9B0B-42F0820AB29A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumSymbols
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	ISymbol Item(uint index);

	uint GetNext(uint symbolCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out ISymbol[] elements);

	void Skip(uint symbolCount);

	void Reset();

	IEnumSymbols Clone();
}
