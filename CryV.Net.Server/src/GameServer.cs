using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using CryV.Net.Server.Elements;
using CryV.Net.Server.Networking;

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

    }
}
