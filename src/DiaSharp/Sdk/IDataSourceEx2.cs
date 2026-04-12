using DiaSharp.CodeView;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.SDK;

[Guid("D240C8DD-1A0F-456E-80A6-4F1D06BF5DF4")]
public partial interface IDataSourceEx2 : IDataSourceEx
{
	int FindNamedStreams([MarshalAs(UnmanagedType.BStr)] string name, NameSearchOptions searchOptions, out IEnumNamedStreams streams);
};
