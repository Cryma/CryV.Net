using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using CryV.Net.Server.Elements;
using CryV.Net.Server.Networking;
using CryV.Net.Shared.Events.Types;
using CryV.Net.Shared.Payloads;
using EventHandler = CryV.Net.Shared.Events.EventHandler;

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

            EventHandler.Subscribe<NetworkEvent<ClientUpdatePayload>>(OnClientUpdate);
        }

        private void OnClientUpdate(NetworkEvent<ClientUpdatePayload> obj)
        {
            var fromClient = GetClient(obj.Payload.Id);
           
            fromClient.ReadPayload(obj.Payload);

            foreach (var client in GetClients())
            {
                if (client.Id == fromClient.Id)
                {
                    // TODO: Remove debug code
                    //obj.Payload.Id = 1;
                    //obj.Payload.Position.Z += 3.75f;

                    //client.Send(obj.Payload);

                    continue;
                }

                client.Send(obj.Payload);
            }
        }

        public void AddClient(Client client)
        {
            _clients.TryAdd(client.Id, client);

            BootstrapClient(client);
            PropagateNewClient(client);
        }

        public void RemoveClient(int id)
        {
            _clients.TryRemove(id, out var client);

            PropagateClientDisconnect(client);
        }

        public IList<Client> GetClients()
        {
            return _clients.Values.ToList();
        }

        public Client GetClient(int id)
        {
            _clients.TryGetValue(id, out var client);

            return client;
        }

        public void Tick()
        {
            _networkServer?.Tick();
        }

        private void BootstrapClient(Client client)
        {
            var bootstrapPayload = new BootstrapPayload(client.Id, client.Position, client.Heading, client.Model);
            client.Send(bootstrapPayload);
        }

        private void PropagateNewClient(Client client)
        {
            var payload = client.GetPayload();

            foreach (var existingClient in _clients.Values)
            {
                // Don't sync self
                if (existingClient.Id == client.Id)
                {
                    continue;
                }

                existingClient.Send(payload);
            }
        }

        private void PropagateClientDisconnect(Client client)
        {
            var payload = new RemoveClientPayload(client.Id);

            foreach (var existingClient in _clients.Values)
            {
                // Don't sync self
                if (existingClient.Id == client.Id)
                {
                    continue;
                }

                existingClient.Send(payload);
            }
        }

    }
}
