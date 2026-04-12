using DiaSharp.Storage;

namespace DiaSharp.SDK;

[Guid("9D416F9C-E184-45B2-A4F0-CE517F719E9B")]
public partial interface IPropertyStorage
{
	unsafe int ReadMultiple(uint specifierCount, PropertySpecifier* specifiers, out void* propVariant);

	unsafe int ReadPropertyNames(uint propertyIDCount, uint* propertyIDs, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.BStr, SizeParamIndex = 0)] out string[] names);

	int GetEnum(out IEnumStatPropertyStorage enumerator);

	int ReadUint(uint id, out uint value);

	int ReadInt(out int value);

	int ReadBool(uint id, [MarshalAs(UnmanagedType.Bool)] out bool value);

	int ReadUlong(uint id, out ulong value);

	int ReadBStr(uint id, [MarshalAs(UnmanagedType.BStr)] out string value);
}
