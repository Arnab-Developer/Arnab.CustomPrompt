namespace Arnab.CustomPrompt.Test.SectionProviders;

public partial class GitSectionProvider_Test
{
    [Fact]
    public void GetSection_WorkProperly_GivenValidInput()
    {
        _dataProvider.Setup(dp => dp.GetData()).Returns("Test Git Branch");
        var section = _gitSectionProvider.GetSection();

        Assert.Equal("Git: Test Git Branch ", section);
        _dataProvider.Verify(dp => dp.GetData(), Times.Once());
    }

    [Fact]
    public void GetSection_ReturnEmptyString_GivenEmptyString()
    {
        _dataProvider.Setup(dp => dp.GetData()).Returns("");
        var section = _gitSectionProvider.GetSection();

        Assert.Equal("", section);
        _dataProvider.Verify(dp => dp.GetData(), Times.Once());
    }
}