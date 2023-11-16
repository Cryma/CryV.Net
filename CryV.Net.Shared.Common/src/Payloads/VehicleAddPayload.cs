using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads;

[ProtoContract]
public class VehicleAddPayload : IPayload
{

    public PayloadType PayloadType { get; } = PayloadType.AddVehicle;

    [ProtoMember(1)]
    public VehicleUpdatePayload Data { get; set; }

    // Empty construct is needed due to reflection
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public VehicleAddPayload()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }

    public VehicleAddPayload(VehicleUpdatePayload data)
    {
        Data = data;
    }

}
