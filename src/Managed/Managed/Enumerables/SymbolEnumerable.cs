using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.Managed.Enumerables;

public class SymbolEnumerable(IEnumSymbols native) : ComEnumerable<IEnumSymbols, Symbol>(native)
{
	protected override unsafe bool TryFetchBatch()
	{
		void** symbols = stackalloc void*[(int)_batchSize];

		int result = _native.GetNext(_batchSize, symbols, out uint symbolsFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (symbolsFetched == 0) return false;

		Symbol[] managed = new Symbol[symbolsFetched];

		for (int i = 0; i < symbolsFetched; i++) managed[i] = new(ComHelpers.Wrap<ISymbol>(symbols[i]));

		AddRangeToCache(managed);

		return true;
	}
}
