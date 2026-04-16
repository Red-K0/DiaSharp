using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

internal class SourceLinkEnumerable(IEnumSourceLink native) : ComEnumerable<IEnumSourceLink, byte[]>(native)
{
	public override IEnumerator<byte[]> GetEnumerator() => new SourceLinkEnumerator(CloneNative());
	protected override IEnumSourceLink CloneNative() => CloneInternal(_native.Clone(out IEnumSourceLink clone), clone);

	private sealed class SourceLinkEnumerator(IEnumSourceLink native) : ComEnumerator(native)
	{
		protected override unsafe int MoveNextInternal(out byte[]? value)
		{
			value = GetProp<byte>(_native.GetNext).ToArray();

			return (int)KnownResult.S_OK;
		}
		protected override int ResetInternal() => _native.Reset();
	}
}
