using System.Diagnostics;

namespace Arnab.CustomPrompt.DataProviders;

/// <summary>Git data provider.</summary>
public class GitDataProvider : DataProvider
{
    /// <summary>Get data.</summary>
    public override string GetData()
    {
        var currentDirectory = Directory.GetCurrentDirectory();

        var startInfo = new ProcessStartInfo("git.exe")
        {
            UseShellExecute = false,
            WorkingDirectory = currentDirectory,
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            Arguments = "rev-parse --abbrev-ref HEAD"
        };

        var process = new Process { StartInfo = startInfo };
        process.Start();

        var branchName = process.StandardOutput.ReadLine() ?? "";
        return branchName;
    }
}