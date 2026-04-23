using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.Managed.Enumerables;

sealed internal class SymbolEnumerable(IEnumSymbols native) : ComEnumerable<IEnumSymbols, Symbol>(native)
{
	protected override unsafe uint TryFetchBatch()
	{
		void** symbols = stackalloc void*[(int)BatchSize];

		int result = _native.GetNext(BatchSize, symbols, out uint symbolsFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (symbolsFetched == 0) return 0;

		Symbol[] managed = new Symbol[symbolsFetched];

		for (int i = 0; i < symbolsFetched; i++) managed[i] = new(ComHelpers.Wrap<ISymbol>(symbols[i]));

		AddRangeToCache(managed);

		return symbolsFetched;
	}
}
