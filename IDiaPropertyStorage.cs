using System.Runtime.InteropServices.Marshalling;
using DiaSharp.StructuredStorage;

namespace DiaSharp;

[GeneratedComInterface]
[Guid("9d416f9c-e184-45b2-a4f0-ce517f719e9b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IDiaPropertyStorage
{
	unsafe void* ReadMultiple(uint cpspec, [MarshalUsing(CountElementName = nameof(cpspec))] [In] PropertySpecifier[] rgpspec);

	[return: MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.BStr, SizeParamIndex = 0)]
	string[] ReadPropertyNames(uint cpropid, [MarshalUsing(CountElementName = nameof(cpropid))] [In] uint[] rgpropid);

	IEnumStatPropertyStorage Enum();

	uint ReadDWORD(uint id);

	int ReadLONG();

	[return: MarshalAs(UnmanagedType.Bool)]
	bool ReadBOOL(uint id);

	ulong ReadULONGLONG(uint id);

	[return: MarshalAs(UnmanagedType.BStr)]
	string ReadBSTR(uint id);
}

//[
//	uuid(106173A0 - 0173 - 4e5c - 84E7 - E915422BE997),
//	version(2.0),
//	helpstring("dia 2.0 Type Library")
//]
//	library Dia2Lib
//	{

//		importlib("stdole2.tlb");
//		[
//			uuid(e6756135 - 1e65 - 4d17 - 8576 - 610761398c3c),
//			helpstring("DiaSource Class")
//		]
//		coclass DiaSource
//		{
//			[default] interface IDiaDataSource;
//interface IDiaDataSourceEx;
//    };

//
// DiaSourceAlt - a DiaDataSource object that does not use the system heap. 
//
// A process may either make DiaSourceAlt objects or DiaSource objects, but not both.
// When using DiaSourceAlt all returned BSTR's are really LPCOLESTR and should not be 
// used with other BSTR management routines, in particular they must be released using
//      LocalFree( bstr )
//[
//	uuid(91904831 - 49ca - 4766 - b95c - 25397e2dd6dc),
//	helpstring("Local Heap DiaSource Class")
//]
//coclass DiaSourceAlt
//{
//	[default] interface IDiaDataSource;
//interface IDiaDataSourceEx;
//    };


//// General stack walking API    
//[
//	uuid(ce4a85db - 5768 - 475b - a4e1 - c0bca2112a6b),
//	helpstring("General Stackwalk Class")
//]
//coclass DiaStackWalker
//{
//	[default] interface IDiaStackWalker;
//    };

//};

//
// DebugInfoTable
//
// Each id identifies an underlying table of debug information 
// 


// Generic property broweser interface.