namespace Arnab.CustomPrompt.SectionProviders;

/// <summary>User section provider.</summary>
public class UserSectionProvider(IDataProvider dataProvider) : SectionProvider(dataProvider)
{
    /// <summary>Get section.</summary>
    public override string GetSection()
    {
        var data = _dataProvider.GetData();
        return !string.IsNullOrWhiteSpace(data) ? $"User: {data} " : string.Empty;
    }
}