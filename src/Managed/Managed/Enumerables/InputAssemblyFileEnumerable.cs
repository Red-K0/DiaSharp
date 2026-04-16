using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

internal class InputAssemblyFileEnumerable(IEnumInputAssemblyFiles native) : ComEnumerable<IEnumInputAssemblyFiles, InputAssemblyFile>(native)
{
	public override IEnumerator<InputAssemblyFile> GetEnumerator() => new InputAssemblyFileEnumerator(CloneNative());
	protected override IEnumInputAssemblyFiles CloneNative() => CloneInternal(_native.Clone(out IEnumInputAssemblyFiles clone), clone);

	private sealed class InputAssemblyFileEnumerator(IEnumInputAssemblyFiles native) : ComEnumerator(native)
	{
		protected override unsafe int MoveNextInternal(out InputAssemblyFile? value)
		{
			if (!TryGetSingle(_native.GetNext, out IInputAssemblyFile assembly))
			{
				value = null;
				return (int)KnownResult.S_FALSE;
			}

			value = new(assembly);
			return (int)KnownResult.S_OK;
		}

		protected override int ResetInternal() => _native.Reset();
	}
}