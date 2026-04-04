using DiaSharp.Interop;

namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumDebugStreamData
{
	IEnumVARIANT GetNewEnum();

	int GetCount();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetName();

	unsafe void Item(uint index, uint bufferSize, uint* bytesWritten, byte* buffer);

	unsafe uint GetNext(uint dataCount, uint bufferSize, uint* bytesWritten, byte* dataBuffer);

	void Skip(uint dataCount);

	void Reset();

	IEnumDebugStreamData Clone();
}
