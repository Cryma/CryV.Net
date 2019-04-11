using System;
using System.Numerics;
using CryV.Net.Elements;

namespace CryV.Net.Client.Helpers
{
    public static class FingerPointing
    {

        public static void UpdateLocal()
        {
            var cameraPitch = GetCameraPitch();
            var cameraHeading = GetCameraHeading();

            var cosCameraHeading = (float) Math.Cos(cameraHeading);
            var sinCameraHeading = (float) Math.Sin(cameraHeading);

            var coordinates = LocalPlayer.Character.GetOffsetFromEntityGivenWorldCoords(new Vector3(cosCameraHeading * -0.2f - sinCameraHeading * (0.4f * cameraHeading + 0.3f),
                sinCameraHeading * -0.2f + cosCameraHeading * (0.4f * cameraHeading + 0.3f), 0.6f));

            var raycast = Gameplay.StartShapeTestRay(new Vector3(coordinates.X, coordinates.Y, coordinates.Z - 0.2f),
                new Vector3(coordinates.X, coordinates.Y, coordinates.Z + 0.2f), 7, LocalPlayer.Character.Handle, 0);

            var hit = Gameplay.GetShapeTestResult(raycast);

            UpdatePointing(cameraPitch, cameraHeading, hit);
        }

        public static void StartPointing()
        {
            Streaming.LoadAnimationDictionary("anim@mp_point");
            LocalPlayer.Character.SetPedConfigFlag(36, true);
            LocalPlayer.Character.TaskMoveNetwork("task_mp_pointing", 0.5f, false, "anim@mp_point", 24);
        }

        public static void StopPointing()
        {
            LocalPlayer.Character._0xD01015C7316AE176("Stop");
            LocalPlayer.Character.ClearPedSecondaryTask();
            LocalPlayer.Character.SetPedConfigFlag(36, false);

            LocalPlayer.Character.ClearPedTasks();
        }

        private static void UpdatePointing(float cameraPitch, float cameraHeading, bool blocked)
        {
            LocalPlayer.Character._0xD5BB4025AE449A4E("Pitch", cameraPitch);
            LocalPlayer.Character._0xD5BB4025AE449A4E("Heading", cameraHeading * -1.0f + 1.0f);
            LocalPlayer.Character._0xB0A6CFD2C69C1088("isBlocked", blocked);
            LocalPlayer.Character._0xB0A6CFD2C69C1088("isFirstPerson", false);
        }

        private static float GetCameraPitch()
        {
            var cameraPitch = Gameplay.GetGameplayCamRot(2).X - LocalPlayer.Character.GetEntityPitch();

            cameraPitch = Math.Clamp(cameraPitch, -70.0f, 42.0f);

            return (cameraPitch + 70.0f) / 112.0f;
        }

        private static float GetCameraHeading()
        {
            var cameraHeading = Gameplay.GetGameplayCamRelativeHeading();

            cameraHeading = Math.Clamp(cameraHeading, -180.0f, 180.0f);

            return (cameraHeading + 180.0f) / 360.0f;
        }

    }
}