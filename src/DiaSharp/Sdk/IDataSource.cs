using DiaSharp.Interop;
using DiaSharp.Storage;

namespace DiaSharp.Sdk;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("79F1BB5F-B66E-48E5-B6A9-1545C323CA3D")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDataSource
{
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetLastError();

	void LoadDataFromPdb(string pdbPath);

	void LoadAndValidateDataFromPdb(string pdbPath, ref Guid pdbSignature, uint signature, uint age);

	void LoadDataForExe(string executable, string searchPath, IUnknown callback);

	void LoadDataFromIStream(IStream stream);

	ISession OpenSession();

	void LoadDataFromCodeViewInfo(string executable, string searchPath, uint infoSize, [MarshalUsing(CountElementName = nameof(infoSize))] byte[] info, IUnknown callback);

	void LoadDataFromMiscInfo(string executable, string searchPath, uint exeTimestamp, uint debugTimestamp, uint exeSize, uint infoSize, [MarshalUsing(CountElementName = nameof(infoSize))] byte[] info, IUnknown callback);
}
