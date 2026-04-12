using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Symbols;

namespace DiaSharp.Managed;

public sealed unsafe class Session(ISession session) : ComObject<ISession>(session)
{
	public Symbol GlobalScope => new(ThrowOrGet<ISymbol>(_native.GetGlobalScope));

	public ulong LoadAddress
	{
		get => ThrowOrGet<ulong>(_native.GetLoadAddress);

		set => ThrowOrSet(_native.PutLoadAddress, value);
	}
}

public sealed unsafe class Symbol(ISymbol symbol) : ComObject<ISymbol>(symbol)
{

}