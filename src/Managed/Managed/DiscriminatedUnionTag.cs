using DiaSharp.Native;

namespace DiaSharp.Managed;

public readonly struct DiscriminatedUnionTag
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
}
