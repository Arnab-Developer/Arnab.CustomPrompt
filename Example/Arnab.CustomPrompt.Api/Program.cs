using Arnab.CustomPrompt.DataProviders;
using Arnab.CustomPrompt.SectionProviders;
using Arnab.CustomPrompt.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/get-prompt", () =>
{
    var userDataProvider = new UserDataProvider();
    var folderDataProvider = new FolderDataProvider();
    var gitDataProvider = new GitDataProvider();

    var userSectionProvider = new UserSectionProvider(userDataProvider);
    var folderSectionProvider = new FolderSectionProvider(folderDataProvider);
    var gitSectionProvider = new GitSectionProvider(gitDataProvider);

    var sectionProviders = new List<ISectionProvider>
    {
        userSectionProvider,
        folderSectionProvider,
        gitSectionProvider
    };

    var promptService = new PromptService(sectionProviders);
    var prompt = promptService.GetPrompt();

    return Results.Ok(prompt);
});

app.Run();