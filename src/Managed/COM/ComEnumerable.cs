using System.Collections;

namespace DiaSharp.COM;

public abstract class ComEnumerable<TEnum, TValue>(TEnum native) : ComObject<TEnum>(native), IEnumerable<TValue> where TEnum : class where TValue : notnull
{
	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	public abstract IEnumerator<TValue> GetEnumerator();

	protected abstract TEnum CloneNative();

	[StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected static TEnum CloneInternal(int result, TEnum enumerator)
	{
		if (result < 0) Marshal.ThrowExceptionForHR(result);

		return enumerator;
	}

	protected abstract class ComEnumerator(TEnum native) : ComObject<TEnum>(native), IEnumerator<TValue>
	{
		protected bool _moved = false;

		[AllowNull]
		public TValue Current { get => field ?? throw new InvalidOperationException(_moved ? "Enumeration has already finished." : "Enumeration has not started. Call MoveNext."); protected set; }

		object IEnumerator.Current => Current;

		protected abstract int MoveNextInternal(out TValue? value);

		public bool MoveNext()
		{
			int result = MoveNextInternal(out TValue? value);

			if (result == (int)KnownResult.S_FALSE)
			{
				_moved = true;
				Current = default;
				return false;
			}

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			Current = value;
			return true;
		}

		protected abstract int ResetInternal();

		public void Reset()
		{
			int result = ResetInternal();

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			_moved = false;

			Current = default;
		}
	}
}
