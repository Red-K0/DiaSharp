using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[DefaultMember(nameof(Item))]
[Guid("08CBB41E-47A6-4F87-92F1-1C9C87CED044")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumDebugStreams
{
	IEnumVARIANT get__NewEnum();

	[DispId(1)]
	int get_Count();

	IDiaEnumDebugStreamData Item(uint index);

	uint Next(uint celt, [MarshalUsing(CountElementName = nameof(celt))] out IDiaEnumDebugStreamData[] rgelt);

	void Skip(uint celt);

	void Reset();

	IDiaEnumDebugStreams Clone();
}
