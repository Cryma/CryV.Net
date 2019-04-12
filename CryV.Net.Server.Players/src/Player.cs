using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using CryV.Net.Elements;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Common.Payloads.Helpers;
using LiteNetLib;

namespace CryV.Net.Server.Players
{
    public class Player : IPlayer
    {

        public int Id => _peer.Id;

        public Vector3 Position { get; set; }

        public Vector3 Velocity { get; set; }

        public float Heading { get; set; }

        public int Speed { get; set; }

        public ulong Model { get; set; }

        public bool IsJumping { get; set; }

        public bool IsClimbing { get; set; }
        
        public bool IsClimbingLadder { get; set; }

        public bool IsRagdoll { get; set; }

        private readonly NetPeer _peer;
        private readonly IEventHandler _eventHandler;
        private readonly IPlayerManager _playerManager;

        public Player(IPlayerManager playerManager, IEventHandler eventHandler, NetPeer peer)
        {
            _playerManager = playerManager;
            _eventHandler = eventHandler;
            _peer = peer;

            BootstrapPlayer();
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

        private void BootstrapPlayer()
        {
            var existingPlayers = new List<ClientUpdatePayload>();

            foreach (var player in _playerManager.GetPlayers())
            {
                existingPlayers.Add(player.GetPayload());
            }

            var payload = new BootstrapPayload(_peer.Id, new Vector3(161.1652f, -1069.867f, 29.19238f), 0.0f, 1885233650, existingPlayers);

            Send(payload, DeliveryMethod.ReliableOrdered);
        }

    }
}
