namespace Arnab.CustomPrompt.Test.SectionProviders;

public partial class FolderSectionProvider_Test
{
    private readonly Mock<IDataProvider> _dataProvider;
    private readonly FolderSectionProvider _folderSectionProvider;

    public FolderSectionProvider_Test()
    {
        _dataProvider = new Mock<IDataProvider>();
        _folderSectionProvider = new FolderSectionProvider(_dataProvider.Object);
    }
}