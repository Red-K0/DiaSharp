using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Enumerators;
using DiaSharp.Enums;

namespace DiaSharp;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("D240C8DD-1A0F-456E-80A6-4F1D06BF5DF4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDataSourceEx2 : IDataSourceEx
{
	IEnumNamedStreams FindNamedStreams([MarshalAs(UnmanagedType.BStr)] string name, NameSearchOptions searchOptions);
};
