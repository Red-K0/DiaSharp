using DiaSharp.COM;
using DiaSharp.SDK;

IDataSource dataSource = ComHelpers.CoCreateInstance<IDataSource>(Constants.DiaSourceGUID);

dataSource.LoadDataFromPdb("DiaSharp.pdb");

dataSource.OpenSession(out var session);

session.GetGlobalScope(out var scope);

scope.GetName(out string name);

Console.WriteLine(name);
