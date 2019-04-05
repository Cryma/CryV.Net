using System;
using System.Linq;
using CryV.Net.Client.Elements;
using CryV.Net.Client.Enums;
using CryV.Net.Client.Networking;

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

            LocalPlayer.SetModel(skinName);
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

    }
}
