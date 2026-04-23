using static DiaSharp.HR;

[assembly: InternalsVisibleTo("Managed")]

namespace DiaSharp;

file static class HR { public const uint BASE = ((uint)1 << 31) | ((uint)0x6d << 16), PDB = BASE | 1, DIA = BASE | 100, COFF = BASE | 200; }

[SuppressMessage("Naming", "CA1700:Do not name enum values 'Reserved'", Justification = "HRESULT name sourced from header file.")]
internal enum KnownResult : uint
{
	S_OK                                   = 0x00000000,
	S_FALSE                                = 0x00000001,

	CO_S_NOTALLINTERFACES                  = 0x00080012,

	E_NOTIMPL                              = 0x80004001,
	E_NOINTERFACE                          = 0x80004002,
	CLASS_E_NOAGGREGATION                  = 0x80040110,
	REGDB_E_CLASSNOTREG                    = 0x80040154,

	E_OUTOFMEMORY                          = 0x8007000E,
	E_INVALIDARG                           = 0x80070057,
	E_UNEXPECTED                           = 0x8000FFFF,

	E_PDB_OK                               =  PDB + 0,
	E_PDB_USAGE                            =  PDB + 1,
	E_PDB_OUT_OF_MEMORY                    =  PDB + 2,
	E_PDB_FILE_SYSTEM                      =  PDB + 3,
	E_PDB_NOT_FOUND                        =  PDB + 4,
	E_PDB_INVALID_SIG                      =  PDB + 5,
	E_PDB_INVALID_AGE                      =  PDB + 6,
	E_PDB_PRECOMP_REQUIRED                 =  PDB + 7,
	E_PDB_OUT_OF_TI                        =  PDB + 8,
	E_PDB_NOT_IMPLEMENTED                  =  PDB + 9,
	E_PDB_V1_PDB                           =  PDB + 10,
	E_PDB_FORMAT                           =  PDB + 11,
	E_PDB_LIMIT                            =  PDB + 12,
	E_PDB_CORRUPT                          =  PDB + 13,
	E_PDB_TI16                             =  PDB + 14,
	E_PDB_ACCESS_DENIED                    =  PDB + 15,
	E_PDB_ILLEGAL_TYPE_EDIT                =  PDB + 16,
	E_PDB_INVALID_EXECUTABLE               =  PDB + 17,
	E_PDB_DBG_NOT_FOUND                    =  PDB + 18,
	E_PDB_NO_DEBUG_INFO                    =  PDB + 19,
	E_PDB_INVALID_EXE_TIMESTAMP            =  PDB + 20,
	E_PDB_RESERVED                         =  PDB + 21,
	E_PDB_DEBUG_INFO_NOT_IN_PDB            =  PDB + 22,
	E_PDB_SYMSRV_BAD_CACHE_PATH            =  PDB + 23,
	E_PDB_SYMSRV_CACHE_FULL                =  PDB + 24,
	E_PDB_OBJECT_DISPOSED                  =  PDB + 25,
	E_PDB_MAX                              =  PDB + 26,
	E_PDB_IFC_RECORD_MISSING_DESIGNATOR    =  PDB + 27,
	E_PDB_IFC_RECORD_MISSING_REFERENCE     =  PDB + 28,
	E_PDB_IFC_FAILED_TO_LOAD               =  PDB + 29,
	E_PDB_IFC_FAILED_TO_LOAD_MISMATCH_HASH =  PDB + 30,
	E_PDB_IFC_DEBUG_STREAM_FAILED_OPEN     =  PDB + 31,
	E_PDB_IFC_DEBUG_STREAM_EMPTY           =  PDB + 32,
	E_PDB_IFC_DEBUG_STREAM_HASH_MISMATCH   =  PDB + 33,

	E_DIA_INPROLOG                         =  DIA + 0,
	E_DIA_SYNTAX                           =  DIA + 1,
	E_DIA_FRAME_ACCESS                     =  DIA + 2,
	E_DIA_VALUE                            =  DIA + 3,

	E_DIA_COFF_ACCESS                      = COFF + 0,
	E_DIA_COMP_PDB_ACCESS                  = COFF + 1,
}

static internal class Extensions
{
	public static unsafe int GetHashCode<T>(ref readonly T o) where T : unmanaged
	{
		HashCode code = new();

		fixed (T* ptr = &o) code.AddBytes(new(ptr, sizeof(T)));

		return code.ToHashCode();
	}

	public static unsafe bool ValueEquals<T>(T* a, T* b) where T : unmanaged => new ReadOnlySpan<T>(a, sizeof(T)).SequenceEqual(new ReadOnlySpan<T>(b, sizeof(T)));
}