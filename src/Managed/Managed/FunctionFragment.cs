namespace DiaSharp.Managed;

[StructLayout(LayoutKind.Sequential)]
public readonly struct FunctionFragment(uint virtualAddress, uint length) : IEquatable<FunctionFragment>
{
	public readonly uint VirutalAddress = virtualAddress;
	public readonly uint Length = length;

	public override bool Equals(object? obj) => obj is FunctionFragment fragment && this == fragment;

	public override int GetHashCode() => (int)(VirutalAddress ^ Length);

	public static unsafe bool operator ==(FunctionFragment left, FunctionFragment right)
	{
		return *(ulong*)&left == *(ulong*)&right;
	}

	public static unsafe bool operator !=(FunctionFragment left, FunctionFragment right)
	{
		return *(ulong*)&left != *(ulong*)&right;
	}

	public bool Equals(FunctionFragment other) => this == other;
}