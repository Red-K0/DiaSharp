using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

[Guid("2B01F5E0-98DB-4824-A9A0-5192833BEF47")]
public partial interface IEnumNamedStreams
{
	int GetNewEnum(out IEnumVARIANT enumerator);

	int GetCount(out int count);

	int GetNext([MarshalAs(UnmanagedType.BStr)] out string name);

	int Skip(uint nameCount);

	int Reset();

	int Clone(out IEnumNamedStreams enumerator);
}
