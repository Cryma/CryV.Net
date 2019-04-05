using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Shared.Payloads.Partials;
using CryV.Net.Shared.src.Enums;
using LiteNetLib.Utils;

namespace CryV.Net.Shared.Payloads
{
    public class BootstrapPayload : IPayload
    {

        public PayloadType PayloadType { get; } = PayloadType.Bootstrap;

        public int LocalId { get; set; }

        public Vector3 StartPosition { get; set; }

        public List<ClientPayload> Players { get; set; }

        public BootstrapPayload()
        {
        }

        public BootstrapPayload(int localId, Vector3 startPosition, List<ClientPayload> players)
        {
            LocalId = localId;
            StartPosition = startPosition;
            Players = players;
        }

        public void Write(NetDataWriter writer)
        {
            writer.Put((byte) PayloadType);

            writer.Put(LocalId);

            writer.Put(StartPosition.X);
            writer.Put(StartPosition.Y);
            writer.Put(StartPosition.Z);

            writer.Put(Players.Count);

            foreach (var player in Players)
            {
                player.Write(writer);
            }
        }

        public void Read(NetDataReader reader)
        {
            LocalId = reader.GetInt();

            StartPosition = new Vector3(reader.GetFloat(), reader.GetFloat(), reader.GetFloat());

            var playerAmount = reader.GetInt();

            Players = new List<ClientPayload>();
            for (var i = 0; i < playerAmount; i++)
            {
                var clientPayload = new ClientPayload();
                clientPayload.Read(reader);

                Players.Add(clientPayload);
            }
        }

    }
}
