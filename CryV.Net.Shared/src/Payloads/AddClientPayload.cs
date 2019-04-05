using System.Numerics;
using CryV.Net.Shared.Payloads.Partials;
using CryV.Net.Shared.src.Enums;
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

            writer.Put(Client.Id);

            writer.Put(Client.Position.X);
            writer.Put(Client.Position.Y);
            writer.Put(Client.Position.Z);

            writer.Put(Client.Heading);
        }

        public void Read(NetDataReader reader)
        {
            Client.Id = reader.GetInt();
            Client.Position = new Vector3(reader.GetFloat(), reader.GetFloat(), reader.GetFloat());
            Client.Heading = reader.GetFloat();
        }

    }
}
