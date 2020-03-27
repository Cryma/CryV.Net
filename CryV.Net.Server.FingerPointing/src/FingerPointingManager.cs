using System.Threading.Tasks;
using Autofac;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Events;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.FingerPointing
{
    public class FingerPointingManager : IStartable
    {

        private readonly IEventAggregator _eventAggregator;
        private readonly IPlayerManager _playerManager;

        public FingerPointingManager(IEventAggregator eventAggregator, IPlayerManager playerManager)
        {
            _eventAggregator = eventAggregator;
            _playerManager = playerManager;
        }

        public void Start()
        {
            _eventAggregator.Subscribe<NetworkEvent<PointingUpdatePayload>>(OnPointingUpdate);
            _eventAggregator.Subscribe<NetworkEvent<StopPointingPayload>>(OnStopPointing);
        }

        private Task OnPointingUpdate(NetworkEvent<PointingUpdatePayload> obj)
        {
            var player = _playerManager.GetPlayer(obj.Payload.Id);

            if (player == null)
            {
                return Task.CompletedTask;
            }

            foreach (var otherPlayer in _playerManager.GetPlayers())
            {
                if (otherPlayer == player)
                {
#if PEDMIRROR
                    obj.Payload.Id = 1;
                    otherPlayer.Send(obj.Payload, DeliveryMethod.Unreliable);
#endif
                    continue;
                }

                otherPlayer.Send(obj.Payload, DeliveryMethod.Unreliable);
            }

            return Task.CompletedTask;
        }

        private Task OnStopPointing(NetworkEvent<StopPointingPayload> obj)
        {
            var player = _playerManager.GetPlayer(obj.Payload.Id);

            if (player == null)
            {
                return Task.CompletedTask;
            }

            foreach (var otherPlayer in _playerManager.GetPlayers())
            {
                if (otherPlayer == player)
                {
#if PEDMIRROR
                    obj.Payload.Id = 1;
                    otherPlayer.Send(obj.Payload, DeliveryMethod.Unreliable);
#endif
                    continue;
                }

                otherPlayer.Send(obj.Payload, DeliveryMethod.Unreliable);
            }

            return Task.CompletedTask;
        }

    }
}
