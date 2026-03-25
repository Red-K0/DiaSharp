using DiaSharp.Interop;

namespace DiaSharp.Structs;

[StructLayout(LayoutKind.Explicit)]
public struct Variant
{
	[FieldOffset(0)]
	public VariantType vt;

	[FieldOffset(2)]
	public ushort wReserved1;
	
	[FieldOffset(4)]
	public ushort wReserved2;
	
	[FieldOffset(6)]
	public ushort wReserved3;

	[FieldOffset(8)]
	public long llVal;

	[FieldOffset(8)]
	public int lVal;

	[FieldOffset(8)]
	public byte bVal;

	[FieldOffset(8)]
	public short iVal;

	[FieldOffset(8)]
	public float fltVal;

	[FieldOffset(8)]
	public double dblVal;
	
	[FieldOffset(8)]
	public short boolVal;
	
	[FieldOffset(8)]
	public IntPtr bstrVal;
	
	[FieldOffset(8)]
	public IntPtr punkVal;
	
	[FieldOffset(8)]
	public IntPtr pdispVal;
	
	[FieldOffset(8)]
	public IntPtr parray;
	
	[FieldOffset(8)]
	public IntPtr byref;

	[FieldOffset(8)]
	public decimal decVal;

	[FieldOffset(8)]
	public RecordStruct record;

	[StructLayout(LayoutKind.Sequential)]
	public struct RecordStruct
	{
		public IntPtr pvRecord;
		public IntPtr pRecInfo;
	}
}
