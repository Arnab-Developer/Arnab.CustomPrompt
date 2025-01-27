namespace Arnab.CustomPrompt.Test.SectionProviders;

public partial class UserSectionProvider_Test
{
    private readonly Mock<IDataProvider> _dataProvider;
    private readonly UserSectionProvider _userSectionProvider;

    public UserSectionProvider_Test()
    {
        _dataProvider = new Mock<IDataProvider>();
        _userSectionProvider = new UserSectionProvider(_dataProvider.Object);
    }
}