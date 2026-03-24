using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.Symbols;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[DefaultMember("symIndexId")]
[Guid("64CE6CD5-7315-4328-86D6-10E303E010B4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public unsafe partial interface IDiaSymbol7 : IDiaSymbol6
{
	[DispId(224)]
	int get_isSignRet();
}
