using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.Managed.Enumerables;

internal class SymbolEnumerable(IEnumSymbols native) : ComEnumerable<IEnumSymbols, Symbol>(native)
{
	public override IEnumerator<Symbol> GetEnumerator() => new SymbolEnumerator(CloneNative());

	protected override IEnumSymbols CloneNative() => CloneInternal(_native.Clone(out IEnumSymbols clone), clone);

	private sealed class SymbolEnumerator(IEnumSymbols native) : ComEnumerator(native)
	{
		protected override unsafe int MoveNextInternal(out Symbol? value)
		{
			if (!TryGetSingle(_native.GetNext, out ISymbol symbol))
			{
				value = null;
				return (int)KnownResult.S_FALSE;
			}

			value = new(symbol);
			return (int)KnownResult.S_OK;
		}

		protected override int ResetInternal() => _native.Reset();
	}
}
