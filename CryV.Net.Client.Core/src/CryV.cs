using System;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Elements;
using CryV.Net.Plugins;

namespace CryV.Net.Client.Core
{
    public class CryV : IPlugin
    {

        private readonly ContainerManager _containerManager;

        public CryV()
        {
            _containerManager = new ContainerManager();

            _containerManager.Start();
        }

        public void Tick()
        {
            NativeHelper.InvokeNativeTick();
        }

        public void OnKeyboard(ConsoleKey key, char character, bool isPressed)
        {
            NativeHelper.InvokeKeyboardTick(key, character, isPressed);
        }

    }
}
