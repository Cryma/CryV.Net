using System;
using System.Drawing;
using System.Numerics;
using System.Threading.Tasks;
using CryV.Net.Client.Console;
using CryV.Net.Client.Helpers;
using CryV.Net.Elements;
using CryV.Net.Enums;
using CryV.Net.Plugins;

namespace CryV.Net.Client
{
    public class Plugin : IPlugin
    {

        private readonly GameConsole _console;
        private readonly GameClient _gameClient;

        public Plugin()
        {

            Gameplay.DestroyAllCams(true);
            Gameplay.SetNoLoadingScreen(true);

            Gameplay.UseFreemodeMapBehaviour(true);
            //Gameplay.LoadMpDlcMaps();

            Cleanup.Initial();

            World.SetWeather(WeatherType.Extrasunny);

            LocalPlayer.Character.Position = new Vector3(412.4f, -976.71f, 29.43f);

            _gameClient = new GameClient();
            _console = new GameConsole(_gameClient);

            Task.Run(Cleanup.ClearEntities);
        }

        public void Tick()
        {
            if (_console.IsVisible == false)
            {
                UserInterface.DrawText("CryV", new Vector2(0.975f, 0.01f), 0.42f, Color.FromArgb(255, 200, 200, 200), TextFont.ChaletLondon, TextAlignment.Center, 1.0f);
            }

            Cleanup.Tick();

            _gameClient.Tick();
            _console.Update();

            Gameplay.DisableControlAction(0, 199, true);
            Gameplay.DisableControlAction(0, 200, true);

            if (Gameplay.IsDisabledControlJustPressed(0, 200))
            {
                UserInterface.ActivateFrontendMenu(3123948979, false, -1);
            }
        }

        public void OnKeyboard(ConsoleKey key, char character, bool isPressed)
        {
            _console.HandleKeyboardCallback(key, character, isPressed);
        }

    }
}
