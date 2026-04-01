using DiaSharp.COM;
using DiaSharp.SDK;

IDataSource dataSource = ComHelpers.CoCreateInstance<IDataSource>(Constants.DiaSourceGUID);

dataSource.LoadDataFromPdb("DiaSharp.pdb");

Console.WriteLine(dataSource.OpenSession().GetGlobalScope().GetName());
