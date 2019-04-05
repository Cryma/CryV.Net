using System.Collections.Generic;
using System.Numerics;
using LiteNetLib.Utils;

namespace CryV.Net.Shared.Payloads
{
    public class Bootstrap
    {
        
        public int LocalId { get; set; }

        public Vector3 StartPosition { get; set; }

        public int PlayerAmount { get; set; }

        public List<Vector3> Players { get; set; }

        public Bootstrap()
        {
        }

        public Bootstrap(int localId, Vector3 startPosition, List<Vector3> players)
        {
            LocalId = localId;
            StartPosition = startPosition;
            PlayerAmount = players.Count;
            Players = players;
        }

        public void Write(NetDataWriter writer)
        {
            writer.Put(LocalId);

            writer.Put(StartPosition.X);
            writer.Put(StartPosition.Y);
            writer.Put(StartPosition.Z);

            writer.Put(PlayerAmount);

            foreach (var player in Players)
            {
                writer.Put(player.X);
                writer.Put(player.Y);
                writer.Put(player.Z);
            }
        }

        public void Read(NetDataReader reader)
        {
            LocalId = reader.GetInt();

            StartPosition = new Vector3(reader.GetFloat(), reader.GetFloat(), reader.GetFloat());

            PlayerAmount = reader.GetInt();

            Players = new List<Vector3>();
            for (var i = 0; i < PlayerAmount; i++)
            {
                Players.Add(new Vector3(reader.GetFloat(), reader.GetFloat(), reader.GetFloat()));
            }
        }

    }
}
