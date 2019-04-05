using CryV.Net.Server.Networking;

namespace CryV.Net.Server
{
    public class GameServer
    {

        private readonly NetworkServer _networkServer;

        public GameServer()
        {
            _networkServer = new NetworkServer(this);
            _networkServer.Start(1337);
        }

        public void Tick()
        {
            _networkServer?.Tick();
        }

    }
}
