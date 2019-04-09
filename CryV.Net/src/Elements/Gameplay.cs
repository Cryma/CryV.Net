using CryV.Net.Helpers;
using CryV.Net.Native;

namespace CryV.Net.Elements
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

        public static void DisableAllControlActions(int inputGroup)
        {
            CryVNative.Native_Gameplay_DisableAllControlActions(CryVNative.Plugin, inputGroup);
        }

        public static void DisableControlAction(int inputGroup, int control, bool disable)
        {
            CryVNative.Native_Gameplay_DisableControlAction(CryVNative.Plugin, inputGroup, control, disable);
        }

        public static bool IsDisabledControlJustPressed(int inputGroup, int control)
        {
            return CryVNative.Native_Gameplay_IsDisabledControlJustPressed(CryVNative.Plugin, inputGroup, control);
        }

        public static void DestroyAllCams(bool thisScriptCheck)
        {
            CryVNative.Native_Gameplay_DestroyAllCams(CryVNative.Plugin, thisScriptCheck);
        }

        public static void SetNoLoadingScreen(bool toggle)
        {
            CryVNative.Native_Gameplay_SetNoLoadingScreen(CryVNative.Plugin, toggle);
        }

    }
}
