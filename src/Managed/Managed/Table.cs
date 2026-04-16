using DiaSharp.COM;
using DiaSharp.Interop;
using DiaSharp.SDK;

namespace DiaSharp.Managed;

public class Table(ITable native) : ComEnumerable<ITable, nint>(native)
{
	public override IEnumerator<nint> GetEnumerator() => new TableEnumerator(CloneNative());
	protected override ITable CloneNative() => CloneInternal(_native.Clone(out IEnumUnknown? clone), ComHelpers.QueryInterface<IEnumUnknown, ITable>(clone));

	private sealed class TableEnumerator(ITable native) : ComEnumerator(native)
	{
		protected override unsafe int MoveNextInternal(out nint value)
		{
			void* pointer;

			int result = _native.GetNext(1, &pointer, out _);

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			if (result == 1)
			{
				value = default;
				return (int)KnownResult.S_FALSE;
			}

			value = (nint)pointer;
			return (int)KnownResult.S_OK;
		}

		protected override int ResetInternal() => _native.Reset();
	}
}
