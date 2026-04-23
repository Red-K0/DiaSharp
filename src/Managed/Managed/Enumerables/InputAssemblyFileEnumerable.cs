using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

sealed internal class InputAssemblyFileEnumerable(IEnumInputAssemblyFiles native) : ComEnumerable<IEnumInputAssemblyFiles, InputAssemblyFile>(native)
{
	protected override unsafe uint TryFetchBatch()
	{
		void** files = stackalloc void*[(int)BatchSize];

		int result = _native.GetNext(BatchSize, files, out uint filesFetched);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		if (filesFetched == 0) return 0;

		InputAssemblyFile[] managed = new InputAssemblyFile[filesFetched];

		for (int i = 0; i < filesFetched; i++) managed[i] = new(ComHelpers.Wrap<IInputAssemblyFile>(files[i]));

		AddRangeToCache(managed);

		return filesFetched;
	}
}