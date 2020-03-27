using System;
using System.Numerics;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Elements;

namespace CryV.Net.Client.LocalPlayer
{
    public partial class LocalPlayer
    {

        private bool _isFingerPointing;

        private float _fingerPointingPitch;
        private float _fingerPointingHeading;

        private float GetCameraPitch()
        {
            var cameraPitch = Gameplay.GetGameplayCamRot().X - Elements.LocalPlayer.Character.GetEntityPitch();

            cameraPitch = Math.Clamp(cameraPitch, -70.0f, 42.0f);

            return (cameraPitch + 70.0f) / 112.0f;
        }

        private float GetCameraHeading()
        {
            var cameraHeading = Gameplay.GetGameplayCamRelativeHeading();

            cameraHeading = Math.Clamp(cameraHeading, -180.0f, 180.0f);

            return (cameraHeading + 180.0f) / 360.0f;
        }

        private void FingerPointingTick(float deltaTime)
        {
            if (_networkManager.IsConnected == false)
            {
                return;
            }

            if (Utility.IsKeyReleased(ConsoleKey.B))
            {
                if (_isFingerPointing == false)
                {
                    FingerPointingHelper.StartPointing(Elements.LocalPlayer.Character);
                    _isFingerPointing = true;
                }
                else
                {
                    FingerPointingHelper.StopPointing(Elements.LocalPlayer.Character);
                    _isFingerPointing = false;
                }
            }

            if (_isFingerPointing)
            {
                UpdateLocalFingerPointing();
            }
        }

        private void UpdateLocalFingerPointing()
        {
            var cameraPitch = GetCameraPitch();
            var cameraHeading = GetCameraHeading();

            var cosCameraHeading = (float)Math.Cos(cameraHeading);
            var sinCameraHeading = (float)Math.Sin(cameraHeading);

            var coordinates = Elements.LocalPlayer.Character.GetOffsetFromEntityGivenWorldCoords(new Vector3(cosCameraHeading * -0.2f - sinCameraHeading * (0.4f * cameraHeading + 0.3f),
                sinCameraHeading * -0.2f + cosCameraHeading * (0.4f * cameraHeading + 0.3f), 0.6f));

            var raycast = Gameplay.StartShapeTestRay(new Vector3(coordinates.X, coordinates.Y, coordinates.Z - 0.2f),
                new Vector3(coordinates.X, coordinates.Y, coordinates.Z + 0.2f), 7, Elements.LocalPlayer.Character.Handle, 0);

            var hit = Gameplay.GetShapeTestResult(raycast);

            _fingerPointingPitch = cameraPitch;
            _fingerPointingHeading = cameraHeading * -1.0f + 1.0f;

            FingerPointingHelper.UpdatePointing(Elements.LocalPlayer.Character, _fingerPointingPitch, _fingerPointingHeading, hit);
        }

    }
}
