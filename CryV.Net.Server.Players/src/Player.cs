﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using CryV.Net.Elements;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Flags;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Common.Payloads.Helpers;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Server.Players
{
    public class Player : IPlayer
    {

        public int Id => _peer.Id;

        public Vector3 Position { get; set; } = new Vector3(161.1652f, -1069.867f, 29.19238f);

        public Vector3 Velocity { get; set; }

        public float Heading { get; set; }

        public int Speed { get; set; }

        public ulong Model { get; set; } = 1885233650; // Male freemode model

        public bool IsJumping { get; set; }

        public bool IsClimbing { get; set; }
        
        public bool IsClimbingLadder { get; set; }

        public bool IsRagdoll { get; set; }

        private readonly List<ISubscription> _subscriptions = new List<ISubscription>();

        private readonly NetPeer _peer;
        private readonly IEventHandler _eventHandler;
        private readonly IPlayerManager _playerManager;

        public Player(IPlayerManager playerManager, IEventHandler eventHandler, NetPeer peer)
        {
            _playerManager = playerManager;
            _eventHandler = eventHandler;
            _peer = peer;

            _subscriptions.Add(_eventHandler.Subscribe<NetworkEvent<ClientUpdatePayload>>(OnNetworkUpdate, x => x.Payload.Id == Id));

            BootstrapPlayer();
            PropagateNewPlayer();
        }

        public void Send(IPayload payload, DeliveryMethod deliveryMethod)
        {
            var data = PayloadHandler.SerializePayload(payload).Prepend((byte)payload.PayloadType).ToArray();

            if (_peer == null)
            {
                Utility.Log("Client peer is null!");

                return;
            }

            _peer.Send(data, deliveryMethod);
        }

        public ClientUpdatePayload GetPayload()
        {
            return new ClientUpdatePayload(Id, Position, Velocity, Heading, Speed, Model, IsJumping, IsClimbing, IsClimbingLadder, IsRagdoll);
        }

        public void ReadPayload(ClientUpdatePayload payload)
        {
            Position = payload.Position;
            Velocity = payload.Velocity;
            Heading = payload.Heading;
            Model = payload.Model;
            Speed = payload.Speed;

            IsJumping = (payload.PedData & (int) PedData.IsJumping) > 0;
            IsClimbing = (payload.PedData & (int) PedData.IsClimbing) > 0;
            IsClimbingLadder = (payload.PedData & (int) PedData.IsClimbingLadder) > 0;
            IsRagdoll = (payload.PedData & (int) PedData.IsRagdoll) > 0;
        }

        private void BootstrapPlayer()
        {
            var existingPlayers = new List<ClientUpdatePayload>();

            foreach (var player in _playerManager.GetPlayers())
            {
                existingPlayers.Add(player.GetPayload());
            }

#if PEDMIRROR
            var mirrorPayload = GetPayload();

            mirrorPayload.Id = 1;
            mirrorPayload.Position.X += 2.0f;

            existingPlayers.Add(mirrorPayload);
#endif

            var payload = new BootstrapPayload(_peer.Id, Position, Heading, Model, existingPlayers);

            Send(payload, DeliveryMethod.ReliableOrdered);
        }

        private void PropagateNewPlayer()
        {
            foreach (var existingPlayer in _playerManager.GetPlayers())
            {
                if (existingPlayer == this)
                {
                    continue;
                }

                existingPlayer.Send(new AddClientPayload(GetPayload()), DeliveryMethod.ReliableOrdered);
            }
        }

        private void OnNetworkUpdate(NetworkEvent<ClientUpdatePayload> obj)
        {
            var payload = obj.Payload;

            ReadPayload(payload);

            foreach (var player in _playerManager.GetPlayers())
            {
                if (player == this)
                {
#if PEDMIRROR
                    payload.Id = 1;
                    payload.Position.X += 2.0f;

                    player.Send(payload, DeliveryMethod.Unreliable);
#endif
                    continue;
                }

                player.Send(payload, DeliveryMethod.Unreliable);
            }
        }

        public void Dispose()
        {
            foreach (var subscription in _subscriptions)
            {
                _eventHandler.Unsubscribe(subscription);
            }

            foreach (var player in _playerManager.GetPlayers())
            {
                if (player == this)
                {
                    continue;
                }

                player.Send(new RemoveClientPayload(Id), DeliveryMethod.ReliableOrdered);
            }
        }
    }
}
