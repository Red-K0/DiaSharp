using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("E8368CA9-01D1-419d-AC0C-E31235DBDA9F")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumSegments
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	ISegment Item(uint index);

	uint GetNext(uint segmentCount, [MarshalUsing(CountElementName = MarshalUsingAttribute.ReturnsCountValue)] out ISegment[] segments);

	void Skip(uint segmentCount);

	void Reset();

	IEnumSegments Clone();
}
