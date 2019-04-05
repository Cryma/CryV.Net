using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using CryV.Net.Server.Elements;
using CryV.Net.Server.Networking;
using CryV.Net.Shared.Payloads;
using CryV.Net.Shared.Payloads.Partials;

namespace CryV.Net.Server
{
    public class GameServer
    {

        private readonly ConcurrentDictionary<int, Client> _clients = new ConcurrentDictionary<int, Client>();

        private readonly NetworkServer _networkServer;

        public GameServer()
        {
            _networkServer = new NetworkServer(this);
            _networkServer.Start(1337);
        }

        public void AddClient(Client client)
        {
            _clients.TryAdd(client.Id, client);

            BootstrapClient(client);
        }

        public void RemoveClient(int id)
        {
            _clients.TryRemove(id, out _);
        }

        public IList<Client> GetClients()
        {
            return _clients.Values.ToList();
        }

        public void Tick()
        {
            _networkServer?.Tick();
        }

        private void BootstrapClient(Client client)
        {
            var playerPayloads = new List<ClientPayload>();
            foreach (var existingClient in _clients.Values)
            {
                // Don't sync self
                if (existingClient.Id == client.Id)
                {
                    continue;
                }

                playerPayloads.Add(new ClientPayload(existingClient.Id, existingClient.Position, 0.0f));
            }

            var bootstrapPayload = new BootstrapPayload(client.Id, client.Position, playerPayloads);
            client.Send(bootstrapPayload);
        }

    }
}
