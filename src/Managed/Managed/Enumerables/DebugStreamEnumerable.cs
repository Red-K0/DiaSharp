using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

internal class DebugStreamEnumerable(IEnumDebugStreams native) : ComEnumerable<IEnumDebugStreams, DebugStreamDataEnumerable>(native)
{
	public override IEnumerator<DebugStreamDataEnumerable> GetEnumerator() => new DebugStreamEnumerator(CloneNative());
	protected override IEnumDebugStreams CloneNative() => CloneInternal(_native.Clone(out IEnumDebugStreams clone), clone);

	private sealed class DebugStreamEnumerator(IEnumDebugStreams native) : ComEnumerator(native)
	{
		protected override unsafe int MoveNextInternal(out DebugStreamDataEnumerable? value)
		{
			if (!TryGetSingle(_native.GetNext, out IEnumDebugStreamData enumerator))
			{
				value = null;
				return (int)KnownResult.S_FALSE;
			}

			value = new(enumerator);
			return (int)KnownResult.S_OK;
		}

		protected override int ResetInternal() => _native.Reset();
	}
}
