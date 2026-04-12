namespace DiaSharp.SDK.Callbacks;

[Guid("C32ADB82-73F4-421b-95D5-A4706EDF5DBE")]
public partial interface ILoadCallback
{
	unsafe int NotifyDebugDirectory([MarshalAs(UnmanagedType.Bool)] bool executable, uint dataSize, byte* data);

	int NotifyOpenDebug([MarshalAs(UnmanagedType.BStr)] string debugPath, uint resultCode);

	int NotifyOpenPDB([MarshalAs(UnmanagedType.BStr)] string pdbPath, uint resultCode);

	int RestrictRegistryAccess();

	int RestrictSymbolServerAccess();
}
