using Arnab.CustomPrompt.DataProviders;
using Arnab.CustomPrompt.SectionProviders;
using Arnab.CustomPrompt.Services;

namespace Arnab.CustomPrompt.Api;

public static class PromptApi
{
    public static void MapPromptApi(this IEndpointRouteBuilder app)
    {
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

            return TypedResults.Ok(prompt);
        });
    }
}