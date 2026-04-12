using DiaSharp.SDK.Callbacks;
using DiaSharp.Storage;

namespace DiaSharp.SDK;

[Guid("1A21EB69-962A-4BC4-8BD3-681797D38B23")]
public unsafe partial interface IDataSourceEx : IDataSource
{
	int LoadDataFromPDB(string pdbPath, [MarshalAs(UnmanagedType.Bool)] bool prefetchPDB);

	int LoadAndValidateDataFromPDB(string pdbPath, Guid* pdbSignature, uint signature, uint age, [MarshalAs(UnmanagedType.Bool)] bool prefetchPDB);

	unsafe int LoadDataForExe(string executable, string searchPath, void* callback, [MarshalAs(UnmanagedType.Bool)] bool prefetchPDB);

	int LoadDataFromIStream(IStream stream, [MarshalAs(UnmanagedType.Bool)] bool prefetchPDB);

	int GetStreamSize(string stream, out ulong size);

	unsafe int GetStreamRawData(string stream, ulong byteOffset, ulong bufferSize, out ulong bytesWritten, byte* buffer);

	int SetMiniPDBErrorCallback(nint context, MiniPDBErrorCallback callback);

	int ValidatePDB(string pdbPath, Guid* pdbSignature, uint signature, uint age, [MarshalAs(UnmanagedType.Bool)] out bool valid);
}