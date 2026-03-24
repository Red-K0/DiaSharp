using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("45cd1eb3-5c6c-43e3-b20a-a4d8035de4e2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaEnumSourceLink
{
	uint Count();

	uint SizeOfNext();

	[return: MarshalUsing(CountElementName = nameof(cb))]
	byte[] Next(uint cb, out uint pcb);

	void Skip(uint cb);

	void Reset();

	IDiaEnumSourceLink Clone();
}
