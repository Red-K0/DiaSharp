using System.Runtime.InteropServices.Marshalling;
using DiaSharp.StructuredStorage;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("9d416f9c-e184-45b2-a4f0-ce517f719e9b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IPropertyStorage
{
	unsafe void* ReadMultiple(uint specifierCount, [MarshalUsing(CountElementName = nameof(specifierCount))] [In] PropertySpecifier[] specifiers);

	[return: MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.BStr, SizeParamIndex = 0)]
	string[] ReadPropertyNames(uint propertyIDCount, [MarshalUsing(CountElementName = nameof(propertyIDCount))] [In] uint[] propertyIDs);

	IEnumStatPropertyStorage GetEnum();

	uint ReadUint(uint id);

	int ReadInt();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool ReadBool(uint id);

	ulong ReadUlong(uint id);

	[return: MarshalAs(UnmanagedType.BStr)]
	string ReadBStr(uint id);
}
