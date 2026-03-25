using DiaSharp.Sdk.Enumerators;
using DiaSharp.Sdk.Symbols;

namespace DiaSharp.Sdk;

[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("cd24eed5-5fea-4742-a320-6254c920e78b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISessionEx : ISession
{
	[return: MarshalAs(UnmanagedType.Bool)]
	bool IsFastLinkPDB();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool IsPortablePDB();

	IEnumSourceLink GetSourceLinkInfo(ISymbol parent);
}
