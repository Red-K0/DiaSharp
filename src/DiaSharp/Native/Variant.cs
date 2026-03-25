using DiaSharp.Interop;

namespace DiaSharp.Native;

[StructLayout(LayoutKind.Explicit)]
public struct Variant : IEquatable<Variant>
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
	public VariantRecord record;

	public override readonly bool Equals(object? obj) => obj is Variant variant && this == variant;

	public override unsafe int GetHashCode()
	{
		HashCode code = new();

		fixed (Variant* variant = &this) code.AddBytes(new(variant, sizeof(Variant)));

		return code.ToHashCode();
	}

	public static unsafe bool operator ==(Variant left, Variant right)
	{
		return new ReadOnlySpan<byte>(&left, sizeof(Variant)) == new ReadOnlySpan<byte>(&right, sizeof(Variant));
	}

	public static unsafe bool operator !=(Variant left, Variant right)
	{
		return new ReadOnlySpan<byte>(&left, sizeof(Variant)) != new ReadOnlySpan<byte>(&right, sizeof(Variant));
	}

	public readonly bool Equals(Variant other) => this == other;
}

[StructLayout(LayoutKind.Sequential)]
public struct VariantRecord : IEquatable<VariantRecord>
{
	public IntPtr Record, RecordInfo;

	public override readonly bool Equals(object? obj) => obj is VariantRecord record && this == record;

	public override readonly unsafe int GetHashCode()
	{
		HashCode code = new();

		fixed (VariantRecord* record = &this) code.AddBytes(new(record, sizeof(VariantRecord)));

		return code.ToHashCode();
	}

	public static unsafe bool operator ==(VariantRecord left, VariantRecord right)
	{
		return sizeof(nint) == 8 ? *(UInt128*)&left == *(UInt128*)&right : *(ulong*)&left == *(ulong*)&right;

	}

	public static unsafe bool operator !=(VariantRecord left, VariantRecord right)
	{
		return sizeof(nint) == 8 ? *(UInt128*)&left != *(UInt128*)&right : *(ulong*)&left != *(ulong*)&right;
	}

	public readonly bool Equals(VariantRecord other) => this == other;
}