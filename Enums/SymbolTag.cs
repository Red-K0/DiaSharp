namespace DiaSharp.Enums;

/// <summary>
/// Specifies the type of symbol.
/// </summary>
/// <remarks>
/// <para> All symbols within a debug file have an identifying tag that specifies the symbol's type. </para>
/// <para> The IDiaSymbol::get_symTag method returns values from this enumeration. </para>
/// </remarks>
public enum SymbolTag
{
	/// <summary>
	/// Indicates that the symbol has no type.
	/// </summary>
	Null,

	/// <summary>
	/// Indicates that the symbol is an EXE file. Only one <see cref="Exe"/> symbol exists per store, serving as the global scope without a lexical parent.
	/// </summary>
	Exe,

	/// <summary>
	/// Indicates the compiland symbol for each compiland component of the symbol store.
	/// </summary>
	/// <remarks>
	/// <para> For native applications, <see cref="Compiland"/> symbols correspond to the object files linked into the image. </para>
	/// <para> For some kinds of Microsoft Intermediate Language (MSIL) images, there's one compiland per class. </para>
	/// </remarks>
	Compiland,

	/// <summary>
	/// Indicates that the symbol contains extended attributes of the compiland.
	/// </summary>
	CompilandDetails,

	/// <summary>
	/// these properties may require loading compiland symbols.
	/// </summary>
	Retrieving,

	/// <summary>
	/// Indicates that the symbol is an environment string defined for the compiland.
	/// </summary>
	CompilandEnv,

	/// <summary>
	/// Indicates that the symbol is a function.
	/// </summary>
	Function,

	/// <summary>
	/// Indicates that the symbol is a nested block.
	/// </summary>
	Block,

	/// <summary>
	/// Indicates that the symbol is data.
	/// </summary>
	Data,

	/// <summary>
	/// Indicates that the symbol is for a code annotation.
	/// </summary>
	/// <remarks>
	/// <para> Children of this symbol are constant data strings (<see cref="Data"/>, <see cref="DataKind.Constant"/>, and <see cref="LocationType.Constant"/>). </para>
	/// <para> Most clients ignore this symbol. </para>
	/// </remarks>
	Annotation,

	/// <summary>
	/// Indicates that the symbol is a label.
	/// </summary>
	Label,

	/// <summary>
	/// Indicates that the symbol is a public symbol. For native applications, this symbol is the COFF external symbol encountered while linking the image.
	/// </summary>
	PublicSymbol,

	/// <summary>
	/// Indicates that the symbol is a user-defined type (a structure, class, or union).
	/// </summary>
	UDT,

	/// <summary>
	/// Indicates that the symbol is an enumeration.
	/// </summary>
	Enum,

	/// <summary>
	/// Indicates that the symbol is a function signature type.
	/// </summary>
	FunctionType,

	/// <summary>
	/// Indicates that the symbol is a pointer type.
	/// </summary>
	PointerType,

	/// <summary>
	/// Indicates that the symbol is an array type.
	/// </summary>
	ArrayType,

	/// <summary>
	/// Indicates that the symbol is a base type.
	/// </summary>
	BaseType,

	/// <summary>
	/// Indicates that the symbol is a typedef that is an alias for another type.
	/// </summary>
	Typedef,

	/// <summary>
	/// Indicates that the symbol is a base class of a user-defined type.
	/// </summary>
	BaseClass,

	/// <summary>
	/// Indicates that the symbol is a friend of a user-defined type.
	/// </summary>
	Friend,

	/// <summary>
	/// Indicates that the symbol is a function argument.
	/// </summary>
	FunctionArgType,

	/// <summary>
	/// Indicates that the symbol is the end location of a function's prologue code.
	/// </summary>
	FuncDebugStart,

	/// <summary>
	/// Indicates that the symbol is the beginning location of a function's epilogue code.
	/// </summary>
	FuncDebugEnd,

	/// <summary>
	/// Indicates that the symbol is a namespace name active in the current scope.
	/// </summary>
	UsingNamespace,

	/// <summary>
	/// Indicates that the symbol is a virtual table description.
	/// </summary>
	VTableShape,

	/// <summary>
	/// Indicates that the symbol is a virtual table pointer.
	/// </summary>
	VTable,

	/// <summary>
	/// Indicates that the symbol is a custom symbol. The DIA SDK doesn't provide further interpretation of these symbols.
	/// </summary>
	Custom,

	/// <summary>
	/// Indicates that the symbol is a thunk used for sharing data between 16-bit and 32-bit code.
	/// </summary>
	Thunk,

	/// <summary>
	/// Indicates that the symbol is a custom compiler symbol.
	/// </summary>
	CustomType,

	/// <summary>
	/// Indicates that the symbol is in metadata.
	/// </summary>
	ManagedType,

	/// <summary>
	/// Indicates that the symbol is a FORTRAN multi-dimensional array.
	/// </summary>
	Dimension,

	/// <summary>
	/// Indicates that the symbol represents the call site.
	/// </summary>
	CallSite,

	/// <summary>
	/// Indicates that the symbol represents the inline site.
	/// </summary>
	InlineSite,

	/// <summary>
	/// Indicates that the symbol is a base interface.
	/// </summary>
	BaseInterface,

	/// <summary>
	/// Indicates that the symbol is a vector type.
	/// </summary>
	VectorType,

	/// <summary>
	/// Indicates that the symbol is a matrix type.
	/// </summary>
	MatrixType,

	/// <summary>
	/// Indicates that the symbol is a High Level Shader Language type.
	/// </summary>
	HlslType,

	/// <summary>
	/// Indicates that the symbol represents Profile-guided optimization (PGO) caller information.
	/// </summary>
	Caller,

	/// <summary>
	/// Indicates that the symbol represents PGO callee information.
	/// </summary>
	Callee,

	/// <summary>
	/// Indicates that the symbol is an export from a DLL.
	/// </summary>
	Export,

	/// <summary>
	/// Indicates that the symbol represents a heap allocation site (for example, a call to <see langword="new"/>).
	/// </summary>
	HeapAllocationSite,

	/// <summary>
	/// Indicates that the symbol is a COFF group.
	/// </summary>
	CoffGroup,

	/// <summary>
	/// Indicates that the symbol represents the inlinee of an inline site (see <see cref="InlineSite"/>).
	/// </summary>
	Inlinee,

	/// <summary>
	/// Indicates that the symbol is a tagged union (for example, Rust's <see langword="enum"/> type).
	/// </summary>
	TaggedUnionCase,
}
