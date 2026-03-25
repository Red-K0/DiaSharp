using System.Runtime.InteropServices.Marshalling;
using DiaSharp.Interop;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("4A59FB77-ABAC-469B-A30B-9ECC85BFEF14")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface ITable : IEnumUnknown
{
	IEnumVARIANT GetNewEnum();

	[return: MarshalAs(UnmanagedType.LPWStr)]
	string GetName();

	int GetCount();

	IUnknown Item(uint index);
}
