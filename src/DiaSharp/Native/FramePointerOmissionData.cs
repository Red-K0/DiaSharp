namespace DiaSharp.Native;

/// <summary>
/// Represents the stack frame layout for a function on an x86 computer when frame pointer omission (FPO) optimization is used. The structure is used to locate the base of the call frame.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct FramePointerOmissionData : IEquatable<FramePointerOmissionData>
{
	/// <summary>
	/// The offset of the first byte of the function code.
	/// </summary>
	public uint OffStart;

	/// <summary>
	/// The number of bytes in the function.
	/// </summary>
	public uint FunctionSize;

	/// <summary>
	/// The number of local variables.
	/// </summary>
	public uint LocalCount;

	/// <summary>
	/// The size of the parameters, in as a <see langword="uint"/> count.
	/// </summary>
	public ushort ParameterSize;

	private ushort _bitfield;

	/// <summary>
	/// The number of bytes in the function prolog code.
	/// </summary>
	public byte PrologSize
	{
		readonly get => (byte)(_bitfield & 0xFF);
		set => _bitfield = (ushort)((_bitfield & ~0x00FF) | value);
	}

	/// <summary>
	/// The number of registers saved.
	/// </summary>
	public byte RegisterCount
	{
		readonly get => (byte)((_bitfield >> 8) & 0x7);
		set => _bitfield = (ushort)((_bitfield & ~(0x7 << 8)) | ((value & 0x7) << 8));
	}

	/// <summary>
	/// A variable that indicates whether the function uses structured exception handling.
	/// </summary>
	public bool UsesStructuredExceptionHandling
	{
		readonly get => ((_bitfield >> 11) & 0x1) != 0;
		set => _bitfield = (ushort)((_bitfield & ~(1 << 11)) | ((value ? 1 : 0) << 11));
	}

	/// <summary>
	/// A variable that indicates whether the EBP register has been allocated.
	/// </summary>
	public bool UsesEBP
	{
		readonly get => ((_bitfield >> 12) & 0x1) != 0;
		set => _bitfield = (ushort)((_bitfield & ~(1 << 12)) | ((value ? 1 : 0) << 12));
	}

	/// <summary>
	/// Reserved for future use.
	/// </summary>
	public bool Reserved
	{
		readonly get => ((_bitfield >> 13) & 0x1) != 0;
		set => _bitfield = (ushort)((_bitfield & ~(1 << 13)) | ((value ? 1 : 0) << 13));
	}

	/// <summary>
	/// A variable that indicates the frame type.
	/// </summary>
	public StackFrameType FrameType
	{
		readonly get => (StackFrameType)((_bitfield >> 14) & 0x3);
		set => _bitfield = (ushort)((_bitfield & ~(0x3 << 14)) | (((byte)value & 0x3) << 14));
	}

	public override readonly bool Equals(object? obj) => obj is FramePointerOmissionData data && this == data;

	public override readonly unsafe int GetHashCode()
	{
		HashCode code = new();

		fixed (FramePointerOmissionData* data = &this) code.AddBytes(new(data, sizeof(FramePointerOmissionData)));

		return code.ToHashCode();
	}

	public static unsafe bool operator ==(FramePointerOmissionData left, FramePointerOmissionData right)
	{
		return *(UInt128*)&left == *(UInt128*)&right;
	}

	public static unsafe bool operator !=(FramePointerOmissionData left, FramePointerOmissionData right)
	{
		return *(UInt128*)&left != *(UInt128*)&right;
	}

	public readonly bool Equals(FramePointerOmissionData other) => this == other;
}
