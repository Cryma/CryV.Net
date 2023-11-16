using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Http;
using Micky5991.EventAggregator.Interfaces;
using Newtonsoft.Json;

namespace CryV.Net.Client.Api;

public class ScriptManager : IScriptManager, IDisposable
{

    private Dictionary<string, List<FileEntry>> _clientFiles = new();

    private readonly WebClient _webClient = new();
    private readonly AssemblyLoader _assemblyLoader;

    private readonly IEventAggregator _eventAggregator;
    private readonly INetworkManager _networkManager;

    public ScriptManager(IEventAggregator eventAggregator, INetworkManager networkManager)
    {
        _eventAggregator = eventAggregator;
        _networkManager = networkManager;
        
        _assemblyLoader = new AssemblyLoader(eventAggregator);
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _eventAggregator.Subscribe<LocalPlayerBootstrapEvent>(OnBootstrap);

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private Task OnBootstrap(LocalPlayerBootstrapEvent obj)
    {
        var fileMap = _webClient.DownloadString($"http://{_networkManager.EndPoint.Address}:{_networkManager.EndPoint.Port + 1}/filemap.json");
        _clientFiles = JsonConvert.DeserializeObject<Dictionary<string, List<FileEntry>>>(fileMap);

        DownloadFiles();
        LoadAssemblies();

        return Task.CompletedTask;
    }

    private void LoadAssemblies()
    {
        foreach (var element in _clientFiles)
        {
            var gamemode = element.Key;

            foreach (var dll in Directory.GetFiles(Path.Combine(GetFileBasePath(), gamemode), "*.dll", SearchOption.AllDirectories))
            {
                _assemblyLoader.LoadAssembly(dll);
            }
        }
    }

    private void DownloadFiles()
    {
        foreach (var element in _clientFiles)
        {
            var gamemodePath = Path.Combine(GetFileBasePath(), element.Key);

            if (Directory.Exists(gamemodePath) == false)
            {
                Directory.CreateDirectory(gamemodePath);
            }

            foreach (var file in element.Value)
            {
                if (IsFileUpToDate(element.Key, file))
                {
                    continue;
                }

                var filePath = Path.Combine(gamemodePath, file.Path);

                if (Directory.Exists(Path.GetDirectoryName(filePath)) == false)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }

                _webClient.DownloadFile($"http://{_networkManager.EndPoint.Address}:{_networkManager.EndPoint.Port + 1}/{element.Key}/{file.Path}", filePath);
            }
        }

        CheckForDeletedFiles();
    }

    private bool IsFileUpToDate(string gamemode, FileEntry fileEntry)
    {
        var absolutePath = Path.Combine(GetFileBasePath(), gamemode, fileEntry.Path);

        if (File.Exists(absolutePath) == false)
        {
            return false;
        }

        using (var sha = SHA256.Create())
        {
            var hash = sha.ComputeHash(File.ReadAllBytes(absolutePath));

            var stringBuilder = new StringBuilder();
            foreach (var element in hash)
            {
                stringBuilder.Append(element.ToString("x2"));
            }

            return stringBuilder.ToString() == fileEntry.Hash;
        }
    }

    private void CheckForDeletedFiles()
    {
        foreach (var gamemode in _clientFiles)
        {
            var gamemodePath = Path.Combine(GetFileBasePath(), gamemode.Key);

            foreach (var file in Directory.GetFiles(gamemodePath, "*", SearchOption.AllDirectories))
            {
                var relativeFilePath = file.Remove(0, gamemodePath.Length + 1);

                if (gamemode.Value.Any(x => x.Path == relativeFilePath))
                {
                    continue;
                }

                File.Delete(file);
            }
        }
    }

    private string GetFileBasePath()
    {
        return Path.Combine(Utility.GetInstallDirectory(), "dotnet", "clientresources", _networkManager.EndPoint.ToString().Replace(':', '_'));
    }

    public void Dispose()
    {
        _webClient.Dispose();
    }
}
