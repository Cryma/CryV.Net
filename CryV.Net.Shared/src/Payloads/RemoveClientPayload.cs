using CryV.Net.Shared.Enums;
using LiteNetLib.Utils;

namespace CryV.Net.Shared.Payloads
{
    public class RemoveClientPayload : IPayload
    {

        public PayloadType PayloadType { get; } = PayloadType.RemoveClient;

        public int Id { get; set; }

        public RemoveClientPayload()
        {
        }

        public RemoveClientPayload(int id)
        {
            Id = id;
        }

        public void Write(NetDataWriter writer)
        {
            writer.Put((byte) PayloadType);

            writer.Put(Id);
        }

        public void Read(NetDataReader reader)
        {
            Id = reader.GetInt();
        }

    }
}
