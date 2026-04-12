using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumNamedStreams
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int GetNext([MarshalAs(UnmanagedType.BStr)] out string name);

	int Skip(uint nameCount);

	int Reset();

	int Clone(out IEnumNamedStreams enumerator);
}
