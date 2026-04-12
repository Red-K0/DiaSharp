namespace DiaSharp.SDK.Enumerators;

[Guid("EC9D461D-CE74-4711-A020-7D8F9A1DD255")]
public partial interface IEnumStackFrames
{
	unsafe int GetNext(uint frameCount, void** frames, out uint framesFetched);

	int Reset();
}
