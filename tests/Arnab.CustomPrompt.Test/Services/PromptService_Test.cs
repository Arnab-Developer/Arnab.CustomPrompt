namespace Arnab.CustomPrompt.Test.Services;

public partial class PromptService_Test
{
    private readonly Mock<ISectionProvider> _sectionOneProviderMock = new();
    private readonly Mock<ISectionProvider> _sectionTwoProviderMock = new();
    private readonly Mock<ISectionProvider> _sectionThreeProviderMock = new();
}