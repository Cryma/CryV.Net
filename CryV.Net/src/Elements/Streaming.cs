using CryV.Net.Helpers;
using CryV.Net.Native;

namespace CryV.Net.Elements;

public static class Streaming
{

    public static void LoadModel(ulong hash)
    {
        if (hash == 0)
        {
            Utility.Log("Tried to load model \"0\".");

            return;
        }

        RequestModel(hash);

        while (HasModelLoaded(hash) == false)
        {
            Utility.Wait(0);
        }
    }

    public static void UnloadModel(ulong hash)
    {
        SetModelAsNoLongerNeeded(hash);
    }

    public static void LoadAnimationDictionary(string animationDictionary)
    {
        if (HasAnimDictLoaded(animationDictionary))
        {
            return;
        }

        RequestAnimDict(animationDictionary);

        while (HasAnimDictLoaded(animationDictionary) == false)
        {
            Utility.Wait(0);
        }
    }

    public static bool HasAnimDictLoaded(string animDict)
    {
        using var converter = new StringConverter();
        return CryVNative.Native_Streaming_HasAnimDictLoaded(CryVNative.Plugin, converter.StringToPointer(animDict));
    }

    public static void RequestAnimDict(string animDict)
    {
        using var converter = new StringConverter();
        CryVNative.Native_Streaming_RequestAnimDict(CryVNative.Plugin, converter.StringToPointer(animDict));
    }

    public static void RequestModel(ulong model)
    {
        CryVNative.Native_Streaming_RequestModel(CryVNative.Plugin, model);
    }

    private static bool HasModelLoaded(ulong model)
    {
        return CryVNative.Native_Streaming_HasModelLoaded(CryVNative.Plugin, model);
    }

    private static void SetModelAsNoLongerNeeded(ulong model)
    {
        CryVNative.Native_Streaming_SetModelAsNoLongerNeeded(CryVNative.Plugin, model);
    }

}
