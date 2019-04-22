using System.Collections.Concurrent;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Client.Helpers.Pointing;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Client.FingerPointing.src
{
    public class FingerPointingManager : IStartable
    {

        private readonly ConcurrentDictionary<int, FingerPointingPlayer> _pointingPlayers = new ConcurrentDictionary<int, FingerPointingPlayer>();

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
            _eventHandler.Subscribe<NetworkEvent<StopPointingPayload>>(x => OnStopPointing(x.Payload.Id));
            _eventHandler.Subscribe<PlayerDisconnectedEvent>(x => OnStopPointing(x.Player.Id));

            NativeHelper.OnNativeTick += Tick;
        }

        private void Tick(float deltaTime)
        {
            foreach (var pointingPlayer in _pointingPlayers.Values)
            {
                pointingPlayer.Tick(deltaTime);
            }
        }

        private void OnPointingUpdate(NetworkEvent<PointingUpdatePayload> obj)
        {
            var payload = obj.Payload;

            if (_pointingPlayers.TryGetValue(payload.Id, out var pointingPlayer) == false)
            {
                var player = _playerManager.GetPlayer(payload.Id);

                pointingPlayer = new FingerPointingPlayer(player, payload);

                _pointingPlayers.TryAdd(payload.Id, pointingPlayer);

                return;
            }

            pointingPlayer.UpdatePointing(payload);
        }

        private void OnStopPointing(int playerId)
        {
            if (_pointingPlayers.TryRemove(playerId, out var pointingPlayer) == false)
            {
                return;
            }

            pointingPlayer.Dispose();
        }

    }
}
