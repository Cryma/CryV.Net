using System.Numerics;
using CryV.Net.Client.Elements;

namespace CryV.Net.Client.Networking
{
    public class Client
    {
        
        public int Id { get; }

        private readonly Ped _ped;

        public Client(int id, Vector3 position, float heading)
        {
            Id = id;

            _ped = new Ped("mp_m_freemode_01", position, heading);
        }

    }
}
