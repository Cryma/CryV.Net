using System;
using System.Drawing;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Elements;
using CryV.Net.Enums;
using Microsoft.Extensions.Hosting;

namespace CryV.Net.Client.Helpers
{
    public class PauseMenuHelper : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            NativeHelper.OnNativeTick += Tick;

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private void Tick(float deltatime)
        {
            UserInterface.DrawText("CryV", new Vector2(0.975f, 0.01f), 0.42f, Color.FromArgb(255, 200, 200, 200), TextFont.ChaletLondon, TextAlignment.Center, 1.0f);

            Gameplay.DisableControlAction(0, 199, true);
            Gameplay.DisableControlAction(0, 200, true);

            if (Utility.IsKeyReleased(ConsoleKey.Escape))
            {
                UserInterface.ActivateFrontendMenu(Utility.Joaat("FE_MENU_VERSION_SP_PAUSE"), false, -1);
            }
        }

    }
}
