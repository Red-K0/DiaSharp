namespace DiaSharp.Sdk.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("ABE2DE00-DC2D-4793-AF9A-EF1D90832644")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISymbol5 : ISymbol4
{
	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetHasAbsoluteAddress();
}
