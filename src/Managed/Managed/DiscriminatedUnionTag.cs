using DiaSharp.Native;

namespace DiaSharp.Managed;

[StructLayout(LayoutKind.Auto)]
public readonly struct DiscriminatedUnionTag : IEquatable<DiscriminatedUnionTag>
{
	internal DiscriminatedUnionTag(Symbol type, uint offset, TagValue mask)
	{
		Type = type;
		Offset = offset;
		Mask = mask;
	}

	public readonly Symbol Type;
	public readonly uint Offset;
	public readonly TagValue Mask;

	public override bool Equals(object? obj) => obj is DiscriminatedUnionTag tag && this == tag;

	public override int GetHashCode() => HashCode.Combine(Type.GetHashCode(), Offset, Mask);

	public static bool operator ==(DiscriminatedUnionTag left, DiscriminatedUnionTag right)
	{
		return left.Type == right.Type && left.Offset == right.Offset && left.Mask == right.Mask;
	}

	public static bool operator !=(DiscriminatedUnionTag left, DiscriminatedUnionTag right)
	{
		return left.Type != right.Type || left.Offset != right.Offset || left.Mask != right.Mask;
	}

	public bool Equals(DiscriminatedUnionTag other) => this == other;
}
