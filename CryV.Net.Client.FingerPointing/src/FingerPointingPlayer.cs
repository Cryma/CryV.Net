using System;
using System.Threading;
using Autofac;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Client.FingerPointing;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Client.Helpers.Pointing
{
    public class FingerPointingPlayer : IDisposable
    {

        private readonly IPlayer _player;

        private const float _syncFactor = 4.0f;

        private float _currentHeading;
        private float _currentPitch;

        private float _targetHeading;
        private float _targetPitch;

        public FingerPointingPlayer(IPlayer player, PointingUpdatePayload payload)
        {
            _player = player;

            StartPointing();

            _currentHeading = payload.Heading;
            _targetHeading = payload.Heading;

            _currentPitch = payload.Pitch;
            _targetPitch = payload.Pitch;
        }

        public void Tick(float deltaTime)
        {
            var lerpedPitch = Interpolation.Lerp(_currentPitch, _targetPitch, deltaTime * _syncFactor);
            var lerpedHeading = Interpolation.Lerp(_currentHeading, _targetHeading, deltaTime * _syncFactor);

            var ped = _player?.Ped;
            if (ped == null)
            {
                return;
            }

            FingerPointingUtils.UpdatePointing(ped, lerpedPitch, lerpedHeading, false);

            _currentPitch = lerpedPitch;
            _currentHeading = lerpedHeading;
        }

        public void StartPointing()
        {
            ThreadHelper.Run(() =>
            {
                FingerPointingUtils.StartPointing(_player.Ped);
            });
        }

        public void UpdatePointing(PointingUpdatePayload payload)
        {
            _targetHeading = payload.Heading;
            _targetPitch = payload.Pitch;
        }

        private void StopPointing()
        {
            ThreadHelper.Run(() =>
            {
                FingerPointingUtils.StopPointing(_player.Ped);
            });
        }

        public void Dispose()
        {
            StopPointing();
        }
    }
}
