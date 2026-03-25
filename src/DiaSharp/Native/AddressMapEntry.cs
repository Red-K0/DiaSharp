namespace DiaSharp.Native;

/// <summary>
/// Describes an entry in an address map.
/// </summary>
/// <remarks>
/// <para> An address map provides a translation from one image layout (A) to another (B). An array of <see cref="AddressMapEntry"/> structures sorted by <see cref="RelativeVirtualAddress"/> defines an address map. </para>
/// <para>
/// To translate an address, <c>addrA</c>, in image A to an address, <c>addrB</c>, in image B, perform the following steps:
/// <list type="number">
///     <item> Search the map for the entry, <c>e</c>, with the largest <see cref="RelativeVirtualAddress"/> less than or equal to <c>addrA</c>. </item>
///     <item> Set <c>delta = addrA - e.rva</c>. </item>
///     <item> Set <c>addrB = e.rvaTo + delta</c>. </item>
/// </list>
/// </para>
/// <para> An array of <see cref="AddressMapEntry"/> structures is passed to the AddressMap::set_addressMap method. </para>
/// </remarks>
[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
public readonly struct AddressMapEntry : IEquatable<AddressMapEntry>
{
	/// <summary>
	/// A relative virtual address (RVA) in image A.
	/// </summary>
	[FieldOffset(0)]
	public readonly uint RelativeVirtualAddress;

	/// <summary>
	/// The relative virtual address (RVA) <see cref="RelativeVirtualAddress"/> is mapped to in image B.
	/// </summary>
	[FieldOffset(4)]
	public readonly uint RelativeVirtualAddressTarget;

	public override bool Equals(object? obj) => obj is AddressMapEntry entry && this == entry;

	public override int GetHashCode() => (int)(RelativeVirtualAddressTarget ^ RelativeVirtualAddress);

	public static unsafe bool operator ==(AddressMapEntry left, AddressMapEntry right)
	{
		return *(ulong*)&left == *(ulong*)&right;
	}

	public static unsafe bool operator !=(AddressMapEntry left, AddressMapEntry right)
	{
		return *(ulong*)&left != *(ulong*)&right;
	}

	public bool Equals(AddressMapEntry other) => this == other;
}
