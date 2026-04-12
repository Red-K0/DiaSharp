using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

[Guid("10F3DBD9-664F-4469-B808-9471C7A50538")]
public partial interface IEnumSourceFiles
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int Item(uint index, out ISourceFile file);

	unsafe int GetNext(uint fileCount, void** files, out uint filesFetched);

	int Skip(uint fileCount);

	int Reset();

	int Clone(out IEnumSourceFiles enumerator);
}
