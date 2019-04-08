using System;

namespace CryV.Net.Plugins
{
    public interface IPlugin
    {
        void Tick();

        void OnKeyboard(ConsoleKey key, char character, bool isPressed);

    }
}
