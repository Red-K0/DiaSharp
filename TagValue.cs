using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DiaSharp;

/// <summary>
/// Describes the numeric value of a discriminated union's tag.
/// </summary>
/// <remarks>
/// <para>
/// A <see cref="TagValue"/> can represent various values relating to discriminated or tagged unions, like Rust's <see langword="enum"/> variants.<br/>
/// An alternative way to think about the layout of a <see cref="TagValue"/> could be something like this:
/// </para> <para> <code>
/// [<see cref="StructLayoutAttribute"/>(<see cref="LayoutKind.Explicit"/>, Pack = 1, Size = 17)]<br/>
/// <see langword="struct"/> <see cref="TagValue"/><br/>
/// {
///     [<see cref="FieldOffsetAttribute"/>(00)] <see cref="UInt128"/> Value128;  <br/>
///     [<see cref="FieldOffsetAttribute"/>(08)] <see cref="ulong"/>   Value64;   <br/>
///     [<see cref="FieldOffsetAttribute"/>(12)] <see cref="uint"/>    Value32;   <br/>
///     [<see cref="FieldOffsetAttribute"/>(14)] <see cref="ushort"/>  Value16;   <br/>
///     [<see cref="FieldOffsetAttribute"/>(15)] <see cref="byte"/>    Value8;    <br/>
///     [<see cref="FieldOffsetAttribute"/>(16)] <see cref="byte"/>    ValueSize; <br/>
/// };
/// </code>
/// </para>
/// </remarks>
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 17)]
public readonly struct TagValue
{
    /// <summary>
    /// The integer value stored in little-endian byte ordering.
    /// </summary>
    [FieldOffset(0)]
    public readonly InlineArray16<byte> Value;

    /// <summary>
    /// The size in bytes of <see cref="Value"/>. Must be one of 1, 2, 4, 8, 16, or 0 if this value is empty.
    /// </summary>
    [FieldOffset(16)]
    public readonly byte ValueSize;
}
