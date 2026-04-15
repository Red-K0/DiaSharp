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
		protected override unsafe (int, Symbol) MoveNextInternal()
		{
			if (!ComEnumerableHelpers.TryGetSingle(_native.GetNext, out ISymbol symbol)) return (1, null!);

			return (0, new(symbol));
		}

		protected override int ResetInternal() => _native.Reset();
	}
}