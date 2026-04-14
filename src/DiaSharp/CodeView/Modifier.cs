namespace DiaSharp.CodeView;

public enum Modifier
{
	Invalid = 0x0000,

	Const     = 0x0001,
	Volatile  = 0x0002,
	Unaligned = 0x0003,

	HlslUniform             = 0x0200,
	HlslLine                = 0x0201,
	HlslTriangle            = 0x0202,
	HlslLineadj             = 0x0203,
	HlslTriangleadj         = 0x0204,
	HlslLinear              = 0x0205,
	HlslCentroid            = 0x0206,
	HlslConstinterp         = 0x0207,
	HlslNoperspective       = 0x0208,
	HlslSample              = 0x0209,
	HlslCenter              = 0x020A,
	HlslSnorm               = 0x020B,
	HlslUnorm               = 0x020C,
	HlslPrecise             = 0x020D,
	HlslUavGloballyCoherent = 0x020E,
}
