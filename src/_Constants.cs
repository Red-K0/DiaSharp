using System.Runtime.CompilerServices;

[assembly: DisableRuntimeMarshalling]

namespace DiaSharp;

#pragma warning disable IDE1006

internal class _Constants
{
	public const string HlslObsoleteMessage = "The newer DXC compiler no longer produces PDBs. This API only has valid values on PDBs produced by the older fxc.exe compiler.";
}

#pragma warning restore IDE1006

public static class DiaCLSIDs
{
	public const string
			 DiaSource = "e6756135-1e65-4d17-8576-610761398c3c",
		  DiaSourceAlt = "91904831-49ca-4766-b95c-25397e2dd6dc",
		DiaStackWalker = "ce4a85db-5768-475b-a4e1-c0bca2112a6b";
}

public static class DiaGUIDs
{
	public static readonly Guid
			 DiaSource = new("e6756135-1e65-4d17-8576-610761398c3c"),
		  DiaSourceAlt = new("91904831-49ca-4766-b95c-25397e2dd6dc"),
		DiaStackWalker = new("ce4a85db-5768-475b-a4e1-c0bca2112a6b");
}
