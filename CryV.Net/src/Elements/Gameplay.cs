using System.Numerics;
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

        public static int StartShapeTestRay(Vector3 start, Vector3 end, int flags, int entityHandle, int p8)
        {
            return CryVNative.Native_Gameplay_StartShapeTestRay(CryVNative.Plugin, start.X, start.Y, start.Z, end.X, end.Y, end.Z, flags, entityHandle, p8);
        }

        public static bool GetShapeTestResult(int rayHandle)
        {
            return CryVNative.Native_Gameplay_GetShapeTestResult(CryVNative.Plugin, rayHandle);
        }

        public static Vector3 GetGameplayCamRot(int rotationOrder = 2)
        {
            return StructConverter.PointerToStruct<Vector3>(CryVNative.Native_Gameplay_GetGameplayCamRot(CryVNative.Plugin, rotationOrder));
        }

        public static float GetGameplayCamRelativeHeading()
        {
            return CryVNative.Native_Gameplay_GetGameplayCamRelativeHeading(CryVNative.Plugin);
        }

    }
}
