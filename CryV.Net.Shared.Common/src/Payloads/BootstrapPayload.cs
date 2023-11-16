using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Payloads.Partials;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads;

[ProtoContract]
public class BootstrapPayload : IPayload
{

    public PayloadType PayloadType { get; } = PayloadType.Bootstrap;

    [ProtoMember(1)]
    public int LocalId { get; set; }

    [ProtoMember(2)]
    public SerializableVector3 StartPosition { get; set; }

    [ProtoMember(3)]
    public float StartHeading { get; set; }

    [ProtoMember(4)]
    public ulong StartModel { get; set; }

    [ProtoMember(5)]
    public List<PlayerUpdatePayload> ExistingPlayers { get; set; }

    [ProtoMember(6)]
    public List<VehicleUpdatePayload> ExistingVehicles { get; set; }

    // Empty construct is needed due to reflection
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public BootstrapPayload()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }

    public BootstrapPayload(int localId, Vector3 startPosition, float startHeading, ulong startModel, List<PlayerUpdatePayload> existingPlayers, List<VehicleUpdatePayload> existingVehicles)
    {
        LocalId = localId;
        StartPosition = startPosition;
        StartHeading = startHeading;
        StartModel = startModel;
        ExistingPlayers = existingPlayers;
        ExistingVehicles = existingVehicles;
    }

}
