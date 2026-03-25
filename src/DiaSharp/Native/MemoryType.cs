namespace DiaSharp.Native;

/// <summary>
/// Specifies the type of memory to access.
/// </summary>
/// <remarks>
/// The values in this enumeration are passed to the StackWalkHelper::readMemory method to limit access to different types of memory.
/// </remarks>
public enum MemoryType
{
	/// <summary>
	/// Accesses any kind of memory.
	/// </summary>
	Any = -1,

	/// <summary>
	/// Accesses only code memory.
	/// </summary>
	Code = 0,

	/// <summary>
	/// Accesses data or stack memory.
	/// </summary>
	Data = 1,

	/// <summary>
	/// Accesses only stack memory.
	/// </summary>
	Stack = 2,

	/// <summary>
	/// Accesses only code memory generated on heap at runtime.
	/// </summary>
	CodeOnHeap = 3
}
