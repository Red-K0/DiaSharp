using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

internal class InputAssemblyFileEnumerable(IEnumInputAssemblyFiles native) : ComEnumerable<IEnumInputAssemblyFiles, InputAssemblyFile>(native)
{
	protected override unsafe bool TryFetchBatch()
	{
		void** files = stackalloc void*[(int)_batchSize];

		int result = _native.GetNext(_batchSize, files, out uint filesFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (filesFetched == 0) return false;

		InputAssemblyFile[] managed = new InputAssemblyFile[filesFetched];

		for (int i = 0; i < filesFetched; i++) managed[i] = new(ComHelpers.Wrap<IInputAssemblyFile>(files[i]));

		AddRangeToCache(managed);

		return true;
	}
}