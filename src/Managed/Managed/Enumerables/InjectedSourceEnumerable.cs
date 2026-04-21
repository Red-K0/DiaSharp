using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

internal class InjectedSourceEnumerable(IEnumInjectedSources native) : ComEnumerable<IEnumInjectedSources, InjectedSource>(native)
{
	protected override unsafe bool TryFetchBatch()
	{
		void** sources = stackalloc void*[(int)_batchSize];

		int result = _native.GetNext(_batchSize, sources, out uint sourcesFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (sourcesFetched == 0) return false;

		InjectedSource[] managed = new InjectedSource[sourcesFetched];

		for (int i = 0; i < sourcesFetched; i++) managed[i] = new(ComHelpers.Wrap<IInjectedSource>(sources[i]));

		AddRangeToCache(managed);

		return true;
	}
}
