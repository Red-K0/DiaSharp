//using DiaSharp.CodeView;
//using DiaSharp.COM;
//using DiaSharp.SDK;
//using DiaSharp.SDK.Enumerators;

//namespace DiaSharp.Managed;

//public sealed unsafe class DataSource : ComObject<IDataSource>
//{
//	public DataSource() : base(ComHelpers.CoCreateInstance<IDataSource>(Constants.DiaSourceGUID)) { }

//	public bool TryLoadDataFromPdb(string pdbPath)
//	{
//		EnsureNotDisposed();

//		try
//		{
//			_native.LoadDataFromPdb(pdbPath);

//			return true;
//		}
//		catch
//		{
//			return false;
//		}
//	}

//	public bool TryLoadDataFromPdb(string pdbPath, Guid pdbSignature, uint signature, uint age)
//	{
//		EnsureNotDisposed();

//		try
//		{
//			_native.LoadAndValidateDataFromPdb(pdbPath, ref pdbSignature, signature, age);

//			return true;
//		}
//		catch
//		{
//			return false;
//		}
//	}

//	public bool TryLoadDataForExe(string exePath, string searchPath)
//	{
//		EnsureNotDisposed();

//		try
//		{
//			_native.LoadDataForExe(exePath, searchPath, null!);

//			return true;
//		}
//		catch
//		{
//			return false;
//		}
//	}

//	public bool TryLoadDataFromCodeViewInfo(string exePath, string searchPath, ReadOnlySpan<byte> info)
//	{
//		_native.LoadDataFromCodeViewInfo(exePath, searchPath, info.Length, )
//	}

//	public bool TryLoadDataFromMiscInfo(string exePath, string searchPath, DateTime exeTimestamp, DateTime debugTimestamp, uint exeSize, ReadOnlySpan<byte> info)
//	{

//	}

//	public string* FindNamedStreams(string name, NameSearchOptions searchOptions = NameSearchOptions.None)
//	{
//		EnsureNotDisposed();

//		if (!TryQueryInterface(out IDataSourceEx2? source)) throw new NotSupportedException("The IDataSourceEx2 interface is unsupported, please ensure the latest version of the DIA SDK is installed.");

//		try
//		{
//			IEnumNamedStreams streams = source.FindNamedStreams(name, searchOptions);

//			try
//			{
//				string* streamNames = new string[streams.GetCount()];

//				for (int i = 0; i < streamNames.Length; i++) streamNames[i] = streams.GetNext();

//				return streamNames;
//			}
//			finally
//			{
//				ComHelpers.Release(ref streams);
//			}
//		}
//		finally
//		{
//			ComHelpers.Release(ref source);
//		}
//	}
//}
