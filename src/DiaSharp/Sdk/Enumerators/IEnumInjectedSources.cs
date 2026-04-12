using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

[Guid("D5612573-6925-4468-8883-98CDEC8C384A")]
public partial interface IEnumInjectedSources
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int Item(uint index, out IInjectedSource source);

	unsafe int GetNext(uint sourceCount, void** sources, out uint sourcesFetched);

	int Skip(uint sourceCount);

	int Reset();

	int Clone(out IEnumInjectedSources enumerator);
}
