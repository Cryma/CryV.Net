using System.Numerics;
using CryV.Net.Shared.Enums;
using CryV.Net.Shared.Payloads.Partials;
using LiteNetLib.Utils;

namespace CryV.Net.Shared.Payloads
{
    public class AddClientPayload : IPayload
    {

        public PayloadType PayloadType { get; } = PayloadType.AddClient;

        public ClientPayload Client { get; set; }

        public AddClientPayload()
        {
        }

        public AddClientPayload(ClientPayload clientPayload)
        {
            Client = clientPayload;
        }

        public void Write(NetDataWriter writer)
        {
            writer.Put((byte) PayloadType);

            Client.Write(writer);
        }

        public void Read(NetDataReader reader)
        {
            Client = new ClientPayload();
            Client.Read(reader);
        }

    }
}
