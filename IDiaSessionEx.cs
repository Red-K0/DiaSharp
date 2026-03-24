using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Enumerators;
using DiaSharp.Symbols;

namespace DiaSharp;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("cd24eed5-5fea-4742-a320-6254c920e78b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaSessionEx : IDiaSession
{
	[return: MarshalAs(UnmanagedType.Bool)]
	bool isFastLinkPDB();


	[return: MarshalAs(UnmanagedType.Bool)]
	bool isPortablePDB();

	IDiaEnumSourceLink getSourceLinkInfo(IDiaSymbol parent);
}
