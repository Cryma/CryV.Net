﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using CryV.Net.Server.Elements;
using CryV.Net.Server.Networking;
using CryV.Net.Shared.Events.Types;
using CryV.Net.Shared.Payloads;
using LiteNetLib;
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
            EventHandler.Subscribe<NetworkEvent<PointingUpdatePayload>>(OnPointingUpdate);
            EventHandler.Subscribe<NetworkEvent<StopPointingPayload>>(OnStopPointing);
        }

        private void OnStopPointing(NetworkEvent<StopPointingPayload> obj)
        {
            var fromClient = GetClient(obj.Payload.Id);

            foreach (var client in GetClients())
            {
                if (client.Id == fromClient.Id)
                {
#if PEDMIRROR
                    obj.Payload.Id = 1;
                    client.Send(obj.Payload);
#endif
                    continue;
                }

                client.Send(obj.Payload);
            }
        }

        private void OnPointingUpdate(NetworkEvent<PointingUpdatePayload> obj)
        {
            var fromClient = GetClient(obj.Payload.Id);

            foreach (var client in GetClients())
            {
                if (client.Id == fromClient.Id)
                {
#if PEDMIRROR
                    obj.Payload.Id = 1;
                    client.Send(obj.Payload, DeliveryMethod.Unreliable);
#endif
                    continue;
                }

                client.Send(obj.Payload, DeliveryMethod.Unreliable);
            }
        }

        private void OnClientUpdate(NetworkEvent<ClientUpdatePayload> obj)
        {
            var fromClient = GetClient(obj.Payload.Id);
           
            fromClient.ReadPayload(obj.Payload);

            foreach (var client in GetClients())
            {
                if (client.Id == fromClient.Id)
                {
#if PEDMIRROR
                    obj.Payload.Id = 1;
                    obj.Payload.Position.X += 1.0f;

                    client.Send(obj.Payload);
#endif
                    continue;
                }

                client.Send(obj.Payload, DeliveryMethod.Unreliable);
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
