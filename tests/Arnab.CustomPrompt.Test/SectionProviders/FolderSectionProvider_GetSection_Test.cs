namespace Arnab.CustomPrompt.Test.SectionProviders;

public partial class FolderSectionProvider_Test
{
    [Fact]
    public void GetSection_WorkProperly_GivenValidInput()
    {
        _dataProvider.Setup(dp => dp.GetData()).Returns("Test Folder");
        var section = _folderSectionProvider.GetSection();

        Assert.Equal("Folder: Test Folder ", section);
        _dataProvider.Verify(dp => dp.GetData(), Times.Once());
    }

    [Fact]
    public void GetSection_ReturnEmptyString_GivenEmptyString()
    {
        _dataProvider.Setup(dp => dp.GetData()).Returns("");
        var section = _folderSectionProvider.GetSection();

        Assert.Equal("", section);
        _dataProvider.Verify(dp => dp.GetData(), Times.Once());
    }
}