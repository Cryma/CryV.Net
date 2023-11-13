using System;

namespace CryV.Net.Client.Common.Helpers;

public static class NativeHelper
{

    public delegate void NativeTick(float deltaTime);
    public delegate void KeyboardTick(ConsoleKey key, char character, bool isPressed);

    public static event NativeTick OnNativeTick;
    public static event KeyboardTick OnKeyboardTick;

    private static DateTime _lastTick = DateTime.UtcNow;

    public static void InvokeNativeTick()
    {
        var now = DateTime.UtcNow;
        var deltaTime = (float) (now - _lastTick).TotalSeconds;

        OnNativeTick?.Invoke(deltaTime);

        _lastTick = now;
    }

    public static void InvokeKeyboardTick(ConsoleKey key, char character, bool isPressed)
    {
        OnKeyboardTick?.Invoke(key, character, isPressed);
    }

}
