namespace Arnab.CustomPrompt.DataProviders;

/// <summary>Folder data provider.</summary>
public class FolderDataProvider : DataProvider
{
    /// <summary>Get data.</summary>
    public override string GetData()
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        var folderName = Path.GetFileName(currentDirectory);
        return folderName;
    }
}