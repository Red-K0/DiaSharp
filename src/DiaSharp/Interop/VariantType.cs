namespace DiaSharp.Interop;

[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Type names necessary.")]
public enum VariantType : ushort
{
	/// <summary> Not specified. </summary>
	Empty = 0,

	/// <summary> Null. </summary>
	Null = 1,

	/// <summary> A 2-byte integer. </summary>
	Short = 2,

	/// <summary> A 4-byte integer. </summary>
	Integer = 3,

	/// <summary> A 4-byte real. </summary>
	Float = 4,

	/// <summary> An 8-byte real. </summary>
	Double = 5,

	/// <summary> Currency. </summary>
	Currency = 6,

	/// <summary> A date. </summary>
	Date = 7,

	/// <summary> A string. </summary>
	BinaryString = 8,

	/// <summary> An IDispatch pointer. </summary>
	IDispatch = 9,

	/// <summary> An SCODE value. </summary>
	Error = 10,

	/// <summary> A Boolean value. True is -1 and false is 0. </summary>
	Boolean = 11,

	/// <summary> A VARIANT pointer. </summary>
	Variant = 12,

	/// <summary> An IUnknown pointer. </summary>
	IUnknown = 13,

	/// <summary> A 16-byte fixed-pointer value. </summary>
	Decimal = 14,

	/// <summary> A character. </summary>
	SignedByte = 16,

	/// <summary> An unsigned character. </summary>
	Byte = 17,

	/// <summary> An unsigned short. </summary>
	UnsignedShort = 18,

	/// <summary> An unsigned long. </summary>
	UnsignedInteger = 19,

	/// <summary> A 64-bit integer. </summary>
	Long = 20,

	/// <summary> A 64-bit unsigned integer. </summary>
	UnsignedLong = 21,

	/// <summary> An integer. </summary>
	UnknownInteger = 22,

	/// <summary> An unsigned integer. </summary>
	UnsignedUnknownInteger = 23,

	/// <summary> A C-style void. </summary>
	Void = 24,

	/// <summary> An HRESULT value. </summary>
	ResultHandle = 25,

	/// <summary> A pointer type. </summary>
	Pointer = 26,

	/// <summary> A safe array. </summary>
	SafeArray = 27,

	/// <summary> A C-style array. </summary>
	CArray = 28,

	/// <summary> A user-defined type. </summary>
	UserDefined = 29,

	/// <summary> A null-terminated string. </summary>
	LPString = 30,

	/// <summary> A wide null-terminated string. </summary>
	LPWideString = 31,

	/// <summary> A user-defined type. </summary>
	UserDefinedRecord = 36,

	/// <summary> A signed machine register size width. </summary>
	NativeInteger = 37,

	/// <summary> An unsigned machine register size width. </summary>
	UnsignedNativeInteger = 38,

	/// <summary> A FILETIME value. </summary>
	FileTime = 64,

	/// <summary> Length-prefixed bytes. </summary>
	Blob = 65,

	/// <summary> The name of the stream follows. </summary>
	Stream = 66,

	/// <summary> The name of the DiaSharp.Storage follows. </summary>
	Storage = 67,

	/// <summary> The stream contains an object. </summary>
	StreamedObject = 68,

	/// <summary> The DiaSharp.Storage contains an object. </summary>
	StoredObject = 69,

	/// <summary> The blob contains an object. </summary>
	BlobObject = 70,

	/// <summary> A clipboard format. </summary>
	ClipboardFormat = 71,

	/// <summary> A class ID. </summary>
	ClassID = 72,

	/// <summary> A stream with a GUID version. </summary>
	VersionedStream = 73,

	/// <summary> A simple counted array. </summary>
	Vector = 0x1000,

	/// <summary> A SAFEARRAY pointer. </summary>
	Array = 0x2000,

	/// <summary> A void pointer for local use. </summary>
	ByRef = 0x4000,

	TypeMask = 0x0FFF,
	Illegal = 0xFFFF,
}
