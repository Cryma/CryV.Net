using System;
using System.Numerics;
using CryV.Net.Elements;
using CryV.Net.Shared.Events.Types;
using CryV.Net.Shared.Payloads;

namespace CryV.Net.Client.Helpers.Pointing
{
    public class FingerPointing
    {

        private readonly Ped _ped;

        private const float _syncFactor = 4.0f;

        private float _currentHeading;
        private float _currentPitch;

        private float _targetHeading;
        private float _targetPitch;

        private bool _isPointing;

        private DateTime _lastReceiveDate;

        public FingerPointing(Ped ped)
        {
            _ped = ped;

            _lastReceiveDate = DateTime.UtcNow;
        }

        public void Tick(float deltaTime)
        {
            var lerpedPitch = Interpolation.Lerp(_currentPitch, _targetPitch, deltaTime * _syncFactor);
            var lerpedHeading = Interpolation.Lerp(_currentHeading, _targetHeading, deltaTime * _syncFactor);

            FingerPointingUtils.UpdatePointing(_ped, lerpedPitch, lerpedHeading, false);

            _currentPitch = lerpedPitch;
            _currentHeading = lerpedHeading;
        }

        public void OnPointingUpdate(NetworkEvent<PointingUpdatePayload> obj)
        {
            if (_isPointing == false)
            {
                FingerPointingUtils.StartPointing(_ped);

                _isPointing = true;
            }

            var payload = obj.Payload;

            Utility.Log("Receiving");

            _targetHeading = payload.Heading;
            _targetPitch = payload.Pitch;

            _lastReceiveDate = DateTime.UtcNow;
        }

    }
}
