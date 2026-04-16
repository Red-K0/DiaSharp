using DiaSharp.COM;
using DiaSharp.SDK.Enumerators;

namespace DiaSharp.Managed.Enumerables;

internal class DebugStreamDataEnumerable(IEnumDebugStreamData native) : ComEnumerable<IEnumDebugStreamData, byte[]>(native)
{
	public override IEnumerator<byte[]> GetEnumerator() => new DebugStreamDataEnumerator(CloneNative());
	protected override IEnumDebugStreamData CloneNative() => CloneInternal(_native.Clone(out IEnumDebugStreamData clone), clone);

	private sealed class DebugStreamDataEnumerator(IEnumDebugStreamData native) : ComEnumerator(native)
	{
		protected override unsafe int MoveNextInternal(out byte[]? value)
		{
			int result = _native.GetNext(1, 0, out uint bufferSize, null, out _);

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			if (result == (int)KnownResult.S_FALSE)
			{
				value = null;
				return (int)KnownResult.S_FALSE;
			}

			byte* buffer = stackalloc byte[(int)bufferSize];

			result = _native.GetNext(1, bufferSize, out _, buffer, out _);

			if (result < 0) Marshal.ThrowExceptionForHR(result);

			value = new ReadOnlySpan<byte>(buffer, (int)bufferSize).ToArray();

			return (int)KnownResult.S_OK;
		}

		protected override int ResetInternal() => _native.Reset();
	}
}
