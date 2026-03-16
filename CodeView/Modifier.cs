namespace DiaSharp.CodeView;

public enum Modifier
{
    Invalid = 0x0000,

    Const     = 0x0001,
    Volatile  = 0x0002,
    Unaligned = 0x0003,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslUniform             = 0x0200,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslLine                = 0x0201,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslTriangle            = 0x0202,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslLineadj             = 0x0203,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslTriangleadj         = 0x0204,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslLinear              = 0x0205,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslCentroid            = 0x0206,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslConstinterp         = 0x0207,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslNoperspective       = 0x0208,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslSample              = 0x0209,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslCenter              = 0x020A,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslSnorm               = 0x020B,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslUnorm               = 0x020C,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslPrecise             = 0x020D,

    [Obsolete(__Constants.HlslObsoleteMessage)]
    HlslUavGloballyCoherent = 0x020E,
}
