using System.Runtime.InteropServices.Marshalling;

namespace DiaSharp.StructuredStorage;

#pragma warning disable CA1711

[GeneratedComInterface]
[Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ISequentialStream
{
	uint Read(out byte value, uint byteCount);

	uint Write(ref byte value, uint byteCount);
}

#pragma warning restore CA1711