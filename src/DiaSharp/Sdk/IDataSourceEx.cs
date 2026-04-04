using DiaSharp.SDK.Callbacks;
using DiaSharp.Storage;

namespace DiaSharp.SDK;

public unsafe partial interface IDataSourceEx : IDataSource
{
	int LoadDataFromPdb(string pdbPath, [MarshalAs(UnmanagedType.Bool)] bool prefetchPDB);

	int LoadAndValidateDataFromPdb(string pdbPath, ref Guid pdbSignature, uint signature, uint age, [MarshalAs(UnmanagedType.Bool)] bool prefetchPDB);

	unsafe int LoadDataForExe(string executable, string searchPath, void* callback, [MarshalAs(UnmanagedType.Bool)] bool prefetchPDB);

	int LoadDataFromIStream(IStream stream, [MarshalAs(UnmanagedType.Bool)] bool prefetchPDB);

	int GetStreamSize(string stream, out ulong size);

	unsafe int GetStreamRawData(string stream, ulong byteOffset, ulong bufferSize, out ulong bytesWritten, byte* buffer);

	int SetMiniPdbErrorCallback(nint context, MiniPdbErrorCallback callback);

	int ValidatePdb(string pdbPath, ref Guid pdbSignature, uint signature, uint age, [MarshalAs(UnmanagedType.Bool)] out bool valid);
}