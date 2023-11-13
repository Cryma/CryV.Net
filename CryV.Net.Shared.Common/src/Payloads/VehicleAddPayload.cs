using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads;

[ProtoContract]
public class VehicleAddPayload : IPayload
{

    public PayloadType PayloadType { get; } = PayloadType.AddVehicle;

    [ProtoMember(1)]
    public VehicleUpdatePayload Data { get; set; }

    public VehicleAddPayload()
    {
    }

    public VehicleAddPayload(VehicleUpdatePayload data)
    {
        Data = data;
    }

}
