namespace Arnab.CustomPrompt.Test.SectionProviders;

public partial class UserSectionProvider_Test
{
    [Fact]
    public void GetSection_WorkProperly_GivenValidInput()
    {
        _dataProvider.Setup(dp => dp.GetData()).Returns("Test User");
        var section = _userSectionProvider.GetSection();

        Assert.Equal("User: Test User ", section);
        _dataProvider.Verify(dp => dp.GetData(), Times.Once());
    }

    [Fact]
    public void GetSection_ReturnEmptyString_GivenEmptyString()
    {
        _dataProvider.Setup(dp => dp.GetData()).Returns("");
        var section = _userSectionProvider.GetSection();

        Assert.Equal("", section);
        _dataProvider.Verify(dp => dp.GetData(), Times.Once());
    }
}