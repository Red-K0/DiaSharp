using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

internal class TableEnumerable(IEnumTables native) : ComEnumerable<IEnumTables, Table>(native)
{
	public override IEnumerator<Table> GetEnumerator() => new TableEnumerator(CloneNative());
	protected override IEnumTables CloneNative() => CloneInternal(_native.Clone(out IEnumTables enumerator), enumerator);

	private sealed class TableEnumerator(IEnumTables native) : ComEnumerator(native)
	{
		protected override unsafe int MoveNextInternal(out Table? value)
		{
			if (!TryGetSingle(_native.GetNext, out ITable table))
			{
				value = null;
				return (int)KnownResult.S_FALSE;
			}

			value = new(table);
			return (int)KnownResult.S_OK;
		}
		protected override int ResetInternal() => _native.Reset();
	}
}