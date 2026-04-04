using DiaSharp.Storage;

namespace DiaSharp.SDK;

public partial interface IPropertyStorage
{
	unsafe int ReadMultiple(uint specifierCount, PropertySpecifier* specifiers, out void* PropVariant);

	unsafe int ReadPropertyNames(uint propertyIDCount, uint* propertyIDs, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.BStr, SizeParamIndex = 0)] out string[] names);

	int GetEnum(out IEnumStatPropertyStorage enumerator);

	int ReadUint(uint id, out uint value);

	int ReadInt(out int value);

	int ReadBool(uint id, [MarshalAs(UnmanagedType.Bool)] out bool value);

	int ReadUlong(uint id, out ulong value);

	int ReadBStr(uint id, [MarshalAs(UnmanagedType.BStr)] out string value);
}
