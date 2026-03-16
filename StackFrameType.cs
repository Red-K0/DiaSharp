namespace DiaSharp;

/// <summary>
/// Specifies the stack frame type.
/// </summary>
/// <remarks>
/// The values in this enumeration are returned by a call to the IDiaStackFrame::get_type method.
/// </remarks>
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

    /// <summary>
    /// Frame pointer omitted; Frame data info available.
    /// </summary>
    FrameData,

    /// <summary>
    /// Frame that does not have any debug info.
    /// </summary>
    Unknown
}
