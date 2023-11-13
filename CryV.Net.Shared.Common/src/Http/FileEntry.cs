using System;

namespace CryV.Net.Shared.Common.Http;

public class FileEntry
{
    
    public string Path { get; set; }

    public string Hash { get; set; }

    public FileEntry(string path, string hash)
    {
        Path = path;
        Hash = hash;
    }

}
