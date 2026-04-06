namespace DiaSharp.SDK.Callbacks;

public partial interface ILoadCallback
{
	unsafe int NotifyDebugDirectory([MarshalAs(UnmanagedType.Bool)] bool executable, uint dataSize, byte* data);

	int NotifyOpenDebug([MarshalAs(UnmanagedType.BStr)] string debugPath, uint resultCode);

	int NotifyOpenPDB([MarshalAs(UnmanagedType.BStr)] string pdbPath, uint resultCode);

	int RestrictRegistryAccess();

	int RestrictSymbolServerAccess();
}
