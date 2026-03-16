namespace DiaSharp;

/// <summary>
/// Designates thunk types.
/// </summary>
/// <remarks>
/// The values in this enumeration are returned from a call to the IDiaSymbol::get_thunkOrdinal method.
/// </remarks>
public enum ThunkOrdinal
{
    /// <summary>
    /// Standard thunk.
    /// </summary>
    NoType,

    /// <summary>
    /// A <see langword="this"/> adjustor thunk.
    /// </summary>
    Adjustor,

    /// <summary>
    /// Virtual call thunk.
    /// </summary>
    VirtualCall,

    /// <summary>
    /// P-code thunk.
    /// </summary>
    PCode,

    /// <summary>
    /// Delay load thunk.
    /// </summary>
    DelayLoad,

    /// <summary>
    /// Incremental trampoline thunk (a trampoline thunk is used to bounce calls from one memory space to another).
    /// </summary>
    IncrementalTrampoline,

    /// <summary>
    /// Branch point trampoline thunk.
    /// </summary>
    BranchIslandTrampoline,

    /// <summary>
    /// Strict icf trampoline thunk.
    /// </summary>
    StrictIcfTrampoline,

    /// <summary>
    /// ARM64X same address trampoline thunk.
    /// </summary>
    ARM64XSameAddressTrampoline,

    /// <summary>
    /// Function overriding trampoline thunk.
    /// </summary>
    FunctionOverrideTrampoline,

}
