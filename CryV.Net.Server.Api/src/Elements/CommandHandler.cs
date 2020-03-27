using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;
using CryV.Net.Shared.Common.Events;
using CryV.Net.Shared.Common.Payloads;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Api.Elements
{
    public class CommandHandler : ICommandHandler
    {

        private readonly ConcurrentDictionary<string, Action<IPlayer, string[]>> _commands = new ConcurrentDictionary<string, Action<IPlayer, string[]>>();

        private readonly IEventAggregator _eventAggregator;

        private readonly IPlayerManager _playerManager;

        public CommandHandler(IEventAggregator eventAggregator, IPlayerManager playerManager)
        {
            _eventAggregator = eventAggregator;
            _playerManager = playerManager;

            _eventAggregator.Subscribe<NetworkEvent<RemoteCommandPayload>>(OnRemoteCommand);
        }

        public void AddCommand(string commandName, Action<IPlayer, string[]> callback)
        {
            _commands.TryAdd(commandName, callback);
        }

        private Task OnRemoteCommand(NetworkEvent<RemoteCommandPayload> obj)
        {
            var sender = obj.Sender;
            var player = _playerManager.GetPlayer(sender);
            if (player == null)
            {
                return Task.CompletedTask;
            }

            var payload = obj.Payload;

            var commandArray = payload.Command.Split(' ');
            if (commandArray.Length == 0)
            {
                return Task.CompletedTask;
            }

            var commandName = commandArray[0];
            var commandArguments = commandArray.Skip(1).ToArray();

            if (_commands.TryGetValue(commandName, out var action) == false || action == null)
            {
                return Task.CompletedTask;
            }

            action(player, commandArguments);

            return Task.CompletedTask;
        }

    }
}
