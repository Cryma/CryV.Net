using System.Numerics;
using CryV.Net.Helpers;
using CryV.Net.Native;

namespace CryV.Net.Elements;

public static class Gameplay
{

    public static void TerminateAllScriptsWithThisName(string scriptName)
    {
        using (var converter = new StringConverter())
        {
            var namePointer = converter.StringToPointer(scriptName);

            CryVNative.Native_Misc_TerminateAllScriptsWithThisName(CryVNative.Plugin, namePointer);
        }
    }

    public static void UseFreemodeMapBehaviour(bool enabled)
    {
        CryVNative.Native_Misc_UseFreemodeMapBehavior(CryVNative.Plugin, enabled);
    }

    public static void LoadMpDlcMaps()
    {
        CryVNative.Native_Dlc_LoadMpDlcMaps(CryVNative.Plugin);
    }

    public static void DisableAllControlActions(int inputGroup)
    {
        CryVNative.Native_Pad_DisableAllControlActions(CryVNative.Plugin, inputGroup);
    }

    public static void DisableControlAction(int inputGroup, int control, bool disable)
    {
        CryVNative.Native_Pad_DisableControlAction(CryVNative.Plugin, inputGroup, control, disable);
    }

    public static bool IsDisabledControlJustPressed(int inputGroup, int control)
    {
        return CryVNative.Native_Pad_IsDisabledControlJustPressed(CryVNative.Plugin, inputGroup, control);
    }

    public static bool IsControlJustPressed(int inputGroup, int control)
    {
        return CryVNative.Native_Pad_IsControlJustPressed(CryVNative.Plugin, inputGroup, control);
    }

    public static void DestroyAllCams(bool thisScriptCheck)
    {
        CryVNative.Native_Cam_DestroyAllCams(CryVNative.Plugin, thisScriptCheck);
    }

    public static void SetNoLoadingScreen(bool toggle)
    {
        CryVNative.Native_Script_SetNoLoadingScreen(CryVNative.Plugin, toggle);
    }

    public static int StartShapeTestRay(Vector3 start, Vector3 end, int flags, int entityHandle, int p8)
    {
        return CryVNative.Native_Shapetest_StartShapeTestRay(CryVNative.Plugin, start.X, start.Y, start.Z, end.X, end.Y, end.Z, flags, entityHandle, p8);
    }

    public static bool GetShapeTestResult(int rayHandle)
    {
        // TODO: Reimplement
        return false;
    }

    public static Vector3 GetGameplayCamCoord()
    {
        return StructConverter.PointerToStruct<Vector3>(CryVNative.Native_Cam_GetGameplayCamCoord(CryVNative.Plugin));
    }

    public static Vector3 GetGameplayCamRot(int rotationOrder = 2)
    {
        return StructConverter.PointerToStruct<Vector3>(CryVNative.Native_Cam_GetGameplayCamRot(CryVNative.Plugin, rotationOrder));
    }

    public static float GetGameplayCamRelativeHeading()
    {
        return CryVNative.Native_Cam_GetGameplayCamRelativeHeading(CryVNative.Plugin);
    }

    public static void DisableStuntJumpSet(int set)
    {
        CryVNative.Native_Misc_DisableStuntJumpSet(CryVNative.Plugin, set);
    }

    public static void DeleteStuntJump(int stuntJump)
    {
        CryVNative.Native_Misc_DeleteStuntJump(CryVNative.Plugin, stuntJump);
    }

    public static void PauseClock(bool toggle)
    {
        CryVNative.Native_Clock_PauseClock(CryVNative.Plugin, toggle);
    }

    public static void SetSlowmotion(bool toggle)
    {
        CryVNative.Native_Memory_SetSlowmotion(CryVNative.Plugin, toggle);
    }

}
