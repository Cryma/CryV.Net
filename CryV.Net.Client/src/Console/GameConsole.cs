using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Mail;
using System.Numerics;
using CryV.Net.Client.Elements;
using CryV.Net.Client.Enums;
using CryV.Net.Client.Native;

namespace CryV.Net.Client.Console
{
    public class GameConsole
    {

        private bool _visible = false;
        private string _input = string.Empty;
        private readonly List<string> _output = new List<string>();
        private int _outputLines = 5;
        private bool _blinkState = false;
        private DateTime _lastBlinkUpdate = DateTime.UtcNow;
        private int _cursorIndex = 0;

        private List<string> _inputHistory;
        private int _currentHistoryIndex = -1;

        private const float _backgroundInputHeight = 18.0f;
        private const float _backgroundLineHeight = 16.0f;

        public void Update()
        {
            if (Utility.IsKeyReleased(ConsoleKey.F1))
            {
                _visible = _visible == false;
            }
            
            if (_visible == false)
            {
                return;
            }

            // TODO: Disable all game controls

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
            if (_visible == false || isPressed == false)
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

                _input = _input.Substring(_cursorIndex, 1);
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

            // Add history, left, right, autocomplete, copy, paste

            if ((int) key < 32 || (int) key > 126)
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
            var commandName = commandArray[0];

            if (commandName == "test")
            {
                PrintLine("Ahja!");
            }
            else
            {
                PrintLine("~o~Unknown command: ~s~" + commandName);
            }
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
        }

        private void DrawText(string text, float x, float y)
        {
            CryVNative.Native_UserInterface_SetTextFont(CryVNative.Plugin, 0);
            CryVNative.Native_UserInterface_SetTextScale(CryVNative.Plugin, 0.3f, 0.3f);
            CryVNative.Native_UserInterface_SetTextColour(CryVNative.Plugin, 255, 255, 255, 255);

            using (var converter = new StringConverter())
            {
                var componentTypePointer = converter.StringToPointer("STRING");
                var textPointer = converter.StringToPointer(text);

                CryVNative.Native_UserInterface_BeginTextCommandDisplayText(CryVNative.Plugin, componentTypePointer);
                CryVNative.Native_UserInterface_AddTextComponentSubstringPlayerName(CryVNative.Plugin, textPointer);
                CryVNative.Native_UserInterface_EndTextCommandDisplayText(CryVNative.Plugin, x, y);
            }
        }

    }
}
