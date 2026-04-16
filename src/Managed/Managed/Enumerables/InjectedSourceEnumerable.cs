using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

internal class InjectedSourceEnumerable(IEnumInjectedSources native) : ComEnumerable<IEnumInjectedSources, InjectedSource>(native)
{
	public override IEnumerator<InjectedSource> GetEnumerator() => new InjectedSourceEnumerator(CloneNative());
	protected override IEnumInjectedSources CloneNative() => CloneInternal(_native.Clone(out IEnumInjectedSources clone), clone);

	private sealed class InjectedSourceEnumerator(IEnumInjectedSources native) : ComEnumerator(native)
	{
		protected override unsafe int MoveNextInternal(out InjectedSource? value)
		{
			if (!TryGetSingle(_native.GetNext, out IInjectedSource source))
			{
				value = null;
				return (int)KnownResult.S_FALSE;
			}

			value = new(source);
			return (int)KnownResult.S_OK;
		}

		protected override int ResetInternal() => _native.Reset();
	}
}
