using DiaSharp.Managed;

DataSource source = new();

source.LoadData("DiaSharp.pdb");

Console.WriteLine(source.OpenSession().GlobalScope.Name);