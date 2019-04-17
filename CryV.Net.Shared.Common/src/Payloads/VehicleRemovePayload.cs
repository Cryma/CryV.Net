using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads
{
    [ProtoContract]
    public class VehicleRemovePayload : IPayload
    {

        public PayloadType PayloadType { get; } = PayloadType.RemoveVehicle;

        [ProtoMember(1)]
        public int Id { get; set; }

        public VehicleRemovePayload()
        {
        }

        public VehicleRemovePayload(int id)
        {
            Id = id;
        }

    }
}
