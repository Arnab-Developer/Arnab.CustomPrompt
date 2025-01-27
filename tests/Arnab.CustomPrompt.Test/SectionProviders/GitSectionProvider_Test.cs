namespace Arnab.CustomPrompt.Test.SectionProviders;

public partial class GitSectionProvider_Test
{
    private readonly Mock<IDataProvider> _dataProvider;
    private readonly GitSectionProvider _gitSectionProvider;

    public GitSectionProvider_Test()
    {
        _dataProvider = new Mock<IDataProvider>();
        _gitSectionProvider = new GitSectionProvider(_dataProvider.Object);
    }
}