using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Enumerators;

namespace DiaSharp;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("D240C8DD-1A0F-456E-80A6-4F1D06BF5DF4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaDataSourceEx2 : IDiaDataSourceEx
{
	IDiaEnumNamedStreams findNamedStreams([MarshalAs(UnmanagedType.BStr)] string name, uint compareFlags);
};
