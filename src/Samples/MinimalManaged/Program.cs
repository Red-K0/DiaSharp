using DiaSharp.Managed;

DataSource source = new();

source.LoadData("DiaSharp.pdb");

foreach (string name in source.FindNamedStreams(""))
{
	Console.WriteLine(name);
}