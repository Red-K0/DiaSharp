namespace DiaSharp.SDK.Callbacks;

public partial interface ILoadCallback2 : ILoadCallback
{
	int RestrictOriginalPathAccess();
	int RestrictReferencePathAccess();
	int RestrictDBGAccess();
	int RestrictSystemRootAccess();
}