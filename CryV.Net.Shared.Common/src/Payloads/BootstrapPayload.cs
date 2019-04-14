using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Payloads.Partials;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads
{
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

        public BootstrapPayload()
        {
        }

        public BootstrapPayload(int localId, Vector3 startPosition, float startHeading, ulong startModel, List<PlayerUpdatePayload> existingPlayers)
        {
            LocalId = localId;
            StartPosition = startPosition;
            StartHeading = startHeading;
            StartModel = startModel;
            ExistingPlayers = existingPlayers;
        }

    }
}
