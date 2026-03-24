using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Callbacks;
using DiaSharp.Interop;
using DiaSharp.StructuredStorage;

namespace DiaSharp;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("1A21EB69-962A-4BC4-8BD3-681797D38B23")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaDataSourceEx : IDiaDataSource
{
	void loadDataFromPdbEx(string pdbPath, [MarshalAs(UnmanagedType.Bool)] bool fPdbPrefetching);

	void loadAndValidateDataFromPdbEx(string pdbPath, ref Guid pcsig70, uint sig, uint age, [MarshalAs(UnmanagedType.Bool)] bool fPdbPrefetching);

	void loadDataForExeEx(string executable, string searchPath, IUnknown pCallback, [MarshalAs(UnmanagedType.Bool)] bool fPdbPrefetching);

	void loadDataFromIStreamEx(IStream pIStream, [MarshalAs(UnmanagedType.Bool)] bool fPdbPrefetching);

	ulong getStreamSize(string stream);

	[return: MarshalUsing(CountElementName = nameof(cbRead))]
	byte[] getStreamRawData(string stream, ulong cbOffset, ulong cbRead, out ulong pcbRead);

	void setPfnMiniPDBErrorCallback2(nint pvContext, MiniPdbErrorCallback pfn);

	[return: MarshalAs(UnmanagedType.Bool)]
	bool ValidatePdb(string pdbPath, ref Guid pcsig70, uint sig, uint age);
}