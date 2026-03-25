namespace DiaSharp.Native;

/// <summary>
/// Specifies the stack frame type.
/// </summary>
public enum StackFrameType
{
	/// <summary>
	/// Frame pointer omitted; FPO info available.
	/// </summary>
	FramePointerOmitted,

	/// <summary>
	/// Kernel Trap frame.
	/// </summary>
	Trap,

	/// <summary>
	/// Hardware task switch frame based on a Task State Segment (TSS).
	/// </summary>
	TaskStateSegment,

	/// <summary>
	/// Standard EBP stack frame.
	/// </summary>
	Standard,

	/// <summary>ss
	/// Frame pointer omitted; Frame data info available.
	/// </summary>
	FrameData,

	/// <summary>
	/// Frame that does not have any debug info.
	/// </summary>
	Unknown
}
