using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Shared.Enums;
using CryV.Net.Shared.Payloads.Partials;
using ProtoBuf;

namespace CryV.Net.Shared.Payloads
{
    [ProtoContract]
    public class BootstrapPayload : IPayload
    {

        public PayloadType PayloadType { get; } = PayloadType.Bootstrap;

        [ProtoMember(1)]
        public int LocalId { get; set; }

        [ProtoMember(2)]
        public Vector3 StartPosition { get; set; }

        [ProtoMember(3)]
        public float StartHeading { get; set; }

        [ProtoMember(4)]
        public List<ClientPayload> Players { get; set; }

        public BootstrapPayload()
        {
        }

        public BootstrapPayload(int localId, Vector3 startPosition, float startHeading, List<ClientPayload> players)
        {
            LocalId = localId;
            StartPosition = startPosition;
            StartHeading = startHeading;
            Players = players;
        }

    }
}
