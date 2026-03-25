using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp.Enumerators;

[GeneratedComInterface]
[Guid("486943E8-D187-4A6B-A3C4-291259FFF60D")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IEnumDebugStreamData
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetName();

	[return: MarshalUsing(CountElementName = nameof(bytesWritten))]
	byte[] Item(uint index, uint bufferSize, out uint bytesWritten);

	uint Next(uint dataCount, uint bufferSize, out uint bytesWritten, [MarshalUsing(CountElementName = nameof(bufferSize))] out byte[] dataBuffer);

	void Skip(uint dataCount);

	void Reset();

	IEnumDebugStreamData Clone();
}
