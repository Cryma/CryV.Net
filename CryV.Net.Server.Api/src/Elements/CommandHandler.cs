using System;
using System.Collections.Concurrent;
using System.Linq;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Server.Api.Elements
{
    public class CommandHandler : ICommandHandler
    {

        private readonly ConcurrentDictionary<string, Action<IPlayer, string[]>> _commands = new ConcurrentDictionary<string, Action<IPlayer, string[]>>();

        private readonly IEventHandler _eventHandler;
        private readonly IPlayerManager _playerManager;

        public CommandHandler(IEventHandler eventHandler, IPlayerManager playerManager)
        {
            _eventHandler = eventHandler;
            _playerManager = playerManager;

            eventHandler.Subscribe<NetworkEvent<RemoteCommandPayload>>(OnRemoteCommand);
        }

        public void AddCommand(string commandName, Action<IPlayer, string[]> callback)
        {
            _commands.TryAdd(commandName, callback);
        }

        private void OnRemoteCommand(NetworkEvent<RemoteCommandPayload> obj)
        {
            var sender = obj.Sender;
            var player = _playerManager.GetPlayer(sender);
            if (player == null)
            {
                return;
            }

            var payload = obj.Payload;

            var commandArray = payload.Command.Split(' ');
            if (commandArray.Length == 0)
            {
                return;
            }

            var commandName = commandArray[0];
            var commandArguments = commandArray.Skip(1).ToArray();

            if (_commands.TryGetValue(commandName, out var action) == false || action == null)
            {
                return;
            }

            action(player, commandArguments);
        }

    }
}
