using Microsoft.Win32.SafeHandles;

namespace AsyncOperationExample;

public class FileSystem
{
    public async Task<FileStream> GetFromPath(string path)
    {
        await Task.Delay(1000);
        return new FileStream(path, FileMode.Open);
    }
}