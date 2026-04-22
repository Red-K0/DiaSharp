using DiaSharp.Managed;

DataSource source = new();

source.LoadData(@"DiaSharp.pdb");

Session session = source.OpenSession();

Console.WriteLine(session.GlobalScope.Name);