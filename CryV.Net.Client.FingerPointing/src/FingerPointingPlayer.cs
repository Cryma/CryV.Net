using System;
using Autofac;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Client.FingerPointing;
using CryV.Net.Elements;
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

        private DateTime _lastReceiveDate;

        public FingerPointingPlayer(IPlayer player)
        {
            _player = player;

            _lastReceiveDate = DateTime.UtcNow;

            StartPointing();
        }

        public void Tick(float deltaTime)
        {
            var lerpedPitch = Interpolation.Lerp(_currentPitch, _targetPitch, deltaTime * _syncFactor);
            var lerpedHeading = Interpolation.Lerp(_currentHeading, _targetHeading, deltaTime * _syncFactor);

            FingerPointingUtils.UpdatePointing(_player.GetPed(), lerpedPitch, lerpedHeading, false);

            _currentPitch = lerpedPitch;
            _currentHeading = lerpedHeading;
        }

        public void StartPointing()
        {
            FingerPointingUtils.StartPointing(_player.GetPed());
        }

        public void UpdatePointing(PointingUpdatePayload payload)
        {

            _targetHeading = payload.Heading;
            _targetPitch = payload.Pitch;

            _lastReceiveDate = DateTime.UtcNow;
        }

        private void StopPointing()
        {
            FingerPointingUtils.StopPointing(_player.GetPed());
        }

        public void Dispose()
        {
            StopPointing();
        }
    }
}
