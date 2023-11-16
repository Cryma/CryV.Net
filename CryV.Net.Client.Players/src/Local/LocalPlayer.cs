using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;
using Microsoft.Extensions.Hosting;

namespace CryV.Net.Client.Players.Local;

public partial class LocalPlayer : IHostedService
{

    public static int Id
    {
        get => LocalPlayerHelper.LocalId;
        set => LocalPlayerHelper.LocalId = value;
    }

    private CancellationTokenSource? _cancellationTokenSource;

    private PlayerUpdatePayload? _lastPlayerPayload;

    private readonly IEventAggregator _eventAggregator;
    private readonly INetworkManager _networkManager;
    private readonly IVehicleManager _vehicleManager;

    public LocalPlayer(IEventAggregator eventAggregator, INetworkManager networkManager, IVehicleManager vehicleManager)
    {
        _eventAggregator = eventAggregator;
        _networkManager = networkManager;
        _vehicleManager = vehicleManager;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        NativeHelper.OnNativeTick += FingerPointingTick;

        _eventAggregator.Subscribe<LocalPlayerConnectedEvent>(OnLocalPlayerConnected);
        _eventAggregator.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnected);

        _eventAggregator.Subscribe<LocalPlayerBootstrapEvent>(OnBootstrap);

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private Task OnLocalPlayerConnected(LocalPlayerConnectedEvent obj)
    {
        return Task.CompletedTask;
    }

    private Task OnLocalPlayerDisconnected(LocalPlayerDisconnectedEvent obj)
    {
        _cancellationTokenSource?.Cancel();

        return ThreadHelper.RunAsync(EntityPool.Clear);
    }

    private Task OnBootstrap(LocalPlayerBootstrapEvent obj)
    {
        Id = obj.LocalId;

        return ThreadHelper.RunAsync(() =>
        {
            var rotation = Elements.LocalPlayer.Character.Rotation;

            Elements.LocalPlayer.Character.Position = obj.StartPosition;
            Elements.LocalPlayer.Model = obj.StartModel;
            Elements.LocalPlayer.Character.Rotation = new Vector3(rotation.X, rotation.Y, obj.StartHeading);

            _cancellationTokenSource = new CancellationTokenSource();
            Task.Run(Sync, _cancellationTokenSource.Token);
        });
    }

    private async Task Sync()
    {
        while (_cancellationTokenSource?.IsCancellationRequested == false)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(50), _cancellationTokenSource.Token);

            await ThreadHelper.RunAsync(SyncLocalPlayer);
        }
    }

    private void SyncLocalPlayer()
    {
        var ped = Elements.LocalPlayer.Character;

        var position = ped.Position;
        var rotation = ped.Rotation;
        var velocity = ped.Velocity;
        var aimTarget = Gameplay.GetGameplayCamCoord() + Utility.GetDirection(Gameplay.GetGameplayCamRot(), 50.0f);
        var model = Elements.LocalPlayer.Model;
        var weaponModel = ped.GetCurrentPedWeapon();
        var isAiming = ped.GetIsTaskActive(290);
        var isEnteringVehicle = ped.IsEnteringVehicle();
        var isInVehicle = ped.IsInAnyVehicle();
        var isLeavingVehicle = ped.IsLeavingVehicle();
        var vehicleId = GetDesiredVehicleId();
        var seat = isEnteringVehicle ? ped.GetSeatPedIsTryingToEnter() : ped.Seat;

        var transformPayload = new PlayerUpdatePayload(Id, position, velocity, rotation.Z, _fingerPointingPitch, _fingerPointingHeading, aimTarget,
            Elements.LocalPlayer.Character.Speed(), model, weaponModel, ped.IsPedJumping(), ped.IsPedClimbing(), ped.IsClimbingLadder(),
            ped.IsPedRagdoll(), isAiming, isEnteringVehicle, isInVehicle, vehicleId, (int) seat, isLeavingVehicle, _isFingerPointing);

        if (_lastPlayerPayload != null && transformPayload.IsDifferent(_lastPlayerPayload) == false)
        {
            return;
        }

        _lastPlayerPayload = transformPayload;

        _networkManager.Send(transformPayload, DeliveryMethod.Unreliable);
    }

    private int? GetDesiredVehicleId()
    {
        var ped = Elements.LocalPlayer.Character;

        if (ped.IsEnteringVehicle())
        {
            var vehicle = _vehicleManager.GetVehicle(ped.GetVehiclePedIsTryingToEnter());
            if (vehicle != null)
            {
                if (vehicle.NativeVehicle.GetIsVehicleEngineRunning() == false)
                {
                    vehicle.NativeVehicle.SetVehicleEngineOn(true, true);
                }

                LocalPlayerHelper.SetVehicle(vehicle);

                return vehicle.Id;
            }
        }
        else if (ped.IsInAnyVehicle())
        {
            var vehicle = _vehicleManager.GetVehicle(ped.GetVehiclePedIsIn());
            if (vehicle != null)
            {
                LocalPlayerHelper.SetVehicle(vehicle);

                return vehicle.Id;
            }
        }
        else if (ped.IsLeavingVehicle())
        {
            var vehicle = _vehicleManager.GetVehicle(ped.GetLastVehiclePedIsIn());
            if (vehicle != null)
            {
                LocalPlayerHelper.SetVehicle(vehicle);

                return vehicle.Id;
            }
        }

        LocalPlayerHelper.SetVehicle(null);

        return null;
    }
}
