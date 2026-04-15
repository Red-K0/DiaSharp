using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

sealed internal class LineNumberEnumerable(IEnumLineNumbers native) : ComEnumerable<IEnumLineNumbers, LineNumber>(native)
{
	public override IEnumerator<LineNumber> GetEnumerator() => new LineNumberEnumerator(CloneNative());

	protected override IEnumLineNumbers CloneNative() => CloneInternal(_native.Clone(out IEnumLineNumbers clone), clone);

	private sealed class LineNumberEnumerator(IEnumLineNumbers native) : ComEnumerator(native)
	{
		protected override unsafe (int, LineNumber) MoveNextInternal()
		{
			if (!ComEnumerableHelpers.TryGetSingle(_native.GetNext, out ILineNumber number)) return (1, null!);

			return (0, new(number));
		}

		protected override int ResetInternal() => _native.Reset();
	}
}
