namespace DiaSharp.SDK.Callbacks;

public partial interface ILoadCallback
{
	unsafe void NotifyDebugDirectory([MarshalAs(UnmanagedType.Bool)] bool executable, uint dataSize, byte* data);

	void NotifyOpenDebug([MarshalAs(UnmanagedType.BStr)] string debugPath, uint resultCode);

	void NotifyOpenPDB([MarshalAs(UnmanagedType.BStr)] string pdbPath, uint resultCode);

	void RestrictRegistryAccess();

	void RestrictSymbolServerAccess();
}
