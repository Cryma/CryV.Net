using System;
using CryV.Net.Elements;
using CryV.Net.Enums;

namespace CryV.Net.Client.Console
{
    public partial class GameConsole
    {

        private void CommandOutputText(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length == 0)
            {
                PrintLine("Please specify something to output.");

                return;
            }

            PrintLine("Output: " + string.Join(' ', arguments));
        }

        private void CommandClear(GameConsole gameConsole, params string[] arguments)
        {
            lock (_output)
            {
                _output.Clear();
            }
        }

        private void CommandSetSkin(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length == 0)
            {
                PrintLine("Please specify a skin name.");

                return;
            }

            var skinName = arguments[0];

            LocalPlayer.Model = Utility.GetHashKey(skinName);
        }

        private void CommandSetWeather(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length == 0)
            {
                PrintLine("Please specify a weather name.");

                return;
            }

            var weatherName = arguments[0];
            if (Enum.TryParse(weatherName, out WeatherType weatherType) == false)
            {
                PrintLine("Your specified weather name is invalid.");

                return;
            }

            World.SetWeather(weatherType);
        }

        private void CommandNetworkConnect(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length != 2)
            {
                PrintLine("Please specify address and port.");

                return;
            }

            var address = arguments[0];

            if (int.TryParse(arguments[1], out var port) == false)
            {
                PrintLine("Your specified port is not an integer.");

                return;
            }

            if (_gameClient.IsConnected)
            {
                PrintLine("You are already connected to a server.");

                return;
            }

            _gameClient.Connect(address, port);

            PrintLine($"You connected to \"{address}:{port}\".");
        }

        private void CommandNetworkDisconnect(GameConsole gameConsole, params string[] arguments)
        {
            if (_gameClient.IsConnected == false)
            {
                PrintLine("You are not connected to any server.");

                return;
            }

            _gameClient.Disconnect();

            PrintLine("You disconnected from the server.");
        }

        private void CommandInterpolation(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length == 0)
            {
                PrintLine("Please specify an interpolation factor.");

                return;
            }

            if (float.TryParse(arguments[0], out var factor) == false)
            {
                PrintLine("Interpolation factor must be of type \"float\".");

                return;
            }

            Elements.Client.InterpolationFactor = factor;
        }

        private void CommandPlayAnimation(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length < 1)
            {
                PrintLine("Please specify an animation dictionary and name.");

                return;
            }
            
            Streaming.LoadAnimationDictionary(arguments[0]);
            LocalPlayer.Character.TaskPlayAnim(arguments[0], arguments[1], 8.0f, 10.0f, -1, 1 | 2147483648, 1.0f, true, true, true);
        }

        private void CommandStopAnimation(GameConsole gameConsole, params string[] arguments)
        {
            LocalPlayer.Character.ClearPedTasks();
        }

    }
}
