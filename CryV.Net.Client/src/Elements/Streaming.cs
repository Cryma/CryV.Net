using CryV.Net.Client.Native;

namespace CryV.Net.Client.Elements
{
    public static class Streaming
    {

        public static void RequestModel(ulong model)
        {
            CryVNative.Native_Gameplay_RequestModel(CryVNative.Plugin, model);
        }

        public static bool HasModelLoaded(ulong model)
        {
            return CryVNative.Native_Gameplay_HasModelLoaded(CryVNative.Plugin, model);
        }

        public static void SetModelAsNoLongerNeeded(ulong model)
        {
            CryVNative.Native_Gameplay_SetModelAsNoLongerNeeded(CryVNative.Plugin, model);
        }

    }
}