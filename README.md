# Custom Prompt

This is a library to create a custom prompt.

Install it from NuGet.

```
dotnet add package Arnab.CustomPrompt
```

## How to use

```csharp
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

Console.WriteLine(prompt);
```
