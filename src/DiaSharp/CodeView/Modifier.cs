namespace DiaSharp.CodeView;

public enum Modifier
{
	Invalid = 0x0000,

	Const     = 0x0001,
	Volatile  = 0x0002,
	Unaligned = 0x0003,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslUniform             = 0x0200,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslLine                = 0x0201,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslTriangle            = 0x0202,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslLineadj             = 0x0203,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslTriangleadj         = 0x0204,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslLinear              = 0x0205,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslCentroid            = 0x0206,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslConstinterp         = 0x0207,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslNoperspective       = 0x0208,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslSample              = 0x0209,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslCenter              = 0x020A,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslSnorm               = 0x020B,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslUnorm               = 0x020C,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslPrecise             = 0x020D,

	[Obsolete(_Constants.HlslObsoleteMessage)]
	HlslUavGloballyCoherent = 0x020E,
}
