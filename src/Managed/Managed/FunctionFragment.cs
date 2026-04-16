namespace DiaSharp.Managed;

public readonly struct FunctionFragment(uint virtualAddress, uint length)
{
	public readonly uint VirutalAddress = virtualAddress;
	public readonly uint Length = length;
}