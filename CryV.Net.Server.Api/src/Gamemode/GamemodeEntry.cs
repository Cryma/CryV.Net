using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using CryV.Net.Server.Common.Interfaces.Api;
using CryV.Net.Shared.Common.Http;

namespace CryV.Net.Server.Api.Gamemode;

public class GamemodeEntry
{

    public IGamemode GamemodeInstance { get; }

    public string BasePath { get; }

    public List<FileEntry> ClientsideFiles = new List<FileEntry>();

    public GamemodeEntry(IGamemode gamemodeInstance, string basePath)
    {
        GamemodeInstance = gamemodeInstance;
        BasePath = basePath;

        IndexFiles();
    }

    public void IndexFiles()
    {
        var filePath = Path.Combine(BasePath, "client");
        if (Directory.Exists(filePath) == false)
        {
            return;
        }

        var clientFiles = Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);
        foreach (var clientFile in clientFiles)
        {
            var relativeFilePath = clientFile.Remove(0, filePath.Length + 1);

            using (var sha = SHA256.Create())
            {
                var hash = sha.ComputeHash(File.ReadAllBytes(clientFile));

                var stringBuilder = new StringBuilder();
                foreach (var element in hash)
                {
                    stringBuilder.Append(element.ToString("x2"));
                }

                ClientsideFiles.Add(new FileEntry(relativeFilePath, stringBuilder.ToString()));
            }
        }
    }

}
