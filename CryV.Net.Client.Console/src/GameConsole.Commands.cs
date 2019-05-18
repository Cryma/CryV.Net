using System;
using System.Drawing;
using System.Numerics;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Elements;
using CryV.Net.Enums;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;

namespace CryV.Net.Client.Console
{
    public partial class GameConsole
    {

        private NativeHelper.NativeTick _syncedEntitiesCallback;

        private void CommandOutputText(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length == 0)
            {
                PrintLine("Please specify something to output.");

                return;
            }

            PrintLine("Output: " + string.Join(' ', arguments));
        }

        private void CommandClear(GameConsole gameConsole, params string[] arguments)
        {
            lock (_output)
            {
                _output.Clear();
            }
        }

        private void CommandSetSkin(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length == 0)
            {
                PrintLine("Please specify a skin name.");

                return;
            }

            var skinName = arguments[0];

            LocalPlayer.Model = Utility.GetHashKey(skinName);
        }

        private void CommandSetWeather(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length == 0)
            {
                PrintLine("Please specify a weather name.");

                return;
            }

            var weatherName = arguments[0];
            if (Enum.TryParse(weatherName, out WeatherType weatherType) == false)
            {
                PrintLine("Your specified weather name is invalid.");

                return;
            }

            World.SetWeather(weatherType);
        }

        private void CommandNetworkConnect(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length != 2)
            {
                PrintLine("Please specify address and port.");

                return;
            }

            var address = arguments[0];

            if (int.TryParse(arguments[1], out var port) == false)
            {
                PrintLine("Your specified port is not an integer.");

                return;
            }

            if (_networkManager.IsConnected)
            {
                PrintLine("You are already connected to a server.");

                return;
            }

            _networkManager.Connect(address, port);

            IsVisible = false;

            PrintLine($"You connected to \"{address}:{port}\".");
        }

        private void CommandNetworkDisconnect(GameConsole gameConsole, params string[] arguments)
        {
            if (_networkManager.IsConnected == false)
            {
                PrintLine("You are not connected to any server.");

                return;
            }

            _networkManager.Disconnect();

            PrintLine("You disconnected from the server.");
        }

        private void CommandPlayAnimation(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length < 1)
            {
                PrintLine("Please specify an animation dictionary and name.");

                return;
            }

            Streaming.LoadAnimationDictionary(arguments[0]);
            LocalPlayer.Character.TaskPlayAnim(arguments[0], arguments[1], 8.0f, 10.0f, -1, 1 | 2147483648, 1.0f, true, true, true);
        }

        private void CommandStopAnimation(GameConsole gameConsole, params string[] arguments)
        {
            LocalPlayer.Character.ClearPedTasks();
        }

        private void CommandAddWeapon(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length == 0)
            {
                PrintLine("Please specify a weapon name.");

                return;
            }

            LocalPlayer.Character.GiveWeaponToPed(Utility.GetHashKey("weapon_" + arguments[0]), 999, true, true);
        }

        private void CommandRemoveAllWeapons(GameConsole gameConsole, params string[] arguments)
        {
            LocalPlayer.Character.RemoveAllPedWeapons();
        }

        private void CommandShowSynced(GameConsole gameConsole, params string[] arguments)
        {
            _syncedEntitiesCallback = deltaTime =>
            {
                foreach (var syncedEntity in _syncManager.GetSyncedEntities())
                {
                    UserInterface.DrawMarker(0, syncedEntity.NativeVehicle.Position + Vector3.UnitZ * 2, Vector3.Zero, Vector3.Zero, Vector3.One,
                        Color.OrangeRed, true);
                }
            };

            NativeHelper.OnNativeTick += _syncedEntitiesCallback;

            PrintLine("Entities that are synced by you will now be shown.");
        }

        private void CommandHideSynced(GameConsole gameConsole, params string[] arguments)
        {
            NativeHelper.OnNativeTick -= _syncedEntitiesCallback;
            _syncedEntitiesCallback = null;

            PrintLine("Entities that are synced by you will no longer be shown.");
        }

        private void CommandRemoteCommand(GameConsole gameConsole, params string[] arguments)
        {
            if (_networkManager.IsConnected == false)
            {
                PrintLine("You are not connected to any server.");

                return;
            }

            var args = string.Join(' ', arguments);

            var payload = new RemoteCommandPayload(args);

            _networkManager.Send(payload, DeliveryMethod.ReliableOrdered);
        }

    }
}
