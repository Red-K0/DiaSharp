using DiaSharp.Interop;

namespace DiaSharp.CodeView;

public enum Modifier
{
	Invalid = 0x0000,

	Const     = 0x0001,
	Volatile  = 0x0002,
	Unaligned = 0x0003,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslUniform             = 0x0200,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslLine                = 0x0201,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslTriangle            = 0x0202,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslLineadj             = 0x0203,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslTriangleadj         = 0x0204,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslLinear              = 0x0205,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslCentroid            = 0x0206,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslConstinterp         = 0x0207,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslNoperspective       = 0x0208,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslSample              = 0x0209,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslCenter              = 0x020A,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslSnorm               = 0x020B,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslUnorm               = 0x020C,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslPrecise             = 0x020D,

	[Obsolete(Constants.HlslObsoleteMessage)]
	HlslUavGloballyCoherent = 0x020E,
}
