using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CryV.Net.Client.Console
{
    public partial class GameConsole : IHostedService
    {

        public bool IsVisible { get; private set; }

        private string _input = string.Empty;
        private readonly List<string> _output = new List<string>();
        private int _outputLines = 5;
        private bool _blinkState;
        private DateTime _lastBlinkUpdate = DateTime.UtcNow;
        private int _cursorIndex;

        private readonly List<string> _inputHistory = new List<string>();
        private int _currentHistoryIndex = -1;

        private const float _backgroundInputHeight = 18.0f;
        private const float _backgroundLineHeight = 16.0f;

        private delegate void CommandDelegate(GameConsole gameConsole, params string[] arguments);

        private readonly ConcurrentDictionary<string, CommandDelegate> _commands = new ConcurrentDictionary<string, CommandDelegate>();

        private readonly INetworkManager _networkManager;
        private readonly ISyncManager _syncManager;
        private readonly ILogger _logger;

        public GameConsole(INetworkManager networkManager, ISyncManager syncManager, ILogger<GameConsole> logger)
        {
            _networkManager = networkManager;
            _syncManager = syncManager;
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _cursorIndex = 0;

            RegisterCommands();

            NativeHelper.OnNativeTick += Tick;
            NativeHelper.OnKeyboardTick += HandleKeyboardCallback;

#if DEBUG
            Task.Run(async () =>
            {
                while (true)
                {
                    var input = System.Console.ReadLine();

                    await ThreadHelper.RunAsync(() => HandleCommand(input));
                }
            });
#endif

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private void RegisterCommands()
        {
            RegisterCommand("output", CommandOutputText);
            RegisterCommand("clear", CommandClear);
            RegisterCommand("setskin", CommandSetSkin);
            RegisterCommand("setweather", CommandSetWeather);

            RegisterCommand("connect", CommandNetworkConnect);
            RegisterCommand("disconnect", CommandNetworkDisconnect);

            RegisterCommand("playanim", CommandPlayAnimation);
            RegisterCommand("stopanim", CommandStopAnimation);

            RegisterCommand("addweapon", CommandAddWeapon);
            RegisterCommand("removeallweapons", CommandRemoveAllWeapons);

            RegisterCommand("showsynced", CommandShowSynced);
            RegisterCommand("hidesynced", CommandHideSynced);

            RegisterCommand("gettrailer", CommandGetTrailer);

            RegisterCommand("cmd", CommandRemoteCommand);
        }

        private void RegisterCommand(string commandName, CommandDelegate action)
        {
            commandName = commandName.ToLowerInvariant();

            _commands.TryAdd(commandName, action);
        }

        public void Tick(float deltaTime)
        {
            if (Utility.IsKeyReleased(ConsoleKey.F1))
            {
                IsVisible = IsVisible == false;
            }

            if (IsVisible == false)
            {
                return;
            }

            Gameplay.DisableAllControlActions(0);

            UserInterface.GetScreenResolution(out var width, out var height);

            var outputHeight = _backgroundLineHeight * _outputLines / height;
            var inputHeight = _backgroundInputHeight / height;

            UserInterface.DrawRect(new Vector2(0.5f, outputHeight / 2.0f), new Vector2(1.0f, outputHeight), Color.FromArgb(150, 50, 50, 50));
            UserInterface.DrawRect(new Vector2(0.5f, outputHeight + inputHeight / 2.0f), new Vector2(1.0f, inputHeight), Color.FromArgb(150, 0, 0, 0));

            var count = 0;

            lock (_output)
            {
                foreach (var line in _output)
                {
                    DrawText(line, 0.001f, _backgroundLineHeight * count++ / height);
                }
            }

            DrawText(_input, 0.001f, outputHeight);

            var now = DateTime.UtcNow;
            if ((now - _lastBlinkUpdate).TotalMilliseconds > 500)
            {
                _blinkState = _blinkState == false;

                _lastBlinkUpdate = now;
            }

            if (_blinkState)
            {
                var textWidth = UserInterface.GetTextWidth(_input.Substring(0, _cursorIndex), 0.3f);

                UserInterface.DrawRect(new Vector2(textWidth - 0.0005f, outputHeight + inputHeight / 2.0f), new Vector2(0.001f, inputHeight * 0.8f),
                    Color.FromArgb(200, 255, 255, 255));
            }
        }

        public void HandleKeyboardCallback(ConsoleKey key, char character, bool isPressed)
        {
            if (IsVisible == false || isPressed == false)
            {
                return;
            }

            if (key == ConsoleKey.Enter)
            {
                HandleCommand(_input);

                _input = string.Empty;
                _currentHistoryIndex = -1;
                _cursorIndex = 0;

                return;
            }

            if (key == ConsoleKey.Backspace)
            {
                if (_input.Length == 0 || _cursorIndex == 0)
                {
                    return;
                }

                _input = _input.Remove(_input.Length - 1);
                _cursorIndex--;

                return;
            }

            if (key == ConsoleKey.Delete)
            {
                if (_input.Length == 0 || _cursorIndex == _input.Length)
                {
                    return;
                }

                _input = _input.Remove(_cursorIndex, 1);

                return;
            }

            if (key == ConsoleKey.End)
            {
                _cursorIndex = _input.Length;

                return;
            }

            if (key == ConsoleKey.Home)
            {
                _cursorIndex = 0;

                return;
            }

            if (key == ConsoleKey.UpArrow)
            {
                if (_currentHistoryIndex + 1 >= _inputHistory.Count)
                {
                    return;
                }

                _currentHistoryIndex++;
                _input = _inputHistory[_currentHistoryIndex];
                _cursorIndex = _input.Length;

                return;
            }

            if (key == ConsoleKey.DownArrow)
            {
                if (_currentHistoryIndex <= 0)
                {
                    return;
                }

                _currentHistoryIndex--;
                _input = _inputHistory[_currentHistoryIndex];
                _cursorIndex = _input.Length;

                return;
            }

            if (key == ConsoleKey.LeftArrow)
            {
                if (_cursorIndex <= 0)
                {
                    return;
                }

                _cursorIndex--;

                return;
            }

            if (key == ConsoleKey.RightArrow)
            {
                if (_cursorIndex >= _input.Length)
                {
                    return;
                }

                _cursorIndex++;

                return;
            }

            // Add autocomplete, copy, paste

            if (character < 32 || character > 126)
            {
                return;
            }

            _input = _input.Insert(_cursorIndex, character.ToString());
            _cursorIndex++;
        }

        private void HandleCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                return;
            }

            var commandArray = command.Split(' ');
            var commandName = commandArray[0].ToLowerInvariant();

            _inputHistory.Insert(0, command);

            if (_inputHistory.Count > 20)
            {
                _inputHistory.RemoveAt(0);
            }

            if (_commands.TryGetValue(commandName, out var action) == false)
            {
                PrintLine("~o~Unknown command: ~s~" + commandName);
            }

            action?.Invoke(this, commandArray.Skip(1).ToArray());
        }

        private void PrintLine(string text)
        {
            lock (_output)
            {
                _output.Add(text);

                while (_output.Count > _outputLines)
                {
                    _output.RemoveAt(0);
                }
            }

            _logger.LogInformation("GameConsole: {Output}", text);
        }

        private void DrawText(string text, float x, float y)
        {
            UserInterface.DrawText(text, new Vector2(x, y), 0.3f, Color.FromArgb(255, 255, 255, 255));
        }
    }
}
