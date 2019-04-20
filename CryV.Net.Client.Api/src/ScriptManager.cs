using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using Autofac;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Http;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;
using Newtonsoft.Json;

namespace CryV.Net.Client.Http
{
    public class ScriptManager : IStartable, IDisposable
    {

        private Dictionary<string, List<FileEntry>> _clientFiles = new Dictionary<string, List<FileEntry>>();

        private readonly WebClient _webClient = new WebClient();

        private readonly IEventHandler _eventHandler;
        private readonly INetworkManager _networkManager;

        public ScriptManager(IEventHandler eventHandler, INetworkManager networkManager)
        {
            _eventHandler = eventHandler;
            _networkManager = networkManager;
        }

        public void Start()
        {
            _eventHandler.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);
        }

        private void OnBootstrap(NetworkEvent<BootstrapPayload> obj)
        {
            var fileMap = _webClient.DownloadString($"http://{_networkManager.EndPoint.Address}:{_networkManager.EndPoint.Port + 1}/filemap.json");
            _clientFiles = JsonConvert.DeserializeObject<Dictionary<string, List<FileEntry>>>(fileMap);

            DownloadFiles();
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

        private string GetFileBasePath()
        {
            return Path.Combine(Utility.GetInstallDirectory(), "dotnet", "clientresources", _networkManager.EndPoint.ToString().Replace(':', '_'));
        }

        public void Dispose()
        {
            _webClient.Dispose();
        }

    }
}
