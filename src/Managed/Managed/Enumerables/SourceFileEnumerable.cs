using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

internal class SourceFileEnumerable(IEnumSourceFiles native) : ComEnumerable<IEnumSourceFiles, SourceFile>(native)
{
	public override IEnumerator<SourceFile> GetEnumerator() => new SourceFileEnumerator(CloneNative());
	protected override IEnumSourceFiles CloneNative() => CloneInternal(_native.Clone(out IEnumSourceFiles clone), clone);

	private sealed class SourceFileEnumerator(IEnumSourceFiles native) : ComEnumerator(native)
	{
		protected override unsafe int MoveNextInternal(out SourceFile? value)
		{
			if (!TryGetSingle(_native.GetNext, out ISourceFile file))
			{
				value = null;
				return (int)KnownResult.S_FALSE;
			}

			value = new(file);
			return (int)KnownResult.S_OK;

		}
		protected override int ResetInternal() => _native.Reset();
	}
}
