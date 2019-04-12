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

        private void BootstrapPlayer()
        {
            var payload = new BootstrapPayload(_peer.Id, new Vector3(161.1652f, -1069.867f, 29.19238f), 0.0f, 1885233650);

            Send(payload, DeliveryMethod.ReliableOrdered);
        }

    }
}
