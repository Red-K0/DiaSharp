namespace DiaSharp.SDK.Enumerators;

public partial interface IEnumStackFrames
{
	unsafe int GetNext(uint frameCount, void** frames, out uint framesFetched);

	int Reset();
}
