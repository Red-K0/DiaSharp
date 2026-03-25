using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Callbacks;

[GeneratedComInterface]
[Guid("C32ADB82-73F4-421b-95D5-A4706EDF5DBE")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface LoadCallback
{
	void NotifyDebugDir([MarshalAs(UnmanagedType.Bool)] bool fExecutable, uint cbData, [MarshalUsing(CountElementName = nameof(cbData))] byte[] pbData);

	void NotifyOpenDBG([MarshalAs(UnmanagedType.BStr)] string dbgPath, HRESULT resultCode);

	void NotifyOpenPDB([MarshalAs(UnmanagedType.BStr)] string pdbPath, HRESULT resultCode);

	void RestrictRegistryAccess();

	void RestrictSymbolServerAccess();
}
