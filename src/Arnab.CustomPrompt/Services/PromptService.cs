using Arnab.CustomPrompt.SectionProviders;

namespace Arnab.CustomPrompt.Services;

/// <summary>Prompt service.</summary>
public class PromptService(IEnumerable<ISectionProvider> sectionProviders) : IPromptService
{
    private readonly IEnumerable<ISectionProvider> _sectionProviders = sectionProviders;

    /// <summary>Get the prompt.</summary>
    public string GetPrompt() =>
        _sectionProviders
            .Select(sp => sp.GetSection())
            .Aggregate((a, b) => $"{a}{b}");
}