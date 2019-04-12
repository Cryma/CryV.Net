using System;

namespace CryV.Net.Client.Common.Helpers
{
    public static class NativeHelper
    {

        public delegate void NativeTick();
        public delegate void KeyboardTick(ConsoleKey key, char character, bool isPressed);

        public static event NativeTick OnNativeTick;
        public static event KeyboardTick OnKeyboardTick;

        public static void InvokeNativeTick()
        {
            OnNativeTick?.Invoke();
        }

        public static void InvokeKeyboardTick(ConsoleKey key, char character, bool isPressed)
        {
            OnKeyboardTick?.Invoke(key, character, isPressed);
        }

    }
}
