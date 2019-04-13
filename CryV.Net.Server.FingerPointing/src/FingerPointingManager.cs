using Autofac;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Server.FingerPointing
{
    public class FingerPointingManager : IStartable
    {

        private readonly IEventHandler _eventHandler;
        private readonly IPlayerManager _playerManager;

        public FingerPointingManager(IEventHandler eventHandler, IPlayerManager playerManager)
        {
            _eventHandler = eventHandler;
            _playerManager = playerManager;
        }

        public void Start()
        {
            _eventHandler.Subscribe<NetworkEvent<PointingUpdatePayload>>(OnPointingUpdate);
            _eventHandler.Subscribe<NetworkEvent<StopPointingPayload>>(OnStopPointing);
        }

        private void OnPointingUpdate(NetworkEvent<PointingUpdatePayload> obj)
        {
            var player = _playerManager.GetPlayer(obj.Payload.Id);

            if (player == null)
            {
                return;
            }

            foreach (var otherPlayer in _playerManager.GetPlayers())
            {
                if (otherPlayer == player)
                {
                    continue;
                }

                otherPlayer.Send(obj.Payload, DeliveryMethod.Unreliable);
            }
        }

        private void OnStopPointing(NetworkEvent<StopPointingPayload> obj)
        {
            var player = _playerManager.GetPlayer(obj.Payload.Id);

            if (player == null)
            {
                return;
            }

            foreach (var otherPlayer in _playerManager.GetPlayers())
            {
                if (otherPlayer == player)
                {
                    continue;
                }

                otherPlayer.Send(obj.Payload, DeliveryMethod.Unreliable);
            }
        }

    }
}
