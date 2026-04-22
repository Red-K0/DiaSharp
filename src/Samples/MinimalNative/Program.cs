using DiaSharp.COM;
using DiaSharp.SDK;
using DiaSharp.SDK.Symbols;

IDataSource dataSource = ComHelpers.CoCreateInstance<IDataSource>(Constants.DiaSourceGUID);

dataSource.LoadDataFromPDB("DiaSharp.pdb");

dataSource.OpenSession(out ISession? session);

session.GetGlobalScope(out ISymbol? scope);

scope.GetName(out string name);

Console.WriteLine(name);