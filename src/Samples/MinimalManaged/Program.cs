using DiaSharp.Managed;

DataSource dataSource = new();

dataSource.TryLoadDataFromPdb("DiaSharp.pdb");

Console.WriteLine(dataSource.FindNamedStreams("").First());