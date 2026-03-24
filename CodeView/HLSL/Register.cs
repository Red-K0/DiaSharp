using DiaSharp.Interop;

namespace DiaSharp.CodeView.Hlsl;

/// <summary>
/// Specifies the HLSL register type.
/// </summary>
/// <remarks>
/// Retrieved via IDiaSymbol::get_registerType for HLSL symbols.
/// </remarks>
[Obsolete(Constants.HlslObsoleteMessage)]
internal enum Register
{
	Temp                          = 0,
	Input                         = 1,
	Output                        = 2,
	IndexableTemp                 = 3,
	Immediate32                   = 4,
	Immediate64                   = 5,
	Sampler                       = 6,
	Resource                      = 7,
	ConstantBuffer                = 8,
	ImmediateConstantBuffer       = 9,
	Label                         = 10,
	InputPrimitiveId              = 11,
	OutputDepth                   = 12,
	Null                          = 13,
	Rasterizer                    = 14,
	OutputCoverageMask            = 15,
	Stream                        = 16,
	FunctionBody                  = 17,
	FunctionTable                 = 18,
	Interface                     = 19,
	FunctionInput                 = 20,
	FunctionOutput                = 21,
	OutputControlPointId          = 22,
	InputForkInstanceId           = 23,
	InputJoinInstanceId           = 24,
	InputControlPoint             = 25,
	OutputControlPoint            = 26,
	InputPatchConstant            = 27,
	InputDomainPoint              = 28,
	ThisPointer                   = 29,
	UnorderedAccessView           = 30,
	ThreadGroupSharedMemory       = 31,
	InputThreadId                 = 32,
	InputThreadGroupId            = 33,
	InputThreadIdInGroup          = 34,
	InputCoverageMask             = 35,
	InputThreadIdInGroupFlattened = 36,
	InputGsInstanceId             = 37,
	OutputDepthGreaterEqual       = 38,
	OutputDepthLessEqual          = 39,
	CycleCounter                  = 40
}