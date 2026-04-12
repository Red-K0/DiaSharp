using DiaSharp.Storage;

namespace DiaSharp.SDK;

[Guid("79F1BB5F-B66E-48E5-B6A9-1545C323CA3D")]
public partial interface IDataSource
{
	int GetLastError([MarshalAs(UnmanagedType.BStr)] out string error);

	int LoadDataFromPDB(string pdbPath);

	unsafe int LoadAndValidateDataFromPDB(string pdbPath, Guid* pdbSignature, uint signature, uint age);

	unsafe int LoadDataForExe(string exePath, string searchPath, void* callback);

	int LoadDataFromIStream(IStream stream);

	int OpenSession(out ISession session);

	unsafe int LoadDataFromCodeViewInfo(string executable, string searchPath, uint infoSize, byte* info, void* callback);

	unsafe int LoadDataFromMiscInfo(string executable, string searchPath, uint exeTimestamp, uint debugTimestamp, uint exeSize, uint infoSize, byte* info, void* callback);
}
