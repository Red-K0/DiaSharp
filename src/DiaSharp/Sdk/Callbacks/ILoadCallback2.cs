namespace DiaSharp.SDK.Callbacks;

public partial interface ILoadCallback2 : ILoadCallback
{
	void RestrictOriginalPathAccess();
	void RestrictReferencePathAccess();
	void RestrictDBGAccess();
	void RestrictSystemRootAccess();
}