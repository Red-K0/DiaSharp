using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Callbacks;

[GeneratedComInterface]
[Guid("C32ADB82-73F4-421b-95D5-A4706EDF5DBE")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ILoadCallback
{
	[return: MarshalUsing(CountElementName = nameof(dataSize))]
	byte[] NotifyDebugDirectory([MarshalAs(UnmanagedType.Bool)] bool executable, uint dataSize);

	void NotifyOpenDebug([MarshalAs(UnmanagedType.BStr)] string debugPath, HRESULT resultCode);

	void NotifyOpenPDB([MarshalAs(UnmanagedType.BStr)] string pdbPath, HRESULT resultCode);

	void RestrictRegistryAccess();

	void RestrictSymbolServerAccess();
}
