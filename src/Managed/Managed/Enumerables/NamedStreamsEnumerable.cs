using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

sealed internal class NamedStreamsEnumerable(IEnumNamedStreams native) : ComEnumerable<IEnumNamedStreams, string>(native)
{
	public override IEnumerator<string> GetEnumerator() => new NamedStreamsEnumerator(CloneNative());

	protected override IEnumNamedStreams CloneNative() => CloneInternal(_native.Clone(out IEnumNamedStreams? clone), clone);

	private sealed class NamedStreamsEnumerator(IEnumNamedStreams native) : ComEnumerator(native)
	{
		protected override (int, string) MoveNextInternal() => (_native.GetNext(out string name), name);

		protected override int ResetInternal() => _native.Reset();
	}
}
