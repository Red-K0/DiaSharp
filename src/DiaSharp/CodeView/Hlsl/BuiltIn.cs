namespace DiaSharp.CodeView.Hlsl;

/// <summary>
/// Specifies the HLSL built in type kind.
/// </summary>
/// <remarks>
/// Use the Symbol::GetbuiltInKind method to retrieve the built in type kind for a HLSL symbol.
/// </remarks>
public enum BuiltIn
{
	Invalid = 0x0000,

	InterfacePointer        = 0x0200,
	Texture1D               = 0x0201,
	Texture1DArray          = 0x0202,
	Texture2D               = 0x0203,
	Texture2DArray          = 0x0204,
	Texture3D               = 0x0205,
	TextureCube             = 0x0206,
	TextureCubeArray        = 0x0207,
	Texture2DMs             = 0x0208,
	Texture2DMsArray        = 0x0209,
	Sampler                 = 0x020A,
	SamplerComparison       = 0x020B,
	Buffer                  = 0x020C,
	PointStream             = 0x020D,
	LineStream              = 0x020E,
	TriangleStream          = 0x020F,
	InputPatch              = 0x0210,
	OutputPatch             = 0x0211,
	RWTexture1D             = 0x0212,
	RWTexture1DArray        = 0x0213,
	RWTexture2D             = 0x0214,
	RWTexture2DArray        = 0x0215,
	RWTexture3D             = 0x0216,
	RWBuffer                = 0x0217,
	ByteAddressBuffer       = 0x0218,
	RWByteAddressBuffer     = 0x0219,
	StructuredBuffer        = 0x021A,
	RWStructuredBuffer      = 0x021B,
	AppendStructuredBuffer  = 0x021C,
	ConsumeStructuredBuffer = 0x021D,
	Min8Float               = 0x021E,
	Min10Float              = 0x021F,
	Min16Float              = 0x0220,
	Min12Int                = 0x0221,
	Min16Int                = 0x0222,
	Min16Uint               = 0x0223,
	ConstantBuffer          = 0x0224,
}
