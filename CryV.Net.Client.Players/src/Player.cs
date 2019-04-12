using System;
using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Flags;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Client.Players
{
    public class Player : IPlayer, IDisposable
    {

        public int Id { get; }

        public Vector3 Position
        {
            get => _ped.Position;
            set => _ped.Position = value;
        }

        public Vector3 TargetPosition { get; set; }

        public Vector3 Velocity { get; set; }

        public Vector3 Rotation
        {
            get => _ped.Rotation;
            set => _ped.Rotation = value;
        }

        public float TargetHeading { get; set; }

        public int Speed { get; set; }

        public ulong Model
        {
            get => _ped.Model;
            set => _ped.Model = value;
        }

        public bool IsJumping { get; set; }

        public bool IsClimbing { get; set; }

        public bool IsClimbingLadder { get; set; }

        public bool IsRagdoll { get; set; }

        private Ped _ped;

        private static float _interpolationFactor = 3.0f;

        private DateTime _lastTick = DateTime.UtcNow;

        private float _lastRange;
        private bool _wasNegative;
        private bool _wasJumping;
        private bool _wasClimbing;
        private bool _wasRagdoll;

        private readonly List<ISubscription> _eventSubscriptions = new List<ISubscription>();

        private readonly IEventHandler _eventHandler;

        public Player(IEventHandler eventHandler, ClientUpdatePayload payload)
        {
            _eventHandler = eventHandler;

            Id = payload.Id;
            TargetPosition = payload.Position;
            TargetHeading = payload.Heading;

            _eventSubscriptions.Add(_eventHandler.Subscribe<NetworkEvent<ClientUpdatePayload>>(update => ReadPayload(update.Payload), x => x.Payload.Id == Id));

            ThreadHelper.Run(() =>
            {
                _ped = new Ped(payload.Model, payload.Position, payload.Heading)
                {
                    Velocity = Velocity
                };
            });
        }

        public void ReadPayload(ClientUpdatePayload payload)
        {
            TargetPosition = payload.Position;
            TargetHeading = payload.Heading;
            Velocity = payload.Velocity;
            Speed = payload.Speed;

            IsJumping = (payload.PedData & (int) PedData.IsJumping) > 0;
            if (IsJumping == false)
            {
                _wasJumping = false;
            }

            IsClimbing = (payload.PedData & (int) PedData.IsClimbing) > 0;
            if (IsClimbing == false)
            {
                _wasClimbing = false;
            }

            IsClimbingLadder = (payload.PedData & (int) PedData.IsClimbingLadder) > 0;

            IsRagdoll = (payload.PedData & (int) PedData.IsRagdoll) > 0;

            // TODO: Optimize
            ThreadHelper.Run(() =>
            {
                if (Model != payload.Model)
                {
                    Model = payload.Model;
                }
            });
        }

        public void Dispose()
        {
            foreach (var subscription in _eventSubscriptions)
            {
                _eventHandler.Unsubscribe(subscription);
            }

            _ped.Delete();
        }

    }
}
