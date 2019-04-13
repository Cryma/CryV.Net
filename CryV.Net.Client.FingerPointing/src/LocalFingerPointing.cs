﻿using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;

namespace CryV.Net.Client.FingerPointing
{
    public class LocalFingerPointing : IStartable
    {

        private float _currentHeading;
        private float _currentPitch;

        private float _lastSentHeading;
        private float _lastSentPitch;

        private CancellationTokenSource _cancellationTokenSource;

        private bool _isPointing;

        private readonly INetworkManager _networkManager;

        public LocalFingerPointing(INetworkManager networkManager)
        {
            _networkManager = networkManager;
        }

        public void Start()
        {
            NativeHelper.OnNativeTick += Tick;
        }

        public void Tick(float deltaTime)
        {
            if (Utility.IsKeyReleased(ConsoleKey.B))
            {
                if (_isPointing == false)
                {
                    FingerPointingUtils.StartPointing(LocalPlayer.Character);
                    _isPointing = true;

                    if (_networkManager.IsConnected)
                    {
                        Task.Run(SyncPointing, _cancellationTokenSource.Token);
                    }
                }
                else
                {
                    FingerPointingUtils.StopPointing(LocalPlayer.Character);
                    _isPointing = false;

                    _cancellationTokenSource.Cancel();
                    _cancellationTokenSource = new CancellationTokenSource();

                    if (_networkManager.IsConnected)
                    {
                        _networkManager.Send(new StopPointingPayload(LocalPlayerHelper.LocalId), DeliveryMethod.ReliableOrdered);
                    }
                }
            }

            if (_isPointing)
            {
                UpdateLocal();
            }
        }

        public async Task SyncPointing()
        {
            while (_cancellationTokenSource.IsCancellationRequested == false)
            {
                try
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(200), _cancellationTokenSource.Token);

                    if (Math.Abs(_lastSentHeading - _currentHeading) < 0.05f && Math.Abs(_lastSentPitch - _currentPitch) < 0.05f)
                    {
                        continue;
                    }

                    _lastSentHeading = _currentHeading;
                    _lastSentPitch = _currentPitch;

                    _networkManager.Send(new PointingUpdatePayload(LocalPlayerHelper.LocalId, _currentPitch, _currentHeading), DeliveryMethod.Unreliable);
                }
                catch (TaskCanceledException exception)
                {
                    // exception is expected
                }
            }
        }

        public void UpdateLocal()
        {
            var cameraPitch = GetCameraPitch();
            var cameraHeading = GetCameraHeading();

            var cosCameraHeading = (float)Math.Cos(cameraHeading);
            var sinCameraHeading = (float)Math.Sin(cameraHeading);

            var coordinates = LocalPlayer.Character.GetOffsetFromEntityGivenWorldCoords(new Vector3(cosCameraHeading * -0.2f - sinCameraHeading * (0.4f * cameraHeading + 0.3f),
                sinCameraHeading * -0.2f + cosCameraHeading * (0.4f * cameraHeading + 0.3f), 0.6f));

            var raycast = Gameplay.StartShapeTestRay(new Vector3(coordinates.X, coordinates.Y, coordinates.Z - 0.2f),
                new Vector3(coordinates.X, coordinates.Y, coordinates.Z + 0.2f), 7, LocalPlayer.Character.Handle, 0);

            var hit = Gameplay.GetShapeTestResult(raycast);

            _currentHeading = cameraHeading * -1.0f + 1.0f;
            _currentPitch = cameraPitch;

            FingerPointingUtils.UpdatePointing(LocalPlayer.Character, _currentPitch, _currentHeading, hit);
        }

        private float GetCameraPitch()
        {
            var cameraPitch = Gameplay.GetGameplayCamRot(2).X - LocalPlayer.Character.GetEntityPitch();

            cameraPitch = Math.Clamp(cameraPitch, -70.0f, 42.0f);

            return (cameraPitch + 70.0f) / 112.0f;
        }

        private float GetCameraHeading()
        {
            var cameraHeading = Gameplay.GetGameplayCamRelativeHeading();

            cameraHeading = Math.Clamp(cameraHeading, -180.0f, 180.0f);

            return (cameraHeading + 180.0f) / 360.0f;
        }

    }
}
