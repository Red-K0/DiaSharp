using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DiaSharp.COM;

public static class Constants
{
	public static readonly string IUnknownIID = "00000000-0000-0000-C000-000000000046";

	[FixedAddressValueType] public static readonly Guid IUnknownGUID = new(IUnknownIID);

	[EditorBrowsable(EditorBrowsableState.Advanced)] public static readonly unsafe Guid* _IUnknownGUID;


	public static readonly string DiaSourceCLSID = "e6756135-1e65-4d17-8576-610761398c3c";

	[FixedAddressValueType] public static readonly Guid DiaSourceGUID = new(DiaSourceCLSID);

	[EditorBrowsable(EditorBrowsableState.Advanced)] public static readonly unsafe Guid* _DiaSourceGUID;


	public static readonly string DiaSourceAltCLSID = "91904831-49ca-4766-b95c-25397e2dd6dc";

	[FixedAddressValueType] public static readonly Guid DiaSourceAltGUID = new(DiaSourceAltCLSID);

	[EditorBrowsable(EditorBrowsableState.Advanced)] public static readonly unsafe Guid* _DiaSourceAltGUID;


	public static readonly string DiaStackWalkerCLSID = "ce4a85db-5768-475b-a4e1-c0bca2112a6b";

	[FixedAddressValueType] public static readonly Guid DiaStackWalkerGUID = new(DiaStackWalkerCLSID);

	[EditorBrowsable(EditorBrowsableState.Advanced)] public static readonly unsafe Guid* _DiaStackWalkerGUID;

	static unsafe Constants()
	{
		fixed (Guid* unknown = &IUnknownGUID, source = &DiaSourceGUID, altSource = &DiaSourceAltGUID, stack = &DiaStackWalkerGUID)
		{
			      _IUnknownGUID = unknown;
			     _DiaSourceGUID = source;
			  _DiaSourceAltGUID = altSource;
			_DiaStackWalkerGUID = stack;
		}
	}
}
