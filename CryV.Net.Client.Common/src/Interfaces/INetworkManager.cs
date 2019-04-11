namespace CryV.Net.Client.Common.Interfaces
{
    public interface INetworkManager
    {

        bool IsConnected { get; }

        void Connect(string address, int port);

        void Disconnect();

    }
}
