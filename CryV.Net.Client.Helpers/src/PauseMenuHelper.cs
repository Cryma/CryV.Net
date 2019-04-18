using System;
using System.Drawing;
using System.Numerics;
using Autofac;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Elements;
using CryV.Net.Enums;

namespace CryV.Net.Client.Helpers
{
    public class PauseMenuHelper : IStartable
    {

        public void Start()
        {
            NativeHelper.OnNativeTick += Tick;
        }

        private void Tick(float deltatime)
        {
            UserInterface.DrawText("CryV", new Vector2(0.975f, 0.01f), 0.42f, Color.FromArgb(255, 200, 200, 200), TextFont.ChaletLondon, TextAlignment.Center, 1.0f);

            Gameplay.DisableControlAction(0, 199, true);
            Gameplay.DisableControlAction(0, 200, true);

            if (Utility.IsKeyReleased(ConsoleKey.Escape))
            {
                UserInterface.ActivateFrontendMenu(3123948979, false, -1);
            }
        }

    }
}
