using DiaSharp.SDK.Enumerators;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.SDK;

[Guid("CD24EED5-5FEA-4742-A320-6254C920E78B")]
public partial interface ISessionEx : ISession
{
	int IsFastLinkPDB([MarshalAs(UnmanagedType.Bool)] out bool value);


	int IsPortablePDB([MarshalAs(UnmanagedType.Bool)] out bool value);

	int GetSourceLinkInfo(ISymbol parent, out IEnumSourceLink link);
}
