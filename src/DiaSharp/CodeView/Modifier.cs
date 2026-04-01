namespace DiaSharp.CodeView;

public enum Modifier
{
	Invalid = 0x0000,

	Const     = 0x0001,
	Volatile  = 0x0002,
	Unaligned = 0x0003,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslUniform             = 0x0200,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslLine                = 0x0201,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslTriangle            = 0x0202,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslLineadj             = 0x0203,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslTriangleadj         = 0x0204,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslLinear              = 0x0205,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslCentroid            = 0x0206,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslConstinterp         = 0x0207,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslNoperspective       = 0x0208,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslSample              = 0x0209,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslCenter              = 0x020A,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslSnorm               = 0x020B,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslUnorm               = 0x020C,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslPrecise             = 0x020D,

	[Obsolete(_Globals.HlslObsoleteMessage)]
	HlslUavGloballyCoherent = 0x020E,
}
