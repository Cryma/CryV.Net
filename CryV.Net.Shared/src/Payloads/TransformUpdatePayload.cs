using CryV.Net.Shared.Enums;
using CryV.Net.Shared.Payloads.Partials;
using LiteNetLib.Utils;

namespace CryV.Net.Shared.Payloads
{
    public class TransformUpdatePayload : IPayload
    {
        public PayloadType PayloadType { get; } = PayloadType.TransformUpdate;

        public ClientPayload Client { get; set; }

        public TransformUpdatePayload()
        {
        }

        public TransformUpdatePayload(ClientPayload clientPayload)
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
