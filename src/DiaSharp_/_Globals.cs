using System.Runtime.CompilerServices;

[assembly: DisableRuntimeMarshalling]

namespace DiaSharp;

#pragma warning disable IDE1006

static internal class _Globals
{
	public const string HlslObsoleteMessage = "The newer DXC compiler no longer produces PDBs. This API only has valid values on PDBs produced by the older fxc.exe compiler.";
}

#pragma warning restore IDE1006