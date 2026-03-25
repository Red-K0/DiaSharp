using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Callbacks;
using DiaSharp.Interop;
using DiaSharp.StructuredStorage;

namespace DiaSharp;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("1A21EB69-962A-4BC4-8BD3-681797D38B23")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDataSourceEx : IDataSource
{
	void LoadDataFromPdb(string pdbPath, [MarshalAs(UnmanagedType.Bool)] bool prefetchPDB);

	void LoadAndValidateDataFromPdb(string pdbPath, ref Guid pdbSignature, uint signature, uint age, [MarshalAs(UnmanagedType.Bool)] bool prefetchPDB);

	void LoadDataForExe(string executable, string searchPath, IUnknown callback, [MarshalAs(UnmanagedType.Bool)] bool prefetchPDB);

	void LoadDataFromIStream(IStream stream, [MarshalAs(UnmanagedType.Bool)] bool prefetchPDB);

	ulong GetStreamSize(string stream);

	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] GetStreamRawData(string stream, ulong byteOffset, ulong bufferSize, out ulong bytesWritten);

	void SetMiniPdbErrorCallback(nint context, MiniPdbErrorCallback callback);

	[return: MarshalAs(UnmanagedType.Bool)]
	bool ValidatePdb(string pdbPath, ref Guid pdbSignature, uint signature, uint age);
}