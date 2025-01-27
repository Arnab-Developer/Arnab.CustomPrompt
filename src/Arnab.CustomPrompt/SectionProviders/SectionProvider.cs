namespace Arnab.CustomPrompt.SectionProviders;

/// <summary>Section provider.</summary>
public abstract class SectionProvider(IDataProvider dataProvider) : ISectionProvider
{
    /// <summary>Data provider.</summary>
    protected readonly IDataProvider _dataProvider = dataProvider;

    /// <summary>Get section.</summary>
    public abstract string GetSection();
}