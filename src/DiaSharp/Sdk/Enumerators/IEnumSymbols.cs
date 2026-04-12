using DiaSharp.Interop;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumSymbols
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int Item(uint index, out ISymbol symbol);

	unsafe int GetNext(uint symbolCount, void** symbols, out uint symbolsFetched);

	int Skip(uint symbolCount);

	int Reset();

	int Clone(out IEnumSymbols enumerator);
}
