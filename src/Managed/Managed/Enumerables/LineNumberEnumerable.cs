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
		protected override unsafe int MoveNextInternal(out LineNumber? value)
		{
			if (!TryGetSingle(_native.GetNext, out ILineNumber number))
			{
				value = null;
				return (int)KnownResult.S_FALSE;
			}

			value = new(number);
			return (int)KnownResult.S_OK;
		}

		protected override int ResetInternal() => _native.Reset();
	}
}
