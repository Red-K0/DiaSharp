using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("136d8151-ade7-4704-af13-324080762e8f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumSourceLink2 : IDiaEnumSourceLink
{
	ulong SizeOfNext2();

	[return: MarshalUsing(CountElementName = nameof(cb))]
	byte[] Next2(ulong cb, out ulong pcb);
}
