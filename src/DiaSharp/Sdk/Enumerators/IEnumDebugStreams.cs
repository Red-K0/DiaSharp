using DiaSharp.Interop;

namespace DiaSharp.Sdk.Enumerators;

[GeneratedComInterface]
[Guid("08CBB41E-47A6-4F87-92F1-1C9C87CED044")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumDebugStreams
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	IEnumDebugStreamData Item(uint index);

	uint GetNext(uint dataCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out IEnumDebugStreamData[] steamDatas);

	void Skip(uint dataCount);

	void Reset();

	IEnumDebugStreams Clone();
}
