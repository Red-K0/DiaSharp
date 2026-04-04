using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.SDK;

public partial interface ISessionEx : ISession
{
	int IsFastLinkPDB([MarshalAs(UnmanagedType.Bool)] out bool value);


	int IsPortablePDB([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetSourceLinkInfo(ISymbol parent, out IEnumSourceLink link);
}
