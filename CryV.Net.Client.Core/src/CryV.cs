using System;
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
            
        }

        public void OnKeyboard(ConsoleKey key, char character, bool isPressed)
        {
            
        }

    }
}
