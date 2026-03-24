using System.Runtime.CompilerServices;

[assembly: DisableRuntimeMarshalling]

namespace DiaSharp.Interop;

#pragma warning disable IDE1006 // Naming Styles

public class Constants
{
	internal const string HlslObsoleteMessage = "The newer DXC compiler no longer produces PDBs. This API only has valid values on PDBs produced by the older fxc.exe compiler.";

	public const string
			 DiaSourceGUID = "e6756135-1e65-4d17-8576-610761398c3c",
		  DiaSourceAltGUID = "91904831-49ca-4766-b95c-25397e2dd6dc",
		DiaStackWalkerGUID = "ce4a85db-5768-475b-a4e1-c0bca2112a6b";
}

#pragma warning restore IDE1006
