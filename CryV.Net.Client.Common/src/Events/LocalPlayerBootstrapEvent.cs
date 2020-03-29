using System.Collections.Generic;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Common.Payloads.Partials;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Client.Common.Events
{
    public class LocalPlayerBootstrapEvent : IEvent
    {

        public int LocalId { get; set; }

        public SerializableVector3 StartPosition { get; set; }

        public float StartHeading { get; set; }

        public ulong StartModel { get; set; }

        public List<PlayerUpdatePayload> ExistingPlayers { get; set; }

        public List<VehicleUpdatePayload> ExistingVehicles { get; set; }

        public LocalPlayerBootstrapEvent(int localId, SerializableVector3 startPosition, float startHeading, ulong startModel, List<PlayerUpdatePayload> existingPlayers, List<VehicleUpdatePayload> existingVehicles)
        {
            LocalId = localId;
            StartPosition = startPosition;
            StartHeading = startHeading;
            StartModel = startModel;
            ExistingPlayers = existingPlayers;
            ExistingVehicles = existingVehicles;
        }

    }
}
