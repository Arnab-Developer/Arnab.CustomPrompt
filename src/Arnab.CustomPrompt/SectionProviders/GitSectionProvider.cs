namespace Arnab.CustomPrompt.SectionProviders;

/// <summary>
/// Git section provider.
/// </summary>
public class GitSectionProvider(IDataProvider dataProvider) : SectionProvider(dataProvider)
{
    /// <summary>
    /// Get section.
    /// </summary>
    public override string GetSection()
    {
        var data = _dataProvider.GetData();
        return !string.IsNullOrWhiteSpace(data) ? $"Git: {data} " : string.Empty;
    }
}