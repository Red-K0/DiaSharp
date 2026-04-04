using DiaSharp.CodeView;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.SDK;

public partial interface IDataSourceEx2 : IDataSourceEx
{
	int FindNamedStreams([MarshalAs(UnmanagedType.BStr)] string name, NameSearchOptions searchOptions, out IEnumNamedStreams streams);
};
