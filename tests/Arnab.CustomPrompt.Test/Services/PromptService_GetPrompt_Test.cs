namespace Arnab.CustomPrompt.Test.Services;

public partial class PromptService_Test
{
    [Fact]
    public void GetPrompt_WorkProperly_GivenValidInput()
    {
        _sectionOneProviderMock.Setup(sp => sp.GetSection()).Returns("SectionOne ");
        _sectionTwoProviderMock.Setup(sp => sp.GetSection()).Returns("SectionTwo ");
        _sectionThreeProviderMock.Setup(sp => sp.GetSection()).Returns("SectionThree ");

        var promptService = new PromptService(
        [
            _sectionOneProviderMock.Object,
            _sectionTwoProviderMock.Object,
            _sectionThreeProviderMock.Object
        ]);

        var prompt = promptService.GetPrompt();
        Assert.Equal("SectionOne SectionTwo SectionThree ", prompt);

        _sectionOneProviderMock.Verify(sp => sp.GetSection(), Times.Once());
        _sectionTwoProviderMock.Verify(sp => sp.GetSection(), Times.Once());
        _sectionThreeProviderMock.Verify(sp => sp.GetSection(), Times.Once());
    }
}