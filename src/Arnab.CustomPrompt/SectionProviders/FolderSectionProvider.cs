namespace Arnab.CustomPrompt.SectionProviders;

/// <summary>Folder section provider.</summary>
public class FolderSectionProvider(IDataProvider dataProvider) : SectionProvider(dataProvider)
{
    /// <summary>Get section.</summary>
    public override string GetSection()
    {
        var data = _dataProvider.GetData();
        return !string.IsNullOrWhiteSpace(data) ? $"Folder: {data} " : string.Empty;
    }
}