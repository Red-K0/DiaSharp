using DiaSharp.COM.Exceptions;

namespace DiaSharp.COM;

public static unsafe partial class ComHelpers
{
	/// <summary>
	///		Creates an instance of a specific class on a specific computer.
	/// </summary>
	/// <remarks>
	/// <para>
	///		CoCreateInstanceEx creates a single uninitialized object associated with the given CLSID on a specified remote computer.
	///		This is an extension of the function <see cref="CoCreateInstance(Guid*, void*, ClassContext, Guid*, out void*)"/>, which creates an object on the local computer only.
	/// </para>
	/// <para>
	///		In addition, rather than requesting a single interface and obtaining a single pointer to that interface, CoCreateInstanceEx makes it possible to specify an array of structures.
	///		Each structure points to an interface identifier (IID) on input, and, on return, containing (if available) a pointer to the requested interface and the return value of the QueryInterface call for that interface.
	///		This permits fewer round trips between computers.
	/// </para>
	/// </remarks>
	/// <param name="classID"> The CLSID of the object to be created. </param>
	/// <param name="outerIUnknown">
	///		<para> Indicates the instance is being created as part of an aggregate, and <paramref name="outerIUnknown"/> is to be used as the new instance's controlling IUnknown. </para>
	///		<para> Aggregation is not supported cross-process or cross-computer, and throws an <see cref="AggregateUnsupportedException"/> if <paramref name="outerIUnknown"/> is non-<see langword="null"/>. </para>
	/// </param>
	/// <param name="classContext"> A value from the <see cref="ClassContext"/> enumeration. </param>
	/// <param name="serverInfo">
	///		Information about the computer on which to instantiate the object.
	///		If unspecified, the object is instantiated on the local computer, or at the computer specified in the registry under the class's RemoteServerName value, according to the <paramref name="classContext"/> parameter.
	/// </param>
	/// <param name="resultCount"> The number of structures in <paramref name="results"/>. This value must be greater than 0. </param>
	/// <param name="results"> An array of <see cref="MultiQueryInterface"/> structures, holding the results for each provided query. </param>
	/// <returns>
	///		This function can return one of the following values:
	///		<list type="bullet">
	///			<item>
	///				<see cref="KnownResult.S_OK"/>: Indicates success.
	///			</item>
	///			<item>
	///				<see cref="KnownResult.E_INVALIDARG"/>: Indicates that one or more arguments passed to the function are invalid.
	///			</item>
	///			<item>
	///				<see cref="KnownResult.REGDB_E_CLASSNOTREG"/>:
	///				A specified class is not registered in the registration database.
	///				Also can indicate that the type of server you requested in the <paramref name="classContext"/> enumeration is not registered or the values for the server types in the registry are corrupt.
	///			</item>
	///			<item>
	///				<see cref="KnownResult.CLASS_E_NOAGGREGATION"/>: This class cannot be created as part of an aggregate.
	///			</item>
	///			<item>
	///				<see cref="KnownResult.CO_S_NOTALLINTERFACES"/>:
	///				At least one, but not all of the interfaces requested in the pResults array were successfully retrieved.
	///				The <see cref="MultiQueryInterface.HResult"/> member of each of the structures in <paramref name="results"/> indicates whether the specific interface was returned.
	///			</item>
	///			<item>
	///				<see cref="KnownResult.E_NOINTERFACE"/>: None of the interfaces requested in the <paramref name="results"/> array were successfully retrieved.
	///			</item>
	///		</list>
	/// </returns>
	[LibraryImport("ole32")]
	[SuppressMessage("Interoperability", "CA1401:P/Invokes should not be visible", Justification = "CoCreateInstanceEx is necessary for COM instantation.")]
	[SuppressMessage("Security", "CA5392:Use DefaultDllImportSearchPaths attribute for P/Invokes", Justification = "See https://learn.microsoft.com/en-us/windows/win32/dlls/dynamic-link-library-search-order.")]
	public static partial int CoCreateInstanceEx(Guid* classID, void* outerIUnknown, ClassContext classContext, ServerInfo* serverInfo, uint resultCount, MultiQueryInterface* results);

	/// <summary>
	/// Creates and default-initializes a single object of the class associated with a specified CLSID.
	/// </summary>
	/// <remarks>
	/// Call CoCreateInstance when you want to create only one object on the local system. To create a single object on a remote system, call the CoCreateInstanceEx function.
	/// </remarks>
	/// <param name="classID"> The CLSID associated with the data and code that will be used to create the object. </param>
	/// <param name="outerIUnknown"> If <see langword="null"/>, indicates that the object is not being created as part of an aggregate. Otherwise, a pointer to the aggregate object's IUnknown interface. </param>
	/// <param name="classContext"> The context in which the code that manages the newly created object will run. </param>
	/// <param name="interfaceID"> A reference to the identifier of the interface to be used to communicate with the object. </param>
	/// <param name="value"> Address of variable that receives the interface pointer requested in <paramref name="interfaceID"/>. Upon success, contains the requested pointer. Upon failure contains <see langword="null"/>. </param>
	/// <returns></returns>
	[LibraryImport("ole32")]
	[SuppressMessage("Interoperability", "CA1401:P/Invokes should not be visible", Justification = "CoCreateInstance is necessary for COM instantation.")]
	[SuppressMessage("Security", "CA5392:Use DefaultDllImportSearchPaths attribute for P/Invokes", Justification = "See https://learn.microsoft.com/en-us/windows/win32/dlls/dynamic-link-library-search-order.")]
	public static partial int CoCreateInstance(Guid* classID, void* outerIUnknown, ClassContext classContext, Guid* interfaceID, out void* value);

	/// <summary>
	/// Creates and default-initializes a single managed object of type <typeparamref name="TInterface"/>.
	/// </summary>
	/// <typeparam name="TInterface"> The interface to instantiate. </typeparam>
	/// <param name="classID"> The CLSID associated with the data and code that will be used to instantiate the object. </param>
	/// <param name="classContext"> The context in which the code that manages the newly created object will run. </param>
	/// <returns></returns>
	/// <exception cref="ClassNotRegisteredException"/>
	/// <exception cref="AggregateUnsupportedException"/>
	/// <exception cref="InterfaceNotImplementedException"/>
	public static TInterface CoCreateInstance<TInterface>(Guid classID, ClassContext classContext = ClassContext.InProcessServer) where TInterface : class
	{
		int result = CoCreateInstance(&classID, null, classContext, Constants._IUnknownGUID, out void* value);

		if (result >= 0)
		{
			TInterface? comObject = ComInterfaceMarshaller<TInterface>.ConvertToManaged(value)!;

			Marshal.Release((nint)value);

			return comObject;
		}
		else
		{
			switch (result)
			{
				default: break;

				case      ClassNotRegisteredException.HResultValue: throw new      ClassNotRegisteredException(classID, typeof(TInterface), classContext);
				case    AggregateUnsupportedException.HResultValue: throw new    AggregateUnsupportedException(classID, typeof(TInterface));
				case InterfaceNotImplementedException.HResultValue: throw new InterfaceNotImplementedException(classID, typeof(TInterface));
			}

			Marshal.ThrowExceptionForHR(result);

			throw null!;
		}
	}

	public static unsafe TQueried QueryInterface<TInterface, TQueried>(TInterface comObject) where TInterface : class where TQueried : class
	{
		void* unk = ComInterfaceMarshaller<TInterface>.ConvertToUnmanaged(comObject);

		void** vtable = *(void***)unk;

		delegate* unmanaged<void*, Guid*, void**, int> query = (delegate* unmanaged<void*, Guid*, void**, int>)vtable[0];

		Guid interfaceID = typeof(TQueried).GUID;

		void* value = null;

		int result = query(unk, &interfaceID, &value);

		if (result < 0) Marshal.ThrowExceptionForHR(result);

		TQueried queried = ComInterfaceMarshaller<TQueried>.ConvertToManaged(value)!;

		ComInterfaceMarshaller<TQueried>.Free(value);

		return queried;
	}

	public static unsafe TInterface Wrap<TInterface>(void* comPointer) where TInterface : class
	{
		TInterface comObject = ComInterfaceMarshaller<TInterface>.ConvertToManaged(comPointer)!;

		ComInterfaceMarshaller<TInterface>.Free(comPointer);

		return comObject;
	}

	public static unsafe void Release<TInterface>(ref TInterface comObject) where TInterface : class
	{
		void* ptr = ComInterfaceMarshaller<TInterface>.ConvertToUnmanaged(comObject);

		ComInterfaceMarshaller<TInterface>.Free(ptr);

		comObject = null!;
	}
}
