using System.Collections.Concurrent;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Shared.Common.Events;
using CryV.Net.Shared.Common.Payloads;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Client.FingerPointing
{
    public class FingerPointingManager : IStartable
    {

        private readonly ConcurrentDictionary<int, FingerPointingPlayer> _pointingPlayers = new ConcurrentDictionary<int, FingerPointingPlayer>();

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
            _eventAggregator.Subscribe<NetworkEvent<StopPointingPayload>>(x => OnStopPointing(x.Payload.Id));
            _eventAggregator.Subscribe<PlayerDisconnectedEvent>(x => OnStopPointing(x.Player.Id));

            NativeHelper.OnNativeTick += Tick;
        }

        private void Tick(float deltaTime)
        {
            foreach (var pointingPlayer in _pointingPlayers.Values)
            {
                pointingPlayer.Tick(deltaTime);
            }
        }

        private Task OnPointingUpdate(NetworkEvent<PointingUpdatePayload> obj)
        {
            var payload = obj.Payload;

            if (_pointingPlayers.TryGetValue(payload.Id, out var pointingPlayer) == false)
            {
                var player = _playerManager.GetPlayer(payload.Id);

                pointingPlayer = new FingerPointingPlayer(player, payload);

                _pointingPlayers.TryAdd(payload.Id, pointingPlayer);

                return Task.CompletedTask;
            }

            pointingPlayer.UpdatePointing(payload);

            return Task.CompletedTask;
        }

        private Task OnStopPointing(int playerId)
        {
            if (_pointingPlayers.TryRemove(playerId, out var pointingPlayer) == false)
            {
                return Task.CompletedTask;
            }

            pointingPlayer.Dispose();

            return Task.CompletedTask;
        }

    }
}
