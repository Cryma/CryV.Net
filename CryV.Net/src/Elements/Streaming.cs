using CryV.Net.Native;

namespace CryV.Net.Elements
{
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

        private static void RequestModel(ulong model)
        {
            CryVNative.Native_Gameplay_RequestModel(CryVNative.Plugin, model);
        }

        private static bool HasModelLoaded(ulong model)
        {
            return CryVNative.Native_Gameplay_HasModelLoaded(CryVNative.Plugin, model);
        }

        private static void SetModelAsNoLongerNeeded(ulong model)
        {
            CryVNative.Native_Gameplay_SetModelAsNoLongerNeeded(CryVNative.Plugin, model);
        }

    }
}