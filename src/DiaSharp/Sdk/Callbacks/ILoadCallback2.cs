namespace DiaSharp.SDK.Callbacks;

[GeneratedComInterface]
[Guid("4688a074-5a4d-4486-aea8-7b90711d9f7c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ILoadCallback2 : ILoadCallback
{
	void RestrictOriginalPathAccess();
	void RestrictReferencePathAccess();
	void RestrictDBGAccess();
	void RestrictSystemRootAccess();
}