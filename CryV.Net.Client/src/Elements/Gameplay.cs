using CryV.Net.Client.Native;

namespace CryV.Net.Client.Elements
{
    public static class Gameplay
    {

        public static void TerminateAllScriptsWithThisName(string scriptName)
        {
            using (var converter = new StringConverter())
            {
                var namePointer = converter.StringToPointer(scriptName);

                CryVNative.Native_Gameplay_TerminateAllScriptsWithThisName(CryVNative.Plugin, namePointer);
            }
        }

        public static void UseFreemodeMapBehaviour(bool enabled)
        {
            CryVNative.Native_Gameplay_UseFreemodeMapBehaviour(CryVNative.Plugin, enabled);
        }

        public static void LoadMpDlcMaps()
        {
            CryVNative.Native_Gameplay_LoadMpDlcMaps(CryVNative.Plugin);
        }

    }
}
