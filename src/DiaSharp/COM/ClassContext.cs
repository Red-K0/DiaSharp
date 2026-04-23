namespace DiaSharp.COM;

/// <summary>
/// Flags that indicate the execution contexts in which an object is to be run.
/// </summary>
[Flags]
public enum ClassContext : uint
{
	/// <summary>
	/// The code that creates/manages this class' objects is a DLL, which runs in the same process as the caller specifying the class context.
	/// </summary>
	InProcessServer = 0x1,

	/// <summary>
	/// The code that creates/manages this class' objects is an in-process handler. This is a DLL that runs in the client process, and handles the remotely accessed class (via client-side structures).
	/// </summary>
	InProcessHandler = 0x2,

	/// <summary>
	/// The (executable) code that creates/manages this class' objects runs on same machine, but is loaded in a separate process space.
	/// </summary>
	LocalServer = 0x4,

	/// <summary>
	/// The <see href="https://learn.microsoft.com/en-us/windows/win32/com/localserver32">LocalServer32</see> or <see href="https://learn.microsoft.com/en-us/windows/win32/services/localservice-account">LocalService</see> code
	/// that creates/manages this class' objects is run on a different computer.
	/// </summary>
	RemoteServer = 0x10,

	/// <summary>
	/// Disables downloading code from the <see href="https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/get-started/virtual-dc/active-directory-domain-services-overview">Active Directory Service</see>, or the internet.
	/// This flag cannot be set at the same time as <see cref="EnableCodeDownload"/>.
	/// </summary>
	NoCodeDownload = 0x400,

	/// <summary>
	/// Causes the activation to fail if custom marshalling is used.
	/// </summary>
	NoCustomMarshalling = 0x1000,

	/// <summary>
	/// Enables downloading code from the <see href="https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/get-started/virtual-dc/active-directory-domain-services-overview">Active Directory Service</see>, or the internet.
	/// This flag cannot be set at the same time as <see cref="NoCodeDownload"/>.
	/// </summary>
	EnableCodeDownload = 0x2000,

	/// <summary>
	/// Overrides the logging behaviour for CoCreateInstanceEx failures.
	/// </summary>
	/// <remarks>
	/// If the ActivationFailureLoggingLevel is created, the following values can determine the status of event logging:
	/// <list type="bullet">
	///		<item> 0 = Discretionary logging. Log by default, but clients can override by specifying <see cref="NoFailureLog"/> in CoCreateInstanceEx. </item>
	///		<item> 1 = Always log all failures no matter what the client specified. </item>
	///		<item> 2 = Never log any failures no matter what client specified. </item>
	/// </list>
	/// If the registry entry is missing, the default is 0. If you need to control customer applications, it is recommended that you set this value to 0 and write the client code to override failures.
	/// It is strongly recommended that you do not set the value to 2. If event logging is disabled, it is more difficult to diagnose problems.
	/// </remarks>
	NoFailureLog = 0x4000,

	/// <summary>
	/// Disables activate-as-activator (AAA) activations for this activation only. This flag cannot be set at the same time as <see cref="EnableAAA"/>, and overrides the EOAC_DISABLE_AAA flag.
	/// </summary>
	/// <remarks>
	/// <para> Disabling AAA prevents applications from being used to launch untrusted components. Library applications that use activation calls should always set this flag, to protect against privilege-escalation attacks. </para>
	/// <para> This is the only way to disable AAA activations in a library application, as the EOAC_DISABLE_AAA flag applies only to server processes. </para>
	/// <para> See <see href="https://learn.microsoft.com/en-us/windows/win32/cossdk/role-based-security-administration"> COM+ Role-Based Security Administration </see> for more information. </para>
	/// </remarks>
	DisableAAA = 0x8000,

	/// <summary>
	/// Enables activate-as-activator (AAA) activations for this activation only. This flag cannot be set at the same time as <see cref="DisableAAA"/>, and overrides the EOAC_DISABLE_AAA flag.
	/// </summary>
	/// <remarks>
	/// <para> Using this flag in library applications is a security risk, and can leave the library vulnerable to privilege-escalation. </para>
	/// <para> See <see href="https://learn.microsoft.com/en-us/windows/win32/cossdk/role-based-security-administration"> COM+ Role-Based Security Administration </see> for more information. </para>
	/// </remarks>
	EnableAAA = 0x10000,

	/// <summary>
	/// Begin this activation from the default context of the current apartment.
	/// </summary>
	FromDefaultContext = 0x20000,

	/// <summary>
	/// Activate or connect to a 32-bit version of the server; fail if one is not registered.
	/// </summary>
	Activate32BitServer = 0x40000,

	/// <summary>
	/// Activate or connect to a 64 bit version of the server; fail if one is not registered.
	/// </summary>
	Activate64BitServer = 0x80000,

	/// <summary>
	/// When this flag is specified, COM uses the impersonation token of the thread, if one is present, for the activation request made by the thread.
	/// </summary>
	/// <remarks>
	/// When this flag is not specified, or if the thread does not have an impersonation token, COM uses the process token of the thread's process for the activation request made by the thread.
	/// </remarks>
	EnableCloaking = 0x100000,

	/// <summary>
	/// Specifies 'Interactive User' activation behavior for As-Activator (AA) servers.
	/// </summary>
	/// <remarks>
	/// <para>
	/// A Windows Store app can use this flag to launch an AA COM server without a strong name, or bind to an already-running COM server launched by a desktop application, if the following requirements are met:
	/// <list type="bullet">
	///		<item> The client is running with an IL of 'Medium' (for more information, see <see href="https://learn.microsoft.com/en-us/windows/win32/secauthz/mandatory-integrity-control">Mandatory Integrity Control</see>). </item>
	///		<item> The client shares the same user in its token as the session id's user. </item>
	///		<item> The client is strongly named (containing an <see href="https://learn.microsoft.com/en-us/windows/win32/shell/appids">AUMID</see> in its token). </item>
	///		<item> The client is not in session 0. </item>
	/// </list>
	/// </para>
	/// For an in-process COM server, this flag does nothing. For an out-of-process server:
	/// <list type="bullet">
	///		<item> If the server is an AA server, it launches the server with the token of the client token's session user. This token won't be strongly named. </item>
	///		<item> If the server is <see href="https://learn.microsoft.com/en-us/windows/win32/com/runas">RunAs</see> "Interactive User", this flag has no effect. For any other RunAs type, the activation will fail. </item>
	///		<item> If the server is off-machine, the activation will fail. </item>
	/// </list>
	/// </remarks>
	ActviateAsInteractiveUser = 0x800000,

	ActivateARM32Server = 0x2000000,
}
