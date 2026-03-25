namespace DiaSharp.CodeView;

/// <summary>
/// Specifies the coroutine kind.
/// </summary>
/// <remarks>
/// Use the Symbol8::GetcoroutineKind method to retrieve the coroutine kind for a coroutine function.
/// </remarks>
public enum CoroutineKind
{
	/// <summary>
	/// Not a coroutine.
	/// </summary>
	None,

	/// <summary>
	/// The original coroutine function.
	/// </summary>
	Primary,

	/// <summary>
	/// Initialization function, sets up the coroutine frame.
	/// </summary>
	Init,

	/// <summary>
	/// Resume function, contains the coroutine body code.
	/// </summary>
	Resume,

	/// <summary>
	/// Destroy function, tears down the coroutine frame.
	/// </summary>
	Destroy
}
