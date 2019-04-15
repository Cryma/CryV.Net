using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Client.LocalPlayer
{
    public class LocalPlayer : IStartable
    {

        public int Id
        {
            get => LocalPlayerHelper.LocalId;
            set => LocalPlayerHelper.LocalId = value;
        }

        private CancellationTokenSource _cancellationTokenSource;

        private Vector3 _lastPosition;
        private Vector3 _lastVelocity;
        private float _lastHeading;
        private ulong _lastModel;
        private ulong _lastWeapon;
        private bool _lastAiming;

        private readonly IEventHandler _eventHandler;
        private readonly INetworkManager _networkManager;

        public LocalPlayer(IEventHandler eventHandler, INetworkManager networkManager)
        {
            _eventHandler = eventHandler;
            _networkManager = networkManager;
        }

        public void Start()
        {
            _eventHandler.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);
            _eventHandler.Subscribe<LocalPlayerConnectedEvent>(OnLocalPlayerConnected);
            _eventHandler.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnected);
        }

        private void OnLocalPlayerConnected(LocalPlayerConnectedEvent obj)
        {
        }

        private void OnLocalPlayerDisconnected(LocalPlayerDisconnectedEvent obj)
        {
            _cancellationTokenSource?.Cancel();
        }

        private void OnBootstrap(NetworkEvent<BootstrapPayload> obj)
        {
            var payload = obj.Payload;

            Id = payload.LocalId;

            ThreadHelper.Run(() =>
            {
                var rotation = Elements.LocalPlayer.Character.Rotation;

                Elements.LocalPlayer.Character.Position = payload.StartPosition;
                Elements.LocalPlayer.Model = payload.StartModel;
                Elements.LocalPlayer.Character.Rotation = new Vector3(rotation.X, rotation.Y, payload.StartHeading);

                _cancellationTokenSource = new CancellationTokenSource();
                Task.Run(Sync, _cancellationTokenSource.Token);
            });
        }

        private async Task Sync()
        {
            while (_cancellationTokenSource.IsCancellationRequested == false)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(50), _cancellationTokenSource.Token);

                ThreadHelper.Run(() =>
                {
                    var position = Elements.LocalPlayer.Character.Position;
                    var rotation = Elements.LocalPlayer.Character.Rotation;
                    var velocity = Elements.LocalPlayer.Character.Velocity;
                    var model = Elements.LocalPlayer.Model;
                    var weaponModel = Elements.LocalPlayer.Character.GetCurrentPedWeapon();
                    var isAiming = Elements.LocalPlayer.Character.GetIsTaskActive(290);

                    // TODO: Better detection if something changed
                    if ((position - _lastPosition).Length() < 0.05f && (velocity - _lastVelocity).Length() < 0.05f && Math.Abs(rotation.Z - _lastHeading) < 0.05f &&
                        _lastModel == model && _lastWeapon == weaponModel && _lastAiming == isAiming)
                    {
                        return;
                    }

                    _lastPosition = position;
                    _lastVelocity = velocity;
                    _lastHeading = rotation.Z;
                    _lastModel = model;
                    _lastWeapon = weaponModel;
                    _lastAiming = isAiming;

                    var transformPayload = new PlayerUpdatePayload(Id, position, velocity, rotation.Z, Elements.LocalPlayer.Character.Speed(),
                        model, weaponModel, Elements.LocalPlayer.Character.IsPedJumping(), Elements.LocalPlayer.Character.IsPedClimbing(),
                        Elements.LocalPlayer.Character.GetIsTaskActive(47), Elements.LocalPlayer.Character.IsPedRagdoll(), isAiming);

                    _networkManager.Send(transformPayload, DeliveryMethod.Unreliable);
                });
            }
        }

    }
}
