namespace DiaSharp.SDK.Callbacks;

/// <summary>
/// Provides the file name and error code for the last load error for fastlink PDBs.
/// </summary>
/// <param name="context"> The context that was passed into the call to the DataSourceEx::setPfnMiniPDBErrorCallback2 method. </param>
/// <param name="errorCode"> The error code describing the particular error. </param>
/// <param name="objOrPDB"> The name of the OBJ or PDB file that is related to the error. </param>
/// <param name="lib"> If <paramref name="objOrPDB"/> refers to an OBJ file within a LIB file, this is the name of the LIB. Otherwise it is <see langword="null"/>. </param>
/// <returns> The return value is ignored. </returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int MiniPDBErrorCallback(nint context, uint errorCode, char* objOrPDB, char* lib);