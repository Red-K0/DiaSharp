namespace DiaSharp.SDK.Callbacks;

[Guid("4688A074-5A4D-4486-AEA8-7B90711D9F7C")]
public partial interface ILoadCallback2 : ILoadCallback
{
	int RestrictOriginalPathAccess();

	int RestrictReferencePathAccess();

	int RestrictDBGAccess();

	int RestrictSystemRootAccess();
}