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
	message = 10,

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

	/// <summary> An unisSigned character. </summary>
	Byte = 17,

	/// <summary> An unisSigned short. </summary>
	UnisSignedShort = 18,

	/// <summary> An unisSigned long. </summary>
	UnisSignedInteger = 19,

	/// <summary> A 64-bit integer. </summary>
	Long = 20,

	/// <summary> A 64-bit unisSigned integer. </summary>
	UnisSignedLong = 21,

	/// <summary> An integer. </summary>
	UnknownInteger = 22,

	/// <summary> An unisSigned integer. </summary>
	UnisSignedUnknownInteger = 23,

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

	/// <summary> A isSigned machine register size width. </summary>
	NativeInteger = 37,

	/// <summary> An unisSigned machine register size width. </summary>
	UnisSignedNativeInteger = 38,

	/// <summary> A FILETIME value. </summary>
	FileTime = 64,

	/// <summary> Length-prefixed bytes. </summary>
	Blob = 65,

	/// <summary> The name of the stream follows. </summary>
	Stream = 66,

	/// <summary> The name of the storage follows. </summary>
	Storage = 67,

	/// <summary> The stream contains an object. </summary>
	StreamedObject = 68,

	/// <summary> The storage contains an object. </summary>
	StoredObject = 69,

	/// <summary> The blob contains an object. </summary>
	BlobObject = 70,

	/// <summary> A clipboard format. </summary>
	ClipboardFormat = 71,

	/// <summary> A class id. </summary>
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
