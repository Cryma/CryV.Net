using System.Threading.Tasks;
using CryV.Net.Client.Elements;
using CryV.Net.Client.Networking;
using CryV.Net.Shared.Payloads;
using CryV.Net.Shared.Payloads.Partials;
using LiteNetLib;
using LiteNetLib.Utils;

namespace CryV.Net.Client
{
    public class GameClient
    {

        public bool IsConnected => _networkClient.IsConnected;

        private readonly NetworkClient _networkClient;

        public GameClient()
        {
            _networkClient = new NetworkClient(this);
        }

        public void Connect(string address, int port)
        {
            _networkClient?.Connect(address, port);
        }

        public void Disconnect()
        {
            _networkClient?.Disconnect();
        }

        public void Tick()
        {
            
        }

        public async Task SyncTransform()
        {
            while (_networkClient.CancellationTokenSource.IsCancellationRequested == false)
            {
                await Task.Delay(1000 / 20, _networkClient.CancellationTokenSource.Token);

                ThreadHelper.Run(() =>
                {
                    var writer = new NetDataWriter();
                    var transformPayload = new TransformUpdatePayload(new ClientPayload(_networkClient.LocalId, LocalPlayer.Character.Position, LocalPlayer.Character.Rotation.Z));
                    transformPayload.Write(writer);

                    _networkClient.Peer.Send(writer, DeliveryMethod.Unreliable);
                });
            }
        }

    }
}
