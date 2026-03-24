using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;
using DiaSharp.StructuredStorage;

namespace DiaSharp;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("79F1BB5F-B66E-48E5-B6A9-1545C323CA3D")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaDataSource
{
	[DispId(1)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string get_lastError();

	void loadDataFromPdb(string pdbPath);

	void loadAndValidateDataFromPdb(string pdbPath, ref Guid pdbSignature, uint signature, uint age);

	void loadDataForExe(string executable, string searchPath, IUnknown callback);

	void loadDataFromIStream(ref IStream stream);

	IDiaSession openSession();

	void loadDataFromCodeViewInfo(string executable, string searchPath, uint infoSize, [MarshalUsing(CountElementName = nameof(infoSize))] byte[] info, IUnknown callback);

	void loadDataFromMiscInfo(string executable, string searchPath, uint exeTimestamp, uint debugTimestamp, uint exeSize, uint infoSize, [MarshalUsing(CountElementName = nameof(infoSize))] byte[] info, IUnknown callback);
}
