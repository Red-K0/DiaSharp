namespace DiaSharp.Sdk.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("64CE6CD5-7315-4328-86D6-10E303E010B4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISymbol7 : ISymbol6
{
	[return: MarshalAs(UnmanagedType.Bool)]
	bool GetIsSignedReturn();
}
