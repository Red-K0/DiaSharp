namespace DiaSharp.Storage;

/// <summary>
/// Specifies the conditions for performing the commit operation in <see cref="IStream.Commit(CommitFlags)"/>.
/// </summary>
[Flags]
public enum CommitFlags
{
	/// <summary>
	/// You can specify this condition with <see cref="Consolidate"/>, or some combination of the other three flags in this list of elements. Use this value to increase the readability of code.
	/// </summary>
	None = 0,

	/// <summary>
	/// The commit operation can overwrite existing data to reduce overall space requirements.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This value is not recommended for typical usage because it is not as robust as the default value.
	/// In this case, it is possible for the commit operation to fail after the old data is overwritten, but before the new data is completely committed.
	/// Then, neither the old version nor the new version of the storage object will be intact.
	/// </para>
	/// <para> You can use this value in the following cases: </para>
	/// <list type="bullet">
	/// <item> The user is willing to risk losing the data. </item>
	/// <item> The low-memory save sequence will be used to safely save the storage object to a smaller file. </item>
	/// <item> A previous commit reported STG_E_MEDIUMFULL, but overwriting the existing data would provide enough space to commit changes to the storage object. </item>
	/// </list>
	/// <para>
	/// Be aware that the commit operation verifies that adequate space exists before any overwriting occurs. Thus, if the commit operation fails due to space requirements, the old data is safe.
	/// It is possible, however, for data loss to occur with the <see cref="Overwrite"/> value specified if the commit operation fails for any reason other than lack of disk space.
	/// </para>
	/// </remarks>
	Overwrite = 1,

	/// <summary>
	/// Prevents multiple users of a storage object from overwriting each other's changes.
	/// </summary>
	/// <remarks>
	/// <para>
	/// The commit operation occurs only if there have been no changes to the saved storage object because the user most recently opened it.
	/// Thus, the saved version of the storage object is the same version that the user has been editing.
	/// </para>
	/// <para>
	/// If other users have changed the storage object, the commit operation fails and returns the STG_E_NOTCURRENT value.
	/// To override this behavior, call <see cref="IStream.Commit(CommitFlags)"/> again using the <see cref="None"/> value.
	/// </para>
	/// </remarks>
	OnlyIfCurrent = 2,

	/// <summary>
	/// Commits the changes to a write-behind disk cache, but does not save the cache to the disk.
	/// </summary>
	/// <remarks>
	/// <para>
	/// In a write-behind disk cache, the operation that writes to disk actually writes to a disk cache, thus increasing performance.
	/// The cache is eventually written to the disk, but usually not until after the write operation has already returned.
	/// </para>
	/// <para> The performance increase comes at the expense of an increased risk of losing data if a problem occurs before the cache is saved and the data in the cache is lost. </para>
	/// <para>
	/// If you do not specify this value, then committing changes to root-level storage objects is robust even if a disk cache is used.
	/// The two-phase commit process ensures that data is stored on the disk and not just to the disk cache.
	/// </para>
	/// </remarks>
	DangerouslyCommitMerelyToDiskCache = 4,

	/// <summary>
	/// On Windows 2000 and Windows XP: Indicates that a storage should be consolidated after it is committed, resulting in a smaller file on disk.
	/// </summary>
	/// <remarks>
	/// <para> This flag is valid only on the outermost storage object that has been opened in transacted mode. It is not valid for streams. </para>
	/// <para> The <see cref="Consolidate"/> flag can be combined with any other STGC flags. </para>
	/// </remarks>
	Consolidate = 8
}
