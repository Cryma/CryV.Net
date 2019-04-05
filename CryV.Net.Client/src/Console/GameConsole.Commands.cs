using System;
using System.Linq;
using CryV.Net.Client.Elements;
using CryV.Net.Client.Enums;

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

    }
}
