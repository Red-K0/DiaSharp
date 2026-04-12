using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

[Guid("1C7FF653-51F7-457E-8419-B20F57EF7E4D")]
public partial interface IEnumInputAssemblyFiles
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int Item(uint index, out IInputAssemblyFile file);

	unsafe int GetNext(uint fileCount, void** files, out uint filesFetched);

	int Skip(uint fileCount);

	int Reset();

	int Clone(out IEnumInputAssemblyFiles enumerator);
}
