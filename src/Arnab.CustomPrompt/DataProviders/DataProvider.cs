namespace Arnab.CustomPrompt.DataProviders;

/// <summary>Data provider.</summary>
public abstract class DataProvider : IDataProvider
{
    /// <summary>Get data.</summary>
    public abstract string GetData();
}