using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.Managed;

public sealed unsafe class Session(ISession session) : ComObject<ISession>(session)
{
	public ulong LoadAddress
	{
		get => GetProp<ulong>(_native.GetLoadAddress);

		set => SetProp(_native.PutLoadAddress, value);
	}

	public Symbol GlobalScope => new(GetProp<ISymbol>(_native.GetGlobalScope));


}
